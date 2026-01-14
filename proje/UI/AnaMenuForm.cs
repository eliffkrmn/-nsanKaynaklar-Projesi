using proje.ENTITY;
using System;
using System.Windows.Forms;

namespace proje.UI
{
    public partial class AnaMenuForm : Form
    {
        Personel? _girisYapanPersonel;

        public AnaMenuForm(Personel personel)
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
            _girisYapanPersonel = personel;
        }

        public AnaMenuForm()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
        }

        private void AnaMenuForm_Load(object sender, EventArgs e)
        {
            if (_girisYapanPersonel != null)
            {
                this.Text = "Hoşgeldiniz: " + _girisYapanPersonel.Ad + " " + _girisYapanPersonel.Soyad;

                YetkiKontrolu();
            }
        }

        void YetkiKontrolu()
        {
            btnPersonelYonetimi.Visible = false;
            btnDepartmanYonetimi.Visible = false;
            btnPerformans.Visible = false;
            btnIzinIslemleri.Visible = false;
            btnMaas.Visible = false;      
            btnRaporlar.Visible = false;  

            if (_girisYapanPersonel.Yetki == Roller.Yonetici)
            {
                btnPersonelYonetimi.Visible = true;
                btnDepartmanYonetimi.Visible = true; 
                btnPerformans.Visible = true;
                btnIzinIslemleri.Visible = true;
                btnMaas.Visible = true;
                btnRaporlar.Visible = true;
            }

            else if (_girisYapanPersonel.Yetki == Roller.IK_Personeli)
            {
                btnPersonelYonetimi.Visible = true;  
                btnDepartmanYonetimi.Visible = true; 
                btnIzinIslemleri.Visible = true;     
                btnPerformans.Visible = true;        

            }

            else
            {
                btnIzinIslemleri.Visible = true; 

            }
        }

        private void btnDepartmanYonetimi_Click(object sender, EventArgs e)
        {
            DepartmanYonetimFormu frm = new DepartmanYonetimFormu();
            frm.ShowDialog(); 
        }

        private void btnPersonelYonetimi_Click(object sender, EventArgs e)
        {
            PersonelYonetimFormu frm = new PersonelYonetimFormu();
            frm.ShowDialog();
        }

        private void btnIzinIslemleri_Click(object sender, EventArgs e)
        {
            IzinFormu frm = new IzinFormu();
            frm.KullaniciBilgisiAl(_girisYapanPersonel); 
            frm.ShowDialog();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            RaporFormu frm = new RaporFormu();
            frm.ShowDialog();
        }

        private void btnPerformans_Click(object sender, EventArgs e)
        {
            PerformansFormu frm = new PerformansFormu();
            frm.ShowDialog();
        }
        private void btnMaas_Click(object sender, EventArgs e)
        {
            MaasHesaplamaFormu frm = new MaasHesaplamaFormu();
            frm.ShowDialog();
        }
        private void btnOturumuKapat_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Oturumu kapatmak istediğinize emin misiniz?", "Çıkış Yapılıyor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                Application.Exit();

            }
        }
    }
}