using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Stelf.classes;
using MongoDB.Driver.Linq;

namespace Stelf
{
    public partial class FormLoja : Form
    {
        private Cliente cliente;
        private Desenvolvedora desenvolvedora;
        private List<Jogo> jogos;
        private List<Jogo> carrinho;
        private List<Jogo> biblioteca; 

        public FormLoja(Cliente clienteLogado, Desenvolvedora desenvolvedoraLogada)  
        {
            this.cliente = clienteLogado;
            this.desenvolvedora = desenvolvedoraLogada;
            this.carrinho = new List<Jogo>();
            this.biblioteca = new List<Jogo>();

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
            if (this.Visible == true)
            {
                btnCarrinho.Text = "Carrinho - " + carrinho.Count;
                panelJogos.Controls.Clear();
                ConnectionDB barqueiro = new ConnectionDB();
                this.jogos = barqueiro.getJogoList();
                constroiJogosLoja(jogos);
                if (this.desenvolvedora.Email.Length == 0)
                {
                    this.biblioteca = barqueiro.getBibliotecaList(this.cliente.Email);
                }
            }
        }

        private void constroiJogosLoja(List<Jogo> jogosLoja)
        {
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

                ConstrutorJogo item = new ConstrutorJogo(x_pic + (coluna * x_offset) - panelJogos.Location.X,
                                            y_pic + (linha * y_offset_picture_box) - panelJogos.Location.Y,
                                            x_button + (coluna * x_offset) - panelJogos.Location.X,
                                            y_button + (linha * y_offset_picture_box) - panelJogos.Location.Y,
                                            ConversorImagem.BytesToImage(jogos[i].imagem),
                                            jogos[i]);
                panelJogos.Controls.Add(item.pictureBox);
                panelJogos.Controls.Add(item.button);

                item.pictureBox.Click += Image_Click;
                item.button.Click += Button_Click;

                if (carrinho.Find(x => x._id == jogos[i]._id) != null)
                {
                    item.button.BackColor = Color.Firebrick;
                    item.button.Text = "Remover do Carrinho";
                }
            }
        }

        private void constroiJogosBiblioteca(List<Jogo> biblioteca)
        {
            int linha = -1;
            for (int i = 0; i < biblioteca.Count; i++)
            {
                int x_pic = 235;
                int y_pic = 158;
                int coluna = i % 3;
                if (coluna == 0)
                {
                    linha++;
                }

                int x_offset = 269;
                int y_offset_picture_box = 221;

                ConstrutorJogo item = new ConstrutorJogo(x_pic + (coluna * x_offset) - panelJogos.Location.X,
                                            y_pic + (linha * y_offset_picture_box) - panelJogos.Location.Y,
                                            ConversorImagem.BytesToImage(biblioteca[i].imagem),
                                            biblioteca[i]);
                panelJogos.Controls.Add(item.pictureBox);

                item.pictureBox.Click += Image_Click;
            }
        }

