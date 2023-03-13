namespace Urun_Takip_EntityFramework
{
    partial class FrmUrunler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSatisFiyati = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAlisFiyati = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtStok = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUrunAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnListele = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbKategori = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(919, 397);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(164, 37);
            this.BtnGuncelle.TabIndex = 30;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(919, 346);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(164, 43);
            this.BtnSil.TabIndex = 29;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(919, 296);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(164, 42);
            this.BtnKaydet.TabIndex = 28;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(879, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID:";
            // 
            // TxtSatisFiyati
            // 
            this.TxtSatisFiyati.Location = new System.Drawing.Point(919, 160);
            this.TxtSatisFiyati.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtSatisFiyati.Name = "TxtSatisFiyati";
            this.TxtSatisFiyati.Size = new System.Drawing.Size(175, 28);
            this.TxtSatisFiyati.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(808, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "Satış Fiyatı:";
            // 
            // TxtAlisFiyati
            // 
            this.TxtAlisFiyati.Location = new System.Drawing.Point(919, 124);
            this.TxtAlisFiyati.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtAlisFiyati.Name = "TxtAlisFiyati";
            this.TxtAlisFiyati.Size = new System.Drawing.Size(175, 28);
            this.TxtAlisFiyati.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(819, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Alış Fiyatı:";
            // 
            // TxtStok
            // 
            this.TxtStok.Location = new System.Drawing.Point(919, 88);
            this.TxtStok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtStok.Name = "TxtStok";
            this.TxtStok.Size = new System.Drawing.Size(175, 28);
            this.TxtStok.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(860, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Stok:";
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.Location = new System.Drawing.Point(919, 49);
            this.TxtUrunAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.Size = new System.Drawing.Size(175, 28);
            this.TxtUrunAd.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(826, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ürün Adı:";
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(919, 246);
            this.BtnListele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(164, 42);
            this.BtnListele.TabIndex = 18;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(919, 13);
            this.TxtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(175, 28);
            this.TxtId.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(789, 508);
            this.dataGridView1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(829, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 22);
            this.label6.TabIndex = 31;
            this.label6.Text = "Kategori:";
            // 
            // CmbKategori
            // 
            this.CmbKategori.FormattingEnabled = true;
            this.CmbKategori.Location = new System.Drawing.Point(919, 194);
            this.CmbKategori.Name = "CmbKategori";
            this.CmbKategori.Size = new System.Drawing.Size(175, 30);
            this.CmbKategori.TabIndex = 32;
            // 
            // FrmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1110, 533);
            this.Controls.Add(this.CmbKategori);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSatisFiyati);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtAlisFiyati);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtStok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtUrunAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmUrunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUrunler";
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSatisFiyati;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAlisFiyati;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtStok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUrunAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbKategori;
    }
}