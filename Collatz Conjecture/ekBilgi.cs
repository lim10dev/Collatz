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
    public partial class ekBilgi : Form
    {
        int ciftSayi = 0;
        int tekSayi = 0;
        long enBuyukSayi = 0;
        int adimSayi = 0;

        public ekBilgi()
        {
            InitializeComponent();
            if (Properties.Settings.Default.dil == "")
            {
                _dil = System.Globalization.CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "tr" ? "tr" : "en";
            }
            else { _dil = Properties.Settings.Default.dil; }

            da = new DilAyar(_dil);

            this.Text = da.KelimeAl("bilgi");
            bilgiLabelDefault = da.KelimeAl("bilgiLabel");
            sayiDagilimGroupbox.Text = da.KelimeAl("rakamDagilim");

            hoverText.SetToolTip(sayiDagilimGrafik, da.KelimeAl("rakamDagilimHover"));
            hoverText.SetToolTip(sayiDagilimGroupbox, da.KelimeAl("rakamDagilimHover"));
        }
        private readonly DilAyar da;
        public string _dil;
        public string bilgiLabelDefault;
        public List<long> sayiDagilim;

        public void GrafigiBoya(Color renk)
        {
            sayiDagilimGrafik.Series[0].Color = renk;
        }

        public void GrafigeYaz(System.Windows.Forms.DataVisualization.Charting.Chart grafik_, List<long> liste, int baslangicX = 1)
        {
            grafik_.Series[0].Points.Clear();
            for (int i = 0; i < liste.Count; i++)
            {
                grafik_.Series[0].Points.AddXY(baslangicX + i, liste[i]);
            }
        }

        public List<long> SayiDagilimlariHesapla(List<long> list)
        {
            List<long> list_ = new List<long>() { /*1*/0, /*2*/0, /*3*/0, /*4*/0, /*5*/0, /*6*/0, /*7*/0, /*8*/0, /*9*/0 };
            double x;

            for (int i = 0; i < list.Count; i++)
            {
                x = Math.Pow(10, Math.Floor(Math.Log10(list[i])));
                //MessageBox.Show((((list[i] - (list[i] % x)) / x) - 1).ToString());
                list_[Convert.ToInt32((list[i] - (list[i] % x)) / x) - 1]++;
            }
            return list_;
        }

        public void bilgiAl(List<long> CollatzListe)
        {
            ciftSayi = 0;
            tekSayi = 0;
            enBuyukSayi = 0;
            adimSayi = CollatzListe.Count;
            long a;
            for (int i = 0; i < CollatzListe.Count; i++)
            {
                a = CollatzListe[i];
                if (a > enBuyukSayi)
                {
                    enBuyukSayi = a;
                }
                if (a % 2 == 0)
                {
                    ciftSayi++;
                }
                else
                {
                    tekSayi++;
                }
            }

            string[] bilgiLabel_ = bilgiLabelDefault.Split('/');
            bilgiLabel_[0] += CollatzListe[0].ToString();
            bilgiLabel_[1] += tekSayi.ToString();
            bilgiLabel_[2] += ciftSayi.ToString();
            bilgiLabel_[3] += enBuyukSayi.ToString();
            bilgiLabel_[4] += adimSayi.ToString();

            bilgiLabel.Text = String.Join("\n", bilgiLabel_);
            sayiDagilim = SayiDagilimlariHesapla(CollatzListe);
            if (this.Visible == true)
            {
                GrafigeYaz(sayiDagilimGrafik, sayiDagilim);
            }
        }

        private void ekBilgi_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void ekBilgi_Shown(object sender, EventArgs e)
        {
            GrafigiBoya(Properties.Settings.Default.renk);
            GrafigeYaz(sayiDagilimGrafik, sayiDagilim);
        }

        private void ekBilgi_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                sayiDagilimGrafik.Size = new Size(this.Width - 49, this.Height - 201);
                sayiDagilimGroupbox.Size = new Size(this.Width - 32, this.Height - 176);
                bilgiLabel.Size = new Size(this.Width - 40, 113);
            }
        }
    }
}
