using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proje.DAL;
using proje.ENTITY;

namespace proje.BLL
{
    public class PerformansYoneticisi
    {
        PerformansDeposu depo = new PerformansDeposu();

        public List<Performans> PerformanslariListele()
        {
            return depo.TumunuListele();
        }
    }
}
