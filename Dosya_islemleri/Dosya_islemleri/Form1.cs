using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dosya_islemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnKonumSec_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            label1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void BtnOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            label1.Text=openFileDialog1.FileName;
        }

        private void BtnSaveFileDialog_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        string belgeyolu, belgeadi;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            belgeadi = TxtAd.Text;
            StreamWriter sw = File.CreateText(belgeyolu + "\\" + belgeadi + ".txt");
            MessageBox.Show("Belgeniz başarıyla oluşturuldu", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void BtnOku_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamReader oku = new StreamReader(openFileDialog1.FileName);
                string satir = oku.ReadLine();
                while (satir != null )
                {
                    listBox1.Items.Add(satir);
                    satir=oku.ReadLine();
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Metin Dosyası |*.txt";
            saveFileDialog1.ShowDialog();
            StreamWriter kaydet = new StreamWriter(saveFileDialog1.FileName);
            kaydet.WriteLine(richTextBox1.Text);
            kaydet.Close();
            MessageBox.Show("Metin belgesine kayıt yapıldı", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void BtnKonumSec_Click_1(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                belgeyolu = folderBrowserDialog1.SelectedPath;
                TxtYol.Text = belgeyolu;
            }
        }
    }
}
