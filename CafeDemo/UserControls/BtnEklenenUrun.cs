using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyonuApp.UserControls
{
    public partial class BtnEklenenUrun : UserControl
    {
        public int _Adet;
        public BtnEklenenUrun()
        {
            
            InitializeComponent();
            _Adet = 1;
            txtUrunAdet.Text = _Adet.ToString();
        }

        public string SiparisIsmi
        {
            get => txtSiparisIsmi.Text;
            set => txtSiparisIsmi.Text = value;
        }

        public decimal BirimFiyat { get; set; }        
        public int Adet
        {
            get
            {
                return _Adet;
            }
        }
        public decimal _Tutar; 
        public decimal Tutar
        {
            get
            {
                return _Tutar = BirimFiyat * _Adet;
            }
        }

        public decimal ToplamTutar { get; set; }
        public void btnYemekAdetArttir_Click(object sender, EventArgs e)
        {
            _Adet++;
            txtUrunAdet.Text = _Adet.ToString();
            txtUrunToplamTutar.Text = Tutar.ToString();
        }

        public void btnYemekAdetAzalt_Click(object sender, EventArgs e)
        {
            if (Adet > 1)
            {
                _Adet--;
                txtUrunAdet.Text = _Adet.ToString();
                txtUrunToplamTutar.Text = Tutar.ToString();
            }
            //else if(Adet == 0)
            //{
            //    this.Control
            //}
            else return;
            
        }
    }
}
