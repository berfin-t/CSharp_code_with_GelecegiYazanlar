using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using BusinessLayer;

namespace Katmanli_Mimari
{
    public partial class FrmDers : Form
    {
        public FrmDers()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            EntityDers ent = new EntityDers();
            ent.DersAd = TxtAd.Text;
            BLDers.DersEkleBL(ent);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            List<EntityDers> ders = BLDers.DersListesiBL();
            dataGridView1.DataSource = ders;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            EntityDers ent = new EntityDers();
            ent.DersAd= TxtAd.Text;
            ent.DersID= byte.Parse(TxtId.Text);
            BLDers.DersGuncelleBL(ent);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            byte deger;
            deger = byte.Parse(TxtId.Text);
            EntityDers d = new EntityDers();
            d.DersID = byte.Parse(deger.ToString());
            BLDers.DersSilBL((byte)d.DersID);
        }
    }
}
