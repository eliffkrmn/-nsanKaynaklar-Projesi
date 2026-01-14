namespace proje.ENTITY
{
    public class Maas : BaseEntity
    {
        public int PersonelId { get; set; } 
        public decimal Tutar { get; set; }  
        public string Donem { get; set; }   

        public string PersonelAdSoyad { get; set; }
    }
}