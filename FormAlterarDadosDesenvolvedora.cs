using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stelf
{
    public partial class FormAlterarDadosDesenvolvedora : Form
    {
        public FormAlterarDadosDesenvolvedora()
        {
            InitializeComponent();
        }

        private void desenvolvedoraAlterarDadosConfirmarBtn_Click(object sender, EventArgs e)
        {
            bool isNameValid = Validator.isNomeValid(nomeDesenvolvedoraAlterarDadosTextBox.Text);
            bool isSenhaValid = Validator.isSenhaValid(senhaDesenvolvedoraAlterarDadosTextBox.Text);
            bool isEmailValid = Validator.emailIsValid(emailDesenvolvedoraAlterarDadosTextBox.Text);
            bool isBancoValid = Validator.contaBancariaIsValid(contaBancariaComboBox.Text);

            if (!isNameValid || !isSenhaValid || !isEmailValid || !isBancoValid)
            {
                MessageBox.Show("Campos Inválidos");
            }
        }
    }
}
