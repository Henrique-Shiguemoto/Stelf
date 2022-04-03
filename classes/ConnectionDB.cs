using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Stelf
{
    public class ConnectionDB
    {
        MongoClient m_Client;
        IMongoDatabase m_Database;
        IMongoCollection<Cliente> m_collection;
        IMongoCollection<Desenvolvedora> m_collection2;

        public ConnectionDB()
        {
            m_Client = new MongoClient("mongodb+srv://gostoso:1231@mainstelf.emryq.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            m_Database = m_Client.GetDatabase("mainStelf");
            m_collection = m_Database.GetCollection<Cliente>("Cliente");
            m_collection2 = m_Database.GetCollection<Desenvolvedora>("Desenvolvedora");
        }
         public void inserirCliente(String nome, String email, String senha, DateTime dataNascimento)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = nome;
            cliente.Senha = senha;
            cliente.Email = email;
            cliente.DataNascimento = dataNascimento;
            m_collection.InsertOne(cliente);
        }
        public void inserirDesenvolvedora(String nome, String email, String senha, String /*ContaBancaria*/ contaBancaria)
        {
            Desenvolvedora desenvolvedora = new Desenvolvedora();
            desenvolvedora.Nome = nome;
            desenvolvedora.Senha = senha;
            desenvolvedora.Email = email;
            desenvolvedora.contaBancaria = contaBancaria;
            m_collection2.InsertOne(desenvolvedora);
        }

        public void alterarDadoCliente(String param, String filter)
        {
            //filter = valor a ser alterado
            //param = novo valor
            //BsonDocument filterDoc = BsonDocument.Parse(filter);
            //BsonDocument document = BsonDocument.Parse(param);
            //m_collection.UpdateOne(filterDoc, document);
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
            catch
            {
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
    }
}
