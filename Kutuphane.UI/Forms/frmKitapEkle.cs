using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kutuphane.BLL;
using Kutuphane.Entities;

namespace Kutuphane.UI.Forms
{

    public partial class frmKitapEkle : Form
    {
        private readonly KitapYonetimi _kitapYonetimi;
        private int _seciliKitapId = 0;
        private string _eskiIsbn;
        private string _eskiBaski;
        public frmKitapEkle()
        {
            InitializeComponent();
            _kitapYonetimi = new KitapYonetimi();
            this.Load += frmKitapEkle_Load;
            kaydetBtn.Click += KaydetBtn_Click;
            guncelleBtn.Click += GuncelleBtn_Click;
            silBtn.Click += SilBtn_Click;
            temizleBtn.Click += TemizleBtn_Click;
            yenileBtn.Click += YenileBtn_Click;
            kitapAdiTxt.TextChanged += KitapAdiTxt_TextChanged;
            kitaplarDgv.CellDoubleClick += KitaplarDgv_CellDoubleClick;
            kitaplarDgv.AutoGenerateColumns = true;
            kitaplarDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void KitaplarDgv_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void KitapAdiTxt_TextChanged(object? sender, EventArgs e)
        {
           
        }

        private void YenileBtn_Click(object? sender, EventArgs e)
        {
            kitapIsmiTxt.Clear();
            GridYenile();
            
        }
        private void TextBoxlariTemizle()
        {
            _seciliKitapId = 0;
            kitapAdiTxt.Clear();
            yazarTxt.Clear();
            yayinEviTxt.Clear();
            isbnTxt.Clear();
            basimYiliTxt.Clear();
            baskiTxt.Clear();
            turuCombo.SelectedIndex = -1;
            kitapAdiTxt.Focus();
        }
        private void TemizleBtn_Click(object? sender, EventArgs e)
        {
            TextBoxlariTemizle();
       
        }

        private void SilBtn_Click(object? sender, EventArgs e)
        {
            if (_seciliKitapId <= 0)
            {
                MessageBox.Show("Lütfen listeden silmek istediğiniz kitabı seçip çift tıklayın.");
                return;
            }

            if (MessageBox.Show("Seçili stoktan 1 adet eksiltmek istediğinize emin misiniz?",
                "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            string isbn = isbnTxt.Text.Trim();
            string baski = baskiTxt.Text.Trim();

            bool ok = _kitapYonetimi.KitapSil(_seciliKitapId, isbn, baski, out string mesaj, out int kalanStok);
            MessageBox.Show(mesaj, ok ? "Bilgi" : "Hata",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (ok)
            {
                GridYenile();
                TextBoxlariTemizle();
            }            
        }

        private void GuncelleBtn_Click(object? sender, EventArgs e)
        {

            if (_seciliKitapId <= 0)
            {
                MessageBox.Show("Önce listeden bir kitap seçip çift tıklayın.");
                return;
            }
            int basimYili = int.TryParse(basimYiliTxt.Text, out var by) ? by : 0;
            int stokAdedi = 1; // şimdilik sabit
            var kitap = new Kitap
            {
                Id = _seciliKitapId,
                KitapAdi = kitapAdiTxt.Text.Trim(),
                Yazar = yazarTxt.Text.Trim(),
                YayinEvi = yayinEviTxt.Text.Trim(),
                Isbn = isbnTxt.Text.Trim(),
                BasimYili = basimYili,
                Baski = baskiTxt.Text.Trim(),
                StokAdedi = stokAdedi,
                Turu = turuCombo.Text
            };
            bool ok = _kitapYonetimi.KitapGuncelle(kitap,_eskiIsbn, _eskiBaski, out string mesaj);
            MessageBox.Show(mesaj, ok ? "Bilgi" : "Hata",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (ok)
            {
                _eskiBaski = kitap.Baski;
                _eskiIsbn = kitap.Isbn;
                GridYenile();
                TextBoxlariTemizle();
            }
        }

        private void KaydetBtn_Click(object? sender, EventArgs e)
        {
            int basimYili = int.TryParse(basimYiliTxt.Text, out var by) ? by : 0;
            int stokAdedi = 1; //textkoyup ordan alabilirim değeri
            var kitap = new Kitap
            {
                KitapAdi = kitapAdiTxt.Text.Trim(),
                Yazar = yazarTxt.Text.Trim(),
                YayinEvi = yayinEviTxt.Text.Trim(),
                Isbn = isbnTxt.Text.Trim(),
                BasimYili = basimYili,
                Baski = baskiTxt.Text.Trim(),
                //StokAdedi = stokAdedi,
                Turu = turuCombo.Text.Trim(),
                //OduncDurumu = false //yeni kitaplar mevcut
            };
            bool ok = _kitapYonetimi.KitapEkleStoklu(kitap, out string mesaj);
            MessageBox.Show(mesaj, ok ? "Bilgi" : "Hata",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            if (ok)
            {
                GridYenile();
                TextBoxlariTemizle();
            }
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {

        }

        private void frmKitapEkle_Load(object sender, EventArgs e)
        {
            GridYenile();
            #region dgvRenkAyarlari
            kitaplarDgv.EnableHeadersVisualStyles = false;

            kitaplarDgv.DefaultCellStyle.ForeColor = Color.Black;
            kitaplarDgv.DefaultCellStyle.BackColor = Color.White;
                
            kitaplarDgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            kitaplarDgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White;

            #endregion

        }
        private void GridYenile()
        {
            var liste = _kitapYonetimi.TumKitaplariGetir();
            kitaplarDgv.DataSource = null;
            kitaplarDgv.DataSource = liste;
            if (kitaplarDgv.Columns["OduncDurumu"] != null)
                kitaplarDgv.Columns["OduncDurumu"].Visible = false;
            if (kitaplarDgv.Columns["OduncDurumText"] != null)
                kitaplarDgv.Columns["OduncDurumText"].HeaderText = "Ödünç Durumu";
        }
        
        
        private void kitaplarDgv_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var secili = kitaplarDgv.Rows[e.RowIndex].DataBoundItem as Kitap;
            if (secili == null) return;
            
            _seciliKitapId = secili.Id;
            _eskiBaski = secili.Baski;
            _eskiIsbn = secili.Isbn;

            kitapAdiTxt.Text = secili.KitapAdi;
            yazarTxt.Text = secili.Yazar;
            yayinEviTxt.Text = secili.YayinEvi;
            isbnTxt.Text = secili.Isbn;
            basimYiliTxt.Text = secili.BasimYili.ToString();
            baskiTxt.Text = secili.Baski;
            turuCombo.Text = secili.Turu;
        }

        private void guncelleBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void kitapIsmiTxt_TextChanged(object sender, EventArgs e)
        {
            string aranan = kitapIsmiTxt.Text;
            var liste = _kitapYonetimi.KitapAra(aranan);
            kitaplarDgv.DataSource = null;
            kitaplarDgv.DataSource = liste;

            if (kitaplarDgv.Columns["OduncDurumu"] != null)
                kitaplarDgv.Columns["OduncDurumu"].Visible = false;
        }
    }
}
