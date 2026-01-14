using MySql.Data.MySqlClient;
using proje.ENTITY;
using System.Collections.Generic;
using System;

namespace proje.DAL
{
    public class PersonelDeposu
    {
        baglantiGetir db = new baglantiGetir();

        public Personel KullaniciKontrol(string kAdi, string sifre)
        {
            Personel p = null;
            using (MySqlConnection conn = db.BaglantiGetir())
            {
                string sql = "SELECT * FROM Personeller WHERE KullaniciAdi=@user AND Sifre=@pass AND SilindiMi=0";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", kAdi);
                cmd.Parameters.AddWithValue("@pass", sifre);

                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    p = new Personel();
                    p.Id = Convert.ToInt32(dr["Id"]);
                    p.Ad = dr["Ad"].ToString();
                    p.Soyad = dr["Soyad"].ToString();
                    p.KullaniciAdi = dr["KullaniciAdi"].ToString();
                    p.Sifre = dr["Sifre"].ToString();
                    p.Yetki = (Roller)Convert.ToInt32(dr["Yetki"]);
                }
            }
            return p;
        }

        public List<Personel> TumunuListele()
        {
            List<Personel> liste = new List<Personel>();
            using (MySqlConnection conn = db.BaglantiGetir())
            {
                string sql = "SELECT * FROM Personeller WHERE SilindiMi=0";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    liste.Add(new Personel
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Ad = dr["Ad"].ToString(),
                        Soyad = dr["Soyad"].ToString(),
                        KullaniciAdi = dr["KullaniciAdi"].ToString(),
                        Sifre = dr["Sifre"].ToString(),
                        Maas = dr["Maas"] != DBNull.Value ? Convert.ToDecimal(dr["Maas"]) : 0,
                        DepartmanId = dr["DepartmanId"] != DBNull.Value ? Convert.ToInt32(dr["DepartmanId"]) : 0,
                        Yetki = dr["Yetki"] != DBNull.Value ? (Roller)Convert.ToInt32(dr["Yetki"]) : 0,
                        TCKimlikNo = dr["TCKimlikNo"] != DBNull.Value ? dr["TCKimlikNo"].ToString() : ""
                    });
                }
            }
            return liste;
        }

        public int Ekle(Personel p)
        {
            using (MySqlConnection conn = db.BaglantiGetir())
            {
                string sql = "INSERT INTO Personeller (Ad, Soyad, KullaniciAdi, Sifre, TCKimlikNo, Maas, DepartmanId, Yetki, SilindiMi) VALUES (@Ad, @Soyad, @Kadi, @Sifre, @Tc, @Maas, @DepId, @Yetki, 0)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ad", p.Ad);
                cmd.Parameters.AddWithValue("@Soyad", p.Soyad);
                cmd.Parameters.AddWithValue("@Kadi", p.KullaniciAdi);
                cmd.Parameters.AddWithValue("@Sifre", p.Sifre);
                cmd.Parameters.AddWithValue("@Tc", p.TCKimlikNo);
                cmd.Parameters.AddWithValue("@Maas", p.Maas);
                cmd.Parameters.AddWithValue("@DepId", p.DepartmanId);
                cmd.Parameters.AddWithValue("@Yetki", (int)p.Yetki);
                cmd.ExecuteNonQuery();
                return (int)cmd.LastInsertedId;
            }
        }

        public decimal PersonelMaasGetir(int personelId)
        {
            using (var baglan = db.BaglantiGetir())
            {
                string sql = "SELECT Maas FROM Personeller WHERE Id = @id";
                MySqlCommand komut = new MySqlCommand(sql, baglan);
                komut.Parameters.AddWithValue("@id", personelId);

                object sonuc = komut.ExecuteScalar();
                return sonuc != null ? Convert.ToDecimal(sonuc) : 0;
            }
        }

        public void MaasGuncelle(int id, decimal yeniMaas)
        {
            using (MySqlConnection conn = db.BaglantiGetir())
            {
                string sql = "UPDATE Personeller SET Maas=@maas WHERE Id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@maas", yeniMaas);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}