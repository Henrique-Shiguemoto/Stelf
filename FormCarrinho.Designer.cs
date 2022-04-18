
namespace Stelf
{
    partial class FormCarrinho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarrinho));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.voltarBtn = new System.Windows.Forms.Button();
            this.confirmarBtn = new System.Windows.Forms.Button();
            this.panelCarrinho = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCarrinho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(25, 25);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(221, 54);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "CARRINHO";
            // 
            // voltarBtn
            // 
            this.voltarBtn.Location = new System.Drawing.Point(636, 480);
            this.voltarBtn.Name = "voltarBtn";
            this.voltarBtn.Size = new System.Drawing.Size(102, 23);
            this.voltarBtn.TabIndex = 12;
            this.voltarBtn.Text = "Voltar";
            this.voltarBtn.UseVisualStyleBackColor = true;
            this.voltarBtn.Click += new System.EventHandler(this.voltarBtn_Click);
            // 
            // confirmarBtn
            // 
            this.confirmarBtn.Location = new System.Drawing.Point(514, 480);
            this.confirmarBtn.Name = "confirmarBtn";
            this.confirmarBtn.Size = new System.Drawing.Size(102, 23);
            this.confirmarBtn.TabIndex = 11;
            this.confirmarBtn.Text = "Confirmar";
            this.confirmarBtn.UseVisualStyleBackColor = true;
            // 
            // panelCarrinho
            // 
            this.panelCarrinho.AutoScroll = true;
            this.panelCarrinho.BackColor = System.Drawing.Color.Gray;
            this.panelCarrinho.Controls.Add(this.button1);
            this.panelCarrinho.Controls.Add(this.label3);
            this.panelCarrinho.Controls.Add(this.label2);
            this.panelCarrinho.Controls.Add(this.label1);
            this.panelCarrinho.Controls.Add(this.pictureBox1);
            this.panelCarrinho.Location = new System.Drawing.Point(12, 82);
            this.panelCarrinho.Name = "panelCarrinho";
            this.panelCarrinho.Size = new System.Drawing.Size(726, 333);
            this.panelCarrinho.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(651, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 21);
            this.button1.TabIndex = 4;
            this.button1.Text = "Remover";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(624, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preço";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(155, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome Desenvolvedora";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(155, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Jogo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 96);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormCarrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(750, 515);
            this.Controls.Add(this.panelCarrinho);
            this.Controls.Add(this.voltarBtn);
            this.Controls.Add(this.confirmarBtn);
            this.Controls.Add(this.labelTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(766, 554);
            this.MinimumSize = new System.Drawing.Size(766, 554);
            this.Name = "FormCarrinho";
            this.Text = "Carrinho";
            this.Load += new System.EventHandler(this.FormCarrinho_Load);
            this.panelCarrinho.ResumeLayout(false);
            this.panelCarrinho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button voltarBtn;
        private System.Windows.Forms.Button confirmarBtn;
        private System.Windows.Forms.Panel panelCarrinho;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}