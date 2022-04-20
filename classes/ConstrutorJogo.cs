using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stelf.classes
{
    public class ConstrutorJogo
    {
        public Jogo jogoItem;
        public PictureBox pictureBox;
        public Button button;

        public ConstrutorJogo(int pictureBox_X, int pictureBox_Y, int button_X, int button_Y, Image image, Jogo jogo)
        {
            pictureBox = new PictureBox();
            pictureBox.Location = new Point(pictureBox_X, pictureBox_Y);
            pictureBox.Size = new Size(253, 151);
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Tag = jogo;

            button = new Button();
            button.Location = new Point(button_X, button_Y);
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = Color.LightGreen;
            button.FlatAppearance.BorderSize = 0;
            button.Size = new Size(253, 23);
            button.Text = "R$ " + jogo.preco.ToString();
            button.Tag = jogo;

            jogoItem = jogo;
        }

        public ConstrutorJogo(int pictureBox_X, int pictureBox_Y, Image image, Jogo jogo)
        {
            pictureBox = new PictureBox();
            pictureBox.Location = new Point(pictureBox_X, pictureBox_Y);
            pictureBox.Size = new Size(253, 151);
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Tag = jogo;

            jogoItem = jogo;
        }
    }
}
