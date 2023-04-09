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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }
        OgrenciSinavEntities db= new OgrenciSinavEntities();    
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtBolumAdi.Text == "")
            {
                errorProvider1.SetError(TxtBolumAdi, "Bölüm adı boş geçilemez");
            }
            else
            {
                TblBolum t = new TblBolum();
                t.BolumAd= TxtBolumAdi.Text;
                db.TblBolum.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kayıt yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
