using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urun_Takip_EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbUrunEntities db = new DbUrunEntities();
        private void BtnListele_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = db.TblMusteri.ToList();                                                                                                                                                                                                                                        
            var degerler = from x in db.TblMusteri
                           select new
                           {
                               x.MusteriID,
                               x.Ad,
                               x.Soyad,
                               x.Sehir,
                               x.Bakiye
                           };
            dataGridView1.DataSource= degerler.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TblMusteri t = new TblMusteri();
            t.Ad = TxtAd.Text;
            t.Bakiye = decimal.Parse(TxtBakiye.Text);
            t.Soyad = TxtSoyad.Text;
            t.Sehir = TxtSehir.Text;
            db.TblMusteri.Add(t);
            db.SaveChanges();
            MessageBox.Show("Müşteri kaydedildi");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var x = db.TblMusteri.Find(id);
            db.TblMusteri.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Müşteri Silindi");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var x = db.TblMusteri.Find(id);
            x.Ad = TxtAd.Text;
            x.Bakiye = decimal.Parse(TxtBakiye.Text);
            x.Soyad = TxtSoyad.Text;
            x.Sehir = TxtSehir.Text;
            db.SaveChanges();
            MessageBox.Show("Müşteri bilgisi güncellendi.");
        }
    }
}
