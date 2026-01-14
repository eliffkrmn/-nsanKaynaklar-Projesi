using System;

namespace proje.ENTITY
{
    public class Izin
    {
        public int IzinId { get; set; }
        public int PersonelId { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public string Durum { get; set; } 
        public string Aciklama { get; set; }
        public string PersonelAdSoyad { get; set; }
    }
}