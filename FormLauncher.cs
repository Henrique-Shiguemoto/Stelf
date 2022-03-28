using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stelf
{
    public partial class FormLauncher : Form
    {
        public FormLauncher()
        {
            InitializeComponent();
        }

        private void cadastrarLauncherBtn_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            formCadastro.Tag = this;
            formCadastro.Show(this);
            Hide();
        }

        private void entrarBtn_Click(object sender, EventArgs e)
        {
            ConnectionDB barqueiro = new ConnectionDB();

            Cliente cliente = barqueiro.devolverClientePorEmail(emailTextBox.Text);
            Desenvolvedora desenvolvedora = barqueiro.devolverDesenvolvedoraPorEmail(emailTextBox.Text);

            //Se o Email for uma string vazia, quer dizer que o método devolverClientePorEmail devolveu um cliente inválido
            if (!cliente.Email.Equals("") && cliente.Senha == passwordTextBox.Text)
            {
                MessageBox.Show("Nome: " + cliente.Nome + " ; Data de Nascimento: " + cliente.DataNascimento);
            }
            else if(!desenvolvedora.Email.Equals("") && desenvolvedora.Senha == passwordTextBox.Text)
            {
                MessageBox.Show("Nome: " + desenvolvedora.Nome + " ; Conta Bancária: " + desenvolvedora.ContaBancaria);
            }
            else
            {
                MessageBox.Show("Conta Não Encontrada!");
            }
        }
    }
}
