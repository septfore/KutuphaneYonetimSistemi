using Kutuphane.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ScottPlot;
using ScottPlot.WinForms;
using SDColor = System.Drawing.Color;


namespace Kutuphane.UI.Forms
{
    public partial class frmRaporlar : Form
    {
        private AdminForm _admin;
        RaporYonetimi raporYonetimi = new RaporYonetimi();
        private FormsPlot _formsPlot = null!;
        public frmRaporlar(AdminForm admin)
        {

            InitializeComponent();
            ScottPlotKur();
            _admin = admin;
        }
        public bool TopLevel { get; internal set; }
        public bool TopMost { get; internal set; }
        public FormBorderStyle FormBorderStyle { get; internal set; }

        private void ScottPlotKur()
        {
            _formsPlot = new FormsPlot();
            _formsPlot.Dock = DockStyle.Fill;
            panelGrafik.Controls.Add(_formsPlot); // panelGrafik yoksa this.Controls.Add(_formsPlot)
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            if (dtpBaslangic.Value.Date > dtpBitis.Value.Date)
            {
                MessageBox.Show("Başlangıç tarihi, bitişten büyük olamaz.");
                return;
            }

            GrafigiCiz(dtpBaslangic.Value.Date, dtpBitis.Value.Date);
        }
        private void GrafigiCiz(DateTime baslangic, DateTime bitis)
        {
            var seri = raporYonetimi.GunlukOduncSerisi(baslangic, bitis);

            double[] xs = seri.Select(x => x.Tarih.ToOADate()).ToArray();
            double[] ys = seri.Select(x => (double)x.OduncSayisi).ToArray();

            var plt = _formsPlot.Plot;
            plt.Clear();

            // ---- Dark/Navy tema ----
            #region eskiçalışanrenk
            //SDColor figBg = SDColor.FromArgb(10, 12, 20);
            //SDColor dataBg = SDColor.FromArgb(8, 26, 56);
            //SDColor gridMajor = SDColor.FromArgb(35, 255, 255, 255);
            //SDColor gridMinor = SDColor.FromArgb(18, 255, 255, 255);
            //SDColor neon = SDColor.FromArgb(0, 200, 255);
            #endregion
            SDColor figBg = SDColor.RoyalBlue;                 // form arkası
            SDColor dataBg = SDColor.FromArgb(65, 105, 225);    // RoyalBlue tonu
            SDColor gridMajor = SDColor.FromArgb(60, 255, 255, 255);
            SDColor gridMinor = SDColor.FromArgb(25, 255, 255, 255);
            SDColor lineClr = SDColor.White;
            SDColor fillClr = SDColor.FromArgb(70, 255, 255, 255); // beyaz saydam dolgu

            plt.FigureBackground.Color = ScottPlot.Color.FromColor(figBg);
            plt.DataBackground.Color = ScottPlot.Color.FromColor(dataBg);
            plt.Grid.MajorLineColor = ScottPlot.Color.FromColor(gridMajor);
            plt.Grid.MinorLineColor = ScottPlot.Color.FromColor(gridMinor);

            // --- Area hissi: polygon ile line altını doldur (ScottPlot 5.1.57 uyumlu) ---
            double baseline = 0; // dolgu tabanı (0'dan aşağı inmesin diye)

            double[] polyXs = xs.Concat(xs.Reverse()).ToArray();
            double[] polyYs = ys.Concat(Enumerable.Repeat(baseline, ys.Length).Reverse()).ToArray();

            var poly = plt.Add.Polygon(polyXs, polyYs);
            poly.FillColor = ScottPlot.Color.FromColor(fillClr);
            poly.LineWidth = 0; // sadece dolgu, çizgi istemiyoruz

            // ---- Çizgi + dolgu (ScottPlot 5 uyumlu) ----
            var scat = plt.Add.Scatter(xs, ys);
            scat.Color = ScottPlot.Color.FromColor(lineClr);
            scat.LineWidth = 3;
            scat.MarkerSize = 6;
            scat.MarkerShape = MarkerShape.FilledCircle;
            scat.MarkerFillColor = ScottPlot.Color.FromColor(lineClr);


            // ---- Eksen formatı ----
            //plt.Axes.DateTimeTicksBottom();
            //plt.Title("Son 30 Gün - Günlük Ödünç Sayısı");

            plt.Axes.DateTimeTicksBottom();

            plt.Title("Son 30 Gün - Günlük Ödünç Sayısı");

            // Eksen yazıları beyaz
            plt.Axes.Bottom.TickLabelStyle.ForeColor = ScottPlot.Color.FromColor(SDColor.White);
            plt.Axes.Left.TickLabelStyle.ForeColor = ScottPlot.Color.FromColor(SDColor.White);

            plt.Axes.Bottom.Label.ForeColor = ScottPlot.Color.FromColor(SDColor.White);
            plt.Axes.Left.Label.ForeColor = ScottPlot.Color.FromColor(SDColor.White);

            // toplam label
            int toplam = seri.Sum(x => x.OduncSayisi);
            lblToplamOdunx.Text = toplam.ToString();

            _formsPlot.Refresh();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmRaporlar_Load(object sender, EventArgs e)
        {
            dtpBitis.Value = DateTime.Today;
            dtpBaslangic.Value = DateTime.Today.AddDays(-29);

            GrafigiCiz(dtpBaslangic.Value.Date, dtpBitis.Value.Date);
            #region TASARIM
            label3.BackColor = System.Drawing.Color.RoyalBlue;
            label4.BackColor = System.Drawing.Color.RoyalBlue;
            var ozet = raporYonetimi.GetRaporOzeti();
            lblToplamOdunx.Text = ozet.ToplamOdunc.ToString();
            //lblBuAy.Text = ozet.BuAyOdunc.ToString();
            lblBuAy.Text = ozet.BuAyOdunc == 0
    ? "Bu ay hiç kitap alınmadı."
    : "Bu ay " + ozet.BuAyOdunc + " kitap alındı.";

            //if (ozet.EnCokKitapAlanVar)
            //{
            //    lblEnCokAlan.Text = ozet.EnCokKitapAlan.AdSoyad;
            //    lblEnCokAlanSayi.Text = ozet.EnCokKitapAlan.KitapSayisi.ToString();
            //}
            //else
            //{
            //    lblEnCokAlan.Text = "Henüz yok";
            //    lblEnCokAlanSayi.Text = "0";
            //}
            if (ozet.EnCokKitapAlanVar)
            {
                lblEnCokAlan.Text = ozet.EnCokKitapAlan.AdSoyad;
                lblEnCokAlanSayi.Text =
                    "Bugüne kadar " + ozet.EnCokKitapAlan.KitapSayisi + " kitap aldı.";
            }
            else
            {
                lblEnCokAlan.Text = "Henüz yok";
                lblEnCokAlanSayi.Text = "Bugüne kadar 0 kitap aldı.";
            }

            if (ozet.EnGecKalanVar)
            {
                lblEnGecKalan.Text = ozet.EnGecKalan.KitapAdi;
                lblGecikmeGun.Text = ozet.EnGecKalan.GecikmeGun + " gün";
            }
            else
            {
                lblEnGecKalan.Text = "Geciken kitap yok 🎉";
                lblGecikmeGun.Text = "";
            }
            #endregion

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _admin.IcerikAc(new frmOduncDetayListesi(_admin));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _admin.IcerikAc(new frmEnCokKitapAlan(_admin));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _admin.IcerikAc(new frmEnGecKalanKitap(_admin));
        }
    }
}
