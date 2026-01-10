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
    public partial class frmKitapIadeAl : Form
    {
        private OduncYonetimi oduncYonetimi = new OduncYonetimi();
        private int secilenOduncId = 0;
        private int secilenKitapId = 0;
        private int secilenKullaniciId = 0;
        public frmKitapIadeAl()
        {
            InitializeComponent();
        }

        private void frmKitapIadeAl_Load(object sender, EventArgs e)
        {
            dgvIadeler.DataSource = oduncYonetimi.TumAktifOduncleriGetir();
            dgvIadeler.ClearSelection();

            dtpIadeTarihi.Value = DateTime.Today;
            dgvIadeler.DefaultCellStyle.ForeColor = Color.Black;
            dgvIadeler.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

        }

        private void dgvIadeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvIadeler.Rows[e.RowIndex];

            secilenOduncId = Convert.ToInt32(row.Cells["OduncId"].Value);
            secilenKitapId = Convert.ToInt32(row.Cells["KitapId"].Value);
            secilenKullaniciId = Convert.ToInt32(row.Cells["KullaniciId"].Value);

            // Kitap bilgileri
            txtIsbn.Text = row.Cells["Isbn"].Value.ToString();
            txtKitapAdi.Text = row.Cells["KitapAdi"].Value.ToString();
            txtYayinevi.Text = row.Cells["YayinEvi"].Value.ToString();
            txtBaski.Text = row.Cells["Baski"].Value.ToString();

            // Üye bilgileri
            txtKulNo.Text = row.Cells["kulNo"].Value.ToString();
            txtAdSoyad.Text = row.Cells["AdSoyad"].Value.ToString();
            txtGsm.Text = row.Cells["telNo"].Value.ToString();
            txtEposta.Text = row.Cells["ePosta"].Value.ToString();

            // Tarihler
            dtpOduncTarihi.Value = Convert.ToDateTime(row.Cells["OduncTarihi"].Value);
            dtpTeslimPlan.Value = Convert.ToDateTime(row.Cells["TeslimTarihiPlanlanan"].Value);
            dtpIadeTarihi.Value = DateTime.Today;
        }

        private void dgvIadeler_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvIadeler.Rows[e.RowIndex];
            var cell = row.Cells["Gecikmis"]; // DAL'de CASE ile ürettiğimiz kolon

            if (cell.Value == null || cell.Value == DBNull.Value)
                return;

            int gecikmis = Convert.ToInt32(cell.Value);

            if (gecikmis == 1)
            {
                row.DefaultCellStyle.BackColor = Color.LightCoral;   // geciken: kırmızımsı
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.LightGreen;   // süresi gelmemiş: yeşil
            }
        }

        private void btnIadeAl_Click(object sender, EventArgs e)
        {
            if (secilenOduncId == 0)
            {
                MessageBox.Show("Lütfen iade edilecek kitabı listeden seçin.");
                return;
            }

            bool sonuc = oduncYonetimi.IadeAl(secilenOduncId, dtpIadeTarihi.Value,
                                               out string mesaj, out int gecikmeGun);

            MessageBox.Show(mesaj);

            if (sonuc)
            {
                // Grid'i yenile → iade edilen kitap listeden düşsün
                dgvIadeler.DataSource = oduncYonetimi.TumAktifOduncleriGetir();
                dgvIadeler.ClearSelection();

                secilenOduncId = 0;
                
            }
        }
    }
}
