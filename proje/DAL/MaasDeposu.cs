using MySql.Data.MySqlClient;
using proje.ENTITY;
using System.Collections.Generic;
using System;

namespace proje.DAL
{
    public class MaasDeposu
    {
            baglantiGetir db = new baglantiGetir();

        public List<Maas> Listele()
        {
            List<Maas> liste = new List<Maas>();
            using (MySqlConnection conn = db.BaglantiGetir())
            {
                string sql = "SELECT m.*, p.Ad, p.Soyad FROM Maaslar m JOIN Personeller p ON m.PersonelId = p.Id WHERE m.SilindiMi=0";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    liste.Add(new Maas
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        PersonelId = Convert.ToInt32(dr["PersonelId"]),
                        Tutar = Convert.ToDecimal(dr["Tutar"]),
                        Donem = dr["Donem"].ToString(),
                        OlusturmaTarihi = Convert.ToDateTime(dr["OlusturmaTarihi"]),
                        PersonelAdSoyad = dr["Ad"].ToString() + " " + dr["Soyad"].ToString()
                    });
                }
            }
            return liste;
        }

        public void Ekle(Maas m)
        {
            using (MySqlConnection conn = db.BaglantiGetir())
            {
                string sql = "INSERT INTO Maaslar (PersonelId, Tutar, Donem) VALUES (@pId, @tutar, @donem)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pId", m.PersonelId);
                cmd.Parameters.AddWithValue("@tutar", m.Tutar);
                cmd.Parameters.AddWithValue("@donem", m.Donem);
                cmd.ExecuteNonQuery();
            }
        }
    }
}