using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Stelf
{
    public partial class FormAddJogo : Form
    {
        private Desenvolvedora desenvolvedora;
        public FormAddJogo(Desenvolvedora desenvolvedoraLogada)
        {
            this.desenvolvedora = desenvolvedoraLogada;
            InitializeComponent();
        }
        public byte[] ImageToBytes(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
        public Image BytesToImage(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }   
        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dig = new OpenFileDialog())
            {
                dig.Title = "Select image";
                dig.Filter = "jpg files (*.jpg)|*.jpg";

                if(dig.ShowDialog() == DialogResult.OK)
                {
                    imagemPictureBox.Image = new Bitmap(dig.FileName);
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Requisitos reqMin = new Requisitos();
            reqMin.ram = reqMinRamTextBox.Text;
            reqMin.processador = reqMinProcTextBox.Text;
            reqMin.placaVideo = reqMinGpuTextBox.Text;
            reqMin.rede = reqMinRedeTextBox.Text;
            reqMin.espacoDisco = reqMinDiscoTextBox.Text;
            Requisitos reqRec = new Requisitos();
            reqRec.ram = reqRecRamTextBox.Text;
            reqRec.processador = reqRecProcTextBox.Text;
            reqRec.placaVideo = reqRecGpuTextBox.Text;
            reqRec.rede = reqRecRedeTextBox.Text;
            reqRec.espacoDisco = reqRecDiscoTextBox.Text;
            ConnectionDB barqueiro = new ConnectionDB();
            float preco = (float)Convert.ToDouble(precoTextBox.Text);
            bool validoPreco = float.TryParse(precoTextBox.Text.ToString(), out preco);
            int faixaEt = (int)Convert.ToInt32 (faixaEtTextBox.Text);
            bool validoEt = int.TryParse(faixaEtTextBox.Text.ToString(), out faixaEt);
            barqueiro.inserirJogo(nomeTextBox.Text, ImageToBytes(imagemPictureBox.Image), preco, generoTextBox.Text, faixaEt, desenvolvedora, reqMin, reqRec, descTextBox.Text);
            MessageBox.Show("Jogo Adicionado!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var formLoja = (FormLoja)Tag;
            formLoja.Show();
            Close();
        }
    }
}
