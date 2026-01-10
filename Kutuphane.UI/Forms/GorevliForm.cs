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
    public partial class GorevliForm : Form
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
        public GorevliForm()
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

        private void GorevliForm_Load(object sender, EventArgs e)
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


        private void kitapOduncVerBtn_Click(object sender, EventArgs e)
        {
            navPnl.Height = kitapOduncVerBtn.Height;
            navPnl.Top = kitapOduncVerBtn.Top;
            navPnl.Left = kitapOduncVerBtn.Left;
            kitapOduncVerBtn.BackColor = Color.FromArgb(18, 18, 24);

            this.pnlFormAcici.Controls.Clear();
            frmKitapOduncVer frmkitapoduncver = new frmKitapOduncVer() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmkitapoduncver.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormAcici.Controls.Add(frmkitapoduncver);
            frmkitapoduncver.Show();

        }

        private void kitapIadeAlBtn_Click(object sender, EventArgs e)
        {
            navPnl.Height = kitapIadeAlBtn.Height;
            navPnl.Top = kitapIadeAlBtn.Top;
            navPnl.Left = kitapIadeAlBtn.Left;
            kitapIadeAlBtn.BackColor = Color.FromArgb(18, 18, 24);
            this.pnlFormAcici.Controls.Clear();
            frmKitapIadeAl frmkitapiadeal = new frmKitapIadeAl() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmkitapiadeal.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormAcici.Controls.Add(frmkitapiadeal);
            frmkitapiadeal.Show();
        }
        private void kitapAraBtn_Leave(object sender, EventArgs e)
        {
            kitapAraBtn.BackColor = Color.FromArgb(0, 122, 255);
        }
        private void kitapOduncVerBtn_Leave(object sender, EventArgs e)
        {
            kitapOduncVerBtn.BackColor = Color.FromArgb(0, 122, 255);
        }

        private void kitapIadeAlBtn_Leave(object sender, EventArgs e)
        {
            kitapIadeAlBtn.BackColor = Color.FromArgb(0, 122, 255);
        }

        private void pnlFormAcici_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
