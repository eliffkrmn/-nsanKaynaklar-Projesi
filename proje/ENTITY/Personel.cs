using System;

namespace proje.ENTITY
{
    public class Personel : BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }     
        public string TCKimlikNo { get; set; }
        public decimal Maas { get; set; }     
        public int DepartmanId { get; set; }
        public Roller Yetki { get; set; }
        
        public string AdSoyad { get { return Ad + " " + Soyad; } }

        public override string ToString()
        {
            return Ad + " " + Soyad;
        }
    }
}