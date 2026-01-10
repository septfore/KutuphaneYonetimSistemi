using Kutuphane.BLL;
using Kutuphane.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane.UI.Forms
{
    public partial class frmKitapOduncVer : Form
    {
        private DataTable _dtKullanicilar;
        private KitapYonetimi kitapYonetimi = new KitapYonetimi();
        private OgrenciYonetimi ogrenciYonetimi = new OgrenciYonetimi();
        private OduncYonetimi oduncYonetimi = new OduncYonetimi();
        private List<Kitap> _tumKitaplar;
        private List<Kullanici> _tumKullanicilar;

        private int secilenKitapId = 0;
        private int secilenKullaniciId = 0;
        public frmKitapOduncVer()
        {
            InitializeComponent();
            uyelerDgv.AutoGenerateColumns = true;

            this.Load += frmKitapOduncVer_Load;
            ogrNoAraTxt.TextChanged += ogrNoAraTxt_TextChanged;
        }
        private void frmKitapOduncVer_Load(object sender, EventArgs e)
        {
            // KİTAPLAR
            _tumKitaplar = kitapYonetimi.TumKitaplariGetir();
            KitapListeyiGoster(_tumKitaplar);
            kitapIsmiTxt.TextChanged += kitapIsmiTxt_TextChanged;

            // ÜYELER / KULLANICILAR 
            _dtKullanicilar = ogrenciYonetimi.UyeleriOduncIcinGetir();
            uyelerDgv.AutoGenerateColumns = true;
            uyelerDgv.DataSource = _dtKullanicilar;
            uyelerDgv.ClearSelection();

            // Tarihler
            oduncTarihiDtp.Value = DateTime.Now;
            teslimTarihiDtp.Value = DateTime.Today.AddDays(15);
            teslimTarihiDtp.Enabled = false;
            ButtonStyle(oduncVerBtn);
            #region DGV Ayarları
            kitaplarDgv.EnableHeadersVisualStyles = false;

            kitaplarDgv.DefaultCellStyle.ForeColor = Color.Black;
            kitaplarDgv.DefaultCellStyle.BackColor = Color.White;

            kitaplarDgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            kitaplarDgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White;

            uyelerDgv.EnableHeadersVisualStyles = false;

            uyelerDgv.DefaultCellStyle.ForeColor = Color.Black;
            uyelerDgv.DefaultCellStyle.BackColor = Color.White;

            uyelerDgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            uyelerDgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            #endregion 
        }
        void ButtonStyle(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.Navy;
            btn.ForeColor = Color.White;

            RoundButton(btn, 20);
        }
        private void RoundButton(Button btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path);
        }
        private void KitapListeyiGoster(List<Kitap> liste)
        {
            kitaplarDgv.AutoGenerateColumns = true; // test için true kalsın
            kitaplarDgv.DataSource = null;
            kitaplarDgv.DataSource = liste;

            if (kitaplarDgv.Columns["OduncDurumu"] != null)
                kitaplarDgv.Columns["OduncDurumu"].Visible = false;

            if (kitaplarDgv.Columns["OduncDurumText"] != null)
                kitaplarDgv.Columns["OduncDurumText"].HeaderText = "Ödünç Durumu";
        }

        private void kitaplarDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = kitaplarDgv.Rows[e.RowIndex];
            secilenKitapId = Convert.ToInt32(row.Cells["Id"].Value);
            isbnTxt.Text = row.Cells["ISBN"].Value.ToString();
            kitapAdiTxt.Text = row.Cells["KitapAdi"].Value.ToString();
            yayineviTxt.Text = row.Cells["Yayinevi"].Value.ToString();
            baskiTxt.Text = row.Cells["Baski"].Value.ToString();
        }

        private void uyelerDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = uyelerDgv.Rows[e.RowIndex];
            secilenKullaniciId = Convert.ToInt32(row.Cells["Id"].Value);
            kulAdiTxt.Text = row.Cells["kulAdi"].Value.ToString();
            kulNoTxt.Text = row.Cells["kulNo"].Value.ToString();
            telNoTxt.Text = row.Cells["telNo"].Value.ToString();
            ePostaTxt.Text = row.Cells["ePosta"].Value.ToString();

        }

        private void oduncVerBtn_Click(object sender, EventArgs e)
        {
            if (secilenKullaniciId == 0)
            {
                MessageBox.Show("Lütfen listeden bir üye seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (secilenKitapId == 0)
            {
                MessageBox.Show("Lütfen listeden bir kitap seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool sonuc = oduncYonetimi.OduncVer(secilenKullaniciId, secilenKitapId, oduncTarihiDtp.Value, out string mesaj);
            MessageBox.Show(mesaj);
            if (sonuc)
            {
                kitaplarDgv.DataSource = kitapYonetimi.MevcutKitaplariGetir();
                kitaplarDgv.ClearSelection();
                secilenKitapId = 0;
                isbnTxt.Clear();
                kitapAdiTxt.Clear();
                yayineviTxt.Clear();
                baskiTxt.Clear();
            }
        }

        private void kitapIsmiTxt_TextChanged(object sender, EventArgs e)
        {
            if (_tumKitaplar == null) return;

            string aranan = kitapIsmiTxt.Text.Trim();

            if (string.IsNullOrEmpty(aranan))
            {
                KitapListeyiGoster(_tumKitaplar);
                return;
            }

            var filtreli = _tumKitaplar
                .Where(k => !string.IsNullOrEmpty(k.KitapAdi) &&
                            k.KitapAdi.IndexOf(aranan, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            KitapListeyiGoster(filtreli);
        }



        private void ogrNoAraTxt_TextChanged(object sender, EventArgs e)
        {
            if (_dtKullanicilar == null) return;

            string q = ogrNoAraTxt.Text.Trim().Replace("'", "''"); // tek tırnak kaçışı

            if (string.IsNullOrWhiteSpace(q))
                _dtKullanicilar.DefaultView.RowFilter = "";
            else
                _dtKullanicilar.DefaultView.RowFilter =
    $"kulNo LIKE '%{q}%' OR kulAdi LIKE '%{q}%' OR kulSoyad LIKE '%{q}%'";
        }

        private void yenileBtn_Click(object sender, EventArgs e)
        {
            kitapIsmiTxt.Clear();
        }
    }
}
