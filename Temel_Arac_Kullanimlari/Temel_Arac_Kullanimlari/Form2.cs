using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temel_Arac_Kullanimlari
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            chart1.Series["Bolge"].Points.AddXY("Akdeniz", 15);
            chart1.Series["Bolge"].Points.AddXY("Ege", 23);
            chart1.Series["Bolge"].Points.AddXY("Karadeniz", 17);
            chart1.Series["Bolge"].Points.AddXY("DoğuAnadolu", 20);
            chart1.Series["Bolge"].Points.AddXY("Marmara", 13);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value -=10;
        }

        private void BtnArttir_Click(object sender, EventArgs e)
        {
            progressBar1.Value +=10;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void BtnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PrgBarIslem1.Value += 1;
            if (PrgBarIslem1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            PrgBarIslem2.Value += 10;
            if (PrgBarIslem2.Value == 100)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            PrgBarIslem3.Value += 20;
            if (PrgBarIslem3.Value == 100)
            {
                timer3.Stop();
                MessageBox.Show("Tüm işlemler tamamlandı!");
            }
        }
    }
}
