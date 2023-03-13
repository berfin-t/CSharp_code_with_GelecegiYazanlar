using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urun_Takip
{
    public partial class FrmSatislar : Form
    {
        public FrmSatislar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-NBHVRA9\SQLEXPRESS;Initial Catalog=DbUrun;Integrated Security=True");
        DataSet1TableAdapters.TblSatislarTableAdapter ds = new DataSet1TableAdapters.TblSatislarTableAdapter();

        private void BtnListele_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("Execute SatisListesi", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmSatislar_Load(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Select * from TblUrunler", baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            CmbUrun.ValueMember = "UrunID";
            CmbUrun.DisplayMember = "UrunAd";
            CmbUrun.DataSource = dt2;

            dataGridView1.DataSource = ds.SatisListesi();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            ds.SatisEkle(int.Parse(CmbUrun.SelectedValue.ToString()), int.Parse(TxtMusteri.Text), byte.Parse(TxtAdet.Text), decimal.Parse(TxtFiyat.Text), decimal.Parse(TxtToplam.Text), DateTime.Parse(MtxtTarih.Text));
            MessageBox.Show("Satış başarılı bir şekilde gerçekleştirildi");
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            double adet, fiyat, toplam;
            adet = Convert.ToDouble(TxtAdet.Text);
            fiyat = Convert.ToDouble(TxtFiyat.Text);
            toplam = adet * fiyat;
            TxtToplam.Text=toplam.ToString();
        }
    }
}
