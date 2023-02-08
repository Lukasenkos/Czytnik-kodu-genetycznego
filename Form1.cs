using System;
using System.Windows.Forms;

namespace Czytnik_kodu_genetycznego
{
    public partial class Form1 : Form
    {
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
            "AUA", "AUC", "AUU" ,
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

        void RozpoznawaczBialek(string KodGenetyczny)
        {
            
            for (int i = 0; i < KodGenetyczny.Length; i++)
            {
                if (KodGenetyczny[i] == 'T')
                {
                    //KodGenetyczny[i] = 'U';
                }

                for (int j = 0; j < Kodony[j].Length; j++)
                {
                    //if (KodGenetyczny[i] == Kodony[j])
                    //{

                    //}
                }
            }
        }


        void Sprawdzanie()
        {
            string a = KodgenetycznyInput.Text;
            if (SprawdzaniePoprawnosci(a.ToCharArray()))
            {
                RozpoznawaczBialek(a);
            }
            else
            {
                Console.WriteLine("Kod jest błędny wpisz poprawny");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Zmiana na duże litery w inpucie
            KodgenetycznyInput.SelectionStart = KodgenetycznyInput.Text.Length;
            KodgenetycznyInput.Text = KodgenetycznyInput.Text.ToUpper();
        }



        private void clear_Click(object sender, EventArgs e)
        {
            KodgenetycznyInput.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Zatwierdz_Click(object sender, EventArgs e)
        {
            Sprawdzanie();
        }
    }
}
