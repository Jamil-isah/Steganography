using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace steganography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap img = (Bitmap)pictureBox1.Image;
            for (int i = 0; i < img.Width; i++)
            {
                for (int j= 0; j<img.Height; j++)
                {
                    Color c = img.GetPixel(i, j);
                    if(i==0&&j<textBox1.Text.Length)
                    {
                        char letter = Convert.ToChar(textBox1.Text.Substring(j, 1));
                        int value = Convert.ToInt32(letter);
                        img.SetPixel(i,j, Color.FromArgb(c.R,c.G,value));
                    }
                }
                img.Save(@"C:\Users\Jamil\Downloads\newwimagew.png", System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap newimg = (Bitmap)pictureBox2.Image;
            string newmessage = "";
            for (int i = 0; i < newimg.Width; i++)
            {
                for (int j =0; j < newimg.Height; j++)
                {
                    if (i ==0 && j<7)
                    {
                        Color c = newimg.GetPixel(i, j);
                        char letter = Convert.ToChar(c.B);
                        newmessage += letter;
                    }
                }
                textBox2.Text = newmessage;
            }
        }
    }
}
