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

            Kodgenetycznywyjscie.Text = Form1.KodgenetycznyCheck;
            string[] BialkaWyjsciowe2 = new string[] { "", "", "" };
            Console.WriteLine("Label 1: " + Form1.BialkaWyjsciowe1[0].ToString());
            Console.WriteLine("Label 2: " + Form1.BialkaWyjsciowe1[1].ToString());
            Console.WriteLine("Label 3: " + Form1.BialkaWyjsciowe1[2].ToString());

            if (Form1.BialkaWyjsciowe1[0] != null)
            {
                SekwencjaDNA1.Text = Form1.BialkaWyjsciowe1[0].ToString();
            }
            else
            {
                SekwencjaDNA1.Text = "PUSTY";
            }
            if (Form1.BialkaWyjsciowe1[1] != null)
            {
                SekwencjaDNA2.Text = Form1.BialkaWyjsciowe1[1].ToString();
            }
            else
            {
                SekwencjaDNA2.Text = "PUSTY";
            }
            if (Form1.BialkaWyjsciowe1[2] != null)
            {
                SekwencjaDNA3.Text = Form1.BialkaWyjsciowe1[2].ToString();
            }
            else
            {
                SekwencjaDNA3.Text = "PUSTY";
            }
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
