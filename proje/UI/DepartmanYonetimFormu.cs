using proje.BLL;
using proje.ENTITY;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace proje.UI
{
    public partial class DepartmanYonetimFormu : Form
    {
        DepartmanYoneticisi bll = new DepartmanYoneticisi();

        public DepartmanYonetimFormu()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
        }

        private async void DepartmanYonetimFormu_Load(object sender, EventArgs e)
        {
            await ListeleAsync();
        }

        async Task ListeleAsync()
        {
            try
            {
                gridDepartmanlar.DataSource = await bll.DepartmanlariGetirAsync();

                if (gridDepartmanlar.Columns["SilindiMi"] != null)
                    gridDepartmanlar.Columns["SilindiMi"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                bll.Ekle(txtAd.Text, txtAciklama.Text);

                MessageBox.Show("Departman Başarıyla Eklendi.");

                txtAd.Clear();
                txtAciklama.Clear();

                await ListeleAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}