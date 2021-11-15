using CafeOtomasyonuApp.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeDemoLib.Sınıflar;
using System;
using System.Collections.Generic;

namespace CafeOtomasyonuApp.Formlar
{
    public partial class FrmSiparis : Form
    {
        public FrmSiparis()
        {
            InitializeComponent();
        }

        private void FrmSiparis_Load(object sender, EventArgs e)
        {
            // kategori olusturma
            //int masaSayisi = 100; // Masaların sayısı buradan alınacak
            int kategoriPanelWidth = flwLytPnlKategori.Width - 30;
            int kategoriPanelHeight = 100;

            int MasaNo = this.MdiParent.Controls.Count;
            for (int i = 1; i <= MasaNo; i++)
            {
                Button btnKategori = new Button();
                btnKategori.Name = "btnKategori" + i;
                btnKategori.Text = "Kategori - " + i;        
                btnKategori.Size = new Size(kategoriPanelWidth, kategoriPanelHeight);
                flwLytPnlKategori.Controls.Add(btnKategori);
                btnKategori.Click += BtnKategori_Click; // siparis adeti girme
            }
            // fis olusturma

        }


        public void BtnKategori_Click(object sender, EventArgs e)
        {
            int yemekPanelGenisligi = flwLytYemekEkleme.Width/3 - 15;
            int yemekPanelUzunlugu = 120;
                BtnYemekSecme btnYemekSecme = new BtnYemekSecme();
                btnYemekSecme.Name = "btnYemek";
                btnYemekSecme.Text = "Mercimek";
                btnYemekSecme.Size = new Size(yemekPanelGenisligi, yemekPanelUzunlugu);
                flwLytYemekEkleme.Controls.Add(btnYemekSecme);
            BtnEklenenUrun btnEklenenUrun = new BtnEklenenUrun();
            btnEklenenUrun.Size = new Size(flwLytYemekEklemeEkrani.Width-15, 45);
            flwLytYemekEklemeEkrani.Controls.Add(btnEklenenUrun);
            
            BtnEklenenUrun btnEklenenUrun2 = new BtnEklenenUrun();
            btnEklenenUrun2.Size = new Size(flwLytYemekEklemeEkrani.Width - 15, 45);
            btnEklenenUrun2.BackColor = Color.LightBlue;
            flwLytYemekEklemeEkrani.Controls.Add(btnEklenenUrun2);
        }


    }
}
