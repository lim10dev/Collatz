namespace Collatz_Conjecture
{
    partial class mainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.deger = new System.Windows.Forms.NumericUpDown();
            this.hesapla = new System.Windows.Forms.Button();
            this.hesaplanacakDegerLabel = new System.Windows.Forms.Label();
            this.logaritma = new System.Windows.Forms.CheckBox();
            this.grafik1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.aralikKutusu = new System.Windows.Forms.GroupBox();
            this.bilgiButon = new System.Windows.Forms.Button();
            this.grafik2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.degistir = new System.Windows.Forms.CheckBox();
            this.trackBarLabel2 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBarLabel1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.goster = new System.Windows.Forms.Button();
            this.ayarlar = new System.Windows.Forms.Button();
            this.hesapBilgilendirme = new System.Windows.Forms.Label();
            this.hoverText = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.deger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafik1)).BeginInit();
            this.aralikKutusu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafik2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // deger
            // 
            this.deger.Location = new System.Drawing.Point(207, 20);
            this.deger.Maximum = new decimal(new int[] {
            0,
            8,
            0,
            0});
            this.deger.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.deger.Name = "deger";
            this.deger.Size = new System.Drawing.Size(250, 20);
            this.deger.TabIndex = 0;
            this.deger.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // hesapla
            // 
            this.hesapla.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hesapla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hesapla.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.hesapla.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.hesapla.Location = new System.Drawing.Point(12, 10);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(75, 36);
            this.hesapla.TabIndex = 1;
            this.hesapla.Text = "Hesapla";
            this.hesapla.UseVisualStyleBackColor = false;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // hesaplanacakDegerLabel
            // 
            this.hesaplanacakDegerLabel.AutoSize = true;
            this.hesaplanacakDegerLabel.Location = new System.Drawing.Point(93, 22);
            this.hesaplanacakDegerLabel.Name = "hesaplanacakDegerLabel";
            this.hesaplanacakDegerLabel.Size = new System.Drawing.Size(108, 13);
            this.hesaplanacakDegerLabel.TabIndex = 2;
            this.hesaplanacakDegerLabel.Text = "Hesaplanacak Değer";
            // 
            // logaritma
            // 
            this.logaritma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logaritma.AutoSize = true;
            this.logaritma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logaritma.Location = new System.Drawing.Point(463, 20);
            this.logaritma.Name = "logaritma";
            this.logaritma.Size = new System.Drawing.Size(50, 17);
            this.logaritma.TabIndex = 3;
            this.logaritma.Text = "Log( )";
            this.logaritma.UseVisualStyleBackColor = true;
            this.logaritma.CheckedChanged += new System.EventHandler(this.hesapla_Click);
            // 
            // grafik1
            // 
            this.grafik1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.grafik1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.grafik1.Legends.Add(legend1);
            this.grafik1.Location = new System.Drawing.Point(12, 52);
            this.grafik1.Name = "grafik1";
            this.grafik1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.CustomProperties = "EmptyPointValue=Zero";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.grafik1.Series.Add(series1);
            this.grafik1.Size = new System.Drawing.Size(560, 450);
            this.grafik1.TabIndex = 4;
            this.grafik1.Text = "ana grafik";
            this.grafik1.Visible = false;
            // 
            // aralikKutusu
            // 
            this.aralikKutusu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.aralikKutusu.Controls.Add(this.bilgiButon);
            this.aralikKutusu.Controls.Add(this.grafik2);
            this.aralikKutusu.Controls.Add(this.degistir);
            this.aralikKutusu.Controls.Add(this.trackBarLabel2);
            this.aralikKutusu.Controls.Add(this.trackBar2);
            this.aralikKutusu.Controls.Add(this.trackBarLabel1);
            this.aralikKutusu.Controls.Add(this.trackBar1);
            this.aralikKutusu.Controls.Add(this.goster);
            this.aralikKutusu.Enabled = false;
            this.aralikKutusu.Location = new System.Drawing.Point(12, 508);
            this.aralikKutusu.Name = "aralikKutusu";
            this.aralikKutusu.Size = new System.Drawing.Size(558, 140);
            this.aralikKutusu.TabIndex = 7;
            this.aralikKutusu.TabStop = false;
            this.aralikKutusu.Text = "Belli Bir Aralığa Bak";
            // 
            // bilgiButon
            // 
            this.bilgiButon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bilgiButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bilgiButon.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bilgiButon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bilgiButon.Location = new System.Drawing.Point(81, 101);
            this.bilgiButon.Name = "bilgiButon";
            this.bilgiButon.Size = new System.Drawing.Size(75, 30);
            this.bilgiButon.TabIndex = 20;
            this.bilgiButon.Text = "Bilgi";
            this.bilgiButon.UseVisualStyleBackColor = false;
            this.bilgiButon.Click += new System.EventHandler(this.bilgiButon_Click);
            // 
            // grafik2
            // 
            this.grafik2.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            this.grafik2.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.grafik2.Legends.Add(legend2);
            this.grafik2.Location = new System.Drawing.Point(274, 19);
            this.grafik2.Name = "grafik2";
            this.grafik2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.CustomProperties = "EmptyPointValue=Zero";
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 2;
            this.grafik2.Series.Add(series2);
            this.grafik2.Size = new System.Drawing.Size(278, 115);
            this.grafik2.TabIndex = 19;
            this.grafik2.Text = "ana grafik";
            this.grafik2.Visible = false;
            // 
            // degistir
            // 
            this.degistir.AutoSize = true;
            this.degistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.degistir.Location = new System.Drawing.Point(162, 108);
            this.degistir.Name = "degistir";
            this.degistir.Size = new System.Drawing.Size(98, 17);
            this.degistir.TabIndex = 11;
            this.degistir.Text = "Yerlerini Değiştir";
            this.degistir.UseVisualStyleBackColor = true;
            this.degistir.CheckedChanged += new System.EventHandler(this.degistir_CheckedChanged);
            // 
            // trackBarLabel2
            // 
            this.trackBarLabel2.AutoSize = true;
            this.trackBarLabel2.Location = new System.Drawing.Point(250, 53);
            this.trackBarLabel2.Name = "trackBarLabel2";
            this.trackBarLabel2.Size = new System.Drawing.Size(10, 13);
            this.trackBarLabel2.TabIndex = 16;
            this.trackBarLabel2.Text = "-";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(6, 53);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(238, 45);
            this.trackBar2.TabIndex = 15;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBarScroll);
            // 
            // trackBarLabel1
            // 
            this.trackBarLabel1.AutoSize = true;
            this.trackBarLabel1.Location = new System.Drawing.Point(250, 19);
            this.trackBarLabel1.Name = "trackBarLabel1";
            this.trackBarLabel1.Size = new System.Drawing.Size(10, 13);
            this.trackBarLabel1.TabIndex = 14;
            this.trackBarLabel1.Text = "-";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 19);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(238, 45);
            this.trackBar1.TabIndex = 13;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBarScroll);
            // 
            // goster
            // 
            this.goster.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.goster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goster.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.goster.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.goster.Location = new System.Drawing.Point(6, 101);
            this.goster.Name = "goster";
            this.goster.Size = new System.Drawing.Size(69, 30);
            this.goster.TabIndex = 12;
            this.goster.Text = "Göster";
            this.goster.UseVisualStyleBackColor = false;
            this.goster.Click += new System.EventHandler(this.goster_Click);
            // 
            // ayarlar
            // 
            this.ayarlar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ayarlar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ayarlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ayarlar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ayarlar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ayarlar.Location = new System.Drawing.Point(519, 10);
            this.ayarlar.Name = "ayarlar";
            this.ayarlar.Size = new System.Drawing.Size(53, 36);
            this.ayarlar.TabIndex = 9;
            this.ayarlar.Text = "Ayarlar";
            this.ayarlar.UseVisualStyleBackColor = false;
            this.ayarlar.Click += new System.EventHandler(this.ayarlar_Click);
            // 
            // hesapBilgilendirme
            // 
            this.hesapBilgilendirme.AutoSize = true;
            this.hesapBilgilendirme.BackColor = System.Drawing.SystemColors.Control;
            this.hesapBilgilendirme.Font = new System.Drawing.Font("Microsoft YaHei", 18F);
            this.hesapBilgilendirme.Location = new System.Drawing.Point(65, 258);
            this.hesapBilgilendirme.Name = "hesapBilgilendirme";
            this.hesapBilgilendirme.Size = new System.Drawing.Size(471, 62);
            this.hesapBilgilendirme.TabIndex = 10;
            this.hesapBilgilendirme.Text = "Hesapla / Göster tuşuna bastıktan sonra\r\ngrafiğiniz burada gözükecektir.";
            this.hesapBilgilendirme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainForm
            // 
            this.AcceptButton = this.hesapla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.aralikKutusu);
            this.Controls.Add(this.logaritma);
            this.Controls.Add(this.ayarlar);
            this.Controls.Add(this.hesaplanacakDegerLabel);
            this.Controls.Add(this.hesapla);
            this.Controls.Add(this.deger);
            this.Controls.Add(this.grafik1);
            this.Controls.Add(this.hesapBilgilendirme);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 700);
            this.Name = "mainForm";
            this.Text = "Collatz Sanısı (3x+1)";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.deger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafik1)).EndInit();
            this.aralikKutusu.ResumeLayout(false);
            this.aralikKutusu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafik2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown deger;
        private System.Windows.Forms.Button hesapla;
        private System.Windows.Forms.Label hesaplanacakDegerLabel;
        private System.Windows.Forms.CheckBox logaritma;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafik1;
        private System.Windows.Forms.GroupBox aralikKutusu;
        private System.Windows.Forms.Button ayarlar;
        private System.Windows.Forms.Label hesapBilgilendirme;
        private System.Windows.Forms.Button goster;
        private System.Windows.Forms.Label trackBarLabel2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label trackBarLabel1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox degistir;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafik2;
        private System.Windows.Forms.Button bilgiButon;
        private System.Windows.Forms.ToolTip hoverText;
    }
}

