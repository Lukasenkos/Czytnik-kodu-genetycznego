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

            Kodgenetycznywyjscie.Text = Form1.KodgenetycznyCheck;
            string[] BialkaWyjsciowe2 = new string[] { "", "", "" };

            for(int i = 0; i < Form1.ListaBialek.Length; i++)
            {
                if (Form1.BialkaWyjsciowe1[0] != null || Form1.BialkaWyjsciowe1[0] != "a")
                {
                    if (Form1.BialkaWyjsciowe1[0].ToString().Contains(Form1.ListaBialek[i]))
                    {
                        BialkaWyjsciowe2[0] += Form1.ListaBialek[i];
                    }
                }
                else
                {
                    Console.WriteLine("NULL 1");
                }
            }
            SekwencjaDNA1.Text = BialkaWyjsciowe2[0].ToString();

            for (int i = 0; i < Form1.ListaBialek.Length; i++)
            {
                if (Form1.BialkaWyjsciowe1[1] != null || Form1.BialkaWyjsciowe1[0] != "a")
                {
                    if (Form1.BialkaWyjsciowe1[1].ToString().Contains(Form1.ListaBialek[i]))
                    {
                        BialkaWyjsciowe2[1] += Form1.ListaBialek[i];
                    }
                }
                else
                {
                    Console.WriteLine("NULL 2");
                }
            }
            SekwencjaDNA2.Text = BialkaWyjsciowe2[1].ToString();


            for (int i = 0; i < Form1.ListaBialek.Length; i++)
            {
                if (Form1.BialkaWyjsciowe1[2] != null || Form1.BialkaWyjsciowe1[0] != "a")
                {
                    if (Form1.BialkaWyjsciowe1[2].ToString().Contains(Form1.ListaBialek[i]))
                    {
                        BialkaWyjsciowe2[2] += Form1.ListaBialek[i];
                    }
                }
                else
                {
                    Console.WriteLine("NULL 3");
                }
            }
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
