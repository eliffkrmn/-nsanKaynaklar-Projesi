using System;

namespace proje.ENTITY
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public bool SilindiMi { get; set; }

        public BaseEntity()
        {
            OlusturmaTarihi = DateTime.Now;
            SilindiMi = false;
        }
    }
}