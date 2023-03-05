using System;
using System.Threading;
using System.Windows.Forms;



namespace Czytnik_kodu_genetycznego
{
    public partial class Form2 : Form
    {
        Thread th;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Thread.Sleep(1000);

            Console.WriteLine("\n >>>>>FORM2<<<<< \n");
            //Zablokowanie zmiany wielkości okna programu
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //for (int k = 0; k < 3; k++)
            //{
            //    Console.WriteLine(Form1.BialkaWyjsciowe1[k] + " LINIA " + k);
            //}


            Kodgenetycznywyjscie.Text = Form1.KodgenetycznyCheck;
            string[] BialkaWyjsciowe2 = new string[] { "", "", "" };

            //int dlg0 = 0;

            //for (int i = 0; i < Form1.BialkaWyjsciowe1.Length; i++)
            //{
            //    dlg0 = Form1.BialkaWyjsciowe1[i].Length.ToString()[0] - '1';
            //    Console.WriteLine(dlg0 + " DLG");
            //    for (int j = 0; j < dlg0; j++)
            //    {
            //        Console.WriteLine(Form1.BialkaWyjsciowe1[i].ToString()[j]);
            //    }
            //    Console.WriteLine("================");
            //}

            //for (int j = 0; j < Form1.BialkaWyjsciowe1.Length; j++)
            //{
            //    switch (Form1.BialkaWyjsciowe1[j].ToString())
            //    {
            //        case "M":
            //            BialkaWyjsciowe2[j] += "M";
            //            break;
            //        case "G":
            //            BialkaWyjsciowe2[j] += "G";
            //            break;
            //        case "E":
            //            BialkaWyjsciowe2[j] += "E";
            //            break;
            //        case "D":
            //            BialkaWyjsciowe2[j] += "D";
            //            break;
            //        case "A":
            //            BialkaWyjsciowe2[j] += "A";
            //            break;
            //        case "V":
            //            BialkaWyjsciowe2[j] += "V";
            //            break;
            //        case "R":
            //            BialkaWyjsciowe2[j] += "R";
            //            break;
            //        case "S":
            //            BialkaWyjsciowe2[j] += "S";
            //            break;
            //        case "K":
            //            BialkaWyjsciowe2[j] += "K";
            //            break;
            //        case "N":
            //            BialkaWyjsciowe2[j] += "N";
            //            break;
            //        case "T":
            //            BialkaWyjsciowe2[j] += "T";
            //            break;
            //        case "I":
            //            BialkaWyjsciowe2[j] += "I";
            //            break;
            //        case "Q":
            //            BialkaWyjsciowe2[j] += "Q";
            //            break;
            //        case "H":
            //            BialkaWyjsciowe2[j] += "H";
            //            break;
            //        case "P":
            //            BialkaWyjsciowe2[j] += "P";
            //            break;
            //        case "L":
            //            BialkaWyjsciowe2[j] += "L";
            //            break;
            //        case "W":
            //            BialkaWyjsciowe2[j] += "W";
            //            break;
            //        case "C":
            //            BialkaWyjsciowe2[j] += "C";
            //            break;
            //        case "Y":
            //            BialkaWyjsciowe2[j] += "T";
            //            break;
            //        case "F":
            //            BialkaWyjsciowe2[j] += "F";
            //            break;
            //        default:
            //            Console.WriteLine("DEBUG");
            //            break;
            //    }
            //    Console.WriteLine("===============");
            //}


            //for(int i = 0; i < Form1.ListaBialek.Length; i++)
            //{
            //}

            //for (int i = 0; i < Form1.ListaBialek.Length; i++)
            //{
            //    for (int j = 0; j < Form1.BialkaWyjsciowe1.Length; j++)
            //    {
            //        if (Form1.BialkaWyjsciowe1[j] != null || Form1.BialkaWyjsciowe1[j] != "a")
            //        {
            //            if (Form1.BialkaWyjsciowe1[j].Contains(Form1.ListaBialek[i]))
            //            {
            //                BialkaWyjsciowe2[j] += Form1.ListaBialek[i];
            //            }
            //            else
            //            {
            //                BialkaWyjsciowe2[j] += Form1.ListaBialek[i];
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("NULL 1");
            //        }
            //    }

            //for (int l = 0; l < Form1.BialkaWyjsciowe1.Length; l++)
            //{
            //    if (Form1.BialkaWyjsciowe1[l] != null || Form1.BialkaWyjsciowe1[l] != "a")
            //    {
            //        if (Form1.BialkaWyjsciowe1[l].Contains(Form1.ListaBialek[i]))
            //        {
            //            BialkaWyjsciowe2[l] += Form1.ListaBialek[i];
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("NULL 2");
            //    }
            //}


            //for (int m = 0; m < Form1.BialkaWyjsciowe1.Length; m++)
            //{
            //    if (Form1.BialkaWyjsciowe1[m] != null || Form1.BialkaWyjsciowe1[m] != "a")
            //    {
            //        if (Form1.BialkaWyjsciowe1[m].Contains(Form1.ListaBialek[i]))
            //        {
            //            BialkaWyjsciowe2[m] += Form1.ListaBialek[i];
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("NULL 3");
            //    }
            //}


            Console.WriteLine("Label 1: " + Form1.BialkaWyjsciowe1[0].ToString());
            Console.WriteLine("Label 2: " + Form1.BialkaWyjsciowe1[1].ToString());
            Console.WriteLine("Label 3: " + Form1.BialkaWyjsciowe1[2].ToString());

            SekwencjaDNA1.Text = Form1.BialkaWyjsciowe1[0].ToString();
            SekwencjaDNA2.Text = Form1.BialkaWyjsciowe1[1].ToString();
            SekwencjaDNA3.Text = Form1.BialkaWyjsciowe1[2].ToString();

        }

        private void Kodgenetycznywyjscie_TextChanged(object sender, EventArgs e)
        {

        }

        private void CofnijDoGlownegoBUTTON_Click(object sender, EventArgs e)
        {
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            this.Close();
        }
        private void opennewform(object obj)
        {
            Application.Run(new Form1());
        }
    }
}
