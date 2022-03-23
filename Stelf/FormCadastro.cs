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
            bool isNameValid = Validator.isValid(nomeTextBox.Text);
            bool isSenhaValid = Validator.isValid(senhaTextBox.Text);
            bool isEmailValid = Validator.emailIsValid(emailTextBox.Text);
            bool isBancoValid = true;
            
            if (devRadioBtn.Checked)
            {
                isBancoValid = Validator.contaBancariaIsValid(contaBancariaComboBox.Text);
            }

            //Se algum dos campos forem invalidados
            if (!isNameValid || !isEmailValid || !isSenhaValid || !isBancoValid)
            {
                MessageBox.Show("Campos Inválidos!");
            }
            //Se forem validos, então a conexão com o banco de dados será realizada
            else
            {
                ConnectionDB barqueiro = new ConnectionDB();
                
                if (devRadioBtn.Checked)
                {
                    barqueiro.inserirDesenvolvedora(nomeTextBox.Text, emailTextBox.Text, senhaTextBox.Text, contaBancariaComboBox.Text);
                    MessageBox.Show("Nova Desenvolvedora adicionado");
                }
                if (clienteRadioBtn.Checked)
                {
                    barqueiro.inserirCliente(nomeTextBox.Text, emailTextBox.Text, senhaTextBox.Text, dataNascimentoCadastro.Text);
                    MessageBox.Show("Novo Cliente adicionado");
                }
            }
        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataNascimentoCadastro_ValueChanged(object sender, EventArgs e)
        {

        }

        private void senhaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
