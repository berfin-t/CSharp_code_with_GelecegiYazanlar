using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ogrenci_Akademisyen_Proje.Entity;

namespace Ogrenci_Akademisyen_Proje.Formlar
{
    public partial class FrmOgrenciPanel : Form
    {
        public FrmOgrenciPanel()
        {
            InitializeComponent();
        }
        OgrenciSinavEntities db = new OgrenciSinavEntities();   
        public string numara;
        int ogrenciid;
        private void FrmOgrenciPanel_Load(object sender, EventArgs e)
        {
            MTxtNumara.Text = numara;
            TxtAd.Text = db.TblOgrenciler.Where(x => x.OgrNumara == numara).Select(y => y.OgrAd).FirstOrDefault();
            TxtSoyad.Text = db.TblOgrenciler.Where(x => x.OgrNumara == numara).Select(y => y.OgrSoyad).FirstOrDefault();
            TxtSifre.Text = db.TblOgrenciler.Where(x => x.OgrNumara == numara).Select(y => y.OgrSifre).FirstOrDefault();
            TxtMail.Text = db.TblOgrenciler.Where(x => x.OgrNumara == numara).Select(y => y.OgrMail).FirstOrDefault();
            TxtBolum.Text = db.TblOgrenciler.Where(x => x.OgrNumara == numara).Select(y => y.OgrBolum).FirstOrDefault().ToString();

            ogrenciid = db.TblOgrenciler.Where(x => x.OgrNumara == numara).Select(y => y.OgrID).FirstOrDefault();

            var sinavnotlari = (from x in db.TblNotlar
                                select new
                                {
                                    x.TblDersler.DersAd,
                                    x.Sinav1,
                                    x.Sinav2,
                                    x.Sinav3,
                                    x.Quiz1,
                                    x.Quiz2,
                                    x.Ortalama,
                                    x.Ogrenci
                                }).Where(y => y.Ogrenci == ogrenciid).ToList();
            dataGridView1.DataSource = sinavnotlari;
            }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (TxtYeniSifre1.Text == TxtYeniSifre2.Text)
            {
                var deger = db.TblOgrenciler.Find(ogrenciid);
                deger.OgrSifre = TxtYeniSifre1.Text;
                db.SaveChanges();
                MessageBox.Show("Şifre değiştirme işlemi başarılı bir şekilde gerçekleşti");
            }
            else
            {
                MessageBox.Show("Girdiğiniz yeni şifreler birbiri ile uyuşmuyor!");
            }
        }
    }
}
