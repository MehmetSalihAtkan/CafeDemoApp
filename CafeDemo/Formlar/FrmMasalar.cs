using CafeDemoLib.Models;
using CafeDemoLib.Sınıflar;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CafeOtomasyonuApp.Formlar
{
    public partial class FrmMasalar : Form
    {
        public FrmMasalar()
        {
            InitializeComponent();
        }

        private Button seciliButon;
        public int ToplamKatSayisi = 2;
        private List<Masa> Masalar = new List<Masa>();

       
        //        private List<SiparisDetay> Siparisler = new List<SiparisDetay>();
        int MasaAdeti = 20;
        string Kat = "1";
        public void FrmMasalar_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= MasaAdeti; i++)
            {
                // Yeni Masa Ekleme
                Button btn = new Button();
                btn.Name = $"btnMasa + { i }";
                btn.Text = "Masa - " + i;
                btn.Size = new Size(150, 150);
                btn.TabIndex = i;
                flwLytPnlMasa.Controls.Add(btn);
                Masa yeniMasa = new Masa()
                {
                    MasaNo = i,
                    KatNo = Kat,
                    Durum = false // Masa Boş
                };
                Masalar.Add(yeniMasa);
                yeniMasa.Durum = true;
                btn.Click += BtnMasaSiparis_Click;
            }

        }
        private void BtnMasaSiparis_Click(object sender, EventArgs e)
        {   // Seçilen butonu
            seciliButon = sender as Button;
            FrmSiparis frmSiparis = new FrmSiparis();
            frmSiparis.MdiParent = Application.OpenForms["Form1"];
            // Secili butono masa numarası atma
            frmSiparis.masaNumarası = seciliButon.TabIndex;
            
            frmSiparis.Show();
        }

    }
}