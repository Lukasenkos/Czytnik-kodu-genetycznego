using System;
using System.Windows.Forms;



namespace Czytnik_kodu_genetycznego
{



    public partial class Form1 : Form
    {
        //Zablokowanie zmiany wielkości okna programu
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }


        String[] Gly = { "GGG", "GGA", "GGC", "GGU" };
        String[] Glu = { "GAG", "GAA" };
        String[] Asp = { "GAC", "GAU" };
        String[] Ala = { "GCG", "GCA", "GCC", "GCU" };
        String[] Val = { "GUG", "GUA", "GUC", "GUU" };
        String[] Arg = { "AGG", "AGA", "CGG", "CGA", "CGC", "CGU" };
        String[] Ser = { "AGC", "AGU", "UCU", "UCC", "UCA", "UCG" };
        String[] Lys = { "AAG", "AAA" };
        String[] Asn = { "AAC", "AAU" };
        String[] Thr = { "ACG", "ACA", "ACC", "ACU" };
        String[] Mer = { "AUG" }; //Kodon START
        String[] Ile = { "AUA", "AUC", "AUU" };
        String[] Gln = { "CAG", "CAA" };
        String[] His = { "CAC", "CAU" };
        String[] Pro = { "CCG", "CCA", "CCC", "CCU" };
        String[] Leu = { "CUG", "CUA", "CUC", "CUU", "UUG", "UUA" };
        String[] Trp = { "UGG" };
        String[] Cys = { "UGC", "UGU" };
        String[] Tyr = { "UAC", "UAU" };
        String[] Phe = { "UUC", "UUU" };
        String[] KodonStop = { "UGA", "UAG", "UAA" };
        String[] Kodony = {
            "GGG", "GGA", "GGC", "GGU",
            "GAG", "GAA",
            "GAC", "GAU",
            "GCG", "GCA", "GCC", "GCU",
            "GUG", "GUA", "GUC", "GUU",
            "AGG", "AGA", "CGG", "CGA", "CGC", "CGU",
            "AGC", "AGU", "UCU", "UCC", "UCA", "UCG",
            "AAG", "AAA",
            "AAC", "AAU",
            "ACG", "ACA", "ACC", "ACU",
            "AUG",
            "AUA", "AUC", "AUU",
            "CAG", "CAA",
            "CAC", "CAU",
            "CCG", "CCA", "CCC", "CCU",
            "CUG", "CUA", "CUC", "CUU", "UUG", "UUA",
            "UGG",
            "UGC", "UGU",
            "UAC", "UAU",
            "UUC", "UUU",
            "UGA", "UAG", "UAA"
        };

        public Form1()
        {
            InitializeComponent();
        }

        bool SprawdzaniePoprawnosci(char[] rnaSequence)
        {
            if (checkBox1.Checked != true)
            {
                Console.WriteLine("JEST TO DNA");
                for (int i = 0; i < rnaSequence.Length; i++)
                {
                    if (rnaSequence[i] == 'A' || rnaSequence[i] == 'G' || rnaSequence[i] == 'C' || rnaSequence[i] == 'T' && rnaSequence.Length > 2)
                    {
                        Console.WriteLine("JEST OK: " + i + " " + rnaSequence[i]);
                    }
                    else
                    {
                        Console.WriteLine("Wykryto nie poprawny GEN: " + i + " " + rnaSequence[i]);
                        return false;
                    }
                }
                Console.WriteLine("Kod DNA jest poprawny");
                return true;
            }
            else
            {
                Console.WriteLine("JEST TO RNA");
                for (int i = 0; i < rnaSequence.Length; i++)
                {
                    if (rnaSequence[i] == 'A' || rnaSequence[i] == 'G' || rnaSequence[i] == 'C' || rnaSequence[i] == 'U' && rnaSequence.Length > 2)
                    {
                        Console.WriteLine("JEST OK: " + i + " " + rnaSequence[i]);
                    }
                    else
                    {
                        Console.WriteLine("Wykryto nie poprawny GEN: " + i + " " + rnaSequence[i]);
                        return false;
                    }
                }
                Console.WriteLine("Kod RNA jest poprawny");
                return true;
            }
        }

