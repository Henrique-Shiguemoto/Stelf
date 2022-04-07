﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MongoDB.Driver.Linq;

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
            if (!desenvolvedora.Email.Equals("") && cliente.Email.Equals(""))
            {
                btnAdicionarJogo.Visible = true;
            }
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

        private void btnAdicionarJogo_Click(object sender, EventArgs e)
        {
            FormAddJogo frmAddJogo = new FormAddJogo(desenvolvedora);
            frmAddJogo.Tag = this;
            frmAddJogo.Show(this);
            Hide();
        }

        private void FormLoja_VisibleChanged(object sender, EventArgs e)
        {
            ConnectionDB barqueiro = new ConnectionDB();
            var jogos = barqueiro.getJogoList();

            int linha = -1;
            for (int i = 0; i < jogos.Count; i++)
            {
                int x_pic = 235;
                int y_pic = 158;
                int x_button = 235;
                int y_button = 308;
                int coluna = i % 3;
                if (coluna == 0)
                {
                    linha++;
                }

                int x_offset = 269;
                int y_offset_button = 150;
                int y_offset_picture_box = 221;

                var pic = new PictureBox();
                pic.Location = new Point(x_pic + coluna*x_offset, y_pic + linha*y_offset_picture_box);
                pic.Size = new Size(253, 151);
                pic.Image = barqueiro.BytesToImage(jogos[i].imagem);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(pic);

                var button = new Button();
                button.Text = "R$ " + jogos[i].preco.ToString();
                button.BackColor = Color.LightGreen;
                button.Location = new Point(x_button + coluna * x_offset, y_button + linha* y_offset_picture_box);
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.Size = new Size(253, 23);
                this.Controls.Add(button);
            }
        }
    }
}
