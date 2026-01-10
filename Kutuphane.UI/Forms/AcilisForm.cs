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
    public partial class AcilisForm : Form
    {
        public AcilisForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 10;
            if(panel2.Width >= 502)
            {
                timer1.Stop();
                LoginForm anaForm = new LoginForm();
                anaForm.Show();
                this.Hide();
            }
        }
    }
}
