using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Czytnik_kodu_genetycznego
{
    public partial class Form1 : Form
    {
        Thread th;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            Console.WriteLine("\n >>>>>FORM1<<<<< \n");
            //Zablokowanie zmiany wielkości okna programu
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        bool SprawdzaniePoprawnosci(char[] rnaSequence)
        {
            for (int i = 0; i < rnaSequence.Length; i++)
            {
                if (rnaSequence[i] == 'T')
                {
                    rnaSequence[i] = 'U';
                }
                if (rnaSequence[i] == 'A' || rnaSequence[i] == 'G' || rnaSequence[i] == 'C' || rnaSequence[i] == 'U' && rnaSequence.Length > 2)
                {
                    //Miejsce po Debugu :)
                }
                else
                {
                    Console.WriteLine("Wykryto nie poprawny GEN: " + i + " | " + rnaSequence[i] + " |");
                    return false;
                }
            }
            Console.WriteLine("Kod jest poprawny");
            return true;
        }

        public string[] BialkaWyjsciowe = new string[] { "", "", "" };
        public static string[] BialkaWyjsciowe1 = new string[] { "", "", "" };

        public static string[] ListaBialek = new string[] { "M", "G", "E", "D", "A", "V", "R", "S", "K", "N", "T", "I", "Q", "H", "P", "L", "W", "C", "Y", "F" };


        void RozpoznawaczBialek()
        {
            char[] KodGenetyczny = KodgenetycznyInput.Text.ToCharArray();

            for (int i = 0; i < KodGenetyczny.Length; i++)
            {
                //Zamiana T na U. 
                if (KodGenetyczny[i] == 'T')
                {
                    KodGenetyczny[i] = 'U';
                }
            }
            for (int ii = 0, j = 0; ii < 3; ii++, j++)
            {
                for (int i = ii; i < KodGenetyczny.Length - 2; i = i + 3)
                {
                    switch (KodGenetyczny[i].ToString() + KodGenetyczny[i + 1].ToString() + KodGenetyczny[i + 2].ToString())
                    {
                        //Kodon Start
                        case "AUG":
                            Console.WriteLine("M(START)");
                            BialkaWyjsciowe[j] += "M";
                            break;
                        //
                        case "GGG":
                            Console.WriteLine("G");
                            BialkaWyjsciowe[j] += "G";
                            break;
                        case "GGA":
                            Console.WriteLine("G");
                            BialkaWyjsciowe[j] += "G";
                            break;
                        case "GGC":
                            Console.WriteLine("G");
                            BialkaWyjsciowe[j] += "G";
                            break;
                        case "GGU":
                            Console.WriteLine("G");
                            BialkaWyjsciowe[j] += "G";
                            break;
                        //
                        case "GAG":
                            Console.WriteLine("E");
                            BialkaWyjsciowe[j] += "E";
                            break;
                        case "GAA":
                            Console.WriteLine("E");
                            BialkaWyjsciowe[j] += "E";
                            break;
                        //
                        case "GAC":
                            Console.WriteLine("D");
                            BialkaWyjsciowe[j] += "D";
                            break;
                        case "GAU":
                            Console.WriteLine("D");
                            BialkaWyjsciowe[j] += "D";
                            break;
                        //
                        case "GCG":
                            Console.WriteLine("A");
                            BialkaWyjsciowe[j] += "A";
                            break;
                        case "GCA":
                            Console.WriteLine("A");
                            BialkaWyjsciowe[j] += "A";
                            break;
                        case "GCC":
                            Console.WriteLine("A");
                            BialkaWyjsciowe[j] += "A";
                            break;
                        case "GCU":
                            Console.WriteLine("A");
                            BialkaWyjsciowe[j] += "A";
                            break;
                        //
                        case "GUG":
                            Console.WriteLine("V");
                            BialkaWyjsciowe[j] += "V";
                            break;
                        case "GUA":
                            Console.WriteLine("V");
                            BialkaWyjsciowe[j] += "V";
                            break;
                        case "GUC":
                            Console.WriteLine("V");
                            BialkaWyjsciowe[j] += "V";
                            break;
                        case "GUU":
                            Console.WriteLine("V");
                            BialkaWyjsciowe[j] += "V";
                            break;
                        //
                        case "AGG":
                            Console.WriteLine("R");
                            BialkaWyjsciowe[j] += "R";
                            break;
                        case "AGA":
                            Console.WriteLine("R");
                            BialkaWyjsciowe[j] += "R";
                            break;
                        case "CGG":
                            Console.WriteLine("R");
                            BialkaWyjsciowe[j] += "R";
                            break;
                        case "CGA":
                            Console.WriteLine("R");
                            BialkaWyjsciowe[j] += "R";
                            break;
                        case "CGC":
                            Console.WriteLine("R");
                            BialkaWyjsciowe[j] += "R";
                            break;
                        case "CGU":
                            Console.WriteLine("R");
                            BialkaWyjsciowe[j] += "R";
                            break;
                        //
                        case "AGC":
                            Console.WriteLine("S");
                            BialkaWyjsciowe[j] += "S";
                            break;
                        case "AGU":
                            Console.WriteLine("S");
                            BialkaWyjsciowe[j] += "S";
                            break;
                        case "UCU":
                            Console.WriteLine("S");
                            BialkaWyjsciowe[j] += "S";
                            break;
                        case "UCC":
                            Console.WriteLine("S");
                            BialkaWyjsciowe[j] += "S";
                            break;
                        case "UCA":
                            Console.WriteLine("S");
                            BialkaWyjsciowe[j] += "S";
                            break;
                        case "UCG":
                            Console.WriteLine("S");
                            BialkaWyjsciowe[j] += "S";
                            break;
                        //
                        case "AAG":
                            Console.WriteLine("K");
                            BialkaWyjsciowe[j] += "K";
                            break;
                        case "AAA":
                            Console.WriteLine("K");
                            BialkaWyjsciowe[j] += "K";
                            break;
                        //
                        case "AAC":
                            Console.WriteLine("N");
                            BialkaWyjsciowe[j] += "N";
                            break;
                        case "AAU":
                            Console.WriteLine("N");
                            BialkaWyjsciowe[j] += "N";
                            break;
                        //
                        case "ACG":
                            Console.WriteLine("T");
                            BialkaWyjsciowe[j] += "T";
                            break;
                        case "ACA":
                            Console.WriteLine("T");
                            BialkaWyjsciowe[j] += "T";
                            break;
                        case "ACC":
                            Console.WriteLine("T");
                            BialkaWyjsciowe[j] += "T";
                            break;
                        case "ACU":
                            Console.WriteLine("T");
                            BialkaWyjsciowe[j] += "T";
                            break;
                        //
                        case "AUA":
                            Console.WriteLine("I");
                            BialkaWyjsciowe[j] += "I";
                            break;
                        case "AUC":
                            Console.WriteLine("I");
                            BialkaWyjsciowe[j] += "I";
                            break;
                        case "AUU":
                            Console.WriteLine("I");
                            BialkaWyjsciowe[j] += "I";
                            break;
                        //
                        case "CAG":
                            Console.WriteLine("Q");
                            BialkaWyjsciowe[j] += "Q";
                            break;
                        case "CAA":
                            Console.WriteLine("Q");
                            BialkaWyjsciowe[j] += "Q";
                            break;
                        //
                        case "CAC":
                            Console.WriteLine("H");
                            BialkaWyjsciowe[j] += "H";
                            break;
                        case "CAU":
                            Console.WriteLine("H");
                            BialkaWyjsciowe[j] += "H";
                            break;
                        //
                        case "CCG":
                            Console.WriteLine("P");
                            BialkaWyjsciowe[j] += "P";
                            break;
                        case "CCA":
                            Console.WriteLine("P");
                            BialkaWyjsciowe[j] += "P";
                            break;
                        case "CCC":
                            Console.WriteLine("P");
                            BialkaWyjsciowe[j] += "P";
                            break;
                        case "CCU":
                            Console.WriteLine("P");
                            BialkaWyjsciowe[j] += "P";
                            break;
                        //
                        case "CUG":
                            Console.WriteLine("L");
                            BialkaWyjsciowe[j] += "L";
                            break;
                        case "CUA":
                            Console.WriteLine("L");
                            BialkaWyjsciowe[j] += "L";
                            break;
                        case "CUC":
                            Console.WriteLine("L");
                            BialkaWyjsciowe[j] += "L";
                            break;
                        case "CUU":
                            Console.WriteLine("L");
                            BialkaWyjsciowe[j] += "L";
                            break;
                        case "UUG":
                            Console.WriteLine("L");
                            BialkaWyjsciowe[j] += "L";
                            break;
                        case "UUA":
                            Console.WriteLine("L");
                            BialkaWyjsciowe[j] += "L";
                            break;
                        //
                        case "UGG":
                            Console.WriteLine("W");
                            BialkaWyjsciowe[j] += "W";
                            break;
                        //
                        case "UGC":
                            Console.WriteLine("C");
                            BialkaWyjsciowe[j] += "C";
                            break;
                        case "UGU":
                            Console.WriteLine("C");
                            BialkaWyjsciowe[j] += "C";
                            break;
                        //
                        case "UAC":
                            Console.WriteLine("Y");
                            BialkaWyjsciowe[j] += "Y";
                            break;
                        case "UAU":
                            Console.WriteLine("Y");
                            BialkaWyjsciowe[j] += "Y";
                            break;
                        //
                        case "UUC":
                            Console.WriteLine("F");
                            BialkaWyjsciowe[j] += "F";
                            break;
                        case "UUU":
                            Console.WriteLine("F");
                            BialkaWyjsciowe[j] += "F";
                            break;
                        //
                        case "UGA":
                            Console.WriteLine("(Stop)");
                            i = KodGenetyczny.Length - 2;
                            break;
                        case "UAG":
                            Console.WriteLine("(Stop)");
                            i = KodGenetyczny.Length - 2;
                            break;
                        case "UAA":
                            Console.WriteLine("(Stop)");
                            i = KodGenetyczny.Length - 2;
                            break;
                        //
                        default:
                            Console.WriteLine("BŁĄD.");
                            break;
                    }
                }

                Console.WriteLine("=======================");
            }

            Console.WriteLine(BialkaWyjsciowe[0] + " 0");
            Console.WriteLine(BialkaWyjsciowe[1] + " 1");
            Console.WriteLine(BialkaWyjsciowe[2] + " 2");


            //Zaczynanie od M , zajeło mi to 93 minuty i połowe mego zdrowia psychicznego :)
            if (BialkaWyjsciowe[0] == null)
            {
                BialkaWyjsciowe[0] += "ERROR";

            }
            else
            {
                for (int j = 0; j < BialkaWyjsciowe.Length; j++)
                {
                    for (int k = 0; k < BialkaWyjsciowe[j].Length; k++)
                    {
                        if (BialkaWyjsciowe[j][k] == 'M')
                        {
                            for (int i = k; i < BialkaWyjsciowe[j].Length; i++)
                            {
                                BialkaWyjsciowe1[j] += BialkaWyjsciowe[j][i];
                            }
                            break;
                        }
                    }

                }
                //
                //for (int j = 0; j < BialkaWyjsciowe.Length; j++)
                //{
                //    BialkaWyjsciowe[j] = BialkaWyjsciowe1[j];
                //    for (int k = 0; k < BialkaWyjsciowe[j].Length - 1; k++)
                //    {
                //        string temp = "";
                //        for (int i = k + 1; i < BialkaWyjsciowe[j].Length; i++)
                //        {
                //            if (k != i)
                //            {
                //                temp += BialkaWyjsciowe[j][i];
                //            }
                //            else
                //            {
                //                break;
                //            }
                //        }
                //        BialkaWyjsciowe1[j] = temp;
                //    }

                //}

            }

            Console.WriteLine("===========");
            char[] test = BialkaWyjsciowe1[0].Distinct().ToArray();
            Console.WriteLine(test.ToString() + " <- brak powrórzeń");
            Console.WriteLine("===========");


            //Console.WriteLine("\nVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
            //Console.WriteLine(BialkaWyjsciowe[0] + " BW 0 0");

            //Console.WriteLine(BialkaWyjsciowe[1] + " BW 1 0");

            //Console.WriteLine(BialkaWyjsciowe[2] + " BW 2 0");

            Console.WriteLine("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");

            Console.WriteLine(BialkaWyjsciowe1[0] + " BW1 0 0");

            Console.WriteLine(BialkaWyjsciowe1[1] + " BW1 1 0");

            Console.WriteLine(BialkaWyjsciowe1[2] + " BW1 2 0");
            Console.WriteLine("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV\n");


        }

        public static string KodgenetycznyCheck = "";
        void Sprawdzanie()
        {
            KodgenetycznyCheck = KodgenetycznyInput.Text.ToString();

            if (SprawdzaniePoprawnosci(KodgenetycznyCheck.ToCharArray()))
            {
                RozpoznawaczBialek();
            }
            else
            {
                Console.WriteLine("Kod jest błędny wpisz poprawny");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            KodgenetycznyInput.Clear();
            Infooblendzie.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Zatwierdz_Click(object sender, EventArgs e)
        {
            KodgenetycznyInput.Text = KodgenetycznyInput.Text.Replace(" ", "").ToUpper();

            Sprawdzanie();
            string KodgenetycznyCheck = KodgenetycznyInput.Text;
            if (SprawdzaniePoprawnosci(KodgenetycznyCheck.ToCharArray()))
            {

                th = new Thread(opennewform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();


                Infooblendzie.Hide();
                KodgenetycznyInput.ForeColor = Color.Black;
                Thread.Sleep(500);
                this.Close();
            }
            else
            {
                KodgenetycznyInput.ForeColor = Color.Red;

                Infooblendzie.Show();
                Console.WriteLine("BŁĄD WPISANYCH DANYCH!!!");
            }
        }
        private void opennewform(object obj)
        {
            Application.Run(new Form2());
        }

        String path;

        private void Wczytajzplikubutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();


            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = ofd.FileName;
                string WczytaneDane = System.IO.File.ReadAllText(path);
                KodgenetycznyInput.Text = WczytaneDane;
                Zatwierdz_Click(sender, e);
            }
            else Console.WriteLine("BŁĄD OKNA DIALOGOWEGO!");
        }

    }
}