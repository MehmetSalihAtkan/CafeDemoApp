using CafeDemoLib.Models;
using System;
using System.Windows.Forms;

namespace CafeOtomasyonuApp.UserControls
{
    public delegate void ArttirClicked(object sender, EventArgs e);
    public delegate void AzaltClicked(object sender, EventArgs e);
    public partial class BtnEklenenUrun : UserControl
    {

        public BtnEklenenUrun()
        {
            InitializeComponent();
        }
        public string SiparisIsmi
        {
            get => txtSiparisIsmi.Text;
            set => txtSiparisIsmi.Text = value;
        }
        public int _Adet = 1;
        public int Adet
        {
            get => int.Parse(txtUrunAdet.Text);
            set => txtUrunAdet.Text = _Adet.ToString();
        }
        public decimal BirimFiyat { get; set; }

        public decimal _ToplamTutar;
        public decimal ToplamTutar
        {
            get => BirimFiyat * Adet;
        }
        public event ArttirClicked ArttirClicked;
        public void btnYemekAdetArttir_Click(object sender, EventArgs e)
        {
            _Adet++;
            txtUrunAdet.Text = _Adet.ToString();
            _ToplamTutar = _Adet * BirimFiyat;
            txtUrunToplamTutar.Text = ToplamTutar.ToString();
            ArttirClicked?.Invoke(this, e);
        }
        public event AzaltClicked AzaltClicked;
        public void btnYemekAdetAzalt_Click(object sender, EventArgs e)
        {
            if (_Adet > 1)
            {
                _Adet--;
                txtUrunAdet.Text = _Adet.ToString();
                _ToplamTutar = _Adet * BirimFiyat;
                txtUrunToplamTutar.Text = ToplamTutar.ToString();
                AzaltClicked?.Invoke(sender, e);
            }

            else return;

        }
    }
}
