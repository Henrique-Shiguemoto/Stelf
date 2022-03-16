using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            dataNascimentoTextBox.Enabled = false;
        }

        private void clienteRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            dataNascimentoTextBox.Enabled = true;
            contaBancariaComboBox.Enabled = false;
        }
    }
}
