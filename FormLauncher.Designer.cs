
namespace Stelf
{
    partial class FormLauncher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLauncher));
            this.stelfLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.senhaLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.entrarBtn = new System.Windows.Forms.Button();
            this.cadastrarLauncherBtn = new System.Windows.Forms.Button();
            this.checkBoxExibirSenha = new System.Windows.Forms.CheckBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // stelfLabel
            // 
            this.stelfLabel.AutoSize = true;
            this.stelfLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.stelfLabel.Location = new System.Drawing.Point(218, 68);
            this.stelfLabel.Name = "stelfLabel";
            this.stelfLabel.Size = new System.Drawing.Size(105, 38);
            this.stelfLabel.TabIndex = 0;
            this.stelfLabel.Text = "STELF";
            this.stelfLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(19, 123);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(70, 25);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "E-mail:";
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.senhaLabel.Location = new System.Drawing.Point(19, 187);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(68, 25);
            this.senhaLabel.TabIndex = 2;
            this.senhaLabel.Text = "Senha:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(27, 151);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(495, 23);
            this.emailTextBox.TabIndex = 3;
            this.emailTextBox.Text = "gabriel551@hotmail.com";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(27, 215);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.Size = new System.Drawing.Size(495, 23);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.Text = "gabriel55551";
            // 
            // entrarBtn
            // 
            this.entrarBtn.Location = new System.Drawing.Point(420, 271);
            this.entrarBtn.Name = "entrarBtn";
            this.entrarBtn.Size = new System.Drawing.Size(102, 23);
            this.entrarBtn.TabIndex = 5;
            this.entrarBtn.Text = "Entrar";
            this.entrarBtn.UseVisualStyleBackColor = true;
            this.entrarBtn.Click += new System.EventHandler(this.entrarBtn_Click);
            // 
            // cadastrarLauncherBtn
            // 
            this.cadastrarLauncherBtn.Location = new System.Drawing.Point(303, 271);
            this.cadastrarLauncherBtn.Name = "cadastrarLauncherBtn";
            this.cadastrarLauncherBtn.Size = new System.Drawing.Size(102, 23);
            this.cadastrarLauncherBtn.TabIndex = 6;
            this.cadastrarLauncherBtn.Text = "Cadastrar";
            this.cadastrarLauncherBtn.UseVisualStyleBackColor = true;
            this.cadastrarLauncherBtn.Click += new System.EventHandler(this.cadastrarLauncherBtn_Click);
            // 
            // checkBoxExibirSenha
            // 
            this.checkBoxExibirSenha.AutoSize = true;
            this.checkBoxExibirSenha.Location = new System.Drawing.Point(27, 244);
            this.checkBoxExibirSenha.Name = "checkBoxExibirSenha";
            this.checkBoxExibirSenha.Size = new System.Drawing.Size(90, 19);
            this.checkBoxExibirSenha.TabIndex = 7;
            this.checkBoxExibirSenha.Text = "Exibir Senha";
            this.checkBoxExibirSenha.UseVisualStyleBackColor = true;
            this.checkBoxExibirSenha.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.BackgroundImage")));
            this.pictureBoxClose.Location = new System.Drawing.Point(528, 3);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 8;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // FormLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(555, 318);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.checkBoxExibirSenha);
            this.Controls.Add(this.cadastrarLauncherBtn);
            this.Controls.Add(this.entrarBtn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.senhaLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.stelfLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(555, 318);
            this.MinimumSize = new System.Drawing.Size(555, 318);
            this.Name = "FormLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher";
            this.VisibleChanged += new System.EventHandler(this.FormLauncher_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stelfLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label senhaLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button entrarBtn;
        private System.Windows.Forms.Button cadastrarLauncherBtn;
        private System.Windows.Forms.CheckBox checkBoxExibirSenha;
        private System.Windows.Forms.PictureBox pictureBoxClose;
    }
}

