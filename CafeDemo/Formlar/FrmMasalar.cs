
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
        public int KatSayisi = 2;
        private int MasaSayisi = 5;
        public List<Masa> Masalar = new List<Masa>();
        public void FrmMasalar_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < KatSayisi; i++)
            //{
                for (int i = 1; i <= MasaSayisi; i++)
                {
                    Masalar.Add
                    (
                        new Masa() {
                            MasaNo = i,
                            KatNo = "1",
                            Durum = true
                        }
                    );
                    Button btn = new Button();
                    btn.Name = "btnMasa" + i;
                    btn.Text = "Masa - " + i;
                    btn.Size = new Size(150, 150);
                    flwLytPnlMasa.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            //}
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            FrmSiparis frmSiparis = new FrmSiparis();
            Button btn = new Button();
            frmSiparis.MdiParent = Application.OpenForms["Form1"];
            frmSiparis.Show();
        }
    }
}
