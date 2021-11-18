using CafeDemoLib.Models;
using CafeDemoLib.Sınıflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeDemo.Formlar
{
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }

        private void btnUrunResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "Bir fotoğraf seçiniz";
            dialog.Filter = "Resim Dosyaları | *.jpeg; *.jpg";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pbUrun.ImageLocation = dialog.FileName;
                pbUrun.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void btnKategoriResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "Bir fotoğraf seçiniz";
            dialog.Filter = "Resim Dosyaları | *.jpeg; *.jpg";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pbKategori.ImageLocation = dialog.FileName;
            }
        }

        

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            string urunAd = txtUrunAdi.Text.Trim();
            UrunAyar yeniUrun = new UrunAyar()
            {
                UrunAdi = urunAd,
                BirimFiyat = nudFiyat.Value,
                Kategori = cmbKategorisi.Text,
                Durum = cbUrunAktifMi.Checked

            };
            if (pbUrun.Image != null)
            {
                MemoryStream resimStream = new MemoryStream();
                pbUrun.Image.Save(resimStream, ImageFormat.Jpeg);

                yeniUrun.Resim = resimStream.ToArray();
            }
            AyarlarContext.Urunler.Add(yeniUrun);
            UrunDoldur();
        }

        private void UrunDoldur()
        {
            dgUrun.DataSource = null;
            dgUrun.DataSource = AyarlarContext.Urunler;
            dgUrun.Columns["UrunId"].Visible = false;
        }

        private UrunAyar _seciliUrun;
        private void dgUrun_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string deger = dgUrun.CurrentRow.Cells["UrunId"].Value.ToString();

            _seciliUrun = AyarlarContext.Urunler.Where(x => x.UrunId == deger).First() as UrunAyar;
            txtUrunAdi.Text = _seciliUrun.UrunAdi;
            cmbKategorisi.Text = _seciliUrun.Kategori;
            nudFiyat.Value = _seciliUrun.BirimFiyat;
            cbUrunAktifMi.Checked = _seciliUrun.Durum;
            if (_seciliUrun.Resim != null)
            {
                MemoryStream stream = new MemoryStream(_seciliUrun.Resim);
                pbUrun.Image = Image.FromStream(stream);
            }

        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                _seciliUrun.UrunAdi = txtUrunAdi.Text;
                _seciliUrun.Kategori = cmbKategorisi.Text;
                _seciliUrun.Durum = cbUrunAktifMi.Checked;
                _seciliUrun.BirimFiyat = nudFiyat.Value;
                if (pbUrun.Image != null)
                {
                    MemoryStream resimStream = new MemoryStream();
                    pbUrun.Image.Save(resimStream, ImageFormat.Jpeg);

                    _seciliUrun.Resim = resimStream.ToArray();
                }
            }
            catch (Exception)
            {

                throw;
            }

            UrunDoldur();

        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"{_seciliUrun.UrunAdi} adlı ürünü silmek istediğinizden emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                AyarlarContext.Urunler.Remove(_seciliUrun);
            UrunDoldur();
        }
        private void KategoriDoldur()
        {
            foreach (Kategori kategori in AyarlarContext.Kategoriler)
            {
                cmbKategorisi.Items.Add(kategori.Adi);
            }
            dgUrun.DataSource = null;
            dgUrun.DataSource = AyarlarContext.Urunler;
            dgUrun.Columns["UrunId"].Visible = false;
        }
        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            string kategoriAd = txtKategoriAdi.Text.Trim();
            Kategori yeniKategori = new Kategori()
            {
                Adi = kategoriAd,
                Durum = cbKategoriAktifMi.Checked

            };
            if (pbKategori.Image != null)
            {
                MemoryStream resimStream = new MemoryStream();
                pbKategori.Image.Save(resimStream, ImageFormat.Jpeg);

                yeniKategori.Resim = resimStream.ToArray();
            }
            AyarlarContext.Kategoriler.Add(yeniKategori);
            KategoriDoldur();
        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"{_seciliKategori.Adi} adlı kategoriyi silmek istediğinizden emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                AyarlarContext.Kategoriler.Remove(_seciliKategori);
            KategoriDoldur();

        }

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                _seciliKategori.Adi = txtKategoriAdi.Text;
                _seciliKategori.Durum = cbKategoriAktifMi.Checked;
                if (pbKategori.Image != null)
                {
                    MemoryStream resimStream = new MemoryStream();
                    pbKategori.Image.Save(resimStream, ImageFormat.Jpeg);

                    _seciliKategori.Resim = resimStream.ToArray();
                }
            }
            catch (Exception)
            {

                throw;
            }

            KategoriDoldur();

        }
        private Kategori _seciliKategori;
        private void dgKategori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string deger = dgKategori.CurrentRow.Cells["KategoriId"].Value.ToString();

            _seciliKategori = AyarlarContext.Kategoriler.Where(x => x.KategoriId == deger).First() as Kategori;
            txtKategoriAdi.Text = _seciliKategori.Adi;


            cbKategoriAktifMi.Checked = _seciliKategori.Durum;
            if (_seciliKategori.Resim != null)
            {
                MemoryStream stream = new MemoryStream(_seciliKategori.Resim);
                pbKategori.Image = Image.FromStream(stream);
            }
        }

        private void btnKaydetIletisim_Click(object sender, EventArgs e)
        {
            RestoranIletisim restoranIletisim = new RestoranIletisim();
            restoranIletisim.SirketAdi = txtRestoranAdi.Text;
            restoranIletisim.Telefon = txtTelefon.Text;
            restoranIletisim.Adres = txtAdres.Text;
        }
        KatDuzen _seciliRestoranDuzeni;
        
        private void btnBolumEkle_Click(object sender, EventArgs e)
        {
            string bolumAdi = restoranBolum1.BolumAdi.Trim();
            KatDuzen yeniKatDuzen = new KatDuzen()
            {
                Adi = bolumAdi,
                Durum = restoranBolum1.Durum,
                MasaSayisi =Convert.ToInt32(restoranBolum1.MasaSayisi)
            };
            AyarlarContext.Katlar.Add(yeniKatDuzen);
            KatDuzenDoldur();
            KatDuzenTemizle();
        }

        private void lstBolumler_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstBolumler.SelectedItem == null) return;
            _seciliRestoranDuzeni = lstBolumler.SelectedItem as KatDuzen;
            restoranBolum1.BolumAdi = _seciliRestoranDuzeni.Adi;
            restoranBolum1.MasaSayisi = _seciliRestoranDuzeni.MasaSayisi;
            restoranBolum1.Durum = _seciliRestoranDuzeni.Durum;
        }
        private void KatDuzenDoldur()
        {
            lstBolumler.Items.Clear();
            foreach (KatDuzen kat in AyarlarContext.Katlar)
            {
                lstBolumler.Items.Add(kat.ToString());
            }
           
        }
        private void KatDuzenTemizle()
        {
            restoranBolum1.BolumAdi = string.Empty;
            restoranBolum1.Durum = false;
            restoranBolum1.MasaSayisi = string.Empty;

        }
    }
}