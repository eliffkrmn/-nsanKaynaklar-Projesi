using proje.DAL;
using proje.ENTITY;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;

namespace proje.BLL
{
    public class DepartmanYoneticisi
    {
        DepartmanDeposu depo = new DepartmanDeposu();

        public List<Departman> DepartmanlariGetir()
        {
            return depo.DepartmanListele();
        }

        public async Task<List<Departman>> DepartmanlariGetirAsync()
        {
            return await depo.DepartmanListeleAsync();
        }

        public void Ekle(string ad, string aciklama)
        {
            if (string.IsNullOrWhiteSpace(ad))
            {
                throw new Exception("Departman adı boş olamaz!");
            }

            Departman d = new Departman();
            d.Ad = ad;
            d.Aciklama = aciklama;

            depo.DepartmanEkle(d);
        }
    }
}