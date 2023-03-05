using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Czytnik_kodu_genetycznego
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }   

        int currentImageIndex = 0;
        string imagesFolderPath = "./Assets/Obrazki/";

        private void Form3_Load(object sender, EventArgs e)
        {
            Console.WriteLine("\n >>>>>FORM3<<<<< \n");
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            NatepnyButton_Click(sender, e);


            Console.WriteLine(Form1.BialkaWyjsciowe0[0]);
            Console.WriteLine(Form1.BialkaWyjsciowe0[1]);
            Console.WriteLine(Form1.BialkaWyjsciowe0[2]);
            
            Console.WriteLine("\n" + Form1.BialkaWyjsciowe0[0]);
            Console.WriteLine(Form1.BialkaWyjsciowe0[1]);
            Console.WriteLine(Form1.BialkaWyjsciowe0[2]);
        }
        private void NatepnyButton_Click(object sender, EventArgs e)
        {
            if (currentImageIndex < Directory.GetFiles(imagesFolderPath).Length - 1)
            {
                currentImageIndex++;
                pictureBox1.Image = Image.FromFile(Directory.GetFiles(imagesFolderPath)[currentImageIndex]);
            }
        }

        private void PoprzedniButton_Click(object sender, EventArgs e)
        {
            if (currentImageIndex > 0)
            {
                currentImageIndex--;
                pictureBox1.Image = Image.FromFile(Directory.GetFiles(imagesFolderPath)[currentImageIndex]);
            }
        }
    }
}