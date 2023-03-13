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
using System.Data.SqlClient;

namespace Urun_Takip
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-NBHVRA9\SQLEXPRESS;Initial Catalog=DbUrun;Integrated Security=True");

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * From TblAdmin Where Kullanici=@p1 and Sifre=@p2", baglanti);
            cmd.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                FrmYonlendirme fr = new FrmYonlendirme();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifreniz hatalı!");
            }
        }

        private void LblSifre_Click(object sender, EventArgs e)
        {

        }

        private void TxtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblKullaniciAdi_Click(object sender, EventArgs e)
        {

        }
    }
}
