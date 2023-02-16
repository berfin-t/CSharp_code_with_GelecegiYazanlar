namespace Ogrenci_Not_Kayit_Sistemi_Projesi
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.TxtSinav1 = new System.Windows.Forms.TextBox();
            this.TxtSinav2 = new System.Windows.Forms.TextBox();
            this.TxtSinav3 = new System.Windows.Forms.TextBox();
            this.TxtOrt = new System.Windows.Forms.TextBox();
            this.CmbDers = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MskNumara = new System.Windows.Forms.MaskedTextBox();
            this.TxtDurum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnCizgi = new System.Windows.Forms.Button();
            this.BtnMesaj = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Fuchsia;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(251, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Not Kayıt Sistemi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ders:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sınav 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sıanv 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sınav 3: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(558, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ort:";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(18, 229);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(104, 37);
            this.BtnKaydet.TabIndex = 7;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(167, 229);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(89, 37);
            this.BtnHesapla.TabIndex = 8;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            this.BtnHesapla.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Location = new System.Drawing.Point(298, 229);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(93, 37);
            this.BtnTemizle.TabIndex = 9;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(18, 318);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(645, 148);
            this.listBox1.TabIndex = 10;
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.Location = new System.Drawing.Point(91, 91);
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(218, 22);
            this.TxtAdSoyad.TabIndex = 11;
            // 
            // TxtSinav1
            // 
            this.TxtSinav1.Location = new System.Drawing.Point(409, 88);
            this.TxtSinav1.Name = "TxtSinav1";
            this.TxtSinav1.Size = new System.Drawing.Size(93, 22);
            this.TxtSinav1.TabIndex = 13;
            // 
            // TxtSinav2
            // 
            this.TxtSinav2.Location = new System.Drawing.Point(409, 124);
            this.TxtSinav2.Name = "TxtSinav2";
            this.TxtSinav2.Size = new System.Drawing.Size(93, 22);
            this.TxtSinav2.TabIndex = 14;
            // 
            // TxtSinav3
            // 
            this.TxtSinav3.Location = new System.Drawing.Point(409, 165);
            this.TxtSinav3.Name = "TxtSinav3";
            this.TxtSinav3.Size = new System.Drawing.Size(93, 22);
            this.TxtSinav3.TabIndex = 15;
            // 
            // TxtOrt
            // 
            this.TxtOrt.Enabled = false;
            this.TxtOrt.Location = new System.Drawing.Point(591, 91);
            this.TxtOrt.Name = "TxtOrt";
            this.TxtOrt.Size = new System.Drawing.Size(72, 22);
            this.TxtOrt.TabIndex = 16;
            // 
            // CmbDers
            // 
            this.CmbDers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDers.FormattingEnabled = true;
            this.CmbDers.Items.AddRange(new object[] {
            "Algoritma",
            "Yapay Zeka",
            "Biçimsel Diller",
            "Mikroişlemciler"});
            this.CmbDers.Location = new System.Drawing.Point(92, 127);
            this.CmbDers.Name = "CmbDers";
            this.CmbDers.Size = new System.Drawing.Size(217, 24);
            this.CmbDers.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Numara:";
            // 
            // MskNumara
            // 
            this.MskNumara.Location = new System.Drawing.Point(91, 164);
            this.MskNumara.Name = "MskNumara";
            this.MskNumara.Size = new System.Drawing.Size(218, 22);
            this.MskNumara.TabIndex = 19;
            // 
            // TxtDurum
            // 
            this.TxtDurum.Enabled = false;
            this.TxtDurum.Location = new System.Drawing.Point(591, 124);
            this.TxtDurum.Name = "TxtDurum";
            this.TxtDurum.Size = new System.Drawing.Size(72, 22);
            this.TxtDurum.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(536, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Durum:";
            // 
            // BtnCizgi
            // 
            this.BtnCizgi.Location = new System.Drawing.Point(427, 229);
            this.BtnCizgi.Name = "BtnCizgi";
            this.BtnCizgi.Size = new System.Drawing.Size(93, 37);
            this.BtnCizgi.TabIndex = 22;
            this.BtnCizgi.Text = "Çizgi";
            this.BtnCizgi.UseVisualStyleBackColor = true;
            this.BtnCizgi.Click += new System.EventHandler(this.BtnCizgi_Click);
            // 
            // BtnMesaj
            // 
            this.BtnMesaj.Location = new System.Drawing.Point(555, 229);
            this.BtnMesaj.Name = "BtnMesaj";
            this.BtnMesaj.Size = new System.Drawing.Size(108, 37);
            this.BtnMesaj.TabIndex = 23;
            this.BtnMesaj.Text = "Mesaj Kutusu";
            this.BtnMesaj.UseVisualStyleBackColor = true;
            this.BtnMesaj.Click += new System.EventHandler(this.BtnMesaj_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(536, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "label10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(750, 486);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtnMesaj);
            this.Controls.Add(this.BtnCizgi);
            this.Controls.Add(this.TxtDurum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MskNumara);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CmbDers);
            this.Controls.Add(this.TxtOrt);
            this.Controls.Add(this.TxtSinav3);
            this.Controls.Add(this.TxtSinav2);
            this.Controls.Add(this.TxtSinav1);
            this.Controls.Add(this.TxtAdSoyad);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.BtnHesapla);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox TxtAdSoyad;
        private System.Windows.Forms.TextBox TxtSinav1;
        private System.Windows.Forms.TextBox TxtSinav2;
        private System.Windows.Forms.TextBox TxtSinav3;
        private System.Windows.Forms.TextBox TxtOrt;
        private System.Windows.Forms.ComboBox CmbDers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox MskNumara;
        private System.Windows.Forms.TextBox TxtDurum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnCizgi;
        private System.Windows.Forms.Button BtnMesaj;
        private System.Windows.Forms.Label label10;
    }
}

