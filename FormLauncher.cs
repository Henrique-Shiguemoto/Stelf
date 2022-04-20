﻿using System;
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

            if (emailTextBox.Text.Length == 0)
            {
                MessageBox.Show("Preencha o email!");
            }

            if (!cliente.Email.Equals("") && cliente.Senha == passwordTextBox.Text)
            {
                FormLoja frmLoja = new FormLoja(cliente, desenvolvedora);
                frmLoja.Tag = this;
                frmLoja.Show(this);
                Hide();
            }
            else if(!desenvolvedora.Email.Equals("") && desenvolvedora.Senha == passwordTextBox.Text)
            {
                FormLoja frmLoja = new FormLoja(cliente, desenvolvedora);
                frmLoja.Tag = this;
                frmLoja.Show(this);
                Hide();
            }
            else
            {
                MessageBox.Show("Conta Não Encontrada!");
            }
            Hide();
        }

        private void FormLauncher_VisibleChanged(object sender, EventArgs e)
        {
            //emailTextBox.Text = "";
            //passwordTextBox.Text = "";
        }
    }
}
