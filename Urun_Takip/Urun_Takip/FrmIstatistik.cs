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

namespace Urun_Takip
{
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-NBHVRA9\SQLEXPRESS;Initial Catalog=DbUrun;Integrated Security=True");
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            // Toplam kategori sayısı
            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand("Select Count(*) From TblKategori", baglanti);
            SqlDataReader dr = cmd1.ExecuteReader();
            while(dr.Read())
            {
                LblToplamKategori.Text = dr[0].ToString();  
            }
            baglanti.Close();

            // Toplam ürün sayısı
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("Select Count(*) From TblUrunler", baglanti);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while(dr2.Read())
            {
                LblToplamUrun.Text = dr2[0].ToString();
            }
            baglanti.Close();

            // En düşük stoklu ürünler
            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("Select * From TblUrunler Where Stok=(Select Min(Stok) From TblUrunler)", baglanti);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                LblEnDusuk.Text = dr3[1].ToString();
            }
            baglanti.Close();

            // En yüksek stoklu ürünler
            baglanti.Open();
            SqlCommand cmd4 = new SqlCommand("Select * From TblUrunler Where Stok=(Select Max(Stok) From TblUrunler)", baglanti);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                LblEnYuksek.Text = dr4[1].ToString();
            }
            baglanti.Close();

            // Toplam beyaz eşya sayısı
            baglanti.Open();
            SqlCommand cmd5 = new SqlCommand("Select Count(*) from TblUrunler where Kategori=(Select ID From TblKategori where Ad='Beyaz Esya')", baglanti);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while( dr5.Read())
            {
                LblBeyazEsya.Text= dr5[0].ToString();
            }
            baglanti.Close();

            // Toplam bilgisayar sayısı
            baglanti.Open();
            SqlCommand cmd6 = new SqlCommand("Select Count(*) from TblUrunler where Kategori=(Select ID From TblKategori where Ad='Bilgisayar')", baglanti);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            while (dr6.Read())
            {
                LblBilgisayar.Text = dr6[0].ToString();
            }
            baglanti.Close();

            // Toplam laptop kar
            baglanti.Open();
            SqlCommand cmd7 = new SqlCommand("Select Stok*(SatisFiyati-AlisFiyati) From TblUrunler where UrunAd='Laptop'", baglanti);
            SqlDataReader dr7 = cmd7.ExecuteReader();
            while (dr7.Read())
            {
                LblToplamLaptopKar.Text = dr7[0].ToString() + "₺";
            }
            baglanti.Close();

            // Beyaz eşya toplam kar
            baglanti.Open();
            SqlCommand cmd8 = new SqlCommand("Select Sum(Stok*(SatisFiyati-AlisFiyati)) as 'Toplam Stokla Çarplan Sonuç' From TblUrunler Where Kategori=(Select ID From TblKategori Where Ad='Beyaz Eşya')", baglanti);
            SqlDataReader dr8 = cmd8.ExecuteReader();
            while (dr8.Read())
            {
                LblBeyazEşyaToplamKarı.Text = dr8[0].ToString() + "₺";
            }
            baglanti.Close();
        }
    }
}
