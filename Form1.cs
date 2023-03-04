using System;
using System.CodeDom.Compiler;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Czytnik_kodu_genetycznego
{
    public partial class Form1 : Form
    {
        Thread th;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
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

        public string[] BialkaWyjsciowe = new string[] { "" , "" , "" };
        public static string[] BialkaWyjsciowe1 = new string[] { "" , "" , "" };

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

            for (int j = 0; j < 3; j++)
            {
                if (BialkaWyjsciowe[j] == null)
                {
                    BialkaWyjsciowe[j] += "a";
                    break;
                }

                if (BialkaWyjsciowe[j].ToString().Contains("M"))
                {
                    if (BialkaWyjsciowe1[j].ToString().Contains("M"))
                    {
                        break;
                    }
                    else
                    {
                        BialkaWyjsciowe1[j] += "M";
                    }
                    break;
                }
                if (BialkaWyjsciowe[j].ToString().Contains("G"))
                {
                    if (BialkaWyjsciowe1[j].ToString().Contains("G"))
                    {
                        break;
                    }
                    else
                    {
                        BialkaWyjsciowe1[j] += "G";
                    }
                    break;
                }
                if (BialkaWyjsciowe[j].ToString().Contains("E"))
                {
                    if (BialkaWyjsciowe1[j].ToString().Contains("E"))
                    {
                        break;
                    }
                    else
                    {
                        BialkaWyjsciowe1[j] += "E";
                    }
                    break;
                }
                if (BialkaWyjsciowe[j].ToString().Contains("D"))
                {
                    if (BialkaWyjsciowe1[j].ToString().Contains("D"))
                    {
                        break;
                    }
                    else
                    {
                        BialkaWyjsciowe1[j] += "D";
                    }
                    break;
                }
                if (BialkaWyjsciowe[j].ToString().Contains("A"))
                {
                    if (BialkaWyjsciowe1[j].ToString().Contains("A"))
                    {
                        break;
                    }
                    else
                    {
                        BialkaWyjsciowe1[j] += "A";
                    }
                    break;
                }
                if (BialkaWyjsciowe[j].ToString().Contains("V"))
                {
                    if (BialkaWyjsciowe1[j].ToString().Contains("V"))
                    {
                        break;
                    }
                    else
                    {
                        BialkaWyjsciowe1[j] += "V";
                    }
                    break;
                }
                if (BialkaWyjsciowe[j].ToString().Contains("R"))
                {
                    if (BialkaWyjsciowe1[j].ToString().Contains("R"))
                    {
                        break;
                    }
                    else
                    {
                        BialkaWyjsciowe1[j] += "R";
                    }
                    break;
                }
                if (BialkaWyjsciowe[j].ToString().Contains("S"))
                {
                    if (BialkaWyjsciowe1[j].ToString().Contains("S"))
                    {
                        break;
                    }
                    else
                    {
                        BialkaWyjsciowe1[j] += "S";
                    }
                    break;
                }
                if (BialkaWyjsciowe[j].ToString().Contains("K"))
                {
                    if (BialkaWyjsciowe1[j].ToString().Contains("K"))
                    {
                        break;
                    }
                    else
                    {
                        BialkaWyjsciowe1[j] += "K";
                    }
                    break;
                }
                if (BialkaWyjsciowe[j].ToString().Contains("N"))
                {
                    if (BialkaWyjsciowe1[j].ToString().Contains("N"))
                    {
                        break;
                    }
                    else
                    {
                        BialkaWyjsciowe1[j] += "N";
                    }
                    break;
                }
                if (BialkaWyjsciowe[j].ToString().Contains("T"))
                {
                    if (BialkaWyjsciowe1[j].ToString().Contains("T"))
                    {
                        break;
                    }
                    else
                    {
                        BialkaWyjsciowe1[j] += "T";
                    }
                    break;
                }
                if (BialkaWyjsciowe[j].ToString().Contains("I"))
                {
                    if (BialkaWyjsciowe1[j].ToString().Contains("I"))
                    {
                        break;
                    }
                    else
                    {
                        BialkaWyjsciowe1[j] += "I";
                    }
                    break;
                }
                if (BialkaWyjsciowe[j].ToString().Contains("Q"))
                {
                    if (BialkaWyjsciowe1[j].ToString().Contains("Q"))
                    {
                        break;
                    }
                    else
                    {
                        BialkaWyjsciowe1[j] += "Q";
                    }
                    break;
                }
                if (BialkaWyjsciowe[j].ToString().Contains("H"))
                {
                    if (BialkaWyjsciowe1[j].ToString().Contains("H"))
                    {
                        break;
                    }
                    else
                    {
                        BialkaWyjsciowe1[j] += "H";
                    }
                    break;
                }
                if (BialkaWyjsciowe[j].ToString().Contains("P"))
                {
                    if (BialkaWyjsciowe1[j].ToString().Contains("P"))
                    {
                        break;
                    }
                    else
                    {
                        BialkaWyjsciowe1[j] += "P";
                    }
                    break;
                }
                if (BialkaWyjsciowe[j].ToString().Contains("L"))
                {
                    if (BialkaWyjsciowe1[j].ToString().Contains("L"))
                    {
                        break;
                    }
                    else
                    {
                        BialkaWyjsciowe1[j] += "L";
                    }
                    break;
                }
                if (BialkaWyjsciowe[j].ToString().Contains("W"))
                {
                    if (BialkaWyjsciowe1[j].ToString().Contains("W"))
                    {
                        break;

                    }
                    else
                    {
                        BialkaWyjsciowe1[j] += "W";
                    }
                    break;
                }
                if (BialkaWyjsciowe[j].ToString().Contains("C"))
                {
                    if (BialkaWyjsciowe1[j].ToString().Contains("C"))
                    {
                        break;
                    }
                    else
                    {
                        BialkaWyjsciowe1[j] += "C";
                    }
                    break;
                }
                if (BialkaWyjsciowe[j].ToString().Contains("Y"))
                {
                    if (BialkaWyjsciowe1[j].ToString().Contains("Y"))
                    {
                        break;
                    }
                    else
                    {
                        BialkaWyjsciowe1[j] += "Y";
                    }
                    break;
                }
                if (BialkaWyjsciowe[j].ToString().Contains("F"))
                {
                    if (BialkaWyjsciowe1[j].ToString().Contains("F"))
                    {
                        break;
                    }
                    else
                    {
                        BialkaWyjsciowe1[j] += "F";
                    }
                    break;
                }
            }

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < BialkaWyjsciowe.Length; i++)
                {
                    switch (BialkaWyjsciowe[j].ToString())
                    {
                        case "M":
                            BialkaWyjsciowe1[j] += "M";
                            break;
                        case "G":
                            BialkaWyjsciowe1[j] += "G";
                            break;
                        case "E":
                            BialkaWyjsciowe1[j] += "E";
                            break;
                        case "D":
                            BialkaWyjsciowe1[j] += "D";
                            break;
                        case "A":
                            BialkaWyjsciowe1[j] += "A";
                            break;
                        case "V":
                            BialkaWyjsciowe1[j] += "V";
                            break;
                        case "R":
                            BialkaWyjsciowe1[j] += "R";
                            break;
                        case "S":
                            BialkaWyjsciowe1[j] += "S";
                            break;
                        case "K":
                            BialkaWyjsciowe1[j] += "K";
                            break;
                        case "N":
                            BialkaWyjsciowe1[j] += "N";
                            break;
                        case "T":
                            BialkaWyjsciowe1[j] += "T";
                            break;
                        case "I":
                            BialkaWyjsciowe1[j] += "I";
                            break;
                        case "Q":
                            BialkaWyjsciowe1[j] += "Q";
                            break;
                        case "H":
                            BialkaWyjsciowe1[j] += "H";
                            break;
                        case "P":
                            BialkaWyjsciowe1[j] += "P";
                            break;
                        case "L":
                            BialkaWyjsciowe1[j] += "L";
                            break;
                        case "W":
                            BialkaWyjsciowe1[j] += "W";
                            break;
                        case "C":
                            BialkaWyjsciowe1[j] += "C";
                            break;
                        case "Y":
                            BialkaWyjsciowe1[j] += "T";
                            break;
                        case "F":
                            BialkaWyjsciowe1[j] += "F";
                            break;
                        default:
                            Console.WriteLine("DEBUGI");
                            break;
                    }
                }
            }
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
                this.Close();
            }
            else
            {
                KodgenetycznyInput.ForeColor = Color.Red;

                Infooblendzie.Show();
                Console.WriteLine("BŁĄD!!!");
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