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

namespace Kutuphane.UI.Forms
{
    public partial class frmEnGecKalanKitap : Form
    {
        private readonly RaporYonetimi raporYonetimi = new RaporYonetimi();
        private readonly AdminForm _admin;
        public frmEnGecKalanKitap(AdminForm admin)
        {
            InitializeComponent();
            _admin = admin;
            dgv.AutoGenerateColumns = true;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;

            this.Load += frmEnGecKalanKitap_Load;
            button1.Click += button1_Click;
        }

        private void frmEnGecKalanKitap_Load(object sender, EventArgs e)
        {
            #region DUZEN
            dgv.DataSource = raporYonetimi.EnGecKalanKitaplariGetir();

            // Başlık düzeni (istersen azalt/çoğalt)
            if (dgv.Columns["OduncId"] != null) dgv.Columns["OduncId"].HeaderText = "Ödünç ID";
            if (dgv.Columns["KitapAdi"] != null) dgv.Columns["KitapAdi"].HeaderText = "Kitap Adı";
            if (dgv.Columns["UyeAdSoyad"] != null) dgv.Columns["UyeAdSoyad"].HeaderText = "Üye";
            if (dgv.Columns["KulNo"] != null) dgv.Columns["KulNo"].HeaderText = "Üye No";
            if (dgv.Columns["TeslimTarihiPlanlanan"] != null) dgv.Columns["TeslimTarihiPlanlanan"].HeaderText = "Planlanan Teslim";
            if (dgv.Columns["TeslimTarihiGercek"] != null) dgv.Columns["TeslimTarihiGercek"].HeaderText = "Gerçek Teslim";
            if (dgv.Columns["GecikmeGun"] != null) dgv.Columns["GecikmeGun"].HeaderText = "Gecikme (Gün)";
            if (dgv.Columns["Durum"] != null) dgv.Columns["Durum"].HeaderText = "Durum";
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            #endregion
            #region TASARIM
            dgv.BackgroundColor = Color.White;
            dgv.ForeColor = Color.Black;

            // HÜCRELER
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;

            // SEÇİLİ SATIR
            dgv.DefaultCellStyle.SelectionBackColor = Color.Navy;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            // BAŞLIKLAR
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _admin.IcerikAc(new frmRaporlar(_admin));
        }
    }
}
