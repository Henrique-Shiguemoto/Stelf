using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MongoDB.Driver;

namespace Stelf
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void voltarCadastroBtn_Click(object sender, EventArgs e)
        {
            var formLogin = (FormLauncher)Tag;
            formLogin.Show();
            Close();
        }

        private void devRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            contaBancariaComboBox.Enabled = true;
            dataNascimentoCadastro.Enabled = false;
        }

        private void clienteRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            dataNascimentoCadastro.Enabled = true;
            contaBancariaComboBox.Enabled = false;
        }

        private void confirmarBtn_Click(object sender, EventArgs e)
        {
            bool isNameValid = Validator.isNomeValid(nomeTextBox.Text);
            bool isSenhaValid = Validator.isSenhaValid(senhaTextBox.Text);
            bool isEmailValid = Validator.emailIsValid(emailTextBox.Text);
            bool isBancoValid = true;

            String[] mensagens_de_erro = {"Nome Inválido", "Senha Inválida", "E-mail Inválido", "Banco Inválido"};
            String mensagem_erro = "";

            if (devRadioBtn.Checked)
            {
                isBancoValid = Validator.contaBancariaIsValid(contaBancariaComboBox.Text);
            }

            if (!isNameValid || !isSenhaValid || !isEmailValid || !isBancoValid)
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

                if (!isBancoValid)
                {
                    mensagem_erro += mensagens_de_erro[3] + "\n";
                }
                MessageBox.Show(mensagem_erro, "Campos Inválidos!");
            }
            //Se forem validos, então a conexão com o banco de dados será realizada
            else
            {
                ConnectionDB barqueiro = new ConnectionDB();
                
                if (devRadioBtn.Checked)
                {
                    //ContaBancaria conta = new ContaBancaria();
                    //conta.banco = ;
                    //conta.agencia = ;
                    //conta.conta = ;
                    //conta.nome = ;
                    barqueiro.inserirDesenvolvedora(nomeTextBox.Text, emailTextBox.Text, senhaTextBox.Text, /*tipo ContaBancaria*/ contaBancariaComboBox.Text);
                    MessageBox.Show("Nova Desenvolvedora adicionado");
                }
                if (clienteRadioBtn.Checked)
                {                    
                    barqueiro.inserirCliente(nomeTextBox.Text, emailTextBox.Text, senhaTextBox.Text, dataNascimentoCadastro.Value);
                    MessageBox.Show("Novo Cliente adicionado");
                }
            }
        }
    }
}
