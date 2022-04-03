using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stelf
{
    public partial class FormAlterarDadosCliente : Form
    {
        private Cliente cliente = null;
        
        public FormAlterarDadosCliente(Cliente cliente)
        {
            this.cliente = cliente;
            InitializeComponent();
        }

        private void clienteAlterarDadosConfirmarBtn_Click(object sender, EventArgs e)
        {
            bool isNameValid = Validator.isNomeValid(nomeClienteAlterarDadosTextBox.Text);
            bool isSenhaValid = Validator.isSenhaValid(senhaClienteAlterarDadosTextBox.Text);
            bool isEmailValid = Validator.emailIsValid(emailClienteAlterarDadosTextBox.Text);

            String[] mensagens_de_erro = { "Nome Inválido", "Senha Inválida", "E-mail Inválido"};
            String mensagem_erro = "";

            if (!isNameValid || !isSenhaValid || !isEmailValid)
            {
                if (!isNameValid)
                {
                    mensagem_erro += mensagens_de_erro[0] + "\n";
                }

                if (!isSenhaValid)
                {
                    mensagem_erro += mensagens_de_erro[1] + "\n";
                }

                if (!isEmailValid)
                {
                    mensagem_erro += mensagens_de_erro[2] + "\n";
                }
                MessageBox.Show(mensagem_erro, "Campos Inválidos!");
            }
            else
            {
                if(!String.IsNullOrWhiteSpace(nomeClienteAlterarDadosLabel.Text))
                {
                    String param = "{$set: { 'Nome' : " + nomeClienteAlterarDadosLabel.Text + "} }";
                    String filter = "{ 'Nome' : 'DiegoTakahashi'}";
                }
            }
        }

        private void clienteAlterarDadosCancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAlterarDadosCliente_VisibleChanged(object sender, EventArgs e)
        {
            ConnectionDB barqueiro = new ConnectionDB();

            Cliente clienteRetornado = barqueiro.devolverClientePorEmail(cliente.Email);

            nomeClienteAlterarDadosTextBox.Text = clienteRetornado.Nome;
            senhaClienteAlterarDadosTextBox.Text = clienteRetornado.Senha;
            emailClienteAlterarDadosTextBox.Text = clienteRetornado.Email;
        }
    }
}
