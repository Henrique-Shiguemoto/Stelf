
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
            this.SuspendLayout();
            // 
            // stelfLabel
            // 
            this.stelfLabel.AutoSize = true;
            this.stelfLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.stelfLabel.Location = new System.Drawing.Point(211, 35);
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
            this.emailLabel.Location = new System.Drawing.Point(12, 90);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(70, 25);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "E-mail:";
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.senhaLabel.Location = new System.Drawing.Point(12, 154);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(68, 25);
            this.senhaLabel.TabIndex = 2;
            this.senhaLabel.Text = "Senha:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(20, 118);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(495, 23);
            this.emailTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(20, 182);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(495, 23);
            this.passwordTextBox.TabIndex = 4;
            // 
            // entrarBtn
            // 
            this.entrarBtn.Location = new System.Drawing.Point(413, 238);
            this.entrarBtn.Name = "entrarBtn";
            this.entrarBtn.Size = new System.Drawing.Size(102, 23);
            this.entrarBtn.TabIndex = 5;
            this.entrarBtn.Text = "Entrar";
            this.entrarBtn.UseVisualStyleBackColor = true;
            this.entrarBtn.Click += new System.EventHandler(this.entrarBtn_Click);
            // 
            // cadastrarLauncherBtn
            // 
            this.cadastrarLauncherBtn.Location = new System.Drawing.Point(296, 238);
            this.cadastrarLauncherBtn.Name = "cadastrarLauncherBtn";
            this.cadastrarLauncherBtn.Size = new System.Drawing.Size(102, 23);
            this.cadastrarLauncherBtn.TabIndex = 6;
            this.cadastrarLauncherBtn.Text = "Cadastrar";
            this.cadastrarLauncherBtn.UseVisualStyleBackColor = true;
            this.cadastrarLauncherBtn.Click += new System.EventHandler(this.cadastrarLauncherBtn_Click);
            // 
            // FormLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(539, 279);
            this.Controls.Add(this.cadastrarLauncherBtn);
            this.Controls.Add(this.entrarBtn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.senhaLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.stelfLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(555, 318);
            this.MinimumSize = new System.Drawing.Size(555, 318);
            this.Name = "FormLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher";
            this.VisibleChanged += new System.EventHandler(this.FormLauncher_VisibleChanged);
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
    }
}

