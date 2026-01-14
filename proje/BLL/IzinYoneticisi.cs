using System;
using System.Collections.Generic;
using proje.ENTITY;

namespace proje.BLL
{
    public class IzinYoneticisi
    {
        static List<Izin> izinler = new List<Izin>();

        public List<Izin> IzinleriListele()
        {
            return izinler;
        }

        public void IzinTalepEt(Izin yeniIzin)
        {
            TimeSpan sure = yeniIzin.BitisTarihi - yeniIzin.BaslangicTarihi;
            if (sure.TotalDays > 14)
            {
                throw new Exception("Tek seferde en fazla 14 gün izin alabilirsiniz.");
            }

            izinler.Add(yeniIzin);
        }
    }
}