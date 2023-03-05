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

            KodgenetycznyInput.Text = Form2.temp;
            BialkaWyjsciowe1[0] = "";
            BialkaWyjsciowe1[1] = "";
            BialkaWyjsciowe1[2] = "";
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
        public static string[] BialkaWyjsciowe0 = new string[] { "", "", "" };
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
                            BialkaWyjsciowe[j] += "M";
                            break;
                        //
                        case "GGG":
                            BialkaWyjsciowe[j] += "G";
                            break;
                        case "GGA":
                            BialkaWyjsciowe[j] += "G";
                            break;
                        case "GGC":
                            BialkaWyjsciowe[j] += "G";
                            break;
                        case "GGU":
                            BialkaWyjsciowe[j] += "G";
                            break;
                        //
                        case "GAG":
                            BialkaWyjsciowe[j] += "E";
                            break;
                        case "GAA":
                            BialkaWyjsciowe[j] += "E";
                            break;
                        //
                        case "GAC":
                            BialkaWyjsciowe[j] += "D";
                            break;
                        case "GAU":
                            BialkaWyjsciowe[j] += "D";
                            break;
                        //
                        case "GCG":
                            BialkaWyjsciowe[j] += "A";
                            break;
                        case "GCA":
                            BialkaWyjsciowe[j] += "A";
                            break;
                        case "GCC":
                            BialkaWyjsciowe[j] += "A";
                            break;
                        case "GCU":
                            BialkaWyjsciowe[j] += "A";
                            break;
                        //
                        case "GUG":
                            BialkaWyjsciowe[j] += "V";
                            break;
                        case "GUA":

                            BialkaWyjsciowe[j] += "V";
                            break;
                        case "GUC":
                            BialkaWyjsciowe[j] += "V";
                            break;
                        case "GUU":
                            BialkaWyjsciowe[j] += "V";
                            break;
                        //
                        case "AGG":
                            BialkaWyjsciowe[j] += "R";
                            break;
                        case "AGA":
                            BialkaWyjsciowe[j] += "R";
                            break;
                        case "CGG":
                            BialkaWyjsciowe[j] += "R";
                            break;
                        case "CGA":
                            BialkaWyjsciowe[j] += "R";
                            break;
                        case "CGC":
                            BialkaWyjsciowe[j] += "R";
                            break;
                        case "CGU":
                            BialkaWyjsciowe[j] += "R";
                            break;
                        //
                        case "AGC":
                            BialkaWyjsciowe[j] += "S";
                            break;
                        case "AGU":
                            BialkaWyjsciowe[j] += "S";
                            break;
                        case "UCU":
                            BialkaWyjsciowe[j] += "S";
                            break;
                        case "UCC":
                            BialkaWyjsciowe[j] += "S";
                            break;
                        case "UCA":
                            BialkaWyjsciowe[j] += "S";
                            break;
                        case "UCG":
                            BialkaWyjsciowe[j] += "S";
                            break;
                        //
                        case "AAG":
                            BialkaWyjsciowe[j] += "K";
                            break;
                        case "AAA":
                            BialkaWyjsciowe[j] += "K";
                            break;
                        //
                        case "AAC":
                            BialkaWyjsciowe[j] += "N";
                            break;
                        case "AAU":
                            BialkaWyjsciowe[j] += "N";
                            break;
                        //
                        case "ACG":
                            BialkaWyjsciowe[j] += "T";
                            break;
                        case "ACA":
                            BialkaWyjsciowe[j] += "T";
                            break;
                        case "ACC":
                            BialkaWyjsciowe[j] += "T";
                            break;
                        case "ACU":
                            BialkaWyjsciowe[j] += "T";
                            break;
                        //
                        case "AUA":
                            BialkaWyjsciowe[j] += "I";
                            break;
                        case "AUC":
                            BialkaWyjsciowe[j] += "I";
                            break;
                        case "AUU":
                            BialkaWyjsciowe[j] += "I";
                            break;
                        //
                        case "CAG":
                            BialkaWyjsciowe[j] += "Q";
                            break;
                        case "CAA":
                            BialkaWyjsciowe[j] += "Q";
                            break;
                        //
                        case "CAC":
                            BialkaWyjsciowe[j] += "H";
                            break;
                        case "CAU":
                            BialkaWyjsciowe[j] += "H";
                            break;
                        //
                        case "CCG":
                            BialkaWyjsciowe[j] += "P";
                            break;
                        case "CCA":
                            BialkaWyjsciowe[j] += "P";
                            break;
                        case "CCC":
                            BialkaWyjsciowe[j] += "P";
                            break;
                        case "CCU":
                            BialkaWyjsciowe[j] += "P";
                            break;
                        //
                        case "CUG":
                            BialkaWyjsciowe[j] += "L";
                            break;
                        case "CUA":
                            BialkaWyjsciowe[j] += "L";
                            break;
                        case "CUC":
                            BialkaWyjsciowe[j] += "L";
                            break;
                        case "CUU":
                            BialkaWyjsciowe[j] += "L";
                            break;
                        case "UUG":
                            BialkaWyjsciowe[j] += "L";
                            break;
                        case "UUA":
                            BialkaWyjsciowe[j] += "L";
                            break;
                        //
                        case "UGG":
                            BialkaWyjsciowe[j] += "W";
                            break;
                        //
                        case "UGC":
                            BialkaWyjsciowe[j] += "C";
                            break;
                        case "UGU":
                            BialkaWyjsciowe[j] += "C";
                            break;
                        //
                        case "UAC":
                            BialkaWyjsciowe[j] += "Y";
                            break;
                        case "UAU":
                            BialkaWyjsciowe[j] += "Y";
                            break;
                        //
                        case "UUC":
                            BialkaWyjsciowe[j] += "F";
                            break;
                        case "UUU":
                            BialkaWyjsciowe[j] += "F";
                            break;
                        //
                        case "UGA":
                            i = KodGenetyczny.Length - 2;
                            break;
                        case "UAG":
                            i = KodGenetyczny.Length - 2;
                            break;
                        case "UAA":
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
            }
            Console.WriteLine("Tu jeszcze działa\n" + BialkaWyjsciowe1[0]);
            Console.WriteLine(BialkaWyjsciowe1[1]);
            Console.WriteLine(BialkaWyjsciowe1[2] + "\n (Tu jescze dziala )END\n");

            for (int j = 0; j < BialkaWyjsciowe.Length; j++)
            {

                char[] test = BialkaWyjsciowe1[j].Distinct().ToArray();
                String Temp = "";
                foreach (char c in test)
                {
                    Temp += c;
                    Console.Write(c.ToString());
                    Console.WriteLine();
                    BialkaWyjsciowe1[j] = c.ToString();
                }
                BialkaWyjsciowe1[j] = Temp;
            }
            Console.WriteLine("Po usunieciu powtórzen\n" + BialkaWyjsciowe1[0]);
            Console.WriteLine(BialkaWyjsciowe1[1]);
            Console.WriteLine(BialkaWyjsciowe1[2] + "\n");
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