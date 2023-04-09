using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Ogrenci_Akademisyen_Proje.Entity;

namespace Ogrenci_Akademisyen_Proje.Formlar
{
    public partial class FrmOgrenciKayit : Form
    {
        public FrmOgrenciKayit()
        {
            InitializeComponent();
        }
        OgrenciSinavEntities db= new OgrenciSinavEntities();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-NBHVRA9\SQLEXPRESS;Initial Catalog=OgrenciSinav;Integrated Security=True");
        private void FrmOgrenciKayit_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * from TblBolum", baglanti);
            //SqlDataReader dr = cmd.ExecuteReader();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CbBolum.ValueMember = "BolumID";
            CbBolum.DisplayMember = "BolumAd";
            CbBolum.DataSource = dt;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtSifre.Text == TxtSifreTekrar.Text)
            {
                TblOgrenciler t = new TblOgrenciler();
                t.OgrAd = TxtAd.Text;
                t.OgrSoyad = TxtSoyad.Text;
                t.OgrNumara = MtbNumara.Text;
                t.OgrMail = TxtMail.Text;
                t.OgrResim = TxtResim.Text;
                t.OgrSifre = TxtSifre.Text;
                t.OgrBolum = int.Parse(CbBolum.SelectedValue.ToString());
                db.TblOgrenciler.Add(t);
                db.SaveChanges();
                MessageBox.Show("Öğrenci kaydı başarılı bir şekilde gerçekleşti.","Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor.Lütfen tekrar deneyin.", "Uyarı", MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void BtnResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            TxtResim.Text= openFileDialog1.FileName;

        }
    }
}
