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

        public Form1()
        {
            InitializeComponent();
        }
        char[] rnaSequence = "AUGUUUCCCUGA".ToCharArray();

        bool SprawdzaniePoprawnosci(char[] rnaSequence)
        {
            for (int i = 0; i < rnaSequence.Length; i++)
            {
                if (rnaSequence[i] != 'A' || rnaSequence[i] != 'U' || rnaSequence[i] != 'G' || rnaSequence[i] != 'C' || rnaSequence.Length > 2)
                {
                    Console.WriteLine("JEST OK");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }


        void Sprawdzanie()
        {
            for (int i = 0; i < rnaSequence.Length; i++)
            {
                if (rnaSequence[i] == 'T')
                {
                    rnaSequence[i] = 'U';
                }
            }

            for (int i = 0; i < rnaSequence.Length - 2; i++)
            {
                if (/*rnaSequence[i] == 'A' && rnaSequence[i + 1] == 'U' && rnaSequence[i + 2] == 'G'*/(rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Mer[0]))
                {
                    Console.WriteLine("Znaleziono kodon START");
                    //Console.WriteLine(rnaSequence[i + 3]);
                    //Console.WriteLine("POCZATEK KODU: "+i);
                    //int poczatek = i; 
                    while (!(rnaSequence[i + 2] + "" + rnaSequence[i + 3] + "" + rnaSequence[i + 4]).Contains(KodonStop[0]))
                    {
                        Console.Write(rnaSequence[i]);
                        i++;
                    }

                    if ((rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]).Contains(Gly[0]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Gly[1]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Gly[2]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Gly[3]))
                    {
                        Console.WriteLine("Gly (G)");
                    }
                    if ((rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Glu[0]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Glu[1]))
                    {
                        Console.WriteLine("Glu (E)");
                    }
                    if ((rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Asp[0]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Asp[1]))
                    {
                        Console.WriteLine("Asp (D)");
                    }
                    if ((rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Ala[0]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Ala[1]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Ala[2]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Ala[3]))
                    {
                        Console.WriteLine("Ala (A)");
                    }
                    if ((rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Val[0]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Val[1]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Val[2]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Val[3]))
                    {
                        Console.WriteLine("Val (V)");
                    }
                    if ((rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Arg[0]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Arg[1]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Arg[2]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Arg[3]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Arg[4]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Arg[5]))
                    {
                        Console.WriteLine("Arg (P)");
                    }
                    if ((rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Ser[0]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Ser[1]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Ser[2]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Ser[3]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Ser[4]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Ser[5]))
                    {
                        Console.WriteLine("Ser (S)");
                    }
                    if ((rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Lys[0]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Lys[1]))
                    {
                        Console.WriteLine("Lys (K)");
                    }
                    if ((rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]).Contains(Asn[0]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Asn[1]))
                    {
                        Console.WriteLine("Asn (N)");
                    }
                    if ((rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Thr[0]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Thr[1]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Thr[2]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Thr[3]))
                    {
                        Console.WriteLine("Thr (T)");
                    }
                    if ((rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Ile[0]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Ile[1]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Ile[2]))
                    {
                        Console.WriteLine("Ile (I)");
                    }
                    if ((rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Gln[0]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Gln[1]))
                    {
                        Console.WriteLine("Gln (Q)");
                    }
                    if ((rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (His[0]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (His[1]))
                    {
                        Console.WriteLine("His (H)");
                    }
                    if ((rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Pro[0]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Pro[1]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Pro[2]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Pro[3]))
                    {
                        Console.WriteLine("Pro (P)");
                        continue;
                    }
                    if ((rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Leu[0]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Leu[1]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Leu[2]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Leu[3]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Leu[4]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Leu[5]))
                    {
                        Console.WriteLine("Leu (L)");
                    }
                    if ((rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Trp[0]))
                    {
                        Console.WriteLine("Trp (W)");
                    }
                    if ((rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Cys[0]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Cys[1]))
                    {
                        Console.WriteLine("Cys (C)");
                    }
                    if ((rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Tyr[0]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Tyr[1]))
                    {
                        Console.WriteLine("Tyr (Y)");
                    }
                    if ((rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Phe[0]) || (rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2]) == (Phe[1]))
                    {
                        Console.WriteLine("Phe (F)");
                        continue;
                    }
                    if ((rnaSequence[i] + "" + rnaSequence[i + 1] + "" + rnaSequence[i + 2] == (Mer[0])))
                    {
                        Console.WriteLine("Mer (M)");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Nie znaleziono kodonu START");
                }

            }
        }
        //textBox.Text = textBox.Text.ToUpper();
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
            string a = KodgenetycznyInput.Text;
            if (SprawdzaniePoprawnosci(a.ToCharArray()))
            {
                Sprawdzanie();
            }
            else
            {
                Console.WriteLine("Kod jest błędny wpisz poprawny");
            }
        }
    }
}
