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

namespace Ogrenci_Akademisyen_Proje.Formlar
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-NBHVRA9\SQLEXPRESS;Initial Catalog=OgrenciSinav;Integrated Security=True");

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * From TblOgrenciler Where OgrNumara=@p1 and OgrSifre=@p2", baglanti);
            cmd.Parameters.AddWithValue("@p1", MTxtNumara.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr= cmd.ExecuteReader();
            if(dr.Read())
            {
                FrmOgrenciPanel frm =new FrmOgrenciPanel();
                frm.numara=MTxtNumara.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Numaranız veya Şifreniz hatalıdır. Lütfen tekrar deneyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MTxtNumara_TextChanged(object sender, EventArgs e)
        {
            if(MTxtNumara.Text=="00000" && TxtSifre.Text=="000")
            {
                FrmHarita frm = new FrmHarita();
                frm.Show();
                this.Hide();
            }
        }

        private void TxtSifre_TextChanged(object sender, EventArgs e)
        {
            if(TxtSifre.Text=="000" && MTxtNumara.Text=="00000")
            {
                FrmHarita frm = new FrmHarita();
                frm.Show();
                this.Hide();
            }
        }
    }
}
