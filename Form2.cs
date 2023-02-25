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

            if (Form1.BialkaWyjsciowe1[0] != null || Form1.BialkaWyjsciowe1[0] != "a")
            {
                SekwencjaDNA1.Text = Form1.BialkaWyjsciowe1[0].ToString();
            }
            else
            {
                Console.WriteLine("NULL 1");
            }

            if (Form1.BialkaWyjsciowe1[1] != null || Form1.BialkaWyjsciowe1[0] != "a")
            {
                SekwencjaDNA2.Text = Form1.BialkaWyjsciowe1[1].ToString();
            }
            else
            {
                Console.WriteLine("NULL 2");
            }

            if (Form1.BialkaWyjsciowe1[2] != null || Form1.BialkaWyjsciowe1[0] != "a")
            {
                SekwencjaDNA3.Text = Form1.BialkaWyjsciowe1[2].ToString();
            }
            else
            {
                Console.WriteLine("NULL 3");
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
