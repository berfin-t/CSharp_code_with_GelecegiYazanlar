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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        DbUrunEntities db = new DbUrunEntities();

        private void BtnListele_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = db.TblUrunler.ToList();
            var urunler = from x in db.TblUrunler
                          select new
                          {
                              x.UrunId,
                              x.UrunAd,
                              x.Stok,
                              x.AlisFiyat,
                              x.SatisFiyat,
                              x.TblKategori.Ad
                          };
            dataGridView1.DataSource = urunler.ToList();
        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            CmbKategori.DataSource=db.TblKategori.ToList();
            CmbKategori.ValueMember = "ID";
            CmbKategori.DisplayMember = "Ad";
        }
    }
}
