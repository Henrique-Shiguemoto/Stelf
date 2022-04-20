using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Text;
using System.Windows.Forms;
using Stelf.classes;

namespace Stelf
{
    public partial class FormCarrinho : Form
    {
        private List<Jogo> carrinho;
        private List<Jogo> biblioteca;
        private Cliente cliente;

        public FormCarrinho(List<Jogo> carrinho, Cliente cliente, List<Jogo> biblioteca)
        {
            this.carrinho = carrinho;
            this.cliente = cliente;
            this.biblioteca = biblioteca;
            InitializeComponent();
        }

        private float getTotalCarrinho()
        {
            float resultado = 0;

            foreach (Jogo jogo in carrinho)
            {
                resultado = resultado + jogo.preco;
            }

            return resultado;
        }

        private void FormCarrinho_Load(object sender, EventArgs e)
        {
            carregar_Jogos(carrinho);   
        }

        private void carregar_Jogos(List<Jogo> jogos)
        {
            panelCarrinho.Controls.Clear();

            lbTotal.Text = "TOTAL = R$ " + getTotalCarrinho().ToString();

            int picBox_X = 10;
            int picBox_Y = 10;
            int nomeJogo_X = 155;
            int nomeJogo_Y = 15;
            int nomeDev_X = 155;
            int nomeDev_Y = 80;
            int preco_X = 580;
            int preco_Y = 15;
            int removerBtn_X = 580; 
            int removerBtn_Y = 80;

            for (int i = 0; i < jogos.Count; i++)
            {
                int incrementoY = 120 * i;

                var pic = new PictureBox();
                pic.Location = new Point(picBox_X, picBox_Y + incrementoY);
                pic.Size = new Size(140, 100);
                pic.Image = ConversorImagem.BytesToImage(jogos[i].imagem);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                panelCarrinho.Controls.Add(pic);

                var nomejogo_label = new Label();
                nomejogo_label.Text = jogos[i].nome;
                nomejogo_label.Location = new Point(nomeJogo_X, nomeJogo_Y + incrementoY);
                nomejogo_label.Font = new Font("Segoe UI", 16);
                nomejogo_label.Size = new Size(120, 30);
                panelCarrinho.Controls.Add(nomejogo_label);

                var nomedev_label = new Label();
                nomedev_label.Text = jogos[i].desenvolvedora.Nome;
                nomedev_label.Location = new Point(nomeDev_X, nomeDev_Y + incrementoY);
                nomedev_label.Font = new Font("Segoe UI", 12);
                panelCarrinho.Controls.Add(nomedev_label);

                var preco_label = new Label();
                preco_label.Text = "R$ " + jogos[i].preco.ToString();
                preco_label.Location = new Point(preco_X, preco_Y + incrementoY);
                preco_label.Font = new Font("Segoe UI", 16);
                preco_label.Size = new Size(120, 30);
                panelCarrinho.Controls.Add(preco_label);

                var remover_button = new Button();
                remover_button.Text = "Remover";
                remover_button.Location = new Point(removerBtn_X, removerBtn_Y + incrementoY);
                remover_button.Font = new Font("Segoe UI", 7);
                remover_button.BackColor = Color.Brown;
                remover_button.FlatStyle = FlatStyle.Flat;
                remover_button.FlatAppearance.BorderSize = 0;
                remover_button.Size = new Size(60, 25);
                remover_button.Tag = jogos[i];
                remover_button.Click += Remover_button_Click;
                panelCarrinho.Controls.Add(remover_button);
            }
        }

        private void Remover_button_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            Jogo jogo = (Jogo)button.Tag;

            carrinho.Remove(carrinho.Find(x => x._id == jogo._id));
            carregar_Jogos(carrinho);
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            var formLoja = (FormLoja)Tag;
            formLoja.Show();
            Close();
        }

        private void confirmarBtn_Click(object sender, EventArgs e)
        {
            String chavePix = "!wL#6^&%f16t6sBxc#^JO0&yWr@KG!1c";
            MessageBox.Show("Utilize a Chave PIX logo abaixo para efetuar o pagamento!\n" + chavePix);

            //colocar os jogos do carrinho para a biblioteca
            List<ObjectId> lista_id = new List<ObjectId>();

            foreach (Jogo jogo_carrinho in carrinho) {
                lista_id.Add(jogo_carrinho._id);
            }

            foreach (Jogo jogo_biblioteca in biblioteca)
            {
                lista_id.Add(jogo_biblioteca._id);
            }

            ConnectionDB barqueiro = new ConnectionDB();
            barqueiro.inserirJogoBiblioteca(lista_id, cliente);

            carrinho.Clear();
            
            var formLoja = (FormLoja)Tag;
            formLoja.Show();
            Close();
        }
    }
}
