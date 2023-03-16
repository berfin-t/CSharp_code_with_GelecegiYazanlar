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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        DbUrunEntities db = new DbUrunEntities();
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            LblMusteriSayisi.Text = db.TblMusteri.Count().ToString();
            LblKategoriSayisi.Text=db.TblKategori.Count().ToString();
            LblUrunSayisi.Text=db.TblUrunler.Count().ToString();
        }
    }
}
