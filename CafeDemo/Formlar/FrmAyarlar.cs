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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                nudFiyat.Enabled = true;
            }
            else
            {
                nudFiyat.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                numericUpDown1.Enabled = true;
            }
            else
            {
                numericUpDown1.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                numericUpDown.Enabled = true;
            }
            else
            {
                numericUpDown.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                numericUpDown3.Enabled = true;
            }
            else
            {
                numericUpDown3.Enabled = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                numericUpDown4.Enabled = true;
            }
            else
            {
                numericUpDown4.Enabled = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                numericUpDown5.Enabled = true;
            }
            else
            {
                numericUpDown5.Enabled = false;
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

        private void btnKaydetDuzen_Click(object sender, EventArgs e)
        {
            //for (int i = 1; i < 7; i++)
            //{
            //    KatDuzen kd = new KatDuzen();
            //    kd.Adi = checkBox[i].Text;
            //    kd.KatNo =[i];
            //    kd.MasaSayisi =Convert.ToInt32(numericUpDown[i].Value);
            //    kd.Durum = checkBox[i].Checked;                
            //}   
        }
    }
}

