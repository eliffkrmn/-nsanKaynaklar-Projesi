using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proje.BLL;    
using proje.ENTITY; 
using proje.DAL; 

namespace proje.UI
{
    public partial class PerformansFormu : Form
    {
        PersonelYoneticisi personelYoneticisi = new PersonelYoneticisi();

        public PerformansFormu()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
        }

        private void PerformansFormu_Load(object sender, EventArgs e)
        {
            PersonelleriDoldur();
            PerformanslariListele();
        }

        void PersonelleriDoldur()
        {
            List<Personel> liste = personelYoneticisi.PersonelleriListele();

            cmbPersonel.DataSource = liste;
            cmbPersonel.DisplayMember = "AdSoyad";       
            cmbPersonel.ValueMember = "Id"; 

            cmbPersonel.SelectedIndex = -1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbPersonel.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen puan verilecek personeli seçin.");
                return;
            }

            Personel secilen = (Personel)cmbPersonel.SelectedItem;
            
            Performans p = new Performans();
            p.PersonelId = secilen.Id;
            p.Puan = (int)numPuan.Value;
            p.DegerlendirmeNotu = "-"; // txtNot text box'ı formda olmadığı için varsayılan değer atandı

            PerformansDeposu dal = new PerformansDeposu();
            dal.Ekle(p);

            MessageBox.Show("Performans puanı veritabanına kaydedildi.");
            PerformanslariListele();
        }

        void PerformanslariListele()
        {
            lstPerformanslar.Items.Clear();
            PerformansDeposu dal = new PerformansDeposu();
            List<Performans> liste = dal.TumunuListele();

            foreach (var item in liste)
            {
                lstPerformanslar.Items.Add($"{item.PersonelAdSoyad} - Puan: {item.Puan} ({item.OlusturmaTarihi.ToShortDateString()})");
            }

        }

        private void cmbPersonel_SelectedIndexChanged(object sender, EventArgs e) { }
        private void numPuan_ValueChanged(object sender, EventArgs e) { }
        private void txtNot_TextChanged(object sender, EventArgs e) { }
        private void lstPerformanslar_SelectedIndexChanged(object sender, EventArgs e) { }

        private void lstPerformanslar_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
