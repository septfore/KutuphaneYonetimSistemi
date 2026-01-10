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
    public partial class UyeForm : Form
    {
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
        public UyeForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            navPnl.Height = kitapAraBtn.Height;
            navPnl.Top = kitapAraBtn.Top;
            navPnl.Left = kitapAraBtn.Left;
            kitapAraBtn.BackColor = Color.FromArgb(18, 18, 24);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void navPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UyeForm_Load(object sender, EventArgs e)
        {

        }

        private void kitapAraBtn_Click(object sender, EventArgs e)
        {
            navPnl.Height = kitapAraBtn.Height;
            navPnl.Top = kitapAraBtn.Top;
            navPnl.Left = kitapAraBtn.Left;
            kitapAraBtn.BackColor = Color.FromArgb(18, 18, 24);

            this.pnlFormAcici.Controls.Clear();
            frmKitapAra frmkitapara = new frmKitapAra() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmkitapara.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormAcici.Controls.Add(frmkitapara);
            frmkitapara.Show();
        }

        private void kitapOduncAlBtn_Click(object sender, EventArgs e)
        {
            navPnl.Height = kitapOduncAlBtn.Height;
            navPnl.Top = kitapOduncAlBtn.Top;
            navPnl.Left = kitapOduncAlBtn.Left;
            kitapOduncAlBtn.BackColor = Color.FromArgb(18, 18, 24);

            this.pnlFormAcici.Controls.Clear();
            frmKitapOduncAl frmkitapoduncal = new frmKitapOduncAl() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmkitapoduncal.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormAcici.Controls.Add(frmkitapoduncal);
            frmkitapoduncal.Show();
        }

        private void kitapAraBtn_Leave(object sender, EventArgs e)
        {
            kitapAraBtn.BackColor = Color.FromArgb(0, 122, 255);
        }

        private void kitapOduncAlBtn_Leave(object sender, EventArgs e)
        {
            kitapOduncAlBtn.BackColor = Color.FromArgb(0, 122, 255);
        }

        private void pnlFormAcici_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
