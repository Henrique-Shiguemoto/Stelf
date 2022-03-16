using System;
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
    }
}
