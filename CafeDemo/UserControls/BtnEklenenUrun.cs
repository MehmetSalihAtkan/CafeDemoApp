using CafeDemoLib.Models;
using System;
using System.Windows.Forms;

namespace CafeOtomasyonuApp.UserControls
{
    public partial class BtnEklenenUrun : UserControl
    {
        
        public int _Adet;
        public BtnEklenenUrun()
        {
            InitializeComponent();
        }

        public string SiparisIsmi
        {
            get => txtSiparisIsmi.Text;
            set => txtSiparisIsmi.Text = value;
        }
        public int Adet
        {
            get => int.Parse(txtUrunAdet.Text);
            set => txtUrunAdet.Text = _Adet.ToString();
        }
        public decimal BirimFiyat { get; set; }

        public decimal _ToplamTutar;
        public decimal ToplamTutar
        {
            get => _ToplamTutar;
            set => txtUrunToplamTutar.Text = value.ToString();
        }

        public void btnYemekAdetArttir_Click(object sender, EventArgs e)
        {
            _Adet++;
            txtUrunAdet.Text = _Adet.ToString();
            _ToplamTutar = _Adet * BirimFiyat;
            txtUrunToplamTutar.Text = ToplamTutar.ToString();
        }

        public void btnYemekAdetAzalt_Click(object sender, EventArgs e)
        {
            if (_Adet > 1)
            {
                _Adet--;
                txtUrunAdet.Text = _Adet.ToString();
                _ToplamTutar = _Adet * BirimFiyat;
                txtUrunToplamTutar.Text = ToplamTutar.ToString();
            }

            else return;
            
        }
    }
}
