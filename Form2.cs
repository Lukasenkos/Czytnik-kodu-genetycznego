using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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

            if (Form1.BialkaWyjsciowe1[0] != null)
            {
                SekwencjaDNA1.Text = Form1.BialkaWyjsciowe1[0].ToString();
            }
            if (Form1.BialkaWyjsciowe1[1] != null)
            {
                SekwencjaDNA2.Text = Form1.BialkaWyjsciowe1[1].ToString();
            }
            if (Form1.BialkaWyjsciowe1[2] != null)
            {
                SekwencjaDNA3.Text = Form1.BialkaWyjsciowe1[2].ToString();
            }
            else
            {
                Console.WriteLine("PUSTE");
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
