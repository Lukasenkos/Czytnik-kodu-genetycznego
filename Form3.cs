using System;
using System.Drawing;
using System.IO;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Czytnik_kodu_genetycznego
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        void Przewijaniezdjecia()
        {




        }

        int currentImageIndex = 0;
        string imagesFolderPath = "./Assets/Obrazki/";


        int LiczenieKodonow(int NumerListy)
        {
            for (int i = 0; i < 20; i++)
            {
                if (Form1.ListaBialek[i] == Form1.BialkaWyjsciowe0[NumerListy])
                {



                    return 0;
                }
                else
                {

                }
            }


            return 0;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Console.WriteLine("\n >>>>>FORM3<<<<< \n");
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            NatepnyButton_Click(sender, e);

            label1.Text = "AAAA " + LiczenieKodonow(0);
            label2.Text = "AAAA " + LiczenieKodonow(1);
            label3.Text = "AAAA " + LiczenieKodonow(2);
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
/*
Form1.BialkaWyjsciowe - ta tabela.
string[] obrazki = new string[Form1.BialkaWyjsciowe.length];
int i = 0;
while (i < Form1.BialkaWyjsciowe.length) {
switch (Form1.BialkaWyjsciowe[i]) {
        case "A":
            obrazk1[i] = "Alanine";
            i = i+1;
            break;
        case "R":
            obrazki[i] = Arginine;
            i = i+1;
            break;
        case "N":
            obrazki[i] = Asparagine;
            i = i+1;
            break;
        case "D":
            obrazki[i] = Aspartic Acid;
            i = i+1;
            break;
        case "C":
            obrazki[i] = Crysteine;
            i = i+1;
            break;
	    case "E":
            obrazk1[i] = Glutamic Acid;
            i = i+1;
            break;
        case "Q":
            obrazki[i] = Glutamine;
            i = i+1;
            break;
        case "G":
            obrazki[i] = Glycine;
            i = i+1;
            break;
        case "H":
            obrazki[i] = Histidnine;
            i = i+1;
            break;
        case "I":
            obrazki[i] = Isoleucine;
            i = i+1;
            break;
	    case "L":
            obrazk1[i] = Leucine;
            i = i+1;
            break;
        case "K":
            obrazki[i] = Lysine;
            i = i+1;
            break;
        case "M":
            obrazki[i] = Methionine;
            i = i+1;
            break;
        case "F":
            obrazki[i] = Phenylalanine;
            i = i+1;
            break;
        case "P":
            obrazki[i] = Proline;
            i = i+1;
            break;
	    case "U":
            obrazk1[i] = Selenofysteine;
            i = i+1;
            break;
        case "S":
            obrazki[i] = Serine;
            i = i+1;
            break;
        case "T":
            obrazki[i] = Theonine;
            i = i+1;
            break;
        case "W":
            obrazki[i] = Tryptophan;
            i = i+1;
            break;
        case "Y":
            obrazki[i] = Tyrosine;
            i = i+1;
            break;
	    case "V":
            obrazki[i] = Valine;
            i = i+1;
            break;
	}
}
*/