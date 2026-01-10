using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Kutuphane.UI.Forms
{
    public partial class AdminForm : Form
    {
        private Form _aktifForm;
        public void IcerikAc(Form frm)
        {
            if(_aktifForm != null)
            {
                _aktifForm.Close();
            }
            _aktifForm = frm;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnlFormAcici.Controls.Clear();
            pnlFormAcici.Controls.Add(frm);
            pnlFormAcici.Tag = frm;
            frm.Show();
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public AdminForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            navPnl.Height = kitapAraBtn.Height;
            navPnl.Top = kitapAraBtn.Top;
            navPnl.Left = kitapAraBtn.Left;
            //kitapAraBtn.BackColor = Color.AliceBlue;

            this.pnlFormAcici.Controls.Clear();
            frmKitapAra frmkitapara = new frmKitapAra() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmkitapara.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormAcici.Controls.Add(frmkitapara);
            frmkitapara.Show();
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GorevliForm_Load(object sender, EventArgs e)
        {

        }


        private void kitapAraBtn_Click(object sender, EventArgs e)
        {
            navPnl.Height = kitapAraBtn.Height;
            navPnl.Top = kitapAraBtn.Top;
            navPnl.Left = kitapAraBtn.Left;
            kitapAraBtn.BackColor = Color.AliceBlue;

            this.pnlFormAcici.Controls.Clear();
            frmKitapAra frmkitapara = new frmKitapAra() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmkitapara.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormAcici.Controls.Add(frmkitapara);
            frmkitapara.Show();
        }
        private void kitapAraBtn_Leave(object sender, EventArgs e)
        {
            kitapAraBtn.BackColor = Color.Navy;
        }
        private void kitapOduncVerBtn_Click_1(object sender, EventArgs e)
        {
            kitapOduncVerBtn.BackColor = Color.AliceBlue;
            navPnl.Height = kitapOduncVerBtn.Height;
            navPnl.Top = kitapOduncVerBtn.Top;
            navPnl.Left = kitapOduncVerBtn.Left;

            this.pnlFormAcici.Controls.Clear();
            frmKitapOduncVer frmkitapoduncver = new frmKitapOduncVer() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmkitapoduncver.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormAcici.Controls.Add(frmkitapoduncver);
            frmkitapoduncver.Show();
        }
        private void kitapOduncVerBtn_Leave(object sender, EventArgs e)
        {
            kitapOduncVerBtn.BackColor = Color.Navy;
        }

        private void kitapIadeAlBtn_Click_1(object sender, EventArgs e)
        {
            navPnl.Height = kitapIadeAlBtn.Height;
            navPnl.Top = kitapIadeAlBtn.Top;
            navPnl.Left = kitapIadeAlBtn.Left;
            kitapIadeAlBtn.BackColor = Color.AliceBlue;
            this.pnlFormAcici.Controls.Clear();
            frmKitapIadeAl frmkitapiadeal = new frmKitapIadeAl() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmkitapiadeal.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormAcici.Controls.Add(frmkitapiadeal);
            frmkitapiadeal.Show();
        }
        private void kitapIadeAlBtn_Leave(object sender, EventArgs e)
        {
            kitapIadeAlBtn.BackColor = Color.Navy;
        }

        private void kitapEkleBtn_Click(object sender, EventArgs e)
        {
            kitapEkleBtn.BackColor = Color.AliceBlue;
            navPnl.Height = kitapEkleBtn.Height;
            navPnl.Top = kitapEkleBtn.Top;
            navPnl.Left = kitapEkleBtn.Left;
            this.pnlFormAcici.Controls.Clear();
            frmKitapEkle frmkitapekle = new frmKitapEkle() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmkitapekle.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormAcici.Controls.Add(frmkitapekle);
            frmkitapekle.Show();
        }

        private void uyeEkleBtn_Click(object sender, EventArgs e)
        {
            uyeEkleBtn.BackColor = Color.AliceBlue;
            navPnl.Height = uyeEkleBtn.Height;
            navPnl.Top = uyeEkleBtn.Top;
            navPnl.Left = uyeEkleBtn.Left;
            this.pnlFormAcici.Controls.Clear();
            frmUyeEkle frmuyeekle = new frmUyeEkle() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmuyeekle.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormAcici.Controls.Add(frmuyeekle);
            frmuyeekle.Show();
        }

        private void kitapEkleBtn_Leave(object sender, EventArgs e)
        {            
            kitapEkleBtn.BackColor = Color.Navy;
        }

        private void uyeEkleBtn_Leave(object sender, EventArgs e)
        {
            uyeEkleBtn.BackColor = Color.Navy;
        }

        private void raporlarBtn_Leave(object sender, EventArgs e)
        {
            raporlarBtn.BackColor = Color.Navy;
        }

        private void raporlarBtn_Click(object sender, EventArgs e)
        {
            raporlarBtn.BackColor = Color.AliceBlue;
            navPnl.Height = raporlarBtn.Height;
            navPnl.Top = raporlarBtn.Top;
            navPnl.Left = raporlarBtn.Left;
            this.pnlFormAcici.Controls.Clear();
            //frmRaporlar frmraporlar = new frmRaporlar() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //frmraporlar.FormBorderStyle = FormBorderStyle.None;
            //this.pnlFormAcici.Controls.Add(frmraporlar);
            //frmraporlar.Show();
            IcerikAc(new frmRaporlar(this));
        }


        private void panel2_Leave(object sender, EventArgs e)
        {

        }

        private void pnlFormAcici_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
