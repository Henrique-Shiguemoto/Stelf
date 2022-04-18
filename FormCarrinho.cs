using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stelf
{
    public partial class FormCarrinho : Form
    {
        private List<Jogo> carrinho;

        public FormCarrinho(List<Jogo> carrinho)
        {
            this.carrinho = carrinho;
            InitializeComponent();
        }

        private void FormCarrinho_Load(object sender, EventArgs e)
        {
            carregar_Jogos(carrinho);   
        }

        private void carregar_Jogos(List<Jogo> jogos)
        {
            int picBox_X = 13;
            int picBox_Y = 16;
            int nomeJogo_X = 155;
            int nomeJogo_Y = 16;
            int nomeDev_X = 155;
            int nomeDev_Y = 79;
            int preco_X = 624;
            int preco_Y = 16;
            int removerBtn_X = 651; 
            int removerBtn_Y = 82;

            ConnectionDB barqueiro = new ConnectionDB();

            for (int i = 0; i < jogos.Count; i++)
            {
                var pic = new PictureBox();
                pic.Location = new Point(picBox_X, picBox_Y);
                pic.Size = new Size(123, 96);
                pic.Image = barqueiro.BytesToImage(jogos[i].imagem);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                panelCarrinho.Controls.Add(pic);

                var nomejogo_label = new Label();
                nomejogo_label.Text = jogos[i].nome;
                nomejogo_label.Location = new Point(nomeJogo_X, nomeJogo_Y);
                nomejogo_label.Font = new Font("Segoe UI", 20);
                panelCarrinho.Controls.Add(nomejogo_label);

                var nomedev_label = new Label();
                nomedev_label.Text = jogos[i].desenvolvedora.Nome;
                nomedev_label.Location = new Point(nomeDev_X, nomeDev_Y);
                nomedev_label.Font = new Font("Segoe UI", 12);
                panelCarrinho.Controls.Add(nomedev_label);

                var preco_label = new Label();
                preco_label.Text = jogos[i].preco.ToString();
                preco_label.Location = new Point(preco_X, preco_Y);
                preco_label.Font = new Font("Segoe UI", 20);
                panelCarrinho.Controls.Add(preco_label);

                var remover_button = new Button();
                remover_button.Text = "Remover";
                remover_button.Location = new Point(removerBtn_X, removerBtn_Y);
                remover_button.Font = new Font("Segoe UI", 7);
                remover_button.BackColor = Color.Brown;
                remover_button.FlatStyle = FlatStyle.Flat;
                remover_button.FlatAppearance.BorderSize = 0;
                remover_button.Size = new Size(56, 21);
                panelCarrinho.Controls.Add(remover_button);
            }
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            var formLoja = (FormLoja)Tag;
            formLoja.Show();
            Close();
        }
    }
}
