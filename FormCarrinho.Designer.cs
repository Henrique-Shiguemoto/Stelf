
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
            this.lbTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(12, 14);
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
            this.confirmarBtn.Click += new System.EventHandler(this.confirmarBtn_Click);
            // 
            // panelCarrinho
            // 
            this.panelCarrinho.AutoScroll = true;
            this.panelCarrinho.BackColor = System.Drawing.Color.DarkGray;
            this.panelCarrinho.Location = new System.Drawing.Point(12, 82);
            this.panelCarrinho.Name = "panelCarrinho";
            this.panelCarrinho.Size = new System.Drawing.Size(726, 353);
            this.panelCarrinho.TabIndex = 13;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTotal.Location = new System.Drawing.Point(12, 450);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(68, 21);
            this.lbTotal.TabIndex = 14;
            this.lbTotal.Text = "TOTAL =";
            // 
            // FormCarrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(750, 515);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.panelCarrinho);
            this.Controls.Add(this.voltarBtn);
            this.Controls.Add(this.confirmarBtn);
            this.Controls.Add(this.labelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(766, 554);
            this.MinimumSize = new System.Drawing.Size(766, 554);
            this.Name = "FormCarrinho";
            this.Text = "Carrinho";
            this.Load += new System.EventHandler(this.FormCarrinho_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button voltarBtn;
        private System.Windows.Forms.Button confirmarBtn;
        private System.Windows.Forms.Panel panelCarrinho;
        private System.Windows.Forms.Label lbTotal;
    }
}