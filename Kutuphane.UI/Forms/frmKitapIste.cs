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
    public partial class frmKitapOduncAl : Form
    {
        private readonly KitapYonetimi _kitapYonetimi;
        private List<Kitap> _tumKitaplar;
        public frmKitapOduncAl()
        {
            InitializeComponent();

        }

        private void frmKitapOduncAl_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void gonderBtn_Click(object sender, EventArgs e)
        {

            // butonun ortasını al
            int x = gonderBtn.Left + (gonderBtn.Width / 2) - (pictureBox1.Width / 2);
            int y = gonderBtn.Top - pictureBox1.Height + 10;

            pictureBox1.Location = new Point(x, y);
            pictureBox1.BringToFront();
            pictureBox1.Visible = true;

            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

            t.Interval = 2000;
            t.Tick += (s, ev) =>
            {
                pictureBox1.Visible = false;
                t.Stop();
            };
            t.Start();
        }
    }
}

