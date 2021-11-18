using System;
using System.Windows.Forms;

namespace CafeOtomasyonuApp.UserControls
{
    public delegate void OrderClicked(object sender, EventArgs e);

    public partial class BtnYemekSecme : UserControl
    {
        public BtnYemekSecme()
        {
            InitializeComponent();
        }
        public string YemekIsmi
        {
            get => btnYemekSiparis.Text;
            set => btnYemekSiparis.Text = value;
        }
        public string Fiyat
        {
            get => txtFiyat.Text;
            set => txtFiyat.Text = value + " ₺";
        }
        public event OrderClicked OrderClicked;
        public void btnYemekSiparis_Click(object sender, EventArgs e)
        {

            OrderClicked?.Invoke(sender, e);
        }

    }
}