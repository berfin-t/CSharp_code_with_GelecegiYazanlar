namespace Urun_Takip
{
    partial class FrmSatislar
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
            this.TxtFiyat = new System.Windows.Forms.TextBox();
            this.TxtSatisId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAdet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtToplam = new System.Windows.Forms.TextBox();
            this.CmbUrun = new System.Windows.Forms.ComboBox();
            this.TxtMusteri = new System.Windows.Forms.TextBox();
            this.MtxtTarih = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.Location = new System.Drawing.Point(107, 168);
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Size = new System.Drawing.Size(189, 28);
            this.TxtFiyat.TabIndex = 12;
            // 
            // TxtSatisId
            // 
            this.TxtSatisId.Location = new System.Drawing.Point(107, 27);
            this.TxtSatisId.Name = "TxtSatisId";
            this.TxtSatisId.Size = new System.Drawing.Size(189, 28);
            this.TxtSatisId.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fiyat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adet:";
            // 
            // TxtAdet
            // 
            this.TxtAdet.Location = new System.Drawing.Point(107, 134);
            this.TxtAdet.Name = "TxtAdet";
            this.TxtAdet.Size = new System.Drawing.Size(189, 28);
            this.TxtAdet.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Müşteri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Satış ID:";
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.Location = new System.Drawing.Point(898, 433);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(143, 41);
            this.BtnGüncelle.TabIndex = 31;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = true;
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(898, 292);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(143, 40);
            this.BtnListele.TabIndex = 30;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(898, 338);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(143, 42);
            this.BtnKaydet.TabIndex = 29;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(898, 386);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(143, 41);
            this.BtnHesapla.TabIndex = 28;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            this.BtnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MtxtTarih);
            this.groupBox1.Controls.Add(this.TxtMusteri);
            this.groupBox1.Controls.Add(this.CmbUrun);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtToplam);
            this.groupBox1.Controls.Add(this.TxtFiyat);
            this.groupBox1.Controls.Add(this.TxtSatisId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtAdet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(791, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 272);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(754, 453);
            this.dataGridView1.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tarih:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = "Toplam";
            // 
            // TxtToplam
            // 
            this.TxtToplam.Location = new System.Drawing.Point(107, 202);
            this.TxtToplam.Name = "TxtToplam";
            this.TxtToplam.Size = new System.Drawing.Size(189, 28);
            this.TxtToplam.TabIndex = 15;
            // 
            // CmbUrun
            // 
            this.CmbUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUrun.FormattingEnabled = true;
            this.CmbUrun.Location = new System.Drawing.Point(107, 62);
            this.CmbUrun.Name = "CmbUrun";
            this.CmbUrun.Size = new System.Drawing.Size(189, 30);
            this.CmbUrun.TabIndex = 17;
            // 
            // TxtMusteri
            // 
            this.TxtMusteri.Location = new System.Drawing.Point(107, 100);
            this.TxtMusteri.Name = "TxtMusteri";
            this.TxtMusteri.Size = new System.Drawing.Size(189, 28);
            this.TxtMusteri.TabIndex = 18;
            // 
            // MtxtTarih
            // 
            this.MtxtTarih.Location = new System.Drawing.Point(107, 237);
            this.MtxtTarih.Mask = "00/00/0000";
            this.MtxtTarih.Name = "MtxtTarih";
            this.MtxtTarih.Size = new System.Drawing.Size(189, 28);
            this.MtxtTarih.TabIndex = 19;
            this.MtxtTarih.ValidatingType = typeof(System.DateTime);
            // 
            // FrmSatislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 486);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnHesapla);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSatislar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSatislar";
            this.Load += new System.EventHandler(this.FrmSatislar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TxtFiyat;
        private System.Windows.Forms.TextBox TxtSatisId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAdet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox CmbUrun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtToplam;
        private System.Windows.Forms.MaskedTextBox MtxtTarih;
        private System.Windows.Forms.TextBox TxtMusteri;
    }
}