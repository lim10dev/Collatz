using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collatz_Conjecture
{
    public partial class ayarlar : Form
    {
        public ayarlar(string dil_)
        {
            InitializeComponent();

            _dil = dil_;
            da = new DilAyar(_dil);

            this.Text = da.KelimeAl("ayarlar");
            ayarlarGroupbox.Text = da.KelimeAl("ayarlar");
            altAciklama.Text = da.KelimeAl("ayarlarAltiAciklama");
            sifirla.Text = da.KelimeAl("ayarlariSifirla");
            labelCollatz.Text = da.KelimeAl("collatzSanisiAciklama");
            labelAna.Text = da.KelimeAl("collatzSanisi");
            labelRenk.Text = da.KelimeAl("grafikRengi");
            labelGrafikStil.Text = da.KelimeAl("grafikStili");
            kaynakKod.Text = da.KelimeAl("kaynakKod");
            onizleme.Text = da.KelimeAl("onizleme");
            renkSecButon.Text = da.KelimeAl("renkSec");
            tamam.Text = da.KelimeAl("tamam");
        }

        private readonly DilAyar da;
        private readonly string _dil;

        public List<System.Windows.Forms.DataVisualization.Charting.SeriesChartType> chartTypesList = new List<System.Windows.Forms.DataVisualization.Charting.SeriesChartType> {
            System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area,
            System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea,
            System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
            System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline,
            System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
        };  
        private void ayarlar_Load(object sender, EventArgs e)
        {
            grafikStil.Items.Clear();
            grafikStil.Items.AddRange(da.KelimeAl("grafikStilEleman").Split('\n'));
            dilSecim.SelectedIndex = (Properties.Settings.Default.dil == "tr" ? 1 : 0);
            grafik.Series[0].ChartType = Properties.Settings.Default.chartStyle;
            grafik.Series[0].Color = Properties.Settings.Default.renk;
            grafikStil.SelectedIndex = chartTypesList.IndexOf(Properties.Settings.Default.chartStyle);
        }

        private void grafikStil_SelectedIndexChanged(object sender, EventArgs e)
        {
            grafik.Series[0].ChartType = chartTypesList[grafikStil.SelectedIndex];
        }

        private void renkSecButon_Click(object sender, EventArgs e)
        {
            renkSecim.Color = grafik.Series[0].Color;
            renkSecim.FullOpen = true;
            if(renkSecim.ShowDialog() == DialogResult.OK)
            {
                grafik.Series[0].Color = renkSecim.Color;
            }
        }

        private void sifirla_Click(object sender, EventArgs e)
        {
            grafik.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            grafik.Series[0].Color = Color.FromArgb(9, 63, 179);
            Properties.Settings.Default.chartStyle = chartTypesList[grafikStil.SelectedIndex];
            Properties.Settings.Default.renk = Color.FromArgb(9, 63, 179);
            grafikStil.SelectedIndex = chartTypesList.IndexOf(System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea);
            Properties.Settings.Default.Save();
        }

        private void tamam_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.chartStyle = chartTypesList[grafikStil.SelectedIndex];
            Properties.Settings.Default.renk = grafik.Series[0].Color;
            Properties.Settings.Default.dil = dilSecim.SelectedIndex == 0 ? "en" : "tr";
            Properties.Settings.Default.Save();
            if(_dil != (dilSecim.SelectedIndex == 0 ? "en" : "tr"))
            {
                if(dilSecim.SelectedIndex != 0)
                {
                    MessageBox.Show("Dil değişikliği yaptınız, lütfen uygulamayı yeniden başlatın.", "Collatz Sanısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else
                {
                    MessageBox.Show("You have changed the language, please restart the app.", "Collatz Conjecture", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            this.Close();
        }

        private void kaynakKod_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show(String.Format(da.KelimeAl("linkUyari"), "\"github.com/lim10dev/collatz\""), da.KelimeAl("collatzSanisi"), MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://github.com/lim10dev/collatz");
                kaynakKod.LinkVisited = true;
            }
        }

        private void kaynakKod_Enter(object sender, EventArgs e)
        {
            if (kaynakKod.LinkVisited == false)
            {
                kaynakKod.LinkColor = Color.White;
            }
        }

        private void kaynakKod_Leave(object sender, EventArgs e)
        {
            if(kaynakKod.LinkVisited == false)
            {
                kaynakKod.LinkColor = Color.FromArgb(197, 211, 235);
            }
        }
    }
}
