using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kutuphane.DAL;
using Kutuphane.Entities;
using System.Data;


namespace Kutuphane.BLL
{   
    public class KullaniciYonetimi
    {
        private readonly KullaniciDAL _kullaniciDal;
        public KullaniciYonetimi()
        {
            _kullaniciDal = new KullaniciDAL();
        }
        public Kullanici GirisYap(string kulNo, string sifre)
        {
            if (string.IsNullOrWhiteSpace(kulNo) || string.IsNullOrWhiteSpace(sifre))
            {
                return null; // Kullanıcı adı veya şifre boşsa null döner
            }
            return _kullaniciDal.GirisYap(kulNo.Trim(), sifre.Trim());
        }
        
    }
}