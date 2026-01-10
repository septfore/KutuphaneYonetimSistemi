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
    public partial class frmEnCokKitapAlan : Form
    {
        private readonly AdminForm _admin;
        private readonly RaporYonetimi raporYonetimi = new RaporYonetimi();
        public frmEnCokKitapAlan(AdminForm admin)
        {
            InitializeComponent();
            _admin = admin;
            dgvUyeler.AutoGenerateColumns = true;
            dgvUyeler.ReadOnly = true;
            dgvUyeler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUyeler.MultiSelect = false;

            this.Load += frmEnCokKitapAlan_Load;
        }

        private void frmEnCokKitapAlan_Load(object sender, EventArgs e)
        {
            dgvUyeler.DataSource = raporYonetimi.EnCokKitapAlanUyeleriGetir();

            if (dgvUyeler.Columns["KullaniciId"] != null) dgvUyeler.Columns["KullaniciId"].HeaderText = "ID";
            if (dgvUyeler.Columns["KulNo"] != null) dgvUyeler.Columns["KulNo"].HeaderText = "Kullanıcı No";
            if (dgvUyeler.Columns["AdSoyad"] != null) dgvUyeler.Columns["AdSoyad"].HeaderText = "Ad Soyad";
            if (dgvUyeler.Columns["Rol"] != null) dgvUyeler.Columns["Rol"].HeaderText = "Rol";
            if (dgvUyeler.Columns["AlinanKitapSayisi"] != null) dgvUyeler.Columns["AlinanKitapSayisi"].HeaderText = "Alınan Kitap Sayısı";

            dgvUyeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            #region TASARIM
           
            // GENEL
            dgvUyeler.BackgroundColor = Color.White;
            dgvUyeler.ForeColor = Color.Black;

            // HÜCRELER
            dgvUyeler.DefaultCellStyle.BackColor = Color.White;
            dgvUyeler.DefaultCellStyle.ForeColor = Color.Black;

            // SEÇİLİ SATIR
            dgvUyeler.DefaultCellStyle.SelectionBackColor = Color.Navy;
            dgvUyeler.DefaultCellStyle.SelectionForeColor = Color.White;

            // BAŞLIKLAR
            dgvUyeler.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvUyeler.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUyeler.EnableHeadersVisualStyles = false;

            dgvUyeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _admin.IcerikAc(new frmRaporlar(_admin));
        }
    }
}
