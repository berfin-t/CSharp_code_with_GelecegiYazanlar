using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ogrenci_Akademisyen_Proje.Formlar
{
    public partial class FrmHarita : Form
    {
        public FrmHarita()
        {
            InitializeComponent();
        }

        private void PnlOgrenciKayit_Click(object sender, EventArgs e)
        {
            FrmOgrenciKayit frm = new FrmOgrenciKayit();
            frm.Show();
        }

        private void PnlDersListesi_Click(object sender, EventArgs e)
        {
            FrmDersListesi frm = new FrmDersListesi();
            frm.Show();
        }

        private void PnlBolumListesi_Click(object sender, EventArgs e)
        {
            FrmBolumListesi frm = new FrmBolumListesi();
            frm.Show();
        }

        private void PnlYeniBolum_Click(object sender, EventArgs e)
        {
            FrmBolumler frm=new FrmBolumler();
            frm.Show();
        }

        private void PnlNotlarFormu_Click(object sender, EventArgs e)
        {
            FrmNotlar frm=new FrmNotlar();
            frm.Show();
        }

        private void PnlÖğrenciFormu_Click(object sender, EventArgs e)
        {
            FrmOgrenci frm=new FrmOgrenci();
            frm.Show();
        }

        private void PnlYeniDers_Click(object sender, EventArgs e)
        {
            FrmDersler frm= new FrmDersler();
            frm.Show();
        }

        private void PnlYardim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Turkcell Geleceği Yazanlar Eğitimi kapsamında hazırlanmıştır. Müfredatın son projesinde amacımız şu ana kadar öğrenmiş olduğumuz konuların büyük bir ısmını içeren örnek bir veri tabanlı proje uygulaması geliştirmektir.Projemizde akademisyen için kullanıcı ad: 00000 olup şifre: 000 şeklindedir.Akademisyen panelinden öğrenci, ders, bölüm, sınav notları gibi işlemlerin tamamı gerçekleştirilebilir. Sisteme giriş yapan öğrenci sadece kendisine ait bilgileri ve sınav notlarını görüntüler.", 
                "Yardım Penceresi",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }

        private void PnlCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}