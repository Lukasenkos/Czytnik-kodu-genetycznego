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
            //Zablokowanie zmiany wielkości okna programu
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            for (int k = 0; k < 3; k++)
            {

                Console.WriteLine(Form1.BialkaWyjsciowe1[k] + " LINIA " + k);
            }


            Kodgenetycznywyjscie.Text = Form1.KodgenetycznyCheck;
            string[] BialkaWyjsciowe2 = new string[] { "", "", "" };

            for (int i = 0; i < Form1.ListaBialek.Length; i++)
            {
                for (int j = 0; j < Form1.BialkaWyjsciowe1.Length; j++)
                {
                    if (Form1.BialkaWyjsciowe1[j] != null || Form1.BialkaWyjsciowe1[j] != "a")
                    {
                        if (Form1.BialkaWyjsciowe1[j] == Form1.ListaBialek[i])
                        {
                            BialkaWyjsciowe2[0] += Form1.ListaBialek[i];
                        }
                    }
                    else
                    {
                        Console.WriteLine("NULL 1");
                    }
                }

                for (int j = 0; j < Form1.BialkaWyjsciowe1.Length; j++)
                {
                    if (Form1.BialkaWyjsciowe1[j] != null || Form1.BialkaWyjsciowe1[j] != "a")
                    {
                        if (Form1.BialkaWyjsciowe1[j] == Form1.ListaBialek[i])
                        {
                            BialkaWyjsciowe2[1] += Form1.ListaBialek[i];
                        }
                    }
                    else
                    {
                        Console.WriteLine("NULL 2");
                    }
                }


                for (int j = 0; j < Form1.BialkaWyjsciowe1.Length; j++)
                {
                    if (Form1.BialkaWyjsciowe1[j] != null || Form1.BialkaWyjsciowe1[j] != "a")
                    {
                        if (Form1.BialkaWyjsciowe1[j] == Form1.ListaBialek[i])
                        {
                            BialkaWyjsciowe2[2] += Form1.ListaBialek[i];
                        }
                    }
                    else
                    {
                        Console.WriteLine("NULL 3");
                    }
                }
            }
            SekwencjaDNA1.Text = BialkaWyjsciowe2[0].ToString();
            SekwencjaDNA2.Text = BialkaWyjsciowe2[1].ToString();
            SekwencjaDNA3.Text = BialkaWyjsciowe2[2].ToString();


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
