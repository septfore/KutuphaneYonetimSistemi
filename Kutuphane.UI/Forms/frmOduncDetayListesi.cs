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
    public partial class frmOduncDetayListesi : Form
    {
        private readonly AdminForm _admin;
        private readonly OduncYonetimi oduncYonetimi = new OduncYonetimi();
        public frmOduncDetayListesi(AdminForm admin)
        {
            InitializeComponent();
            dgv.AutoGenerateColumns = true;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            _admin = admin;


            button1.Click += button1_Click;
            this.Load += frmOduncDetayListesi_Load;
            button1.Click += button1_Click;

        }

        private void frmOduncDetayListesi_Load(object sender, EventArgs e)
        {
            this.Text = "En Çok Alınan Kitaplar (Detay)";
            dgv.DataSource = oduncYonetimi.EnCokAlinanKitapDetayGetir();

            if (dgv.Columns["KitapAdi"] != null) dgv.Columns["KitapAdi"].HeaderText = "Kitap Adı";
            if (dgv.Columns["YayinEvi"] != null) dgv.Columns["YayinEvi"].HeaderText = "Yayınevi";
            if (dgv.Columns["BasimYili"] != null) dgv.Columns["BasimYili"].HeaderText = "Basım Yılı";
            if (dgv.Columns["StokAdedi"] != null) dgv.Columns["StokAdedi"].HeaderText = "Stok Adedi";
            if (dgv.Columns["AlinmaSayisi"] != null) dgv.Columns["AlinmaSayisi"].HeaderText = "Alınma Sayısı";

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