        void RozpoznawaczBialek()
        {
            char[] KodGenetyczny = KodgenetycznyInput.Text.ToCharArray();
            for (int i = 0; i < KodGenetyczny.Length; i++)
            {
                //char gen = KodGenetyczny[i];

                //Zamiana T na U. 
                if (KodGenetyczny[i] == 'T')
                {
                    KodGenetyczny[i] = 'U';
                }
            }

            for (int i = 0; i < KodGenetyczny.Length - 2; i = i + 3)
            {
                switch (KodGenetyczny[i].ToString() + KodGenetyczny[i + 1].ToString() + KodGenetyczny[i + 2].ToString())
                {
                    //Kodon Start
                    case "AUG":
                        Console.WriteLine("Mer");
                        break;
                    //
                    case "GGG":
                        Console.WriteLine("Gly");
                        break;
                    case "GGA":
                        Console.WriteLine("Gly");
                        break;
                    case "GGC":
                        Console.WriteLine("Gly");
                        break;
                    case "GGU":
                        Console.WriteLine("Gly");
                        break;
                    //
                    case "GAG":
                        Console.WriteLine("Glu");
                        break;
                    case "GAA":
                        Console.WriteLine("Glu");
                        break;
                    //
                    case "GAC":
                        Console.WriteLine("Asp");
                        break;
                    case "GAU":
                        Console.WriteLine("Asp");
                        break;
                    //
                    case "GCG":
                        Console.WriteLine("Ala");
                        break;
                    case "GCA":
                        Console.WriteLine("Ala");
                        break;
                    case "GCC":
                        Console.WriteLine("Ala");
                        break;
                    case "GCU":
                        Console.WriteLine("Ala");
                        break;
                    //
                    case "GUG":
                        Console.WriteLine("Val");
                        break;
                    case "GUA":
                        Console.WriteLine("Val");
                        break;
                    case "GUC":
                        Console.WriteLine("Val");
                        break;
                    case "GUU":
                        Console.WriteLine("Val");
                        break;
                    //
                    case "AGG":
                        Console.WriteLine("Arg");
                        break;
                    case "AGA":
                        Console.WriteLine("Arg");
                        break;
                    case "CGG":
                        Console.WriteLine("Arg");
                        break;
                    case "CGA":
                        Console.WriteLine("Arg");
                        break;
                    case "CGC":
                        Console.WriteLine("Arg");
                        break;
                    case "CGU":
                        Console.WriteLine("Arg");
                        break;
                    //
                    case "AGC":
                        Console.WriteLine("Ser");
                        break;
                    case "AGU":
                        Console.WriteLine("Ser");
                        break;
                    case "UCU":
                        Console.WriteLine("Ser");
                        break;
                    case "UCC":
                        Console.WriteLine("Ser");
                        break;
                    case "UCA":
                        Console.WriteLine("Ser");
                        break;
                    case "UCG":
                        Console.WriteLine("Ser");
                        break;
                    //
                    case "AAG":
                        Console.WriteLine("Lys");
                        break;
                    case "AAA":
                        Console.WriteLine("Lys");
                        break;
                    //
                    case "AAC":
                        Console.WriteLine("Asm");
                        break;
                    case "AAU":
                        Console.WriteLine("Asm");
                        break;
                    //
                    case "ACG":
                        Console.WriteLine("Thr");
                        break;
                    case "ACA":
                        Console.WriteLine("Thr");
                        break;
                    case "ACC":
                        Console.WriteLine("Thr");
                        break;
                    case "ACU":
                        Console.WriteLine("Thr");
                        break;
                    //
                    case "AUA":
                        Console.WriteLine("Ile");
                        break;
                    case "AUC":
                        Console.WriteLine("Ile");
                        break;
                    case "AUU":
                        Console.WriteLine("Ile");
                        break;
                    //
                    case "CAG":
                        Console.WriteLine("Gln");
                        break;
                    case "CAA":
                        Console.WriteLine("Gln");
                        break;
                    //
                    case "CAC":
                        Console.WriteLine("His");
                        break;
                    case "CAU":
                        Console.WriteLine("His");
                        break;
                    //
                    case "CCG":
                        Console.WriteLine("Pro");
                        break;
                    case "CCA":
                        Console.WriteLine("Pro");
                        break;
                    case "CCC":
                        Console.WriteLine("Pro");
                        break;
                    case "CCU":
                        Console.WriteLine("Pro");
                        break;
                    //
                    case "CUG":
                        Console.WriteLine("Leu");
                        break;
                    case "CUA":
                        Console.WriteLine("Leu");
                        break;
                    case "CUC":
                        Console.WriteLine("Leu");
                        break;
                    case "CUU":
                        Console.WriteLine("Leu");
                        break;
                    case "UUG":
                        Console.WriteLine("Leu");
                        break;
                    case "UUA":
                        Console.WriteLine("Leu");
                        break;
                    //
                    case "UGG":
                        Console.WriteLine("Trp");
                        break;
                    //
                    case "UGC":
                        Console.WriteLine("Cys");
                        break;
                    case "UGU":
                        Console.WriteLine("Cys");
                        break;
                    //
                    case "UAC":
                        Console.WriteLine("Tyr");
                        break;
                    case "UAU":
                        Console.WriteLine("Tyr");
                        break;
                    //
                    case "UUC":
                        Console.WriteLine("Phe");
                        break;
                    case "UUU":
                        Console.WriteLine("Phe");
                        break;
                    //
                    case "UGA":
                        Console.WriteLine("Stop");
                        break;
                    case "UAG":
                        Console.WriteLine("Stop");
                        break;
                    case "UAA":
                        Console.WriteLine("Stop");
                        break;
                    //
                    default:
                        Console.WriteLine("Coś się zjebało.");
                        break;
                }

            }


        }


        void Sprawdzanie()
        {
            //Sprawdzanie poprawności danych
            string a = KodgenetycznyInput.Text;
            if (SprawdzaniePoprawnosci(a.ToCharArray()))
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
            //Zmiana na duże litery w inpucie
            //KodgenetycznyInput.SelectionStart = KodgenetycznyInput.Text.Length;
            //KodgenetycznyInput.Text = KodgenetycznyInput.Text.ToUpper();
        }


        //Czyści inputa
        private void clear_Click(object sender, EventArgs e)
        {
            KodgenetycznyInput.Clear();
        }

        //Nie usuwać :) 
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Zatwierdz_Click(object sender, EventArgs e)
        {
            Sprawdzanie();
            //Console.WriteLine("KODONY");
            //for (int j = 0; j < 64; j++)
            //{
            //    Console.WriteLine(Kodony[j]);
            //}
        }
    }
}



/*
String[] baza = KodgenetycznyInput.Text.ToString();
String[] trzy = { "" };
for (int i = 0; i < KodGenetyczny.Length; i++)
    {
        trzy = baza[i] + "" + baza[i+1] + "" + baza[i+2];
    }
switch (trzy)
    {
        case == "AUG":
            Console.WriteLine("M(Start)");
            break;

        case == "UAA"||"UAG"||"UGA":
            Console.WriteLine("Stop");
            break;
AMOGUS
*/