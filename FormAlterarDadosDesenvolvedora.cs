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
        private Desenvolvedora desenvolvedora;

        public FormAlterarDadosDesenvolvedora(Desenvolvedora desenvolvedora)
        {
            this.desenvolvedora = desenvolvedora;
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

        private void desenvolvedoraAlterarDadosCancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAlterarDadosDesenvolvedora_VisibleChanged(object sender, EventArgs e)
        {
            ConnectionDB barqueiro = new ConnectionDB();
            Desenvolvedora desenvolvedoraRetornada = barqueiro.devolverDesenvolvedoraPorEmail(desenvolvedora.Email);

            nomeDesenvolvedoraAlterarDadosTextBox.Text = desenvolvedoraRetornada.Nome;
            senhaDesenvolvedoraAlterarDadosTextBox.Text = desenvolvedoraRetornada.Senha;
            emailDesenvolvedoraAlterarDadosTextBox.Text = desenvolvedoraRetornada.Email;
            contaBancariaComboBox.Text = desenvolvedoraRetornada.contaBancaria;
        }
    }
}
