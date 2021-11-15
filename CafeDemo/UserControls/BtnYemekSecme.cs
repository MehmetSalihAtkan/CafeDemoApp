using System;
using System.Windows.Forms;

namespace CafeOtomasyonuApp.UserControls
{

    public partial class BtnYemekSecme : UserControl
    {
        public BtnYemekSecme()
        {
            InitializeComponent();
        }
        public string YemekIsmi
        {
            set => txtYemek.Text = "Ali Baba";
            get => txtYemek.Text;
        }

        public string Fiyat
        {
            set => txtFiyat.Text = "14.10";
            get => txtFiyat.Text;
        }

        public int Adet = 0;
        public void btnArttir_Click(object sender, EventArgs e)
        {
            Adet = Adet + 1;
            MessageBox.Show($"Yeni Siparis Adedi: {Adet}");

        }

        public void btnAzalt_Click(object sender, EventArgs e)
        {
            if (Adet >= 1)
            {
                Adet--;
                MessageBox.Show($"Yeni Siparis Adedi: {Adet}");
            }
            else   
                MessageBox.Show("Ürün adedi: 0");
        }
    }
}