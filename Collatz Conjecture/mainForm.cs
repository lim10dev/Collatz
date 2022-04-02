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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

            // * Dil seçip dil ayarlarını yapar.
            if(Properties.Settings.Default.dil == "")
            {
                _dil = System.Globalization.CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "tr" ? "tr" : "en";
                Properties.Settings.Default.dil = _dil;
                Properties.Settings.Default.Save();
            } else { _dil = Properties.Settings.Default.dil; }

            da = new DilAyar(_dil);

            ayarlar.Text = da.KelimeAl("ayarlar");
            aralikKutusu.Text = da.KelimeAl("aralikKutusu");
            this.Text = da.KelimeAl("collatzSanisi") + " (3x+1)";
            degistir.Text = da.KelimeAl("degistir");
            goster.Text = da.KelimeAl("goster");
            hesaplanacakDegerLabel.Text = da.KelimeAl("hesapDeger");
            hesapBilgilendirme.Text = da.KelimeAl("hesapBilgilendirme");
            hesapla.Text = da.KelimeAl("hesapla");
            bilgiButon.Text = da.KelimeAl("bilgi");
            hoverText.SetToolTip(logaritma, da.KelimeAl("logHover"));
            // * ;

            grafik1.Size = new Size(this.Width - 40, this.Height - 250);
            deger.Size = new Size(this.Width - 350, deger.Height);
            aralikKutusu.Size = new Size(this.Width - 42, aralikKutusu.Height);
            hesapBilgilendirme.Location = new Point((this.Size.Width - hesapBilgilendirme.Size.Width) / 2, 258);
            grafik2.Size = new Size(this.Width - 322, grafik2.Height);


        }
        private readonly DilAyar da;
        public string _dil;

        public Dictionary<bool, System.Windows.Forms.DataVisualization.Charting.Chart> aktifGrafik = new Dictionary<bool, System.Windows.Forms.DataVisualization.Charting.Chart> { };
        // aktifGrafik[!degistir.Checked] = Ana Grafik
        // aktifGrafik[degistir.Checked] = Aralık Grafiği

        public ayarlar ayarlarForm;
        public ekBilgi bilgiForm = new ekBilgi();

        public List<long> suanCollatz = new List<long> { };
        public List<double> suanLogCollatz = new List<double> { };
        public List<long> Collatz(long x)
        {
            /*
             * x sayısı 1 olana kadar tekrarla:
             * Eğer x çift ise ikiye böl (x/2)
             * Eğer x tek ise üçle çarp ve bir ekle (3x+1)
             */
            var list = new List<long>();
            do
            {
                list.Add(x);
                if (x % 2 == 0)
                {
                    x /= 2;
                }
                else
                {
                    x = 3 * x + 1;
                }
            } while (x > 1);
            list.Add(x);
            return list;
        }

        public void LogSuanCollatz()
        {
            // Şu an geçerli olan Collatz listesinin logaritmasını alır.
            suanLogCollatz.RemoveRange(0, suanLogCollatz.Count);
            for (int i = 0; i < suanCollatz.Count; i++)
            {
                suanLogCollatz.Add(Math.Log10(Convert.ToDouble(suanCollatz[i])));
            }
        }

        // ** Seçilen grafiğe, y değerleri liste elemanları olmak üzere yazar.
        public void GrafigeYaz(System.Windows.Forms.DataVisualization.Charting.Chart grafik_, List<double> liste, int baslangicX = 1)
        {
            grafik_.Series[0].Points.Clear();
            for (int i = 0; i < liste.Count; i++)
            {
                grafik_.Series[0].Points.AddXY(baslangicX + i, liste[i]);
            }
        }
        public void GrafigeYaz(System.Windows.Forms.DataVisualization.Charting.Chart grafik_, List<long> liste, int baslangicX = 1)
        {
            grafik_.Series[0].Points.Clear();
            for (int i = 0; i < liste.Count; i++)
            {
                grafik_.Series[0].Points.AddXY(baslangicX + i, liste[i]);
            }
        }
        // ** ;

        private void mainForm_Load(object sender, EventArgs e)
        {
            ayarlarForm = new ayarlar(_dil);
            aktifGrafik.Add(true, grafik1);
            aktifGrafik.Add(false, grafik2);
            grafik1.Series[0].ChartType = Properties.Settings.Default.chartStyle;
            grafik2.Series[0].ChartType = Properties.Settings.Default.chartStyle;
            grafik1.Series[0].Color = Properties.Settings.Default.renk;
            grafik2.Series[0].Color = Properties.Settings.Default.renk;
        }
        private void mainForm_Resize(object sender, EventArgs e)
        {
            if(this.WindowState != FormWindowState.Minimized)
            {
                grafik1.Size = new Size(this.Width - 40, this.Height - 250);
                deger.Size = new Size(this.Width - 350, deger.Height);
                aralikKutusu.Size = new Size(this.Width - 42, aralikKutusu.Height);
                hesapBilgilendirme.Location = new Point((this.Size.Width - hesapBilgilendirme.Size.Width) / 2, 258);
                grafik2.Size = new Size(this.Width - 322, grafik2.Height);
            }
        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            aktifGrafik[!degistir.Checked].Visible = true;
            aktifGrafik[degistir.Checked].Visible = false;
            suanCollatz = Collatz((long)deger.Value);
            bilgiForm.bilgiAl(suanCollatz);
            LogSuanCollatz();
            if (logaritma.Checked)
            {
                GrafigeYaz(aktifGrafik[!degistir.Checked], suanLogCollatz);
            }
            else { GrafigeYaz(aktifGrafik[!degistir.Checked], suanCollatz); }

            aralikKutusu.Enabled = true;

            trackBar1.Maximum = suanCollatz.Count - 1;
            trackBar1.Value = 0;
            trackBarLabel1.Text = "1";

            trackBar2.Maximum = suanCollatz.Count - 1;
            trackBar2.Value = suanCollatz.Count - 1;
            trackBarLabel2.Text = suanCollatz.Count.ToString();
        }

        private void ayarlar_Click(object sender, EventArgs e)
        {
            if(ayarlarForm.ShowDialog() == DialogResult.OK)
            {
                grafik1.Series[0].ChartType = Properties.Settings.Default.chartStyle;
                grafik1.Series[0].Color = Properties.Settings.Default.renk;
                aktifGrafik[degistir.Checked].Visible = false;
                aktifGrafik[!degistir.Checked].Visible = false;
                hesapBilgilendirme.Visible = true;
                aralikKutusu.Enabled = false;
                grafik2.Series[0].ChartType = Properties.Settings.Default.chartStyle;
                grafik2.Series[0].Color = Properties.Settings.Default.renk;
                bilgiForm.GrafigiBoya(Properties.Settings.Default.renk);

            }
        }

        private void trackBarScroll(object sender, EventArgs e)
        {
            Dictionary<TrackBar, Label> TRBar = new Dictionary<TrackBar, Label>()
            {
                { trackBar1, trackBarLabel1 },
                { trackBar2, trackBarLabel2 }
            };
            TRBar[(TrackBar)sender].Text = (((TrackBar)sender).Value + 1).ToString();

        }

        // Aralık grafiğine yazar ve gösterir. 
        private void goster_Click(object sender, EventArgs e)
        {
            int max = Math.Max(trackBar1.Value, trackBar2.Value);
            int min = Math.Min(trackBar1.Value, trackBar2.Value);

            if (min == max)
            {
                aktifGrafik[degistir.Checked].Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            } else
            {
                aktifGrafik[degistir.Checked].Series[0].ChartType = Properties.Settings.Default.chartStyle;
            }

            if (logaritma.Checked)
            {
                GrafigeYaz(aktifGrafik[degistir.Checked], suanLogCollatz.GetRange(min, max - min + 1), min + 1);
            } else
            {
                GrafigeYaz(aktifGrafik[degistir.Checked], suanCollatz.GetRange(min, max - min + 1), min + 1);
            }
            aktifGrafik[degistir.Checked].Visible = true;
        }

        private void degistir_CheckedChanged(object sender, EventArgs e)
        {
            (grafik1.Series[0].ChartType, grafik2.Series[0].ChartType, grafik1.Visible, grafik2.Visible) =
            (grafik2.Series[0].ChartType, grafik1.Series[0].ChartType, grafik2.Visible, grafik1.Visible);

            //aktifGrafik[degistir.Checked].Visible = false;
            if (aktifGrafik[degistir.Checked].Visible)
            {
                goster.PerformClick();
            }
            if (logaritma.Checked)
            {
                GrafigeYaz(aktifGrafik[!degistir.Checked], suanLogCollatz);
            }
            else { GrafigeYaz(aktifGrafik[!degistir.Checked], suanCollatz); }
        }

        private void bilgiButon_Click(object sender, EventArgs e)
        {
            bilgiForm.Show();
            bilgiForm.TopMost = true; bilgiForm.TopMost = false;
        }
    }
}