        private void Image_Click(object sender, EventArgs e)
        {
            var pictureBox = sender as PictureBox;
            Jogo jogo = (Jogo)pictureBox.Tag;

            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 2000;

            String toolTipText = "Nome: " + jogo.nome + "\n" +
                                 "Desenvolvedora: " + jogo.desenvolvedora.Nome + "\n" +
                                 "Gênero: " + jogo.genero.ToString() + "\n" +
                                 "Faixa Etária: " + jogo.faixaEtaria.ToString() + "\n" +
                                 "Descrição: " + jogo.descricao + "\n";
            //Podemos adicionar os requisitos dos jogos na toolTip

            toolTip.Show(toolTipText, pictureBox);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            Jogo jogo = (Jogo)button.Tag;

            //Vamos adicionar o jogo no carrinho
            if (button.BackColor.Equals(Color.LightGreen))
            {
                if (this.biblioteca.Find(x => x._id == jogo._id) != null)
                {
                    MessageBox.Show("Este jogo já está em sua biblioteca!");
                }
                else {
                    button.BackColor = Color.Firebrick;
                    button.Text = "Remover do Carrinho";
                    carrinho.Add(jogo);
                    MessageBox.Show(jogo.nome + " Adicionado com sucesso ao Carrinho!\n" + "Carrinho possui " + carrinho.Count.ToString() + " jogos.");
                }
            }
            //Vamos remover o jogo do carrinho
            else
            {
                button.BackColor = Color.LightGreen;
                carrinho.Remove(carrinho.Find(x => x._id == jogo._id));
                button.Text = "R$ " + jogo.preco;
                MessageBox.Show(jogo.nome + " Removido com sucesso ao Carrinho!\n" + "Carrinho possui " + carrinho.Count.ToString() + " jogos.");
            }

            btnCarrinho.Text = "Carrinho - " + carrinho.Count.ToString();
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
                bool validSearch = true;

                List<Jogo> jogos_a_procurar = new List<Jogo>();
                if (labelTitulo.Text == "L O J A")
                {
                    jogos_a_procurar = this.jogos;
                }
                else if(labelTitulo.Text == "B I B L I O T E C A")
                {
                    jogos_a_procurar = this.biblioteca;
                }

                switch (filtro)
                {
                    case "Nome":
                        foreach (Jogo jogo in jogos_a_procurar)
                        {
                            if (jogo.nome.Equals(textBoxBusca.Text))
                            {
                                jogosFiltrados.Add(jogo);
                            }
                        }
                    break;
                    case "Desenvolvedora":
                        foreach (Jogo jogo in jogos_a_procurar)
                        {
                            if (jogo.desenvolvedora.Nome.Equals(textBoxBusca.Text))
                            {
                                jogosFiltrados.Add(jogo);
                            }
                        }
                    break;
                    case "Faixa Etária":
                        foreach (Jogo jogo in jogos_a_procurar)
                        {
                            try
                            {
                                int faixaEt = Int32.Parse(textBoxBusca.Text);
                                if (jogo.faixaEtaria.Equals(faixaEt))
                                {
                                    jogosFiltrados.Add(jogo);
                                }
                            }
                            catch
                            {
                                validSearch = false;
                            }
                        }
                    break;
                    case "Preço":
                        foreach (Jogo jogo in jogos_a_procurar)
                        {
                            try
                            {
                                float valor_preco = float.Parse(textBoxBusca.Text);
                                if (jogo.preco.Equals(valor_preco))
                                {
                                    jogosFiltrados.Add(jogo);
                                }
                            }
                            catch
                            {
                                validSearch = false;
                            }
                            
                        }
                    break;
                    case "Gênero":
                        foreach (Jogo jogo in jogos_a_procurar)
                        {
                            if (jogo.genero.Equals(textBoxBusca.Text))
                            {
                                jogosFiltrados.Add(jogo);
                            }
                        }
                    break;
                }

                if (validSearch)
                {
                    panelJogos.Controls.Clear();
                    if (labelTitulo.Text == "L O J A")
                    {
                        constroiJogosLoja(jogosFiltrados);
                    }
                    else if (labelTitulo.Text == "B I B L I O T E C A")
                    {
                        constroiJogosBiblioteca(jogosFiltrados);
                    }
                    
                }
            }
        }

        private void btnBiblioteca_Click(object sender, EventArgs e)
        {
            labelTitulo.Text = "B I B L I O T E C A";

            panelJogos.Controls.Clear();
            constroiJogosBiblioteca(biblioteca);
        }

        private void btnCarrinho_Click(object sender, EventArgs e)
        {
            FormCarrinho formCarrinho = new FormCarrinho(this.carrinho, this.cliente, this.biblioteca);
            formCarrinho.Tag = this;
            formCarrinho.Show(this);
            Hide();
        }

        private void btnLoja_Click(object sender, EventArgs e)
        {
            labelTitulo.Text = "L O J A";

            panelJogos.Controls.Clear();
            constroiJogosLoja(jogos);

        }
    }
}
