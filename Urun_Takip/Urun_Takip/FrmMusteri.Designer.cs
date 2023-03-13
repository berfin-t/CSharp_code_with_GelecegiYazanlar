namespace Urun_Takip
{
    partial class FrmMusteri
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
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtBakiye = new System.Windows.Forms.TextBox();
            this.TxtMusteriId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSehir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnAra = new System.Windows.Forms.Button();
            this.RdbSehir = new System.Windows.Forms.RadioButton();
            this.RdbSoyad = new System.Windows.Forms.RadioButton();
            this.RdbAd = new System.Windows.Forms.RadioButton();
            this.TxtAranacakKelime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.Location = new System.Drawing.Point(896, 409);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(143, 41);
            this.BtnGüncelle.TabIndex = 24;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = true;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(896, 268);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(143, 40);
            this.BtnListele.TabIndex = 23;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(896, 314);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(143, 42);
            this.BtnKaydet.TabIndex = 22;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(896, 362);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(143, 41);
            this.BtnSil.TabIndex = 21;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtBakiye);
            this.groupBox1.Controls.Add(this.TxtMusteriId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtSehir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(789, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 222);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // TxtBakiye
            // 
            this.TxtBakiye.Location = new System.Drawing.Point(107, 163);
            this.TxtBakiye.Name = "TxtBakiye";
            this.TxtBakiye.Size = new System.Drawing.Size(189, 28);
            this.TxtBakiye.TabIndex = 12;
            // 
            // TxtMusteriId
            // 
            this.TxtMusteriId.Location = new System.Drawing.Point(107, 27);
            this.TxtMusteriId.Name = "TxtMusteriId";
            this.TxtMusteriId.Size = new System.Drawing.Size(189, 28);
            this.TxtMusteriId.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bakiye:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(107, 61);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(189, 28);
            this.TxtAd.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şehir:";
            // 
            // TxtSehir
            // 
            this.TxtSehir.Location = new System.Drawing.Point(107, 129);
            this.TxtSehir.Name = "TxtSehir";
            this.TxtSehir.Size = new System.Drawing.Size(189, 28);
            this.TxtSehir.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad:";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(107, 95);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(189, 28);
            this.TxtSoyad.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(754, 355);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnAra);
            this.groupBox2.Controls.Add(this.RdbSehir);
            this.groupBox2.Controls.Add(this.RdbSoyad);
            this.groupBox2.Controls.Add(this.RdbAd);
            this.groupBox2.Controls.Add(this.TxtAranacakKelime);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 96);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // BtnAra
            // 
            this.BtnAra.Location = new System.Drawing.Point(593, 28);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(157, 40);
            this.BtnAra.TabIndex = 26;
            this.BtnAra.Text = "Ara";
            this.BtnAra.UseVisualStyleBackColor = true;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // RdbSehir
            // 
            this.RdbSehir.AutoSize = true;
            this.RdbSehir.Location = new System.Drawing.Point(514, 38);
            this.RdbSehir.Name = "RdbSehir";
            this.RdbSehir.Size = new System.Drawing.Size(73, 26);
            this.RdbSehir.TabIndex = 4;
            this.RdbSehir.TabStop = true;
            this.RdbSehir.Text = "Şehir";
            this.RdbSehir.UseVisualStyleBackColor = true;
            // 
            // RdbSoyad
            // 
            this.RdbSoyad.AutoSize = true;
            this.RdbSoyad.Location = new System.Drawing.Point(426, 38);
            this.RdbSoyad.Name = "RdbSoyad";
            this.RdbSoyad.Size = new System.Drawing.Size(82, 26);
            this.RdbSoyad.TabIndex = 3;
            this.RdbSoyad.TabStop = true;
            this.RdbSoyad.Text = "Soyad";
            this.RdbSoyad.UseVisualStyleBackColor = true;
            // 
            // RdbAd
            // 
            this.RdbAd.AutoSize = true;
            this.RdbAd.Location = new System.Drawing.Point(367, 38);
            this.RdbAd.Name = "RdbAd";
            this.RdbAd.Size = new System.Drawing.Size(53, 26);
            this.RdbAd.TabIndex = 2;
            this.RdbAd.TabStop = true;
            this.RdbAd.Text = "Ad";
            this.RdbAd.UseVisualStyleBackColor = true;
            // 
            // TxtAranacakKelime
            // 
            this.TxtAranacakKelime.Location = new System.Drawing.Point(162, 34);
            this.TxtAranacakKelime.Name = "TxtAranacakKelime";
            this.TxtAranacakKelime.Size = new System.Drawing.Size(198, 28);
            this.TxtAranacakKelime.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Aranacak Kelime:";
            // 
            // FrmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 486);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMusteri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtBakiye;
        private System.Windows.Forms.TextBox TxtMusteriId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSehir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.RadioButton RdbSehir;
        private System.Windows.Forms.RadioButton RdbSoyad;
        private System.Windows.Forms.RadioButton RdbAd;
        private System.Windows.Forms.TextBox TxtAranacakKelime;
        private System.Windows.Forms.Label label6;
    }
}