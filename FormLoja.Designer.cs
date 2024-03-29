﻿
namespace Stelf
{
    partial class FormLoja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoja));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnAdicionarJogo = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnEditarPerfil = new System.Windows.Forms.Button();
            this.btnBiblioteca = new System.Windows.Forms.Button();
            this.btnLoja = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxBusca = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.panelJogos = new System.Windows.Forms.Panel();
            this.btnCarrinho = new System.Windows.Forms.Button();
            this.panelPrincipal.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.Gray;
            this.panelPrincipal.Controls.Add(this.btnAdicionarJogo);
            this.panelPrincipal.Controls.Add(this.btnLogOut);
            this.panelPrincipal.Controls.Add(this.btnEditarPerfil);
            this.panelPrincipal.Controls.Add(this.btnBiblioteca);
            this.panelPrincipal.Controls.Add(this.btnLoja);
            this.panelPrincipal.Controls.Add(this.panelLogo);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(200, 596);
            this.panelPrincipal.TabIndex = 0;
            // 
            // btnAdicionarJogo
            // 
            this.btnAdicionarJogo.BackColor = System.Drawing.Color.DimGray;
            this.btnAdicionarJogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdicionarJogo.FlatAppearance.BorderSize = 0;
            this.btnAdicionarJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarJogo.Location = new System.Drawing.Point(0, 465);
            this.btnAdicionarJogo.Name = "btnAdicionarJogo";
            this.btnAdicionarJogo.Size = new System.Drawing.Size(200, 65);
            this.btnAdicionarJogo.TabIndex = 5;
            this.btnAdicionarJogo.Text = "ADICIONAR JOGO";
            this.btnAdicionarJogo.UseVisualStyleBackColor = false;
            this.btnAdicionarJogo.Visible = false;
            this.btnAdicionarJogo.Click += new System.EventHandler(this.btnAdicionarJogo_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.DimGray;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Location = new System.Drawing.Point(0, 530);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(200, 66);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "DESCONECTAR";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnEditarPerfil
            // 
            this.btnEditarPerfil.BackColor = System.Drawing.Color.DimGray;
            this.btnEditarPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditarPerfil.FlatAppearance.BorderSize = 0;
            this.btnEditarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPerfil.Location = new System.Drawing.Point(0, 399);
            this.btnEditarPerfil.Name = "btnEditarPerfil";
            this.btnEditarPerfil.Size = new System.Drawing.Size(200, 66);
            this.btnEditarPerfil.TabIndex = 3;
            this.btnEditarPerfil.Text = "EDITAR PERFIL";
            this.btnEditarPerfil.UseVisualStyleBackColor = false;
            this.btnEditarPerfil.Click += new System.EventHandler(this.btnEditarPerfil_Click);
            // 
            // btnBiblioteca
            // 
            this.btnBiblioteca.BackColor = System.Drawing.Color.DimGray;
            this.btnBiblioteca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBiblioteca.FlatAppearance.BorderSize = 0;
            this.btnBiblioteca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBiblioteca.Location = new System.Drawing.Point(0, 333);
            this.btnBiblioteca.Name = "btnBiblioteca";
            this.btnBiblioteca.Size = new System.Drawing.Size(200, 66);
            this.btnBiblioteca.TabIndex = 2;
            this.btnBiblioteca.Text = "BIBLIOTECA";
            this.btnBiblioteca.UseVisualStyleBackColor = false;
            this.btnBiblioteca.Click += new System.EventHandler(this.btnBiblioteca_Click);
            // 
            // btnLoja
            // 
            this.btnLoja.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoja.BackColor = System.Drawing.Color.DimGray;
            this.btnLoja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLoja.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoja.FlatAppearance.BorderSize = 0;
            this.btnLoja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoja.Location = new System.Drawing.Point(0, 267);
            this.btnLoja.Name = "btnLoja";
            this.btnLoja.Size = new System.Drawing.Size(200, 66);
            this.btnLoja.TabIndex = 1;
            this.btnLoja.Text = "LOJA";
            this.btnLoja.UseVisualStyleBackColor = false;
            this.btnLoja.Click += new System.EventHandler(this.btnLoja_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.DimGray;
            this.panelLogo.Controls.Add(this.lbEmail);
            this.panelLogo.Controls.Add(this.lbNome);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 267);
            this.panelLogo.TabIndex = 0;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbEmail.Location = new System.Drawing.Point(26, 214);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(45, 18);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Email";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbNome.Location = new System.Drawing.Point(26, 177);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(49, 18);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Stelf.Properties.Resources.final;
            this.pictureBox1.Location = new System.Drawing.Point(26, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxBusca
            // 
            this.textBoxBusca.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxBusca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBusca.Location = new System.Drawing.Point(757, 23);
            this.textBoxBusca.Name = "textBoxBusca";
            this.textBoxBusca.Size = new System.Drawing.Size(290, 16);
            this.textBoxBusca.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(927, 47);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(232, 41);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(145, 54);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "L O J A";
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Items.AddRange(new object[] {
            "Nome",
            "Desenvolvedora",
            "Faixa Etária",
            "Preço",
            "Gênero"});
            this.comboBoxFiltro.Location = new System.Drawing.Point(757, 47);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(164, 23);
            this.comboBoxFiltro.TabIndex = 7;
            // 
            // panelJogos
            // 
            this.panelJogos.AutoScroll = true;
            this.panelJogos.BackColor = System.Drawing.Color.Silver;
            this.panelJogos.Location = new System.Drawing.Point(217, 121);
            this.panelJogos.Name = "panelJogos";
            this.panelJogos.Size = new System.Drawing.Size(834, 463);
            this.panelJogos.TabIndex = 8;
            // 
            // btnCarrinho
            // 
            this.btnCarrinho.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCarrinho.FlatAppearance.BorderSize = 0;
            this.btnCarrinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarrinho.Location = new System.Drawing.Point(927, 92);
            this.btnCarrinho.Name = "btnCarrinho";
            this.btnCarrinho.Size = new System.Drawing.Size(120, 23);
            this.btnCarrinho.TabIndex = 9;
            this.btnCarrinho.Text = "Carrinho";
            this.btnCarrinho.UseVisualStyleBackColor = false;
            this.btnCarrinho.Click += new System.EventHandler(this.btnCarrinho_Click);
            // 
            // FormLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1063, 596);
            this.Controls.Add(this.btnCarrinho);
            this.Controls.Add(this.panelJogos);
            this.Controls.Add(this.comboBoxFiltro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.textBoxBusca);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLoja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loja Principal";
            this.VisibleChanged += new System.EventHandler(this.FormLoja_VisibleChanged);
            this.panelPrincipal.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnBiblioteca;
        private System.Windows.Forms.Button btnEditarPerfil;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TextBox textBoxBusca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAdicionarJogo;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button btnLoja;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.Panel panelJogos;
        private System.Windows.Forms.Button btnCarrinho;
    }
}