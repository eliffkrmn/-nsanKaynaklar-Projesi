using proje.DAL;
using proje.ENTITY;
using System.Collections.Generic;
using System.Linq; 

namespace proje.BLL
{
    public class RaporlamaYoneticisi
    {
        PersonelDeposu personelDeposu = new PersonelDeposu();

        public List<Personel> DepartmanaGorePersonelGetir(int departmanId)
        {
            List<Personel> tumPersoneller = personelDeposu.TumunuListele();

            return tumPersoneller.Where(p => p.DepartmanId == departmanId).ToList();
        }

        public List<Personel> YuksekMaasliPersoneller(decimal limit)
        {
            return personelDeposu.TumunuListele().Where(p => p.Maas > limit).ToList();
        }
    }
}