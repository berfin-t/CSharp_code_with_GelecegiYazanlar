using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sezar_Sifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSifrele_Click(object sender, EventArgs e)
        {
            string veri = "";
            veri=TxtVeri.Text;
            char[] karakterler=veri.ToCharArray();
            foreach(char eleman in karakterler)
            {
                TxtSifreliVeri.Text += Convert.ToChar(eleman + 3).ToString();
            }
        }

        private void BtnSifreCoz_Click(object sender, EventArgs e)
        {
            string sifre = "";
            sifre = TxtSifreliVeri.Text;
            char[] karakterler=sifre.ToCharArray();
            foreach(char eleman in karakterler)
            {
                TxtVeri.Text += Convert.ToChar(eleman - 3).ToString();

            }
        }
    }
}
