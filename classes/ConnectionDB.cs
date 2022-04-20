using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson;
using System.IO;
using System.Drawing;

namespace Stelf
{
    public class ConnectionDB
    {
        MongoClient m_Client;
        IMongoDatabase m_Database;
        IMongoCollection<Cliente> m_collection;
        IMongoCollection<Desenvolvedora> m_collection2;
        IMongoCollection<Jogo> m_collection3;

        public ConnectionDB()
        {
            m_Client = new MongoClient("mongodb+srv://gostoso:1231@mainstelf.emryq.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            m_Database = m_Client.GetDatabase("mainStelf");
            m_collection = m_Database.GetCollection<Cliente>("Cliente");
            m_collection2 = m_Database.GetCollection<Desenvolvedora>("Desenvolvedora");
            m_collection3 = m_Database.GetCollection<Jogo>("Jogo");
            var options = new CreateIndexOptions { Unique = true };

        }
        public void inserirCliente(String nome, String email, String senha, DateTime dataNascimento)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.Nome = nome;
                cliente.Senha = senha;
                cliente.Email = email;
                cliente.DataNascimento = dataNascimento;
                cliente.jogosBiblioteca = new List<ObjectId>();
                m_collection.InsertOne(cliente);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void inserirJogoBiblioteca(List<ObjectId> lst_id_jogo, Cliente cliente)
        {
            try {
                var updateDef = Builders<Cliente>.Update.Set("jogosBiblioteca", lst_id_jogo);
                m_collection.UpdateOne(s => s._id == cliente._id, updateDef);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void inserirDesenvolvedora(String nome, String email, String senha, String contaBancaria)
        {
            try
            {
                Desenvolvedora desenvolvedora = new Desenvolvedora();
                desenvolvedora.Nome = nome;
                desenvolvedora.Senha = senha;
                desenvolvedora.Email = email;
                desenvolvedora.contaBancaria = contaBancaria;
                m_collection2.InsertOne(desenvolvedora);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void inserirJogo(String nome, byte[] imagem, float preco, String genero, int faixaEtaria, Desenvolvedora desenvolvedora, Requisitos minRequisitos, Requisitos recRequisitos, String descricao)
        {
            Jogo jogo = new Jogo();
            jogo.nome = nome;
            jogo.imagem = imagem;
            jogo.preco = preco;
            jogo.genero = genero;
            jogo.faixaEtaria = faixaEtaria;
            jogo.desenvolvedora = desenvolvedora;
            jogo.minRequisitos = minRequisitos;
            jogo.recRequisitos = recRequisitos;
            jogo.descricao = descricao;
            m_collection3.InsertOne(jogo);
        }

        public void alterarDadoCliente(ObjectId id, String nome, String senha, String email)
        {
            var updateDef = Builders<Cliente>.Update.Set("Nome", nome).Set("Senha", senha).Set("Email", email);
            m_collection.UpdateOne(s => s._id == id, updateDef);
        }

        public void alterarDadoDesenvolvedora(ObjectId id, String nome, String senha, String email, String contaBanco)
        {
            var updateDef = Builders<Desenvolvedora>.Update.Set("Nome", nome).Set("Senha", senha).Set("Email", email).Set("contaBancaria", contaBanco);
            m_collection2.UpdateOne(s => s._id == id, updateDef);
        }

        public Cliente devolverClientePorEmail(String email)
        {
            Cliente cliente = new Cliente();
            cliente.Email = "";
            try
            {
                var filtro = Builders<Cliente>.Filter.Eq("Email", email);
                return m_collection.Find(filtro).First();
            }
            catch (Exception ex)
            {
                cliente.Email = ex.Message;
                return cliente;
            }
        }

        public Desenvolvedora devolverDesenvolvedoraPorEmail(String email)
        {
            Desenvolvedora desenvolvedora = new Desenvolvedora();
            desenvolvedora.Email = "";
            try
            {
                var filtro = Builders<Desenvolvedora>.Filter.Eq("Email", email);
                return m_collection2.Find(filtro).First();
            }
            catch
            {
                return desenvolvedora;
            }
        }

        public List<Jogo> getJogoList()
        {
            return m_collection3.Find(new BsonDocument()).ToList();
        }

        public List<Jogo> getBibliotecaList(String EmailCliente)
        {
            try
            {
                List<Jogo> jogosLoja = getJogoList();
                List<Jogo> listaBiblioteca = new List<Jogo>();
                List<ObjectId> list_id = devolverClientePorEmail(EmailCliente).jogosBiblioteca;

                if (list_id != null) {
                    foreach (ObjectId id in list_id)
                    {
                        Jogo jg = jogosLoja.Find(x => x._id == id);
                        if (jg != null)
                        {
                            listaBiblioteca.Add(jg);
                        }
                    }
                }
        
                return listaBiblioteca;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new List<Jogo>();
            }         
        }
    }

    
}
