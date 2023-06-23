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
            pictureBox1.Load("C:\\Beems.bmp");
            Source_Image = new Bitmap(pictureBox1.Image);
            Destination_Image = new Bitmap(pictureBox1.Image);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int[,] Kernel = new int[3, 3];
            Kernel[0, 0] = 1; Kernel[0, 1] = 1; Kernel[0, 2] = 1;
            Kernel[1, 0] = 1; Kernel[1, 1] = 3; Kernel[1, 2] = 1;
            Kernel[2, 0] = 1; Kernel[2, 1] = 1; Kernel[2, 2] = 1;
            for (int x = 1; x < pictureBox1.Image.Width - 1; x++)
            {//köşeleri geçmek  1 çıkartıyoruz.(-1)
                for (int y = 1; y < pictureBox1.Image.Height - 1; y++)
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
            double[,] Kernel = new double[3, 3];
            Kernel[0, 0] = 0.0275; Kernel[0, 1] = 0.01102; Kernel[0, 2] = 0.0275;
            Kernel[1, 0] = 0.1102; Kernel[1, 1] = 0.4421; Kernel[1, 2] = 0.1102;
            Kernel[2, 0] = 0.0275; Kernel[2, 1] = 0.1102; Kernel[2, 2] = 0.0275;
            for (int x = 1; x < pictureBox1.Image.Width - 1; x++)
            {//köşeleri geçmek  1 çıkartıyoruz.(-1)
                for (int y = 1; y < pictureBox1.Image.Height - 1; y++)
                {
                    double result = 0;
                    //Convolution
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            result += Kernel[i, j] * Source_Image.GetPixel(x + i - 1, y + j - 1).G;
                        }
                        //Assign to new image
                        Destination_Image.SetPixel(x, y, Color.FromArgb((int)result, (int)result, (int)result));
                    }
                    pictureBox2.Image = Destination_Image;
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int[,] Kernel = new int[3, 3];
            Kernel[0, 0] = 0; Kernel[0, 1] = -1; Kernel[0, 2] = 0;
            Kernel[1, 0] = -1; Kernel[1, 1] = 4; Kernel[1, 2] = -1;
            Kernel[2, 0] = 0; Kernel[2, 1] = -1; Kernel[2, 2] = 0;
            for (int x = 1; x < pictureBox1.Image.Width - 1; x++)
            {//köşeleri geçmek  1 çıkartıyoruz.(-1)
                for (int y = 1; y < pictureBox1.Image.Height - 1; y++)
                {
                    int result = 0;
                    //Convolution
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            result += Kernel[i, j] * Source_Image.GetPixel(x + i - 1, y + j - 1).G;
                        }
                        if (result > 255) { result = 255; }
                        if (result < 0) { result = 0; }
                        //Assign to new image
                        Destination_Image.SetPixel(x, y, Color.FromArgb(result, result, result));
                    }
                    pictureBox2.Image = Destination_Image;
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int[,] Kernel = new int[3, 3];
            Kernel[0, 0] = -1; Kernel[0, 1] = -1; Kernel[0, 2] = -1;
            Kernel[1, 0] = -1; Kernel[1, 1] = 8; Kernel[1, 2] = -1;
            Kernel[2, 0] = -1; Kernel[2, 1] = -1; Kernel[2, 2] = -1;
            for (int x = 1; x < pictureBox1.Image.Width - 1; x++)
            {//köşeleri geçmek  1 çıkartıyoruz.(-1)
                for (int y = 1; y < pictureBox1.Image.Height - 1; y++)
                {
                    int result = 0;
                    //Convolution
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            result += Kernel[i, j] * Source_Image.GetPixel(x + i - 1, y + j - 1).G;
                        }
                        if (result > 255) { result = 255; }
                        if (result < 0) { result = 0; }
                        //Assign to new image
                        Destination_Image.SetPixel(x, y, Color.FromArgb(result, result, result));
                    }
                    pictureBox2.Image = Destination_Image;
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            int[,] Kernel = new int[3, 3];
            Kernel[0, 0] = 0; Kernel[0, 1] = -1; Kernel[0, 2] = 0;
            Kernel[1, 0] = -1; Kernel[1, 1] = 5; Kernel[1, 2] = -1;
            Kernel[2, 0] = 0; Kernel[2, 1] = -1; Kernel[2, 2] = 0;
            for (int x = 1; x < pictureBox1.Image.Width - 1; x++)
            {//köşeleri geçmek  1 çıkartıyoruz.(-1)
                for (int y = 1; y < pictureBox1.Image.Height - 1; y++)
                {
                    int result = 0;
                    //Convolution
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            result += Kernel[i, j] * Source_Image.GetPixel(x + i - 1, y + j - 1).G;
                        }
                        if (result > 255) { result = 255; }
                        if (result < 0) { result = 0; }
                        //Assign to new image
                        Destination_Image.SetPixel(x, y, Color.FromArgb(result, result, result));
                    }
                    pictureBox2.Image = Destination_Image;
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            int[,] Kernel = new int[3, 3];
            Kernel[0, 0] = -1; Kernel[0, 1] = -1; Kernel[0, 2] = -1;
            Kernel[1, 0] = -1; Kernel[1, 1] = 9; Kernel[1, 2] = -1;
            Kernel[2, 0] = -1; Kernel[2, 1] = -1; Kernel[2, 2] = -1;
            for (int x = 1; x < pictureBox1.Image.Width - 1; x++)
            {//köşeleri geçmek  1 çıkartıyoruz.(-1)
                for (int y = 1; y < pictureBox1.Image.Height - 1; y++)
                {
                    int resultR = 0;
                    int resultG = 0;
                    int resultB = 0;
                    //Convolution
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            resultR += Kernel[i, j] * Source_Image.GetPixel(x + i - 1, y + j - 1).G;
                            resultG += Kernel[i, j] * Source_Image.GetPixel(x + i - 1, y + j - 1).G;
                            resultB += Kernel[i, j] * Source_Image.GetPixel(x + i - 1, y + j - 1).G;
                        }
                        if (resultR > 255) { resultR = 255; }
                        if (resultR < 0) { resultR = 0; }

                        if (resultG > 255) { resultG = 255; }
                        if (resultG < 0) { resultG = 0; }

                        if (resultB > 255) { resultB = 255; }
                        if (resultB < 0) { resultB = 0; }
                        //Assign to new image
                        Destination_Image.SetPixel(x, y, Color.FromArgb(resultR, resultG, resultB));
                    }
                    pictureBox2.Image = Destination_Image;
                }
            }
        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = hScrollBar1.Value.ToString();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < pictureBox1.Image.Width; x++)
            {
                for (int y = 0; y < pictureBox1.Image.Height; y++)
                {
                    int result;
                    result = hScrollBar1.Value + Source_Image.GetPixel(x, y).G;

                    if (result > 255) { result = 255; }
                    if (result < 0) { result = 0; }
                    //Assign to new image
                    Destination_Image.SetPixel(x, y, Color.FromArgb(result, result, result));
                }
                pictureBox2.Image = Destination_Image;
            }
        }
        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            textBox2.Text = hScrollBar2.Value.ToString();
        }

       
        private void button9_Click(object sender, EventArgs e)
        {
            int C = hScrollBar2.Value;
            double F = (259.0 * (C + 255.0)) / (255.0 * (259.0 - C));
            for (int x = 0; x < pictureBox1.Image.Width; x++)
            {
                for (int y = 0; y < pictureBox1.Image.Height; y++)
                {
                    double result;
                    //Convolution
                    result = F * (Source_Image.GetPixel(x, y).G - 128) + 128;

                    if (result > 255) { result = 255; }
                    if (result < 0) { result = 0; }
                    //Assign to new image
                    Destination_Image.SetPixel(x, y, Color.FromArgb((int)result, (int)result, (int)result));
                }
                pictureBox2.Image = Destination_Image;
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            double gama = Convert.ToDouble(textBox3.Text);
            for (int x = 0; x < pictureBox1.Image.Width; x++)
            {
                for (int y = 0; y < pictureBox1.Image.Height; y++)
                {
                    double result=0;
                    double img;
                    img = (Source_Image.GetPixel(x, y).G);
                    //Convolution
                    result = 255 * Math.Pow((img / 255), (1 / gama)); ;

                    if (result > 255) { result = 255; }
                    if (result < 0) { result = 0; }
                    //Assign to new image
                    Destination_Image.SetPixel(x, y, Color.FromArgb((int)result, (int)result, (int)result));
                }
                pictureBox2.Image = Destination_Image;
            }
        }
    }
}
