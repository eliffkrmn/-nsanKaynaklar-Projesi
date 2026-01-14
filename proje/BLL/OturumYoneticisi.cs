using proje.DAL;
using proje.ENTITY;
using System;

namespace proje.BLL
{
    public class OturumYoneticisi
    {
        PersonelDeposu depo = new PersonelDeposu();

        public Personel GirisYap(string kAdi, string sifre)
        {
            if (string.IsNullOrEmpty(kAdi) || string.IsNullOrEmpty(sifre))
            {
                throw new Exception("Kullanıcı adı veya şifre boş olamaz.");
            }

            Personel p = depo.KullaniciKontrol(kAdi, sifre);
            return p;
        }
    }
}