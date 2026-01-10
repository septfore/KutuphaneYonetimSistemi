using Kutuphane.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kutuphane.BLL;
using Kutuphane.Entities;

namespace Kutuphane.UI.Forms
{
    public partial class LoginForm : Form
    {
        private KullaniciYonetimi kullaniciYonetimi;
        public LoginForm()
        {
            InitializeComponent();
           kullaniciYonetimi = new KullaniciYonetimi();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kullaniciAdiTxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (kullaniciAdiTxt.Text == "Kullanıcı Numarası")
            {
                kullaniciAdiTxt.Clear();
            }
        }

        private void sifreTxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (sifreTxt.Text == "Şifre")
            {
                sifreTxt.Clear();
                sifreTxt.PasswordChar = '*';
            }
        }
        
        private void girisYapBtn_Click(object sender, EventArgs e)
        {
            
            string kulNo = kullaniciAdiTxt.Text.Trim();
            string sifre = sifreTxt.Text.Trim();
            var kullanici = kullaniciYonetimi.GirisYap(kulNo, sifre);
            if(kullanici == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(kullanici.Rol == "Admin")
            {
                Form acilacakform = new AdminForm();
                this.Hide();
                acilacakform.ShowDialog();
                this.Close();
            }
            else if(kullanici.Rol == "Uye")
            {
                Form acilacakform = new UyeForm();
                this.Hide();
                acilacakform.ShowDialog();
                this.Close();
            }
            else if(kullanici.Rol == "Gorevli")
            {
                Form acilacakform = new GorevliForm();
                this.Hide();
                acilacakform.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bilinmeyen rol: " + kullanici.Rol, "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #region eski kod
            //string kullaniciAdi = kullaniciAdiTxt.Text.Trim();
            //string sifre = sifreTxt.Text.Trim();

            //var girisSonucu = kullaniciYonetimi.GirisYap(kullaniciAdi, sifre);
            //if(!girisSonucu.Basarili)
            //{
            //    MessageBox.Show(girisSonucu.Mesaj, "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}   
            //var kullanici = girisSonucu.Kullanici;
            //Form acilacakform = null;
            //switch(kullanici.Rol)
            //{
            //    case "Admin":
            //        acilacakform = new AdminForm();
            //        break;
            //    case "Kullanici":
            //        acilacakform = new UyeForm();
            //        break;
            //    case "Gorevli":
            //    acilacakform = new GorevliForm();
            //    break;

            //        default:
            //        MessageBox.Show("Bilinmeyen rol: " + kullanici.Rol, "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //}
            //this.Hide();
            //acilacakform.ShowDialog();
            //this.Close();
            #endregion
        }
    }
    }


