using CafeDemo.Formlar;
using CafeDemoLib.Models;
using CafeOtomasyonuApp.Formlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kapatmak istediğinize emin misiniz? ", "Uygulamayı Kapatmak Üzeresiniz!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private FrmMasalar _frmMasalar;
        private void btnMasalar_Click(object sender, EventArgs e)
        {
            if (_frmMasalar == null || _frmMasalar.IsDisposed)
                _frmMasalar = new FrmMasalar();
            _frmMasalar.MdiParent = this;
            if (Application.OpenForms["FrmRaporlar"] != null)
                _frmRaporlar.Close();
            if (Application.OpenForms["FrmAyarlar"] != null)
                _frmAyarlar.Close();
                _frmMasalar.Show();
        }
        private FrmAyarlar _frmAyarlar;
        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            if (_frmAyarlar == null || _frmAyarlar.IsDisposed)
                _frmAyarlar = new FrmAyarlar();
            _frmAyarlar.MdiParent = this;
            if (Application.OpenForms["FrmMasalar"] != null)
                _frmMasalar.Close();
            if (Application.OpenForms["FrmRaporlar"] != null)
                _frmRaporlar.Close();
            _frmAyarlar.Show();
        }
        private FrmRaporlar _frmRaporlar;
        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            if (_frmRaporlar == null || _frmRaporlar.IsDisposed)
                _frmRaporlar = new FrmRaporlar();
            _frmRaporlar.MdiParent = this;
            if (Application.OpenForms["FrmMasalar"] != null)
                _frmMasalar.Close();
            if (Application.OpenForms["FrmAyarlar"] != null)
                _frmAyarlar.Close();
            _frmRaporlar.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
