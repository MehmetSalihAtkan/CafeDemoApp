
using System;
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
        private void FrmMasalar_Load(object sender, EventArgs e)
        {                
            
            int masaSayisi = 100; // Masaların sayısı buradan alınacak
            for (int i = 1; i <= masaSayisi; i++)
            {

                Button btn = new Button();
                btn.Name = "btnMasa" + i;
                btn.Text = "MASA - " + i;
                btn.Size = new Size(150, 150);
                flwLytPnlMasa.Controls.Add(btn);
                btn.Click += Btn_Click;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {

            FrmSiparis frmSiparis = new FrmSiparis();
            frmSiparis.MdiParent = Application.OpenForms["Form1"];
            frmSiparis.Show();

        }
    }
}
