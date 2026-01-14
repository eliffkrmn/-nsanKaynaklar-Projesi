using proje.DAL;
using proje.ENTITY;
using System.Collections.Generic;
using System;

namespace proje.BLL
{
    public class MaasYoneticisi
    {
        MaasDeposu depo = new MaasDeposu();

        public List<Maas> Listele()
        {
            return depo.Listele();
        }

        public void MaasEkle(Maas m)
        {
            if (m.Tutar <= 0)
                throw new Exception("Maaş tutarı 0'dan büyük olmalıdır.");

            depo.Ekle(m);
        }
    }
}