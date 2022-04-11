using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MongoDB.Driver.Linq;

namespace Stelf
{
    public partial class FormLoja : Form
    {
        
        private Cliente cliente;
        private Desenvolvedora desenvolvedora;
        private List<Jogo> jogos;

        public FormLoja(Cliente clienteLogado, Desenvolvedora desenvolvedoraLogada)  
        {
            this.cliente = clienteLogado;
            this.desenvolvedora = desenvolvedoraLogada;

            ConnectionDB barqueiro = new ConnectionDB();
            this.jogos = barqueiro.getJogoList();
            
            InitializeComponent();
            if (!desenvolvedora.Email.Equals("") && cliente.Email.Equals(""))
            {
                btnAdicionarJogo.Visible = true;
            }
            Carrega_Dados_Login();
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            if (cliente.Email.Equals("")) {
                FormAlterarDadosDesenvolvedora formAlterarDadosD = new FormAlterarDadosDesenvolvedora(desenvolvedora);
                formAlterarDadosD.Show();
            } else
            {
                FormAlterarDadosCliente formAlterarDadosC = new FormAlterarDadosCliente(cliente);
                formAlterarDadosC.Show();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var formLauncher = (FormLauncher)Tag;
            formLauncher.Show();
            Close();
        }

        private void Carrega_Dados_Login()
        {
            if (cliente.Email.Equals(""))
            {
                lbNome.Text = desenvolvedora.Nome;
                lbEmail.Text = desenvolvedora.Email;
            }
            else
            {
                lbNome.Text = cliente.Nome;
                lbEmail.Text = cliente.Email;
            }
        }

        private void btnAdicionarJogo_Click(object sender, EventArgs e)
        {
            FormAddJogo frmAddJogo = new FormAddJogo(desenvolvedora);
            frmAddJogo.Tag = this;
            frmAddJogo.Show(this);
            Hide();
        }

        private void FormLoja_VisibleChanged(object sender, EventArgs e)
        {
            ConnectionDB barqueiro = new ConnectionDB();
            this.jogos = barqueiro.getJogoList();
            constroiJogosLoja(jogos);
        }

        private void constroiJogosLoja(List<Jogo> jogosLoja)
        {
            ConnectionDB barqueiro = new ConnectionDB();

            int linha = -1;
            for (int i = 0; i < jogosLoja.Count; i++)
            {
                int x_pic = 235;
                int y_pic = 158;
                int x_button = 235;
                int y_button = 308;
                int coluna = i % 3;
                if (coluna == 0)
                {
                    linha++;
                }

                int x_offset = 269;
                int y_offset_picture_box = 221;

                var pic = new PictureBox();
                pic.Location = new Point(x_pic + (coluna * x_offset) - panelJogos.Location.X, y_pic + (linha * y_offset_picture_box) - panelJogos.Location.Y);
                pic.Size = new Size(253, 151);
                pic.Image = barqueiro.BytesToImage(jogosLoja[i].imagem);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                panelJogos.Controls.Add(pic);

                var button = new Button();
                button.Text = "R$ " + jogosLoja[i].preco.ToString();
                button.BackColor = Color.LightGreen;
                button.Location = new Point(x_button + (coluna * x_offset) - panelJogos.Location.X, y_button + (linha * y_offset_picture_box) - panelJogos.Location.Y);
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.Size = new Size(253, 23);
                panelJogos.Controls.Add(button);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String filtro = comboBoxFiltro.Text;
            
            if (filtro.Equals(""))
            {
                MessageBox.Show("Escolha um filtro primeiramente!");
            }
            else
            {
                List<Jogo> jogosFiltrados = new List<Jogo>();

                switch (filtro)
                {
                    case "Nome":
                        foreach (Jogo jogo in this.jogos)
                        {
                            if (jogo.nome.Equals(textBoxBusca.Text))
                            {
                                jogosFiltrados.Add(jogo);
                            }
                        }
                    break;
                    case "Desenvolvedora":
                        foreach (Jogo jogo in this.jogos)
                        {
                            if (jogo.desenvolvedora.Nome.Equals(textBoxBusca.Text))
                            {
                                jogosFiltrados.Add(jogo);
                            }
                        }
                    break;
                    case "Faixa Etária":
                        foreach (Jogo jogo in this.jogos)
                        {
                            if (jogo.faixaEtaria.Equals(Int32.Parse(textBoxBusca.Text)))
                            {
                                jogosFiltrados.Add(jogo);
                            }
                        }
                    break;
                    case "Preço":
                        foreach (Jogo jogo in this.jogos)
                        {
                            if (jogo.preco.Equals(float.Parse(textBoxBusca.Text)))
                            {
                                jogosFiltrados.Add(jogo);
                            }
                        }
                    break;
                    case "Gênero":
                        foreach (Jogo jogo in this.jogos)
                        {
                            if (jogo.genero.Equals(textBoxBusca.Text))
                            {
                                jogosFiltrados.Add(jogo);
                            }
                        }
                    break;
                }
                panelJogos.Controls.Clear();
                constroiJogosLoja(jogosFiltrados);
            }
        }
    }
}
