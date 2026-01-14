using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using proje.ENTITY;

namespace proje.DAL
{
    public class PerformansDeposu
    {
        baglantiGetir db = new baglantiGetir();

        public List<Performans> TumunuListele()
        {
            List<Performans> liste = new List<Performans>();
            using (MySqlConnection conn = db.BaglantiGetir())
            {
                string sql = "SELECT per.*, p.Ad, p.Soyad FROM Performanslar per JOIN Personeller p ON per.PersonelId = p.Id WHERE per.SilindiMi=0";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    liste.Add(new Performans
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        PerformansId = Convert.ToInt32(dr["Id"]),
                        PersonelId = Convert.ToInt32(dr["PersonelId"]),
                        Puan = dr["Puan"] != DBNull.Value ? Convert.ToInt32(dr["Puan"]) : 0,
                        DegerlendirmeNotu = dr["DegerlendirmeNotu"] != DBNull.Value ? dr["DegerlendirmeNotu"].ToString() : "",
                        PersonelAdSoyad = dr["Ad"].ToString() + " " + dr["Soyad"].ToString(),
                        SilindiMi = Convert.ToBoolean(dr["SilindiMi"]),
                        OlusturmaTarihi = Convert.ToDateTime(dr["OlusturmaTarihi"])
                    });
                }
            }
            return liste;
        }

        public void Ekle(Performans p)
        {
            using (MySqlConnection conn = db.BaglantiGetir())
            {
                string sql = "INSERT INTO Performanslar (PersonelId, Puan, DegerlendirmeNotu, OlusturmaTarihi, SilindiMi) VALUES (@pId, @puan, @not, @tarih, 0)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pId", p.PersonelId);
                cmd.Parameters.AddWithValue("@puan", p.Puan);
                cmd.Parameters.AddWithValue("@not", p.DegerlendirmeNotu);
                cmd.Parameters.AddWithValue("@tarih", DateTime.Now);
                cmd.ExecuteNonQuery();
            }
        }
    }
}