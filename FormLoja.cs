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
        public FormLoja(Cliente clienteLogado, Desenvolvedora desenvolvedoraLogada)  
        {
            this.cliente = clienteLogado;
            this.desenvolvedora = desenvolvedoraLogada;
            InitializeComponent();
        }

        private Cliente cliente;
        private Desenvolvedora desenvolvedora;

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            if (cliente == null) {
                FormAlterarDadosDesenvolvedora formAlterarDadosD = new FormAlterarDadosDesenvolvedora();
                formAlterarDadosD.Show();
            } else
            {
                FormAlterarDadosCliente formAlterarDadosC = new FormAlterarDadosCliente();
                formAlterarDadosC.Show();
            }
            
        }
    }
}
