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

        int watosciObrazkow()
        {
            string[] obrazki = new string[Form1.BialkaWyjsciowe0.Length];
            int i = 0;
            while (i < Form1.BialkaWyjsciowe0[0].Length)
            {
                switch (Form1.BialkaWyjsciowe0[i])
                {
                    case "A":
                        obrazki[i] = "Alanine";
                        i = i + 1;
                        break;
                    case "R":
                        obrazki[i] = "Arginine";
                        i = i + 1;
                        break;
                    case "N":
                        obrazki[i] = "Asparagine";
                        i = i + 1;
                        break;
                    case "D":
                        obrazki[i] = "Aspartic Acid";
                        i = i + 1;
                        break;
                    case "C":
                        obrazki[i] = "Crysteine";
                        i = i + 1;
                        break;
                    case "E":
                        obrazki[i] = "Glutamic Acid";
                        i = i + 1;
                        break;
                    case "Q":
                        obrazki[i] = "Glutamine";
                        i = i + 1;
                        break;
                    case "G":
                        obrazki[i] = "Glycine";
                        i = i + 1;
                        break;
                    case "H":
                        obrazki[i] = "Histidnine";
                        i = i + 1;
                        break;
                    case "I":
                        obrazki[i] = "Isoleucine";
                        i = i + 1;
                        break;
                    case "L":
                        obrazki[i] = "Leucine";
                        i = i + 1;
                        break;
                    case "K":
                        obrazki[i] = "Lysine";
                        i = i + 1;
                        break;
                    case "M":
                        obrazki[i] = "Methionine";
                        i = i + 1;
                        break;
                    case "F":
                        obrazki[i] = "Phenylalanine";
                        i = i + 1;
                        break;
                    case "P":
                        obrazki[i] = "Proline";
                        i = i + 1;
                        break;
                    case "U":
                        obrazki[i] = "Selenofysteine";
                        i = i + 1;
                        break;
                    case "S":
                        obrazki[i] = "Serine";
                        i = i + 1;
                        break;
                    case "T":
                        obrazki[i] = "Theonine";
                        i = i + 1;
                        break;
                    case "W":
                        obrazki[i] = "Tryptophan";
                        i = i + 1;
                        break;
                    case "Y":
                        obrazki[i] = "Tyrosine";
                        i = i + 1;
                        break;
                    case "V":
                        obrazki[i] = "Valine";
                        i = i + 1;
                        break;
                    default:
                        break;
                }
            }
            return 0;
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