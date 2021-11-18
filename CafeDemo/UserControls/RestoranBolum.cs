using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeDemo.UserControls
{
    public partial class RestoranBolum : UserControl
    {
        public RestoranBolum()
        {
            InitializeComponent();
        }

        public string BolumAdi
        {
            get => txtBolumAdi.Text;
            set => txtBolumAdi.Text = value;
        }
        public string MasaSayisi
        {
            get =>txtMasaSayisi.Text;
            set => txtMasaSayisi.Text = value;

        }
        public bool Durum
        {
            get => cbDurum.Checked;
            set => cbDurum.Checked = value;
        }

    }
}
