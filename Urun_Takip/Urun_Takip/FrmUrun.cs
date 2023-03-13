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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-NBHVRA9\SQLEXPRESS;Initial Catalog=DbUrun;Integrated Security=True");
        private void BtnListele_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("Select UrunID,UrunAd,Stok,AlisFiyati,SatisFiyati,Ad,Kategori From TblUrunler Inner Join TblKategori On TblUrunler.Kategori=TblKategori.ID", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Kategori"].Visible = false;
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("Select * From TblKategori", baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            CBKategori.DisplayMember = "Ad";
            CBKategori.ValueMember = "ID";
            CBKategori.DataSource = dt2;
            baglanti.Close();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("Insert into TblUrunler(UrunAd,Stok,AlisFiyati,SatisFiyati,Kategori) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            cmd3.Parameters.AddWithValue("@p1", TxtUrunAdi.Text);
            cmd3.Parameters.AddWithValue("@p2", NUDStok.Value);
            cmd3.Parameters.AddWithValue("@p3", TxtAlisFiyati.Text);
            cmd3.Parameters.AddWithValue("@p4", TxtSatisFiyati.Text);
            cmd3.Parameters.AddWithValue("@p5", CBKategori.SelectedValue);
            cmd3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürun kaydı başarılı bir şekilde gerçekleşti.");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd4 = new SqlCommand("Delete from TblUrunler where UrunID=@p1", baglanti);
            cmd4.Parameters.AddWithValue("@p1", TxtUrunId.Text);
            cmd4.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi başarılı bir şekilde gerçekleşti.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtUrunId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtUrunAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            NUDStok.Value = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            TxtAlisFiyati.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtSatisFiyati.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            CBKategori.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd5 = new SqlCommand("Update TblUrunler set UrunAd=@p1, Stok=@p2, AlisFiyati=@p3, SatisFiyati=@p4, Kategori=@p5 where UrunID=@p6", baglanti);
            cmd5.Parameters.AddWithValue("@p1", TxtUrunAdi.Text);
            cmd5.Parameters.AddWithValue("@p2", NUDStok.Value);
            cmd5.Parameters.AddWithValue("@p3", decimal.Parse(TxtAlisFiyati.Text));
            cmd5.Parameters.AddWithValue("@p4", decimal.Parse(TxtSatisFiyati.Text));
            cmd5.Parameters.AddWithValue("@p5", CBKategori.SelectedValue);
            cmd5.Parameters.AddWithValue("@p6", TxtUrunId.Text);
            cmd5.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi başarılı bir şekilde gerçekleşmiştir.","Güncelleme",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
