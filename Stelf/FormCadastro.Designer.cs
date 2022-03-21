
namespace Stelf
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            this.cadastroLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.dataNascimentoLabel = new System.Windows.Forms.Label();
            this.senhaLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.confirmarBtn = new System.Windows.Forms.Button();
            this.voltarCadastroBtn = new System.Windows.Forms.Button();
            this.clienteRadioBtn = new System.Windows.Forms.RadioButton();
            this.devRadioBtn = new System.Windows.Forms.RadioButton();
            this.tipoContaGroupBox = new System.Windows.Forms.GroupBox();
            this.contaBancariaLabel = new System.Windows.Forms.Label();
            this.contaBancariaComboBox = new System.Windows.Forms.ComboBox();
            this.obsLabel = new System.Windows.Forms.Label();
            this.dataNascimentoCadastro = new System.Windows.Forms.DateTimePicker();
            this.tipoContaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cadastroLabel
            // 
            this.cadastroLabel.AutoSize = true;
            this.cadastroLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cadastroLabel.Location = new System.Drawing.Point(173, 50);
            this.cadastroLabel.Name = "cadastroLabel";
            this.cadastroLabel.Size = new System.Drawing.Size(166, 38);
            this.cadastroLabel.TabIndex = 0;
            this.cadastroLabel.Text = "Cadastrar";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomeLabel.Location = new System.Drawing.Point(31, 241);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(66, 22);
            this.nomeLabel.TabIndex = 1;
            this.nomeLabel.Text = "Nome:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(32, 303);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(68, 22);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "E-mail:";
            // 
            // dataNascimentoLabel
            // 
            this.dataNascimentoLabel.AutoSize = true;
            this.dataNascimentoLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataNascimentoLabel.Location = new System.Drawing.Point(32, 440);
            this.dataNascimentoLabel.Name = "dataNascimentoLabel";
            this.dataNascimentoLabel.Size = new System.Drawing.Size(186, 22);
            this.dataNascimentoLabel.TabIndex = 3;
            this.dataNascimentoLabel.Text = "Data de Nascimento:";
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.senhaLabel.Location = new System.Drawing.Point(32, 372);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(69, 22);
            this.senhaLabel.TabIndex = 4;
            this.senhaLabel.Text = "Senha:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(32, 269);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(466, 23);
            this.nomeTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(32, 332);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(466, 23);
            this.emailTextBox.TabIndex = 6;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(33, 401);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(466, 23);
            this.senhaTextBox.TabIndex = 8;
            // 
            // confirmarBtn
            // 
            this.confirmarBtn.Location = new System.Drawing.Point(274, 584);
            this.confirmarBtn.Name = "confirmarBtn";
            this.confirmarBtn.Size = new System.Drawing.Size(102, 23);
            this.confirmarBtn.TabIndex = 9;
            this.confirmarBtn.Text = "Confirmar";
            this.confirmarBtn.UseVisualStyleBackColor = true;
            this.confirmarBtn.Click += new System.EventHandler(this.confirmarBtn_Click);
            // 
            // voltarCadastroBtn
            // 
            this.voltarCadastroBtn.Location = new System.Drawing.Point(396, 584);
            this.voltarCadastroBtn.Name = "voltarCadastroBtn";
            this.voltarCadastroBtn.Size = new System.Drawing.Size(102, 23);
            this.voltarCadastroBtn.TabIndex = 10;
            this.voltarCadastroBtn.Text = "Voltar";
            this.voltarCadastroBtn.UseVisualStyleBackColor = true;
            this.voltarCadastroBtn.Click += new System.EventHandler(this.voltarCadastroBtn_Click);
            // 
            // clienteRadioBtn
            // 
            this.clienteRadioBtn.AutoSize = true;
            this.clienteRadioBtn.Checked = true;
            this.clienteRadioBtn.Location = new System.Drawing.Point(63, 45);
            this.clienteRadioBtn.Name = "clienteRadioBtn";
            this.clienteRadioBtn.Size = new System.Drawing.Size(89, 29);
            this.clienteRadioBtn.TabIndex = 11;
            this.clienteRadioBtn.TabStop = true;
            this.clienteRadioBtn.Text = "Cliente";
            this.clienteRadioBtn.UseVisualStyleBackColor = true;
            this.clienteRadioBtn.CheckedChanged += new System.EventHandler(this.clienteRadioBtn_CheckedChanged);
            // 
            // devRadioBtn
            // 
            this.devRadioBtn.AutoSize = true;
            this.devRadioBtn.Location = new System.Drawing.Point(241, 45);
            this.devRadioBtn.Name = "devRadioBtn";
            this.devRadioBtn.Size = new System.Drawing.Size(165, 29);
            this.devRadioBtn.TabIndex = 12;
            this.devRadioBtn.Text = "Desenvolvedora";
            this.devRadioBtn.UseVisualStyleBackColor = true;
            this.devRadioBtn.CheckedChanged += new System.EventHandler(this.devRadioBtn_CheckedChanged);
            // 
            // tipoContaGroupBox
            // 
            this.tipoContaGroupBox.Controls.Add(this.clienteRadioBtn);
            this.tipoContaGroupBox.Controls.Add(this.devRadioBtn);
            this.tipoContaGroupBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tipoContaGroupBox.Location = new System.Drawing.Point(33, 123);
            this.tipoContaGroupBox.Name = "tipoContaGroupBox";
            this.tipoContaGroupBox.Size = new System.Drawing.Size(466, 104);
            this.tipoContaGroupBox.TabIndex = 14;
            this.tipoContaGroupBox.TabStop = false;
            this.tipoContaGroupBox.Text = "Tipo de Conta:";
            // 
            // contaBancariaLabel
            // 
            this.contaBancariaLabel.AutoSize = true;
            this.contaBancariaLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contaBancariaLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.contaBancariaLabel.Location = new System.Drawing.Point(33, 510);
            this.contaBancariaLabel.Name = "contaBancariaLabel";
            this.contaBancariaLabel.Size = new System.Drawing.Size(143, 22);
            this.contaBancariaLabel.TabIndex = 15;
            this.contaBancariaLabel.Text = "Conta Bancária:";
            // 
            // contaBancariaComboBox
            // 
            this.contaBancariaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contaBancariaComboBox.Enabled = false;
            this.contaBancariaComboBox.FormattingEnabled = true;
            this.contaBancariaComboBox.Items.AddRange(new object[] {
            "Nubank",
            "PicPay",
            "Caixa Econômica",
            "Banco do Brasil"});
            this.contaBancariaComboBox.Location = new System.Drawing.Point(33, 540);
            this.contaBancariaComboBox.Name = "contaBancariaComboBox";
            this.contaBancariaComboBox.Size = new System.Drawing.Size(236, 23);
            this.contaBancariaComboBox.TabIndex = 17;
            // 
            // obsLabel
            // 
            this.obsLabel.AutoSize = true;
            this.obsLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.obsLabel.Location = new System.Drawing.Point(275, 547);
            this.obsLabel.Name = "obsLabel";
            this.obsLabel.Size = new System.Drawing.Size(226, 13);
            this.obsLabel.TabIndex = 18;
            this.obsLabel.Text = "Obs: Opção para desenvolvedoras apenas.";
            // 
            // dataNascimentoCadastro
            // 
            this.dataNascimentoCadastro.Location = new System.Drawing.Point(33, 471);
            this.dataNascimentoCadastro.Name = "dataNascimentoCadastro";
            this.dataNascimentoCadastro.Size = new System.Drawing.Size(236, 23);
            this.dataNascimentoCadastro.TabIndex = 19;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(524, 622);
            this.Controls.Add(this.dataNascimentoCadastro);
            this.Controls.Add(this.obsLabel);
            this.Controls.Add(this.contaBancariaComboBox);
            this.Controls.Add(this.contaBancariaLabel);
            this.Controls.Add(this.voltarCadastroBtn);
            this.Controls.Add(this.confirmarBtn);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.senhaLabel);
            this.Controls.Add(this.dataNascimentoLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.cadastroLabel);
            this.Controls.Add(this.tipoContaGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(540, 661);
            this.MinimumSize = new System.Drawing.Size(540, 661);
            this.Name = "FormCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.tipoContaGroupBox.ResumeLayout(false);
            this.tipoContaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cadastroLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label dataNascimentoLabel;
        private System.Windows.Forms.Label senhaLabel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Button confirmarBtn;
        private System.Windows.Forms.Button voltarCadastroBtn;
        private System.Windows.Forms.RadioButton clienteRadioBtn;
        private System.Windows.Forms.RadioButton devRadioBtn;
        private System.Windows.Forms.GroupBox tipoContaGroupBox;
        private System.Windows.Forms.Label contaBancariaLabel;
        private System.Windows.Forms.ComboBox contaBancariaComboBox;
        private System.Windows.Forms.Label obsLabel;
        private System.Windows.Forms.DateTimePicker dataNascimentoCadastro;
    }
}