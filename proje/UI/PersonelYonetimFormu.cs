using proje.BLL;
using proje.ENTITY;
using System;
using System.Windows.Forms;

namespace proje.UI
{
    public partial class PersonelYonetimFormu : Form
    {
        PersonelYoneticisi personelBLL = new PersonelYoneticisi();
        DepartmanYoneticisi departmanBLL = new DepartmanYoneticisi();

        public PersonelYonetimFormu()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);

            try
            {
                DepartmanlariDoldur();
                PersonelleriListele();
                RolleriDoldur();
            }
            catch (Exception)
            {
            }
        }

        private void PersonelYonetimFormu_Load(object sender, EventArgs e)
        {
        }

        void DepartmanlariDoldur()
        {
            cmbDepartman.DataSource = null;
            cmbDepartman.Items.Clear();

            var departmanlar = departmanBLL.DepartmanlariGetir();

            cmbDepartman.DataSource = departmanlar;
            cmbDepartman.DisplayMember = "Ad";
            cmbDepartman.ValueMember = "Id";
        }

        void RolleriDoldur()
        {
            cmbRol.Items.Clear();
            cmbRol.Items.Add("Yönetici");
            cmbRol.Items.Add("İK Personeli");
            cmbRol.Items.Add("Normal Kullanıcı");
        }

        void PersonelleriListele()
        {
            gridPersoneller.DataSource = null;
            gridPersoneller.DataSource = personelBLL.PersonelleriListele();

            if (gridPersoneller.Columns["TCKimlikNo"] != null)
                gridPersoneller.Columns["TCKimlikNo"].Visible = false;

            if (gridPersoneller.Columns["Id"] != null)
                gridPersoneller.Columns["Id"].Visible = false;

            if (gridPersoneller.Columns["Sifre"] != null)
                gridPersoneller.Columns["Sifre"].Visible = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDepartman.Items.Count == 0)
                {
                    MessageBox.Show("Sistemde hiç departman yok! Lütfen önce Departman Yönetimi sayfasından departman ekleyiniz.");
                    return;
                }

                if (cmbDepartman.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen listeden bir Departman seçiniz.");
                    return;
                }

                if (cmbRol.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir Rol seçiniz.");
                    return;
                }

                Personel p = new Personel();
                p.Ad = txtAd.Text;
                p.Soyad = txtSoyad.Text;
                p.KullaniciAdi = txtKullaniciAdi.Text;
                p.Sifre = txtSifre.Text;
                p.Maas = numMaas.Value;

                int depId;
                bool idOkunduMu = int.TryParse(cmbDepartman.SelectedValue.ToString(), out depId);

                if (idOkunduMu)
                    p.DepartmanId = depId;
                else
                {
                    MessageBox.Show("Departman ID okunamadı. Lütfen tekrar seçim yapın.");
                    return;
                }

                string secilenRol = cmbRol.SelectedItem.ToString();
                if (secilenRol == "Yönetici") p.Yetki = Roller.Yonetici;
                else if (secilenRol == "İK Personeli") p.Yetki = Roller.IK_Personeli;
                else p.Yetki = Roller.Normal_Kullanici;

                int yeniId = personelBLL.PersonelEkle(p);
                
                // Otomatik Maaş Kaydı Oluştur (O anki ay için)
                MaasYoneticisi maasBLL = new MaasYoneticisi();
                Maas m = new Maas();
                m.PersonelId = yeniId;
                m.Tutar = p.Maas;
                m.Donem = DateTime.Now.ToString("MMMM yyyy"); // Örn: "Ocak 2026"
                maasBLL.MaasEkle(m);

                MessageBox.Show("✅ Personel ve İlk Dönem Maaşı Başarıyla Kaydedildi!");
                PersonelleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}