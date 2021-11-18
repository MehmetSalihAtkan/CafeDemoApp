using CafeDemoLib.Models;
using CafeDemoLib.Sınıflar;
using CafeOtomasyonuApp.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CafeOtomasyonuApp.Formlar
{


    public partial class FrmSiparis : Form
    {
        public FrmSiparis()
        {
            InitializeComponent();
        }

        private Button seciliKategoriButonu;

        private List<SiparisDetay> Siparisler = new List<SiparisDetay>();

        public int masaNumarası;

        private List<Kategori> Kategoriler = new List<Kategori>();
        Kategori kategori1 = new Kategori()
        {
            Adi = "Çorbalar",
            Durum = true
        };
        Kategori kategori2 = new Kategori()
        {
            Adi = "Tatlılar",
            Durum = true
        };
        Kategori kategori3 = new Kategori()
        {
            Adi = "İçecekler",
            Durum = true
        };


        private List<UrunAyar> _urunler = new List<UrunAyar>();
        UrunAyar urun1 = new UrunAyar()
        {
            Kategori = "Çorbalar",
            UrunAdi = "Mercimek Çorbası",
            BirimFiyat = 5

        };
        UrunAyar urun2 = new UrunAyar()
        {
            Kategori = "Çorbalar",
            UrunAdi = "Tavuk Çorbası",
            BirimFiyat = 10

        };
        UrunAyar urun3 = new UrunAyar()
        {
            Kategori = "İçecekler",
            UrunAdi = "Kola",
            BirimFiyat = 2
        };
        UrunAyar urun4 = new UrunAyar()
        {

            Kategori = "İçecekler",
            UrunAdi = "Ayran",
            BirimFiyat = 3
        };


        private void FrmSiparis_Load(object sender, EventArgs e)
        {
            // kategori olusturma
            Kategoriler.Add(kategori1);
            Kategoriler.Add(kategori2);
            Kategoriler.Add(kategori3);
            _urunler.Add(urun1);
            _urunler.Add(urun2);
            _urunler.Add(urun3);
            _urunler.Add(urun4);
            txtMasaNumarasi.Text = masaNumarası.ToString();


            int kategoriPanelWidth = flwLytPnlKategori.Width - 30;
            int kategoriPanelHeight = 100;

            for (int i = 0; i < Kategoriler.Count; i++)
            {
                if (!Kategoriler[i].Durum)
                    continue;
                Button btnKategori = new Button();
                btnKategori.Name = "btnKategori" + i; // 2 heceliyse patlar degistir
                btnKategori.Text = Kategoriler[i].Adi;
                btnKategori.Size = new Size(kategoriPanelWidth, kategoriPanelHeight);
                flwLytPnlKategori.Controls.Add(btnKategori);
                btnKategori.Click += BtnKategori_Click; // siparis adeti girme
            }

        }

        public void BtnKategori_Click(object sender, EventArgs e)
        {
            this.flwLytYemekEkleme.Controls.Clear();

            seciliKategoriButonu = sender as Button;

            int yemekPanelGenisligi = flwLytYemekEkleme.Width / 3 - 15;
            int yemekPanelUzunlugu = 120;

            for (int i = 0; i < _urunler.Count; i++)
            {
                if (seciliKategoriButonu.Text != _urunler[i].Kategori)
                    continue;
                BtnYemekSecme btnYemekSecme = new BtnYemekSecme();
                btnYemekSecme.Name = "btn" + _urunler[i].UrunAdi;
                btnYemekSecme.Size = new Size(yemekPanelGenisligi, yemekPanelUzunlugu);
                flwLytYemekEkleme.Controls.Add(btnYemekSecme);
                btnYemekSecme.YemekIsmi = _urunler[i].UrunAdi;
                btnYemekSecme.Fiyat = _urunler[i].BirimFiyat.ToString();
                //  btnYemekSecme.btnYemekSiparis.Tag = _urunler[i];
                btnYemekSecme.OrderClicked += BtnYemekSecme_OrderClicked;
            }
        }
        decimal toplamTutar = 0;
        public void BtnYemekSecme_OrderClicked(object sender, EventArgs e)
        {
            var secilenYemek = sender as Button;
            for (int i = 0; i < _urunler.Count; i++)
            {
                if (secilenYemek.Text != _urunler[i].UrunAdi)
                    continue;
                BtnEklenenUrun btnYeniUrun = new BtnEklenenUrun();
                btnYeniUrun.Size = new Size(flwLytYemekEklemeEkrani.Width - 30, 45);
                flwLytYemekEklemeEkrani.Controls.Add(btnYeniUrun);
                btnYeniUrun.txtSiparisIsmi.Text = _urunler[i].UrunAdi;
                btnYeniUrun.BirimFiyat = _urunler[i].BirimFiyat;
                btnYeniUrun.txtUrunToplamTutar.Text = (_urunler[i].BirimFiyat * btnYeniUrun.Adet).ToString();
                btnYeniUrun.ArttirClicked += BtnYeniUrun_ArttirClicked;
                btnYeniUrun.AzaltClicked += BtnYeniUrun_AzaltClicked;
                toplamTutar += int.Parse(btnYeniUrun.txtUrunToplamTutar.Text);
            }
            ToplamHesapla();
        }

        private void BtnYeniUrun_ArttirClicked(object sender, EventArgs e)
        {
            ToplamHesapla();

        }

        private void ToplamHesapla()
        {
            decimal total = 0;
            foreach (BtnEklenenUrun item in flwLytYemekEklemeEkrani.Controls)
            {
                total += item.ToplamTutar;
            }
            toplamTutar = total;
            txtToplamTutar.Text = toplamTutar.ToString();
        }

        private void BtnYeniUrun_AzaltClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
