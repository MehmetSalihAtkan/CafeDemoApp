using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeDemo.Formlar
{
    public partial class FrmRaporlar : Form
    {
        public FrmRaporlar()
        {
            InitializeComponent();
        }

        private void FrmRaporlar_Load(object sender, EventArgs e)
        {
            listView1.Items[0].Selected = true;
            SayfaBilgisiAl();
            ToplamAl();
        }
        private void ToplamAl()
        {
            decimal toplam = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                toplam += Convert.ToDecimal(listView1.Items[i].SubItems[2].Text);
            }
            txtToplam.Text = toplam.ToString("#,###.00 TL");
        }

        private void btnBaskiOnizleme_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void btnilkKayit_Click(object sender, EventArgs e)
        {
            listView1.Items[0].Selected = true;
            listView1.Focus();
            SayfaBilgisiAl();
        }
        private void SayfaBilgisiAl()
        {
            lblKonum.Text = (listView1.SelectedIndices[0] + 1).ToString() + "/" + listView1.Items.Count.ToString();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices[0] > 0)
            {
                listView1.Items[listView1.SelectedIndices[0] - 1].Selected = true;
            }
            listView1.Focus();
            SayfaBilgisiAl();
        }

        private void btnileri_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices[0] < listView1.Items.Count - 1)
            {
                listView1.Items[listView1.SelectedIndices[0] + 1].Selected = true;
            }
            listView1.Focus();
            SayfaBilgisiAl();
        }

        private void btnSonKayit_Click(object sender, EventArgs e)
        {
            listView1.Items[listView1.Items.Count - 1].Selected = true;
            listView1.Focus();
            SayfaBilgisiAl();
        }
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            SayfaBilgisiAl();
        }

        private void listView1_KeyUp(object sender, KeyEventArgs e)
        {
            SayfaBilgisiAl();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSayfaAyarlari_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void btnYazdır_Click(object sender, EventArgs e)
        {
            DialogResult pdr = printDialog1.ShowDialog();
            if (pdr == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Yazı fontumu ve çizgi çizmek için fırçamı ve kalem nesnemi oluşturdum
            Font myFont = new Font("Calibri", 28);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black);

            e.Graphics.DrawImage(Properties.Resources.logo, 60, 70);


            //Bu kısımda sipariş formu yazısını ve çizgileri yazdırıyorum
            e.Graphics.DrawLine(myPen, 120, 320, 750, 320);
            e.Graphics.DrawLine(myPen, 120, 380, 750, 380);
            e.Graphics.DrawString("WİSSEN BİSTRO SİPARİŞ FORMU", myFont, sbrush, 180, 320);

            
            e.Graphics.DrawString("Güle Güle Tekrar Bekleriz  :)", myFont, sbrush, 150, 1020);

            e.Graphics.DrawLine(myPen, 120, 520, 750, 520);

            myFont = new Font("Arial", 21, FontStyle.Underline);
            sbrush = new SolidBrush(Color.Red);

            e.Graphics.DrawString($"Tarih={DateTime.Now.ToString("dd.MM.yyyy HH.mm.ss")}", myFont, sbrush, 450, 50);

            myFont = new Font("Calibri", 16, FontStyle.Bold);
            sbrush = new SolidBrush(Color.Black);
            e.Graphics.DrawString("Adet", myFont, sbrush, 125, 528);
            e.Graphics.DrawString("Ürün Adı", myFont, sbrush, 220, 528);
            e.Graphics.DrawString("Birim Fiyatı", myFont, sbrush, 460, 528);
            e.Graphics.DrawString("Fiyat", myFont, sbrush, 640, 528);



            myFont = new Font("Calibri", 14, FontStyle.Bold);
            sbrush = new SolidBrush(Color.Black);
            e.Graphics.DrawLine(myPen, 120, 555, 750, 555);

            int y = 560;

            StringFormat myStringFormat = new StringFormat();
            myStringFormat.Alignment = StringAlignment.Far;

            decimal gTotal = 0;

            foreach (ListViewItem lvi in listView1.Items)
            {
                e.Graphics.DrawString(lvi.SubItems[1].Text, myFont, sbrush, 160, y, myStringFormat);
                e.Graphics.DrawString(lvi.Text, myFont, sbrush, 220, y);
                decimal bFiyat = Convert.ToDecimal(lvi.SubItems[2].Text);
                decimal fiyat = Convert.ToDecimal(lvi.SubItems[1].Text) * Convert.ToDecimal(lvi.SubItems[2].Text);
                gTotal += fiyat;
                e.Graphics.DrawString(bFiyat.ToString("c"), myFont, sbrush, 530, y, myStringFormat);
                e.Graphics.DrawString(fiyat.ToString("c"), myFont, sbrush, 700, y, myStringFormat);

                y += 20;

            }

            e.Graphics.DrawLine(myPen, 120, y, 750, y);
            e.Graphics.DrawString(gTotal.ToString("c"), myFont, sbrush, 700, y + 10, myStringFormat);




        }
    }
}
