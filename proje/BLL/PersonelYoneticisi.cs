using proje.DAL;
using proje.ENTITY;
using System.Collections.Generic;
using System;

namespace proje.BLL
{
    public class PersonelYoneticisi
    {
        PersonelDeposu depo = new PersonelDeposu();

        public Personel GirisYap(string kAdi, string sifre)
        {
            if (string.IsNullOrEmpty(kAdi) || string.IsNullOrEmpty(sifre))
                throw new Exception("Bilgiler boş olamaz");
            return depo.KullaniciKontrol(kAdi, sifre);
        }

        public List<Personel> PersonelleriListele()
        {
            return depo.TumunuListele();
        }

        public int PersonelEkle(Personel p)
        {
            if (p.Maas < 0) throw new Exception("Maaş 0'dan küçük olamaz");
            return depo.Ekle(p);
        }

        public void PersonelMaasGuncelle(int id, decimal yeniMaas)
        {
            if (yeniMaas < 0) throw new Exception("Maaş 0'dan küçük olamaz");
            depo.MaasGuncelle(id, yeniMaas);
        }
    }
}