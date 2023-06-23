using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSPOsystemOfCars
{
    public partial class O_programme : Form
    {
        public O_programme()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile("C:\\Users\\Vladr\\Pictures\\minato");
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Настройка режима отображения изображения

            // Установка размеров PictureBox в соответствии с размерами изображения
            pictureBox.Width = pictureBox.Image.Width;
            pictureBox.Height = pictureBox.Image.Height;

            // Добавление PictureBox на форму
            this.Controls.Add(pictureBox);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
