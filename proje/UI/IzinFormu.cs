using System;
using System.Windows.Forms;
using proje.ENTITY;
using proje.DAL;

namespace proje.UI
{
    public partial class IzinFormu : Form
    {
        Personel? _aktifKullanici;
        IzinDeposu izinDal = new IzinDeposu();

        public IzinFormu()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
        }

        public void KullaniciBilgisiAl(Personel p)
        {
            _aktifKullanici = p;
        }

        private void IzinFormu_Load(object sender, EventArgs e)
        {
            if (_aktifKullanici == null)
            {
                MessageBox.Show("HATA: Kullanıcı bilgisi gelmedi!");
                return;
            }

            gridIzinler.AutoGenerateColumns = true;

            GridGuncelle();

            if (_aktifKullanici.Yetki == Roller.Yonetici)
            {
                grpTalepOlustur.Visible = true; 
                
                dtpBaslangic.Visible = false;
                dtpBitis.Visible = false;
                txtAciklama.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                btnTalepEt.Visible = false;

                btnOnayla.Visible = true;
                btnReddet.Visible = true;
                
                gridIzinler.Visible = true;
            }
            else
            {
                grpTalepOlustur.Visible = true;
                
                dtpBaslangic.Visible = true;
                dtpBitis.Visible = true;
                txtAciklama.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                btnTalepEt.Visible = true;

                btnOnayla.Visible = false;
                btnReddet.Visible = false;
            }
        }

        private void GridGuncelle()
        {
            try
            {
                if (_aktifKullanici != null && _aktifKullanici.Yetki == Roller.Yonetici)
                {
                    var liste = izinDal.BekleyenleriGetir();

                    BindingSource bs = new BindingSource();
                    bs.DataSource = liste;
                    gridIzinler.DataSource = bs;

                    if (gridIzinler.Columns["PersonelId"] != null)
                        gridIzinler.Columns["PersonelId"].Visible = false;

                    if (gridIzinler.Columns["PersonelAdSoyad"] != null)
                    {
                        gridIzinler.Columns["PersonelAdSoyad"].HeaderText = "Personel";
                        gridIzinler.Columns["PersonelAdSoyad"].DisplayIndex = 0;
                    }
                }
                else if (_aktifKullanici != null)
                {
                    gridIzinler.DataSource = izinDal.PersonelIzinleriniGetir(_aktifKullanici.Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnTalepEt_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAciklama.Text)) return;
            Izin i = new Izin();
            i.PersonelId = _aktifKullanici.Id;
            i.BaslangicTarihi = dtpBaslangic.Value;
            i.BitisTarihi = dtpBitis.Value;
            i.Aciklama = txtAciklama.Text;
            izinDal.IzinIste(i);
            MessageBox.Show("Kayıt Başarılı");
            GridGuncelle();
        }

        private void btnOnayla_Click(object sender, EventArgs e) { IslemYap(2); }
        private void btnReddet_Click(object sender, EventArgs e) { IslemYap(3); }

        void IslemYap(int durumKodu)
        {
            int id = 0;

            if (gridIzinler.SelectedRows.Count > 0)
            {
                id = Convert.ToInt32(gridIzinler.SelectedRows[0].Cells["IzinId"].Value);
            }
            else if (gridIzinler.CurrentRow != null)
            {
                id = Convert.ToInt32(gridIzinler.CurrentRow.Cells["IzinId"].Value);
            }

            if (id > 0)
            {
                izinDal.DurumGuncelle(id, durumKodu);
                GridGuncelle();
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir kayıt seçiniz.");
            }
        }

        private void gridIzinler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}