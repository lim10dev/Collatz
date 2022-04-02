namespace Collatz_Conjecture
{
    partial class ekBilgi
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "9,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "8,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "7,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "5,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "3,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "2,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "1,5");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "1,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "1,0");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ekBilgi));
            this.sayiDagilimGrafik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sayiDagilimGroupbox = new System.Windows.Forms.GroupBox();
            this.bilgiLabel = new System.Windows.Forms.Label();
            this.hoverText = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sayiDagilimGrafik)).BeginInit();
            this.sayiDagilimGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sayiDagilimGrafik
            // 
            this.sayiDagilimGrafik.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.sayiDagilimGrafik.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.sayiDagilimGrafik.Legends.Add(legend1);
            this.sayiDagilimGrafik.Location = new System.Drawing.Point(9, 19);
            this.sayiDagilimGrafik.Name = "sayiDagilimGrafik";
            this.sayiDagilimGrafik.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
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
            series1.Points.Add(dataPoint7);
            series1.Points.Add(dataPoint8);
            series1.Points.Add(dataPoint9);
            series1.YValuesPerPoint = 2;
            this.sayiDagilimGrafik.Series.Add(series1);
            this.sayiDagilimGrafik.Size = new System.Drawing.Size(291, 204);
            this.sayiDagilimGrafik.TabIndex = 5;
            this.sayiDagilimGrafik.Text = "ana grafik";
            // 
            // sayiDagilimGroupbox
            // 
            this.sayiDagilimGroupbox.Controls.Add(this.sayiDagilimGrafik);
            this.sayiDagilimGroupbox.Location = new System.Drawing.Point(12, 125);
            this.sayiDagilimGroupbox.Name = "sayiDagilimGroupbox";
            this.sayiDagilimGroupbox.Size = new System.Drawing.Size(306, 229);
            this.sayiDagilimGroupbox.TabIndex = 6;
            this.sayiDagilimGroupbox.TabStop = false;
            this.sayiDagilimGroupbox.Text = "Rakam Dağılımları";
            // 
            // bilgiLabel
            // 
            this.bilgiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgiLabel.Location = new System.Drawing.Point(12, 9);
            this.bilgiLabel.Name = "bilgiLabel";
            this.bilgiLabel.Size = new System.Drawing.Size(300, 113);
            this.bilgiLabel.TabIndex = 7;
            this.bilgiLabel.Text = "Başlangıç Sayısı :\r\nTek Sayı Miktarı : \r\nÇift Sayı Miktarı : \r\nUlaşılan En Büyük " +
    "Sayı : \r\nAdım Miktarı : ";
            // 
            // ekBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 366);
            this.Controls.Add(this.bilgiLabel);
            this.Controls.Add(this.sayiDagilimGroupbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(340, 405);
            this.Name = "ekBilgi";
            this.Text = "ekBilgi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ekBilgi_FormClosing);
            this.Shown += new System.EventHandler(this.ekBilgi_Shown);
            this.SizeChanged += new System.EventHandler(this.ekBilgi_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.sayiDagilimGrafik)).EndInit();
            this.sayiDagilimGroupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart sayiDagilimGrafik;
        private System.Windows.Forms.GroupBox sayiDagilimGroupbox;
        private System.Windows.Forms.Label bilgiLabel;
        private System.Windows.Forms.ToolTip hoverText;
    }
}