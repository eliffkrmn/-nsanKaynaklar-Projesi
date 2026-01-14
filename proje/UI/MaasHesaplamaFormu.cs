using proje.BLL;
using proje.ENTITY;
using System;
using System.Windows.Forms;
using proje.DAL;

namespace proje.UI
{
    public partial class MaasHesaplamaFormu : Form
    {
        MaasYoneticisi maasBLL = new MaasYoneticisi();
        PersonelYoneticisi personelBLL = new PersonelYoneticisi();

        public MaasHesaplamaFormu()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
            cmbPersonel.SelectedIndexChanged += cmbPersonel_SelectedIndexChanged;
        }

        private void MaasHesaplamaFormu_Load(object sender, EventArgs e)
        {
            PersonelleriDoldur();
            Listele();
        }

        void PersonelleriDoldur()
        {
            cmbPersonel.DataSource = personelBLL.PersonelleriListele();
            cmbPersonel.DisplayMember = "AdSoyad"; 
            cmbPersonel.ValueMember = "Id";   
        }

        void Listele()
        {
            gridMaaslar.DataSource = maasBLL.Listele();

            if (gridMaaslar.Columns["PersonelId"] != null)
                gridMaaslar.Columns["PersonelId"].Visible = false;

            if (gridMaaslar.Columns["Id"] != null)
                gridMaaslar.Columns["Id"].Visible = false;

            if (gridMaaslar.Columns["PersonelAdSoyad"] != null)
            {
                gridMaaslar.Columns["PersonelAdSoyad"].HeaderText = "Personel";
                gridMaaslar.Columns["PersonelAdSoyad"].DisplayIndex = 0;
            }
        }

        private void cmbPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPersonel.SelectedValue != null && int.TryParse(cmbPersonel.SelectedValue.ToString(), out int pId))
            {
                // Veritabanından en güncel maaşı çek
                PersonelDeposu pd = new PersonelDeposu();
                decimal guncelMaas = pd.PersonelMaasGetir(pId);

                lblTemelMaas.Text = "Mevcut Maaş: " + guncelMaas.ToString("C2");
                numMaas.Value = guncelMaas > numMaas.Minimum ? guncelMaas : numMaas.Minimum;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPersonel.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen bir personel seçin.");
                    return;
                }

                Maas m = new Maas();
                m.PersonelId = (int)cmbPersonel.SelectedValue; 
                m.Donem = txtDonem.Text;
                m.Tutar = numMaas.Value;

                maasBLL.MaasEkle(m);

                personelBLL.PersonelMaasGuncelle(m.PersonelId, m.Tutar);

                MessageBox.Show("Maaş ödemesi başarıyla kaydedildi ve personelin güncel maaşı yenilendi.");
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}