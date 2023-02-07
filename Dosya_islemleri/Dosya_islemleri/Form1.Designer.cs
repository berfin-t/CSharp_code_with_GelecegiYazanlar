namespace Dosya_islemleri
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.BtnFolderBrowserDialog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnOpenFileDialog = new System.Windows.Forms.Button();
            this.BtnSaveFileDialog = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.TxtYol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnKonumSec = new System.Windows.Forms.Button();
            this.BtnOlustur = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.BtnOku = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnYazdir = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BtnFolderBrowserDialog
            // 
            this.BtnFolderBrowserDialog.Location = new System.Drawing.Point(618, 12);
            this.BtnFolderBrowserDialog.Name = "BtnFolderBrowserDialog";
            this.BtnFolderBrowserDialog.Size = new System.Drawing.Size(180, 41);
            this.BtnFolderBrowserDialog.TabIndex = 0;
            this.BtnFolderBrowserDialog.Text = "Folder Browser Dialog";
            this.BtnFolderBrowserDialog.UseVisualStyleBackColor = true;
            this.BtnFolderBrowserDialog.Click += new System.EventHandler(this.BtnKonumSec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 555);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnOpenFileDialog
            // 
            this.BtnOpenFileDialog.Location = new System.Drawing.Point(618, 59);
            this.BtnOpenFileDialog.Name = "BtnOpenFileDialog";
            this.BtnOpenFileDialog.Size = new System.Drawing.Size(180, 35);
            this.BtnOpenFileDialog.TabIndex = 2;
            this.BtnOpenFileDialog.Text = "Open File Dialog";
            this.BtnOpenFileDialog.UseVisualStyleBackColor = true;
            this.BtnOpenFileDialog.Click += new System.EventHandler(this.BtnOpenFileDialog_Click);
            // 
            // BtnSaveFileDialog
            // 
            this.BtnSaveFileDialog.Location = new System.Drawing.Point(618, 100);
            this.BtnSaveFileDialog.Name = "BtnSaveFileDialog";
            this.BtnSaveFileDialog.Size = new System.Drawing.Size(180, 40);
            this.BtnSaveFileDialog.TabIndex = 3;
            this.BtnSaveFileDialog.Text = "Save File Dialog";
            this.BtnSaveFileDialog.UseVisualStyleBackColor = true;
            this.BtnSaveFileDialog.Click += new System.EventHandler(this.BtnSaveFileDialog_Click);
            // 
            // TxtYol
            // 
            this.TxtYol.Location = new System.Drawing.Point(87, 12);
            this.TxtYol.Name = "TxtYol";
            this.TxtYol.Size = new System.Drawing.Size(223, 22);
            this.TxtYol.TabIndex = 4;
            this.TxtYol.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Belge Adı:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BtnKonumSec
            // 
            this.BtnKonumSec.Location = new System.Drawing.Point(618, 146);
            this.BtnKonumSec.Name = "BtnKonumSec";
            this.BtnKonumSec.Size = new System.Drawing.Size(180, 39);
            this.BtnKonumSec.TabIndex = 6;
            this.BtnKonumSec.Text = "Konum Seç";
            this.BtnKonumSec.UseVisualStyleBackColor = true;
            this.BtnKonumSec.Click += new System.EventHandler(this.BtnKonumSec_Click_1);
            // 
            // BtnOlustur
            // 
            this.BtnOlustur.Location = new System.Drawing.Point(618, 191);
            this.BtnOlustur.Name = "BtnOlustur";
            this.BtnOlustur.Size = new System.Drawing.Size(180, 40);
            this.BtnOlustur.TabIndex = 7;
            this.BtnOlustur.Text = "Oluştur";
            this.BtnOlustur.UseVisualStyleBackColor = true;
            this.BtnOlustur.Click += new System.EventHandler(this.BtnOlustur_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Belge Yolu:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(94, 56);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(223, 22);
            this.TxtAd.TabIndex = 9;
            this.TxtAd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BtnOku
            // 
            this.BtnOku.Location = new System.Drawing.Point(618, 237);
            this.BtnOku.Name = "BtnOku";
            this.BtnOku.Size = new System.Drawing.Size(180, 40);
            this.BtnOku.TabIndex = 10;
            this.BtnOku.Text = "Oku";
            this.BtnOku.UseVisualStyleBackColor = true;
            this.BtnOku.Click += new System.EventHandler(this.BtnOku_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(15, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(302, 180);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // BtnYazdir
            // 
            this.BtnYazdir.Location = new System.Drawing.Point(618, 283);
            this.BtnYazdir.Name = "BtnYazdir";
            this.BtnYazdir.Size = new System.Drawing.Size(180, 40);
            this.BtnYazdir.TabIndex = 12;
            this.BtnYazdir.Text = "Yazdır";
            this.BtnYazdir.UseVisualStyleBackColor = true;
            this.BtnYazdir.Click += new System.EventHandler(this.BtnYazdir_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 304);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(302, 198);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BtnYazdir);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnOku);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnOlustur);
            this.Controls.Add(this.BtnKonumSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtYol);
            this.Controls.Add(this.BtnSaveFileDialog);
            this.Controls.Add(this.BtnOpenFileDialog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFolderBrowserDialog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button BtnFolderBrowserDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnOpenFileDialog;
        private System.Windows.Forms.Button BtnSaveFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox TxtYol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnKonumSec;
        private System.Windows.Forms.Button BtnOlustur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Button BtnOku;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnYazdir;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

