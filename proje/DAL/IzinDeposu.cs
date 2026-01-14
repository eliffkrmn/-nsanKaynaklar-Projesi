using MySql.Data.MySqlClient;
using proje.ENTITY;
using System.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace proje.DAL
{
    public class IzinDeposu
    {
        baglantiGetir db = new baglantiGetir();

        public void IzinIste(Izin izin)
        {
            using (MySqlConnection conn = db.BaglantiGetir())
            {
                string sql = "INSERT INTO Izinler (PersonelId, BaslangicTarihi, BitisTarihi, Aciklama, Durum) " +
                           "VALUES (@pId, @bas, @bit, @aciklama, 0)";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@pId", izin.PersonelId);
                    cmd.Parameters.AddWithValue("@bas", izin.BaslangicTarihi);
                    cmd.Parameters.AddWithValue("@bit", izin.BitisTarihi);
                    cmd.Parameters.AddWithValue("@aciklama", izin.Aciklama);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Izin> BekleyenleriGetir()
        {
            List<Izin> liste = new List<Izin>();
            using (var baglan = db.BaglantiGetir())
            {
                string sql = "SELECT i.*, p.Ad, p.Soyad FROM Izinler i JOIN Personeller p ON i.PersonelId = p.Id WHERE i.Durum = 0";
                MySqlCommand komut = new MySqlCommand(sql, baglan);

                try
                {
                    MySqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        Izin i = new Izin();
                        i.IzinId = Convert.ToInt32(dr["Id"]);
                        i.PersonelId = Convert.ToInt32(dr["PersonelId"]);
                        i.BaslangicTarihi = Convert.ToDateTime(dr["BaslangicTarihi"]);
                        i.BitisTarihi = Convert.ToDateTime(dr["BitisTarihi"]);
                        i.Aciklama = dr["Aciklama"].ToString();
                        i.PersonelAdSoyad = dr["Ad"].ToString() + " " + dr["Soyad"].ToString();

                        i.Durum = "Onay Bekliyor";
                        liste.Add(i);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sorgu Hatası: " + ex.Message);
                }
            }
            return liste;
        }

        public DataTable TumIzinleriGetir()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = db.BaglantiGetir())
            {
                string sql = "SELECT p.Ad, p.Soyad, " +
                           "DATE_FORMAT(i.BaslangicTarihi, '%d.%m.%Y') as Baslangic, " +
                           "DATE_FORMAT(i.BitisTarihi, '%d.%m.%Y') as Bitis, " +
                           "CASE i.Durum " +
                           "  WHEN 0 THEN 'Bekliyor' " +
                           "  WHEN 1 THEN 'Reddedildi' " + 
                           "  WHEN 2 THEN 'Onaylandı' " + 
                           "  WHEN 3 THEN 'Reddedildi' " +
                           "  ELSE 'Belirsiz' END as DurumMetni, " +
                           "i.Aciklama " +
                           "FROM Izinler i " +
                           "LEFT JOIN Personeller p ON i.PersonelId = p.Id";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public void DurumGuncelle(int izinId, int yeniDurum)
        {
            using (MySqlConnection conn = db.BaglantiGetir())
            {
                string sql = "UPDATE Izinler SET Durum = @durum WHERE Id = @id";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@durum", yeniDurum);
                    cmd.Parameters.AddWithValue("@id", izinId);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Güncelleme Hatası: " + ex.Message);
                    }
                }
            }
        }

        public DataTable PersonelIzinleriniGetir(int personelId)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = db.BaglantiGetir())
            {
                try
                {
                    string sql = "SELECT BaslangicTarihi, BitisTarihi, Aciklama, " +
                               "CASE Durum " +
                               "  WHEN 0 THEN 'Bekliyor' " +
                               "  WHEN 1 THEN 'Reddedildi' " +
                               "  WHEN 2 THEN 'Onaylandı' " +
                               "  WHEN 3 THEN 'Reddedildi' " +
                               "  ELSE 'Belirsiz' END as Durum " +
                               "FROM Izinler WHERE PersonelId = @pid";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@pid", personelId);
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd)) 
                        {
                            da.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Personel izinleri getirilirken hata oluştu: " + ex.Message);
                }
            }
            return dt;
        }
    }
}