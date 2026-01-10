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
using System.Drawing.Drawing2D;

namespace Kutuphane.UI.Forms
{
    public partial class frmUyeEkle : Form
    {
        private DataTable _dtKullanicilar;
        private List<Kullanici> _tumKullanicilar;
        private OgrenciYonetimi _uye = new OgrenciYonetimi();
        private int secilenId = 0;
        public frmUyeEkle()
        {
            InitializeComponent();
            uyelerDgv.AutoGenerateColumns = true;

            this.Load += frmUyeEkle_Load;
            kulNoAraTxt.TextChanged += kulNoAraTxt_TextChanged;
        }

        private void frmUyeEkle_Load(object sender, EventArgs e)
        {
            //UyeleriYukle();
            //uyelerDgv.ClearSelection();
            //uyelerDgv.DataSource = _uye.UyeleriGetir();
            _dtKullanicilar = _uye.UyeleriOduncIcinGetir();
            uyelerDgv.AutoGenerateColumns = true;
            uyelerDgv.DataSource = _dtKullanicilar;
            uyelerDgv.ClearSelection();
            KolDuz();
            ButtonStyle(silBtn);
            ButtonStyle(kaydetBtn);
            ButtonStyle(temizleBtn);
            ButtonStyle(guncelleBtn);
            #region dgvrenkayarlari
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
        private void KolDuz()
        {
            if (uyelerDgv.Columns["Id"] != null) uyelerDgv.Columns["Id"].HeaderText = "Kullanıcı ID";
            if (uyelerDgv.Columns["kulNo"] != null) uyelerDgv.Columns["kulNo"].HeaderText = "Kullanıcı No";
            if (uyelerDgv.Columns["kulAdi"] != null)
                uyelerDgv.Columns["kulAdi"].Visible = false;
            if (uyelerDgv.Columns["kulSoyad"] != null)
                uyelerDgv.Columns["kulSoyad"].Visible = false;
            if (uyelerDgv.Columns["AdSoyad"] != null) uyelerDgv.Columns["AdSoyad"].HeaderText = "Ad Soyad";
            if (uyelerDgv.Columns["telNo"] != null) uyelerDgv.Columns["telNo"].HeaderText = "Telefon No";
            if (uyelerDgv.Columns["ePosta"] != null) uyelerDgv.Columns["ePosta"].HeaderText = "E-Posta";
        }
        private void UyeleriYukle()
        {
            uyelerDgv.DataSource = _uye.UyeleriGetir();
            uyelerDgv.ClearSelection();
            secilenId = 0;
        }
        private void TextleriTemizle()
        {
            kulNoTxt.Clear();
            kulAdiTxt.Clear();
            kulSoyadiTxt.Clear();
            telNoTxt.Clear();
            ePostaTxt.Clear();
            sifreTxt.Clear();
            uyelikTarihiDtp.Value = DateTime.Now;
            secilenId = 0;
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            var uye = new Kullanici()
            {
                KulNo = kulNoTxt.Text.Trim(),
                KulAdi = kulAdiTxt.Text.Trim(),
                KulSoyadi = kulSoyadiTxt.Text.Trim(),
                TelNo = telNoTxt.Text.Trim(),
                Eposta = ePostaTxt.Text.Trim(),
                UyelikTarihi = uyelikTarihiDtp.Value,
                Sifre = sifreTxt.Text.Trim(),
                Rol = "Uye"
            };
            if (_uye.UyeEkle(uye, out string mesaj))
            {
                UyeleriYukle();
                TextleriTemizle();
            }
            MessageBox.Show(mesaj);
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {

            var uye = new Kullanici()
            {
                Id = secilenId,
                KulNo = kulNoTxt.Text.Trim(),
                KulAdi = kulAdiTxt.Text.Trim(),
                KulSoyadi = kulSoyadiTxt.Text.Trim(),
                TelNo = telNoTxt.Text.Trim(),
                Eposta = ePostaTxt.Text.Trim(),
                UyelikTarihi = uyelikTarihiDtp.Value,
                Sifre = sifreTxt.Text.Trim(),
                Rol = "Uye"
            };
            if (_uye.UyeGuncelle(uye, out string mesaj))
            {
                UyeleriYukle();
                TextleriTemizle();
            }
            MessageBox.Show(mesaj);
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            if (secilenId == 0)
            {
                MessageBox.Show("Lütfen tablodan bir üye seçin.");
                return;
            }
            if (MessageBox.Show("Bu üyeyi silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_uye.UyeSil(secilenId, out string mesaj))
                {
                    UyeleriYukle();
                    TextleriTemizle();
                }
                MessageBox.Show(mesaj);
            }
        }

        private void temizleBtn_Click(object sender, EventArgs e)
        {
            TextleriTemizle();
        }

        private void uyelerDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = uyelerDgv.Rows[e.RowIndex];

            secilenId = Convert.ToInt32(row.Cells["Id"].Value);
            kulNoTxt.Text = row.Cells["kulNo"].Value.ToString();
            kulAdiTxt.Text = row.Cells["kulAdi"].Value.ToString();
            kulSoyadiTxt.Text = row.Cells["kulSoyad"].Value.ToString();
            telNoTxt.Text = row.Cells["telNo"].Value.ToString();
            ePostaTxt.Text = row.Cells["ePosta"].Value.ToString();
            if (row.Cells["uyelikTarihi"].Value != DBNull.Value)
            {
                uyelikTarihiDtp.Value = Convert.ToDateTime(row.Cells["uyelikTarihi"].Value);
            }
        }

        private void yenileBtn_Click(object sender, EventArgs e)
        {
            //string araNo = kulNoAraTxt.Text.Trim();
            //uyelerDgv.DataSource = _uye.KulNoAra(araNo);
            //uyelerDgv.ClearSelection();
            kulNoAraTxt.Clear();
            secilenId = 0;
        }

        private void kulNoAraTxt_TextChanged(object sender, EventArgs e)
        {
            if (_dtKullanicilar == null) return;

            string q = kulNoAraTxt.Text.Trim().Replace("'", "''"); // tek tırnak kaçışı

            if (string.IsNullOrWhiteSpace(q))
                _dtKullanicilar.DefaultView.RowFilter = "";
            else
                _dtKullanicilar.DefaultView.RowFilter =
    $"kulNo LIKE '%{q}%' OR kulAdi LIKE '%{q}%' OR kulSoyad LIKE '%{q}%'";
        }
    }
}
