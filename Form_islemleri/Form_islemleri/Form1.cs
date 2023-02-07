using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_islemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void kodolustur()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(10000, 100000);
            TxtKod2.Text = sayi.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kodolustur();
            timer1.Start();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            if(TxtKullaniciAdi.Text=="admin" && TxtSifre.Text=="1234" && TxtKod.Text==TxtKod2.Text)
            {
                Form2 frm = new Form2();
                frm.kullanici = TxtKullaniciAdi.Text;
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı bilgi girişi: Kullanıcı adı, şifre veya kod yanlış girildi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void LinkLabSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }
        int sayac;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac % 2 == 0)
            {
                label3.BackColor = Color.YellowGreen;
            }
            else
            {
                label3.BackColor = Color.Olive;
            }
            if(sayac==10)
            {
                sayac = 0;
            }
        }
    }
}
