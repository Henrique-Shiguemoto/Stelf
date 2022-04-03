using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stelf
{
    public partial class FormLoja : Form
    {
        private Cliente cliente;
        private Desenvolvedora desenvolvedora;

        public FormLoja(Cliente clienteLogado, Desenvolvedora desenvolvedoraLogada)  
        {
            this.cliente = clienteLogado;
            this.desenvolvedora = desenvolvedoraLogada;
            InitializeComponent();
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

        private void panelConteudo_VisibleChanged(object sender, EventArgs e)
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
    }
}
