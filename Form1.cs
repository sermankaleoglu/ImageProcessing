using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        Bitmap Source_Image, Destination_Image;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("C:\Beems.bmp");
            Source_Image = new Bitmap(pictureBox1.Image);
            Destination_Image = new Bitmap(pictureBox1.Image);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] Kernel = new int[3, 3];
            Kernel[0, 0] = 1; Kernel[0, 1] = 1; Kernel[0, 2] = 1;
            Kernel[1, 2] = 1; Kernel[1, 1] = 3; Kernel[1, 2] = 1;
            Kernel[2, 0] = 1; Kernel[2, 1] = 1; Kernel[2, 2] = 1;
            for (int x = 0; x < pictureBox1.Image.Width-1; x++)
            {//köşeleri geçmek  1 çıkartıyoruz.(-1)
                for (int y = 0; y < pictureBox1.Image.Height-1; y++)
                {
                    int result = 0;
                    //Convolution
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            result += Kernel[i, j] * Source_Image.GetPixel(x + i - 1, y + j - 1).G;
                        }
                        result = result / 11;
                        //Assign to new image
                        Destination_Image.SetPixel(x, y, Color.FromArgb(result, result, result));
                    }
                    pictureBox2.Image = Destination_Image;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        { 

        }
        private void button7_Click(object sender, EventArgs e)
        {

        }
        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
