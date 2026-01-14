namespace proje.ENTITY
{
    public class Performans : BaseEntity
    {
        public int PerformansId { get; set; }
        public int PersonelId { get; set; }
        public int Puan { get; set; } 
        public string DegerlendirmeNotu { get; set; }
        public string PersonelAdSoyad { get; set; }
    }
}