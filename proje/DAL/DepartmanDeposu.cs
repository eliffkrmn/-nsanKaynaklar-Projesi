using MySql.Data.MySqlClient;
using proje.ENTITY;
using System.Collections.Generic;
using System;
using System.Data;
using System.Threading.Tasks;

namespace proje.DAL
{
    public class DepartmanDeposu
    {
        baglantiGetir db = new baglantiGetir();

        public List<Departman> DepartmanListele()
        {
            List<Departman> liste = new List<Departman>();
            using (MySqlConnection conn = db.BaglantiGetir())
            {
                string sql = "SELECT * FROM Departmanlar WHERE SilindiMi=0";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    liste.Add(new Departman
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Ad = dr["Ad"].ToString(),
                        Aciklama = dr["Aciklama"] != DBNull.Value ? dr["Aciklama"].ToString() : ""
                    });
                }
            }
            return liste;
        }

        public async Task<List<Departman>> DepartmanListeleAsync()
        {
            List<Departman> liste = new List<Departman>();
            using (MySqlConnection conn = await db.BaglantiGetirAsync())
            {
                string sql = "SELECT * FROM Departmanlar WHERE SilindiMi=0";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (var dr = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        liste.Add(new Departman
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Ad = dr["Ad"].ToString(),
                            Aciklama = dr["Aciklama"] != DBNull.Value ? dr["Aciklama"].ToString() : ""
                        });
                    }
                }
            }
            return liste;
        }

        public void DepartmanEkle(Departman dept)
        {
            using (MySqlConnection conn = db.BaglantiGetir())
            {
                string sql = "INSERT INTO Departmanlar (Ad, Aciklama) VALUES (@Ad, @Aciklama)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ad", dept.Ad);
                cmd.Parameters.AddWithValue("@Aciklama", dept.Aciklama);
                cmd.ExecuteNonQuery();
            }
        }
    }
}