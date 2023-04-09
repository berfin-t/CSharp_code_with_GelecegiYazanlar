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
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }
        OgrenciSinavEntities db = new OgrenciSinavEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if(TxtDersAdi.Text=="")
            {
                errorProvider1.SetError(TxtDersAdi, "Ders adı boş geçilemez");

            }
            else
            {
                TblDersler t = new TblDersler();
                t.DersAd=TxtDersAdi.Text;
                db.TblDersler.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kayıt yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
