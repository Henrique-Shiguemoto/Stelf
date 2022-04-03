
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnEditarPerfil = new System.Windows.Forms.Button();
            this.btnBiblioteca = new System.Windows.Forms.Button();
            this.btnLoja = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxBusca = new System.Windows.Forms.TextBox();
            this.panelConteudo = new System.Windows.Forms.FlowLayoutPanel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelPrincipal.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.SystemColors.HotTrack;
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
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.Location = new System.Drawing.Point(0, 530);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(200, 66);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "DESCONECTAR";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnEditarPerfil
            // 
            this.btnEditarPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditarPerfil.Location = new System.Drawing.Point(0, 399);
            this.btnEditarPerfil.Name = "btnEditarPerfil";
            this.btnEditarPerfil.Size = new System.Drawing.Size(200, 66);
            this.btnEditarPerfil.TabIndex = 3;
            this.btnEditarPerfil.Text = "EDITAR PERFIL";
            this.btnEditarPerfil.UseVisualStyleBackColor = true;
            this.btnEditarPerfil.Click += new System.EventHandler(this.btnEditarPerfil_Click);
            // 
            // btnBiblioteca
            // 
            this.btnBiblioteca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBiblioteca.Location = new System.Drawing.Point(0, 333);
            this.btnBiblioteca.Name = "btnBiblioteca";
            this.btnBiblioteca.Size = new System.Drawing.Size(200, 66);
            this.btnBiblioteca.TabIndex = 2;
            this.btnBiblioteca.Text = "BIBLIOTECA";
            this.btnBiblioteca.UseVisualStyleBackColor = true;
            // 
            // btnLoja
            // 
            this.btnLoja.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoja.Location = new System.Drawing.Point(0, 267);
            this.btnLoja.Name = "btnLoja";
            this.btnLoja.Size = new System.Drawing.Size(200, 66);
            this.btnLoja.TabIndex = 1;
            this.btnLoja.Text = "LOJA";
            this.btnLoja.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelLogo.Controls.Add(this.lbDataNascimento);
            this.panelLogo.Controls.Add(this.lbEmail);
            this.panelLogo.Controls.Add(this.lbNome);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 267);
            this.panelLogo.TabIndex = 0;
            // 
            // lbDataNascimento
            // 
            this.lbDataNascimento.AutoSize = true;
            this.lbDataNascimento.Font = new System.Drawing.Font("SF Movie Poster", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDataNascimento.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbDataNascimento.Location = new System.Drawing.Point(59, 224);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(89, 13);
            this.lbDataNascimento.TabIndex = 3;
            this.lbDataNascimento.Text = "Data Nascimento";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("SF Movie Poster", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbEmail.Location = new System.Drawing.Point(59, 197);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(33, 13);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Email";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("SF Movie Poster", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbNome.Location = new System.Drawing.Point(59, 166);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(32, 13);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(26, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxBusca
            // 
            this.textBoxBusca.Location = new System.Drawing.Point(408, 21);
            this.textBoxBusca.Name = "textBoxBusca";
            this.textBoxBusca.Size = new System.Drawing.Size(290, 23);
            this.textBoxBusca.TabIndex = 1;
            // 
            // panelConteudo
            // 
            this.panelConteudo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelConteudo.Location = new System.Drawing.Point(200, 71);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(863, 525);
            this.panelConteudo.TabIndex = 5;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(304, 12);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(57, 32);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Loja";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(744, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // FormLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1063, 596);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.textBoxBusca);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "FormLoja";
            this.Text = "Loja Principal";
            this.panelPrincipal.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBiblioteca;
        private System.Windows.Forms.Button btnLoja;
        private System.Windows.Forms.Button btnEditarPerfil;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TextBox textBoxBusca;
        private System.Windows.Forms.FlowLayoutPanel panelConteudo;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lbDataNascimento;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbNome;
    }
}