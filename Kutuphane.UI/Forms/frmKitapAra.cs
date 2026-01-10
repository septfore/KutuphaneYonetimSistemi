using Kutuphane.BLL;
using Kutuphane.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane.UI.Forms
{
    public partial class frmKitapAra : Form
    {
        private readonly KitapYonetimi _kitapYonetimi;
        private List<Kitap> _tumKitaplar;
        public frmKitapAra()
        {
            InitializeComponent();
            _kitapYonetimi = new KitapYonetimi();

            kitaplarDgw.AutoGenerateColumns = true;

            this.Load += frmKitapAra_Load;
            kitapAdiTxt.TextChanged += kitapAdiTxt_TextChanged;
        }

        private void frmKitapAra_Load(object sender, EventArgs e)
        {
            _tumKitaplar = _kitapYonetimi.TumKitaplariGetir();
            TumKitaplariYukle();
            #region dgvRenkAyarlari
            kitaplarDgw.EnableHeadersVisualStyles = false;

            kitaplarDgw.DefaultCellStyle.ForeColor = Color.Black;
            kitaplarDgw.DefaultCellStyle.BackColor = Color.White;

            kitaplarDgw.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            kitaplarDgw.ColumnHeadersDefaultCellStyle.BackColor = Color.White;

            #endregion

        }
        private void ListeyiGoster(List<Kitap> liste)
        {
            kitaplarDgw.DataSource = null;
            kitaplarDgw.DataSource = liste;
            if (kitaplarDgw.Columns["OduncDurumu"] != null)
                kitaplarDgw.Columns["OduncDurumu"].Visible = false;
            if (kitaplarDgw.Columns["OduncDurumText"] != null)
                kitaplarDgw.Columns["OduncDurumText"].HeaderText = "Ödünç Durumu";
        }
        public void TumKitaplariYukle()
        {
            var kitapListesi = _kitapYonetimi.TumKitaplariGetir();
            kitaplarDgw.DataSource = kitapListesi;
            if (kitaplarDgw.Columns["OduncDurumu"] != null)
                kitaplarDgw.Columns["OduncDurumu"].Visible = false;

            if (kitaplarDgw.Columns["OduncDurumText"] != null)
                kitaplarDgw.Columns["OduncDurumText"].HeaderText = "Ödünç Durumu";
        }
        private void yenileBtn_Click(object sender, EventArgs e)
        {
            kitapAdiTxt.Clear();
        }

        private void kitapAdiTxt_TextChanged(object sender, EventArgs e)
        {
            if (_tumKitaplar == null || _tumKitaplar.Count == 0)
                return;
            string aranan = kitapAdiTxt.Text.Trim();
            if (string.IsNullOrEmpty(aranan))
            {
                ListeyiGoster(_tumKitaplar);
            }
            else
            {
                var filtreliListe = _tumKitaplar
                    .Where(k => k.KitapAdi.IndexOf(aranan, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();
                ListeyiGoster(filtreliListe);
            }

        }
        
    }
}
