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
    public partial class FrmDersListesi : Form
    {
        public FrmDersListesi()
        {
            InitializeComponent();
        }
        OgrenciSinavEntities db=new OgrenciSinavEntities();
        private void FrmDersListesi_Load(object sender, EventArgs e)
        {
            var derslistesi = from x in db.TblDersler
                              select new
                              {
                                  x.DersID,
                                  x.DersAd
                              };
            dataGridView1.DataSource= derslistesi;
        }
    }
}
