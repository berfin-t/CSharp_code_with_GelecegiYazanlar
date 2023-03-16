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
        void urunListesi()
        {
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
        private void BtnListele_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = db.TblUrunler.ToList();
            urunListesi();
        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            CmbKategori.DataSource=db.TblKategori.ToList();
            CmbKategori.ValueMember = "ID";
            CmbKategori.DisplayMember = "Ad";
            urunListesi();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TblUrunler t = new TblUrunler();
            t.AlisFiyat = decimal.Parse(TxtAlisFiyati.Text);
            t.SatisFiyat = decimal.Parse(TxtSatisFiyati.Text) ;
            t.Stok = short.Parse(TxtStok.Text);
            t.UrunAd = TxtUrunAd.Text;
            t.Kategori = int.Parse(CmbKategori.SelectedValue.ToString());
            db.TblUrunler.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün kaydedildi.");
            urunListesi();
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtUrunAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtAlisFiyati.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtSatisFiyati.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtStok.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            CmbKategori.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if(TxtId.Text != "")
            {
                int id = int.Parse(TxtId.Text);
                var x = db.TblMusteri.Find(id);
                db.TblMusteri.Remove(x);
                db.SaveChanges();
                MessageBox.Show("Müşteri Silindi");
            }
            else
            {
                MessageBox.Show("Lütfen verileri listeledikten sonra bir satıra tıklayıp silmek istediğiniz kaydı seçiniz.");
            }
            urunListesi();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var x = db.TblUrunler.Find(id);
            x.UrunAd = TxtUrunAd.Text;
            x.SatisFiyat = decimal.Parse(TxtSatisFiyati.Text);
            x.AlisFiyat = decimal.Parse(TxtAlisFiyati.Text);
            x.Kategori = int.Parse(CmbKategori.SelectedValue.ToString());
            x.Stok = short.Parse(TxtStok.Text);
            db.SaveChanges();
            MessageBox.Show("Verileriniz başarılı bir şekilde güncellendi");
            urunListesi();
        }
    }
}
