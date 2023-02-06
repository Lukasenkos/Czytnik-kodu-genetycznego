using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Czytnik_kodu_genetycznego
{
    public partial class Form1 : Form
    {
        String rnaSequence { get;}
        public Form1()
        {   
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            char [] FinalArrayRnaSequence = { };
            //char [] rnaSequence = KodgenetycznyInput.Text.ToCharArray();
            char[] rnaSequence = "AUGTSTUAA".ToCharArray();
            //Console.WriteLine(rnaSequence);
            //String [] ArrayRnaSequence = new String[] { rnaSequence };
            /*char[] ArrayRnaSequence = rnaSequence.ToCharArray();
            foreach(char ch in ArrayRnaSequence) {
                MessageBox.Show(Strin);
            }*/
            //Console.WriteLine(rnaSequence);
            for (int i = 0; i < rnaSequence.Length; i++)
            {
                if (rnaSequence[i] == 'T')
                {
                    rnaSequence[i] = 'U';
                }
            }
        //Dodać sprawdzanie długości kodu trzeba
        outerLoop:
            for(int i = 0; i <= 0; i++)
            {
                break;
            }

            for (int i = 0; i < rnaSequence.Length-2; i++)
            {
                while (rnaSequence[i] == 'A' && rnaSequence[i + 1] == 'U' && rnaSequence[i + 2] == 'G')
                {
                    //Console.WriteLine(rnaSequence[i + 3]);
                    //Console.WriteLine("POCZATEK KODU: "+i);
                    //int poczatek = i;
                    if (rnaSequence[i + 3] != 'U' && rnaSequence[i + 4] != 'A' && rnaSequence[i + 5] != 'A')
                    {
                        Console.WriteLine(rnaSequence[i+3]);
                        i++;
                    }
                    else
                    {
                        goto outerLoop;
                    }
                }
                /*
                if (rnaSequence[i] == 'A' && rnaSequence[i + 1] == 'U' && rnaSequence[i + 2] == 'G')
                {
                    for (int j = 0; j<rnaSequence.Length-2; j++)
                    {
                        if ((rnaSequence[j] != 'U' && rnaSequence[j + 1] != 'A' && rnaSequence[j + 2] != 'A') || (rnaSequence[i] != 'U' && rnaSequence[i + 1] != 'A' && rnaSequence[i + 2] != 'G') || (rnaSequence[i] != 'U' && rnaSequence[i + 1] != 'G' && rnaSequence[i + 2] != 'A'))
                        {
                            Console.WriteLine(rnaSequence[j + 3]);
                            Console.WriteLine(j + 3);
                            FinalArrayRnaSequence = new char[] { rnaSequence[j + 3] };
                        }
                    }
                }*/
            }
            //Console.WriteLine(FinalArrayRnaSequence);
            //Console.WriteLine('---------------------');
            //Console.WriteLine(String.Join(Environment.NewLine, FinalArrayRnaSequence));
            //Console.WriteLine('---------------------');
            //string kng = FinalArrayRnaSequence.ToString();
            //MessageBox.Show(kng);   //String.Join(' ', FinalArrayRnaSequence));
            //Console.WriteLine(kng);
        }


    }
    
    

    
}
