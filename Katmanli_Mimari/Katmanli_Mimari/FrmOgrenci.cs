﻿using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Katmanli_Mimari
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        private void FrmOgrenci_Load(object sender, EventArgs e)
        {

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int deger = int.Parse(TxtId.Text);
            EntityOgrenci en = new EntityOgrenci();
            en.OgrenciID = deger;
            BLOgrenci.OgrenciSilBL(en.OgrenciID);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent= new EntityOgrenci();
            ent.Ad=TxtAd.Text;
            ent.Soyad=TxtSoyad.Text;
            ent.Bölüm=TxtBolum.Text;
            ent.Numara=MTxtNumara.Text;
            ent.OgrenciID = int.Parse(TxtId.Text);
            BLOgrenci.OgrenciGuncelleBL(ent);
        }
    }
}
