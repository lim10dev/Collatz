namespace Collatz_Conjecture
{
    partial class ayarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ayarlar));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, "10,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, "5,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, "7,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, "2,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, "2,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(6D, "0,0");
            this.logoResim = new System.Windows.Forms.PictureBox();
            this.labelAna = new System.Windows.Forms.Label();
            this.labelCollatz = new System.Windows.Forms.Label();
            this.labellim10dev = new System.Windows.Forms.Label();
            this.ayarlarGroupbox = new System.Windows.Forms.GroupBox();
            this.dilSecim = new System.Windows.Forms.ComboBox();
            this.sifirla = new System.Windows.Forms.Button();
            this.tamam = new System.Windows.Forms.Button();
            this.renkSecButon = new System.Windows.Forms.Button();
            this.labelRenk = new System.Windows.Forms.Label();
            this.onizleme = new System.Windows.Forms.Label();
            this.grafik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelGrafikStil = new System.Windows.Forms.Label();
            this.grafikStil = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.altAciklama = new System.Windows.Forms.Label();
            this.kaynakKod = new System.Windows.Forms.LinkLabel();
            this.renkSecim = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.logoResim)).BeginInit();
            this.ayarlarGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logoResim
            // 
            this.logoResim.Image = global::Collatz_Conjecture.Properties.Resources.collatz;
            this.logoResim.Location = new System.Drawing.Point(12, 12);
            this.logoResim.Name = "logoResim";
            this.logoResim.Size = new System.Drawing.Size(128, 128);
            this.logoResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoResim.TabIndex = 0;
            this.logoResim.TabStop = false;
            // 
            // labelAna
            // 
            this.labelAna.AutoSize = true;
            this.labelAna.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAna.Location = new System.Drawing.Point(146, 12);
            this.labelAna.Name = "labelAna";
            this.labelAna.Size = new System.Drawing.Size(134, 24);
            this.labelAna.TabIndex = 1;
            this.labelAna.Text = "Collatz Sanısı";
            // 
            // labelCollatz
            // 
            this.labelCollatz.Location = new System.Drawing.Point(147, 55);
            this.labelCollatz.Name = "labelCollatz";
            this.labelCollatz.Size = new System.Drawing.Size(245, 85);
            this.labelCollatz.TabIndex = 2;
            this.labelCollatz.Text = resources.GetString("labelCollatz.Text");
            // 
            // labellim10dev
            // 
            this.labellim10dev.AutoSize = true;
            this.labellim10dev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labellim10dev.Location = new System.Drawing.Point(147, 36);
            this.labellim10dev.Name = "labellim10dev";
            this.labellim10dev.Size = new System.Drawing.Size(57, 13);
            this.labellim10dev.TabIndex = 3;
            this.labellim10dev.Text = "lim10dev";
            // 
            // ayarlarGroupbox
            // 
            this.ayarlarGroupbox.Controls.Add(this.dilSecim);
            this.ayarlarGroupbox.Controls.Add(this.sifirla);
            this.ayarlarGroupbox.Controls.Add(this.tamam);
            this.ayarlarGroupbox.Controls.Add(this.renkSecButon);
            this.ayarlarGroupbox.Controls.Add(this.labelRenk);
            this.ayarlarGroupbox.Controls.Add(this.onizleme);
            this.ayarlarGroupbox.Controls.Add(this.grafik);
            this.ayarlarGroupbox.Controls.Add(this.labelGrafikStil);
            this.ayarlarGroupbox.Controls.Add(this.grafikStil);
            this.ayarlarGroupbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ayarlarGroupbox.Location = new System.Drawing.Point(12, 146);
            this.ayarlarGroupbox.Name = "ayarlarGroupbox";
            this.ayarlarGroupbox.Size = new System.Drawing.Size(380, 268);
            this.ayarlarGroupbox.TabIndex = 4;
            this.ayarlarGroupbox.TabStop = false;
            this.ayarlarGroupbox.Text = "Ayarlar";
            // 
            // dilSecim
            // 
            this.dilSecim.BackColor = System.Drawing.SystemColors.Control;
            this.dilSecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dilSecim.Items.AddRange(new object[] {
            "English",
            "Türkçe"});
            this.dilSecim.Location = new System.Drawing.Point(9, 236);
            this.dilSecim.Name = "dilSecim";
            this.dilSecim.Size = new System.Drawing.Size(163, 21);
            this.dilSecim.TabIndex = 11;
            // 
            // sifirla
            // 
            this.sifirla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sifirla.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sifirla.Location = new System.Drawing.Point(178, 228);
            this.sifirla.Name = "sifirla";
            this.sifirla.Size = new System.Drawing.Size(95, 34);
            this.sifirla.TabIndex = 10;
            this.sifirla.Text = "Ayarları Sıfırla";
            this.sifirla.UseVisualStyleBackColor = true;
            this.sifirla.Click += new System.EventHandler(this.sifirla_Click);
            // 
            // tamam
            // 
            this.tamam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tamam.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.tamam.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tamam.Location = new System.Drawing.Point(279, 228);
            this.tamam.Name = "tamam";
            this.tamam.Size = new System.Drawing.Size(95, 34);
            this.tamam.TabIndex = 9;
            this.tamam.Text = "Tamam";
            this.tamam.UseVisualStyleBackColor = true;
            this.tamam.Click += new System.EventHandler(this.tamam_Click);
            // 
            // renkSecButon
            // 
            this.renkSecButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.renkSecButon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.renkSecButon.Location = new System.Drawing.Point(279, 46);
            this.renkSecButon.Name = "renkSecButon";
            this.renkSecButon.Size = new System.Drawing.Size(95, 23);
            this.renkSecButon.TabIndex = 8;
            this.renkSecButon.Text = "Renk Seç";
            this.renkSecButon.UseVisualStyleBackColor = true;
            this.renkSecButon.Click += new System.EventHandler(this.renkSecButon_Click);
            // 
            // labelRenk
            // 
            this.labelRenk.AutoSize = true;
            this.labelRenk.Location = new System.Drawing.Point(6, 51);
            this.labelRenk.Name = "labelRenk";
            this.labelRenk.Size = new System.Drawing.Size(66, 13);
            this.labelRenk.TabIndex = 7;
            this.labelRenk.Text = "Grafik Rengi";
            // 
            // onizleme
            // 
            this.onizleme.AutoSize = true;
            this.onizleme.Location = new System.Drawing.Point(165, 94);
            this.onizleme.Name = "onizleme";
            this.onizleme.Size = new System.Drawing.Size(50, 13);
            this.onizleme.TabIndex = 6;
            this.onizleme.Text = "Önizleme";
            // 
            // grafik
            // 
            this.grafik.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.grafik.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.grafik.Legends.Add(legend1);
            this.grafik.Location = new System.Drawing.Point(6, 94);
            this.grafik.Name = "grafik";
            this.grafik.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.grafik.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(63)))), ((int)(((byte)(179)))))};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.CustomProperties = "EmptyPointValue=Zero";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.YValuesPerPoint = 2;
            this.grafik.Series.Add(series1);
            this.grafik.Size = new System.Drawing.Size(368, 128);
            this.grafik.TabIndex = 5;
            this.grafik.Text = "grafik önizleme";
            // 
            // labelGrafikStil
            // 
            this.labelGrafikStil.AutoSize = true;
            this.labelGrafikStil.Location = new System.Drawing.Point(6, 22);
            this.labelGrafikStil.Name = "labelGrafikStil";
            this.labelGrafikStil.Size = new System.Drawing.Size(54, 13);
            this.labelGrafikStil.TabIndex = 1;
            this.labelGrafikStil.Text = "Grafik Stili";
            // 
            // grafikStil
            // 
            this.grafikStil.BackColor = System.Drawing.SystemColors.Control;
            this.grafikStil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grafikStil.Location = new System.Drawing.Point(94, 19);
            this.grafikStil.Name = "grafikStil";
            this.grafikStil.Size = new System.Drawing.Size(280, 21);
            this.grafikStil.TabIndex = 0;
            this.grafikStil.SelectedIndexChanged += new System.EventHandler(this.grafikStil_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(63)))), ((int)(((byte)(179)))));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 420);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 34);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // altAciklama
            // 
            this.altAciklama.AutoSize = true;
            this.altAciklama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(63)))), ((int)(((byte)(179)))));
            this.altAciklama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(235)))));
            this.altAciklama.Location = new System.Drawing.Point(12, 429);
            this.altAciklama.Name = "altAciklama";
            this.altAciklama.Size = new System.Drawing.Size(171, 13);
            this.altAciklama.TabIndex = 6;
            this.altAciklama.Text = "Matematik proje ödevim için yaptım";
            // 
            // kaynakKod
            // 
            this.kaynakKod.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kaynakKod.AutoSize = true;
            this.kaynakKod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(63)))), ((int)(((byte)(179)))));
            this.kaynakKod.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(235)))));
            this.kaynakKod.Location = new System.Drawing.Point(321, 429);
            this.kaynakKod.Name = "kaynakKod";
            this.kaynakKod.Size = new System.Drawing.Size(71, 13);
            this.kaynakKod.TabIndex = 7;
            this.kaynakKod.TabStop = true;
            this.kaynakKod.Text = "Kaynak Kodu";
            this.kaynakKod.VisitedLinkColor = System.Drawing.Color.White;
            this.kaynakKod.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.kaynakKod_LinkClicked);
            this.kaynakKod.MouseEnter += new System.EventHandler(this.kaynakKod_Enter);
            this.kaynakKod.MouseLeave += new System.EventHandler(this.kaynakKod_Leave);
            // 
            // ayarlar
            // 
            this.AcceptButton = this.tamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 451);
            this.Controls.Add(this.kaynakKod);
            this.Controls.Add(this.altAciklama);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ayarlarGroupbox);
            this.Controls.Add(this.labellim10dev);
            this.Controls.Add(this.labelCollatz);
            this.Controls.Add(this.labelAna);
            this.Controls.Add(this.logoResim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 490);
            this.MinimumSize = new System.Drawing.Size(420, 490);
            this.Name = "ayarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.ayarlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoResim)).EndInit();
            this.ayarlarGroupbox.ResumeLayout(false);
            this.ayarlarGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoResim;
        private System.Windows.Forms.Label labelAna;
        private System.Windows.Forms.Label labelCollatz;
        private System.Windows.Forms.Label labellim10dev;
        private System.Windows.Forms.GroupBox ayarlarGroupbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label altAciklama;
        private System.Windows.Forms.LinkLabel kaynakKod;
        private System.Windows.Forms.Label labelGrafikStil;
        private System.Windows.Forms.ComboBox grafikStil;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafik;
        private System.Windows.Forms.Label onizleme;
        private System.Windows.Forms.ColorDialog renkSecim;
        private System.Windows.Forms.Label labelRenk;
        private System.Windows.Forms.Button renkSecButon;
        private System.Windows.Forms.Button tamam;
        private System.Windows.Forms.Button sifirla;
        private System.Windows.Forms.ComboBox dilSecim;
    }
}