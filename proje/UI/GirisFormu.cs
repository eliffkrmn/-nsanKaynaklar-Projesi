using proje.BLL;
using proje.ENTITY;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace proje.UI
{
    public partial class GirisFormu : Form
    {
        PersonelYoneticisi personelBLL = new PersonelYoneticisi();

        public GirisFormu()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                Personel kullanici = personelBLL.GirisYap(txtKullaniciAdi.Text, txtSifre.Text);

                if (kullanici != null)
                {
                    MessageBox.Show($"Hoşgeldiniz {kullanici.Ad} {kullanici.Soyad}");

                    this.Hide(); 

                    if (kullanici.Yetki == Roller.Yonetici)
                    {
                        AnaMenuForm anaMenu = new AnaMenuForm(kullanici); ;
                        anaMenu.Show();
                    }
                    else if (kullanici.Yetki == Roller.IK_Personeli)
                    {
                        AnaMenuForm anaMenu = new AnaMenuForm(kullanici);
                        anaMenu.Show();
                    }
                    else 
                    {
                        AnaMenuForm anaMenu = new AnaMenuForm(kullanici);
                        anaMenu.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}