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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        OgrenciSinavEntities db = new OgrenciSinavEntities();   

        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            CbDers.DisplayMember = "DersAd";
            CbDers.ValueMember = "DersID";
            CbDers.DataSource = db.TblDersler.ToList();
            CbDersSecim.DisplayMember = "DersAd";
            CbDersSecim.ValueMember = "DersID";
            CbDersSecim.DataSource=db.TblDersler.ToList();  
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TblNotlar t = new TblNotlar();
            t.Sinav1 = byte.Parse(TxtSinav1.Text);
            t.Sinav2 = byte.Parse(TxtSinav2.Text);
            t.Sinav3 = byte.Parse(TxtSinav3.Text);
            t.Quiz1 = byte.Parse(TxtQuiz1.Text);
            t.Quiz2 =byte.Parse(TxtQuiz2.Text);
            t.Proje = byte.Parse(TxtProje.Text);
            t.Ders = int.Parse(CbDers.SelectedValue.ToString());
            t.Ogrenci = int.Parse(TxtOgrenci.Text);
            db.TblNotlar.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kayıt işlemi başarılı bir şekilde gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            byte s1, s2, s3, q1, q2, proje;
            double ortalama;
            s1 = Convert.ToByte(TxtSinav1.Text);
            s2 = byte.Parse(TxtSinav2.Text);
            s3 = byte.Parse(TxtSinav3.Text);
            q1 = byte.Parse(TxtQuiz1.Text);
            q2 = byte.Parse(TxtQuiz2.Text);
            proje = byte.Parse(TxtProje.Text);
            ortalama = (s1 + s2 + s3 + q1 + q2 + proje)/6;
            TxtOrtalama.Text=ortalama.ToString();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = db.View_1.ToList();
            dataGridView1.DataSource = db.Notlar();       
        }

        private void CbDersSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            var degerler = from x in db.TblNotlar
                           select new
                           {
                               x.NotID,
                               x.TblDersler.DersAd,
                               Öğrenci_Adı = x.TblOgrenciler.OgrAd + " " + x.TblOgrenciler.OgrSoyad,
                               x.Sinav1,
                               x.Sinav2,
                               x.Sinav3,
                               x.Quiz1,
                               x.Quiz2,
                               x.Proje,
                               x.Ortalama,
                               x.Ders
                           };
            
            int d = int.Parse(CbDersSecim.SelectedValue.ToString());
            dataGridView1.DataSource = degerler.Where(y => y.Ders == d).ToList();
            dataGridView1.Columns["Ders"].Visible = false;
        }

        //private void BtnAra_Click(object sender, EventArgs e)
        //{
        //    var degerler = from x in db.TblNotlar
        //                   select new
        //                   {
        //                       x.NotID,
        //                       x.TblDersler.DersAd,
        //                       Öğrenci_Adı = x.TblOgrenciler.OgrAd + " " + x.TblOgrenciler.OgrSoyad,
        //                       x.Sinav1,
        //                       x.Sinav2,
        //                       x.Sinav3,
        //                       x.Quiz1,
        //                       x.Quiz2,
        //                       x.Proje,
        //                       x.Ortalama,
        //                       x.Ogrenci
        //                   };
        //    int id = int.Parse(MTxtOgrenciNumarasi.Text);
        //    dataGridView1.DataSource = degerler.Where(y => y.Ogrenci == id).ToList();
        //    dataGridView1.Columns["Ogrenci"].Visible = false;

        //}

        private void BtnAra2_Click(object sender, EventArgs e)
        {
            string no = MTxtOgrenciNumarasi.Text;
            var deger = db.TblOgrenciler.Where(x => x.OgrNumara == no).Select(y=>y.OgrID).FirstOrDefault();
            TxtID.Text = deger.ToString();
            var notlar = from x in db.TblNotlar
                         select new
                         {
                             x.NotID,
                             x.TblDersler.DersAd,
                             Öğrenci_Adı = x.TblOgrenciler.OgrAd + " " + x.TblOgrenciler.OgrSoyad,
                             x.Sinav1,
                             x.Sinav2,
                             x.Sinav3,
                             x.Quiz1,
                             x.Quiz2,
                             x.Proje,
                             x.Ortalama,
                             x.Ogrenci
                         };
            dataGridView1.DataSource = notlar.Where(z => z.Ogrenci == deger).ToList();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtSinav1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtSinav2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtSinav3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            TxtQuiz1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            TxtQuiz2.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            TxtProje.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var x = db.TblNotlar.Find(id);
            x.Sinav1 = int.Parse(TxtSinav1.Text);
            x.Sinav1 = int.Parse(TxtSinav1.Text);
            x.Sinav2 = int.Parse(TxtSinav2.Text);
            x.Sinav3 = int.Parse(TxtSinav3.Text);
            x.Quiz1 = int.Parse(TxtQuiz1.Text);
            x.Quiz2 = int.Parse(TxtQuiz2.Text);
            x.Proje = int.Parse(TxtProje.Text);
            //x.Ortalama = Convert.ToInt32(TxtOrtalama.Text);
            db.SaveChanges();
            MessageBox.Show("Ögrenci başarılı bir şekilde güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

    }
}
