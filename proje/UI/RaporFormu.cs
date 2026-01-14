using proje.BLL;
using proje.DAL;
using proje.ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace proje.UI
{
    public partial class RaporFormu : Form
    {
        PersonelDeposu personelDal = new PersonelDeposu();
        DepartmanDeposu departmanDal = new DepartmanDeposu();
        IzinDeposu izinDal = new IzinDeposu();
        PerformansDeposu performansDal = new PerformansDeposu();

        public RaporFormu()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
        }

        private void RaporFormu_Load(object sender, EventArgs e)
        {
        }

        private void btnPersonelRapor_Click(object sender, EventArgs e)
        {
            lstRapor.Items.Clear(); 
            lstRapor.Items.Add("--- TÜM PERSONEL LİSTESİ VE PERFORMANS PUANLARI ---");

            List<Personel> personelListesi = personelDal.TumunuListele();
            List<Performans> performansListesi = performansDal.TumunuListele();

            foreach (Personel p in personelListesi)
            {
                // Bu personelin son performans notunu bulalım
                var sonPerformans = performansListesi
                                    .Where(x => x.PersonelId == p.Id)
                                    .OrderByDescending(x => x.OlusturmaTarihi)
                                    .FirstOrDefault();

                string performansMetni = (sonPerformans != null) ? sonPerformans.Puan.ToString() : "Girilmedi";

                string satir = $"{p.Ad} {p.Soyad} ({p.KullaniciAdi}) - Maaş: {p.Maas} TL - Performans: {performansMetni}";
                lstRapor.Items.Add(satir);
            }
        }

        private void btnDepartmanRapor_Click(object sender, EventArgs e)
        {
            lstRapor.Items.Clear();
            lstRapor.Items.Add("--- DEPARTMAN LİSTESİ ---");

            List<Departman> liste = departmanDal.DepartmanListele();
            foreach (Departman d in liste)
            {
                string satir = $"{d.Ad} ({d.Aciklama})";
                lstRapor.Items.Add(satir);
            }
        }

        private void btnIzinRapor_Click(object sender, EventArgs e)
        {
            lstRapor.Items.Clear();
            lstRapor.Items.Add("--- İZİN GEÇMİŞİ ---");

            DataTable dt = izinDal.TumIzinleriGetir();
            foreach (DataRow row in dt.Rows)
            {
                string satir = $"{row["Ad"]} {row["Soyad"]} - {row["Baslangic"]} / {row["Bitis"]} - {row["DurumMetni"]}";
                lstRapor.Items.Add(satir);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lstRapor.Items.Clear();
        }

        private void lstRapor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}