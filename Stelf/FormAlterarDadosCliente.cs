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
        public FormAlterarDadosCliente()
        {
            InitializeComponent();
        }

        private void clienteAlterarDadosConfirmarBtn_Click(object sender, EventArgs e)
        {
            bool isNameValid = Validator.isValid(nomeClienteAlterarDadosTextBox.Text);
            bool isSenhaValid = Validator.isValid(senhaClienteAlterarDadosTextBox.Text);
            bool isEmailValid = Validator.emailIsValid(emailClienteAlterarDadosTextBox.Text);

            if (!isNameValid || !isSenhaValid || !isEmailValid)
            {
                MessageBox.Show("Campos Inválidos");
            }
        }
    }
}
