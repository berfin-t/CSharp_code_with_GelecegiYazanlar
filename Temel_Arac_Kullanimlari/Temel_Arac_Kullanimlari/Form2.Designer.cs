namespace Temel_Arac_Kullanimlari
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnArttir = new System.Windows.Forms.Button();
            this.BtnAzalt = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.PrgBarIslem1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PrgBarIslem2 = new System.Windows.Forms.ProgressBar();
            this.PrgBarIslem3 = new System.Windows.Forms.ProgressBar();
            this.BtnBaslat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Bolge";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(446, 173);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // BtnArttir
            // 
            this.BtnArttir.Location = new System.Drawing.Point(479, 21);
            this.BtnArttir.Name = "BtnArttir";
            this.BtnArttir.Size = new System.Drawing.Size(106, 46);
            this.BtnArttir.TabIndex = 1;
            this.BtnArttir.Text = "Arttır";
            this.BtnArttir.UseVisualStyleBackColor = true;
            this.BtnArttir.Click += new System.EventHandler(this.BtnArttir_Click);
            // 
            // BtnAzalt
            // 
            this.BtnAzalt.Location = new System.Drawing.Point(479, 73);
            this.BtnAzalt.Name = "BtnAzalt";
            this.BtnAzalt.Size = new System.Drawing.Size(106, 41);
            this.BtnAzalt.TabIndex = 2;
            this.BtnAzalt.Text = "Azalt";
            this.BtnAzalt.UseVisualStyleBackColor = true;
            this.BtnAzalt.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 205);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(573, 35);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 10;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // PrgBarIslem1
            // 
            this.PrgBarIslem1.Location = new System.Drawing.Point(67, 256);
            this.PrgBarIslem1.Name = "PrgBarIslem1";
            this.PrgBarIslem1.Size = new System.Drawing.Size(476, 35);
            this.PrgBarIslem1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "İşlem1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "İşlem1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "İşlem1:";
            // 
            // PrgBarIslem2
            // 
            this.PrgBarIslem2.Location = new System.Drawing.Point(67, 309);
            this.PrgBarIslem2.Name = "PrgBarIslem2";
            this.PrgBarIslem2.Size = new System.Drawing.Size(476, 35);
            this.PrgBarIslem2.TabIndex = 9;
            // 
            // PrgBarIslem3
            // 
            this.PrgBarIslem3.Location = new System.Drawing.Point(67, 364);
            this.PrgBarIslem3.Name = "PrgBarIslem3";
            this.PrgBarIslem3.Size = new System.Drawing.Size(476, 35);
            this.PrgBarIslem3.TabIndex = 10;
            // 
            // BtnBaslat
            // 
            this.BtnBaslat.Location = new System.Drawing.Point(575, 256);
            this.BtnBaslat.Name = "BtnBaslat";
            this.BtnBaslat.Size = new System.Drawing.Size(89, 35);
            this.BtnBaslat.TabIndex = 11;
            this.BtnBaslat.Text = "Başlat";
            this.BtnBaslat.UseVisualStyleBackColor = true;
            this.BtnBaslat.Click += new System.EventHandler(this.BtnBaslat_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.BtnBaslat);
            this.Controls.Add(this.PrgBarIslem3);
            this.Controls.Add(this.PrgBarIslem2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrgBarIslem1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BtnAzalt);
            this.Controls.Add(this.BtnArttir);
            this.Controls.Add(this.chart1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button BtnArttir;
        private System.Windows.Forms.Button BtnAzalt;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar PrgBarIslem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar PrgBarIslem2;
        private System.Windows.Forms.ProgressBar PrgBarIslem3;
        private System.Windows.Forms.Button BtnBaslat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}