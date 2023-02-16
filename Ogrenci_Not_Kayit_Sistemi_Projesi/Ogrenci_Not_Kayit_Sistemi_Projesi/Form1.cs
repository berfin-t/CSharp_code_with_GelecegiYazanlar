using System;
using System.Windows.Forms;

namespace Ogrenci_Not_Kayit_Sistemi_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, ort;
            string durum;
            s1 = Convert.ToInt16(TxtSinav1.Text);
            s2 = Convert.ToInt16(TxtSinav2.Text);
            s3 = Convert.ToInt16(TxtSinav3.Text);
            ort = (s1 + s2 + s3) / 3;
            TxtOrt.Text = ort.ToString();
            if (ort >= 50)
            {
                durum = "Geçti";
            }
            else
            {
                durum = "Kaldı";
            }
            TxtDurum.Text = durum;
        }
        int sayac = 0;
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtDurum.Text != "" && TxtOrt.Text != "")
            {

                string adsoyad, ders, numara;
                adsoyad = TxtAdSoyad.Text;
                ders = CmbDers.Text;
                numara = MskNumara.Text;
                listBox1.Items.Add(adsoyad + " " + ders + " Numara: " + numara + " Ortalama: " + TxtOrt.Text 
                    + " Durum: " + TxtDurum.Text);
                sayac++;
                label10.Text = "Kaydedilen Öğrenci Sayısı: " + sayac;
            }
            else
            {
                MessageBox.Show("Lütfen ortalama ve durum hesabını yapınız!", "Uyarı", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdSoyad.Clear();
            MskNumara.Clear();
            TxtDurum.Clear();
            TxtOrt.Clear();
            TxtSinav1.Clear();
            TxtSinav2.Clear();
            TxtSinav3.Clear();
            CmbDers.SelectedIndex = -1;
            TxtAdSoyad.Focus();

        }

        private void BtnCizgi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("----------------------------------------");
        }

        private void BtnMesaj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba mı Dünya?", "Mesaj Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

       

       

        }
}

