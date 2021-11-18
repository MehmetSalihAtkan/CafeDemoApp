
namespace CafeDemo.Formlar
{
    partial class FrmAyarlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAyarlar));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tpRestoranBilgileri = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRestoranAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKaydetIletisim = new System.Windows.Forms.Button();
            this.gbRestoranDuzen = new System.Windows.Forms.GroupBox();
            this.lstBolumler = new System.Windows.Forms.ListBox();
            this.btnBolumEkle = new System.Windows.Forms.Button();
            this.btnBolumSil = new System.Windows.Forms.Button();
            this.btnBolumGuncelle = new System.Windows.Forms.Button();
            this.restoranBolum1 = new CafeDemo.UserControls.RestoranBolum();
            this.btnEkle = new System.Windows.Forms.TabControl();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnUrunResim = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.cbUrunAktifMi = new System.Windows.Forms.CheckBox();
            this.pbUrun = new System.Windows.Forms.PictureBox();
            this.cmbKategorisi = new System.Windows.Forms.ComboBox();
            this.Kategorisi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudFiyat = new System.Windows.Forms.NumericUpDown();
            this.dgUrun = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.btnKategoriResim = new System.Windows.Forms.Button();
            this.btnKategoriSil = new System.Windows.Forms.Button();
            this.btnKategoriGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.cbKategoriAktifMi = new System.Windows.Forms.CheckBox();
            this.pbKategori = new System.Windows.Forms.PictureBox();
            this.dgKategori = new System.Windows.Forms.DataGridView();
            this.btnResim = new System.Windows.Forms.TabPage();
            this.tpRestoranBilgileri.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbRestoranDuzen.SuspendLayout();
            this.btnEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUrun)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKategori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKategori)).BeginInit();
            this.btnResim.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tpRestoranBilgileri
            // 
            this.tpRestoranBilgileri.BackColor = System.Drawing.Color.Gainsboro;
            this.tpRestoranBilgileri.Controls.Add(this.gbRestoranDuzen);
            this.tpRestoranBilgileri.Controls.Add(this.groupBox1);
            this.tpRestoranBilgileri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpRestoranBilgileri.Location = new System.Drawing.Point(4, 46);
            this.tpRestoranBilgileri.Name = "tpRestoranBilgileri";
            this.tpRestoranBilgileri.Padding = new System.Windows.Forms.Padding(3);
            this.tpRestoranBilgileri.Size = new System.Drawing.Size(1236, 485);
            this.tpRestoranBilgileri.TabIndex = 2;
            this.tpRestoranBilgileri.Text = "    Restoran Bilgileri    ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btnKaydetIletisim);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtRestoranAdi);
            this.groupBox1.Location = new System.Drawing.Point(19, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 442);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restoran İletişim";
            // 
            // txtRestoranAdi
            // 
            this.txtRestoranAdi.Location = new System.Drawing.Point(291, 89);
            this.txtRestoranAdi.Name = "txtRestoranAdi";
            this.txtRestoranAdi.Size = new System.Drawing.Size(201, 43);
            this.txtRestoranAdi.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 37);
            this.label5.TabIndex = 2;
            this.label5.Text = "Adres";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(291, 153);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(201, 43);
            this.txtTelefon.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 37);
            this.label7.TabIndex = 2;
            this.label7.Text = "Telefon Numarası";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(291, 217);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(201, 80);
            this.txtAdres.TabIndex = 5;
            this.txtAdres.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Restoran Adı";
            // 
            // btnKaydetIletisim
            // 
            this.btnKaydetIletisim.BackColor = System.Drawing.Color.White;
            this.btnKaydetIletisim.ImageKey = "xcvxc.jpg";
            this.btnKaydetIletisim.ImageList = this.ımageList1;
            this.btnKaydetIletisim.Location = new System.Drawing.Point(137, 343);
            this.btnKaydetIletisim.Name = "btnKaydetIletisim";
            this.btnKaydetIletisim.Size = new System.Drawing.Size(171, 75);
            this.btnKaydetIletisim.TabIndex = 6;
            this.btnKaydetIletisim.Text = "Kaydet";
            this.btnKaydetIletisim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKaydetIletisim.UseVisualStyleBackColor = false;
            this.btnKaydetIletisim.Click += new System.EventHandler(this.btnKaydetIletisim_Click);
            // 
            // gbRestoranDuzen
            // 
            this.gbRestoranDuzen.BackColor = System.Drawing.Color.Silver;
            this.gbRestoranDuzen.Controls.Add(this.restoranBolum1);
            this.gbRestoranDuzen.Controls.Add(this.btnBolumGuncelle);
            this.gbRestoranDuzen.Controls.Add(this.btnBolumSil);
            this.gbRestoranDuzen.Controls.Add(this.btnBolumEkle);
            this.gbRestoranDuzen.Controls.Add(this.lstBolumler);
            this.gbRestoranDuzen.Location = new System.Drawing.Point(591, 18);
            this.gbRestoranDuzen.Name = "gbRestoranDuzen";
            this.gbRestoranDuzen.Size = new System.Drawing.Size(607, 442);
            this.gbRestoranDuzen.TabIndex = 7;
            this.gbRestoranDuzen.TabStop = false;
            this.gbRestoranDuzen.Text = "Restoran Düzeni";
            // 
            // lstBolumler
            // 
            this.lstBolumler.FormattingEnabled = true;
            this.lstBolumler.ItemHeight = 37;
            this.lstBolumler.Location = new System.Drawing.Point(399, 89);
            this.lstBolumler.Name = "lstBolumler";
            this.lstBolumler.Size = new System.Drawing.Size(187, 189);
            this.lstBolumler.TabIndex = 8;
            this.lstBolumler.SelectedIndexChanged += new System.EventHandler(this.lstBolumler_SelectedIndexChanged);
            // 
            // btnBolumEkle
            // 
            this.btnBolumEkle.BackColor = System.Drawing.Color.White;
            this.btnBolumEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBolumEkle.ImageKey = "gfnfgn.jpg";
            this.btnBolumEkle.ImageList = this.ımageList1;
            this.btnBolumEkle.Location = new System.Drawing.Point(84, 343);
            this.btnBolumEkle.Name = "btnBolumEkle";
            this.btnBolumEkle.Size = new System.Drawing.Size(131, 73);
            this.btnBolumEkle.TabIndex = 11;
            this.btnBolumEkle.Text = "Ekle";
            this.btnBolumEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBolumEkle.UseVisualStyleBackColor = false;
            this.btnBolumEkle.Click += new System.EventHandler(this.btnBolumEkle_Click);
            // 
            // btnBolumSil
            // 
            this.btnBolumSil.BackColor = System.Drawing.Color.White;
            this.btnBolumSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBolumSil.ImageKey = "ghfgh.png";
            this.btnBolumSil.ImageList = this.ımageList1;
            this.btnBolumSil.Location = new System.Drawing.Point(243, 343);
            this.btnBolumSil.Name = "btnBolumSil";
            this.btnBolumSil.Size = new System.Drawing.Size(109, 73);
            this.btnBolumSil.TabIndex = 10;
            this.btnBolumSil.Text = "Sil";
            this.btnBolumSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBolumSil.UseVisualStyleBackColor = false;
            // 
            // btnBolumGuncelle
            // 
            this.btnBolumGuncelle.BackColor = System.Drawing.Color.White;
            this.btnBolumGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBolumGuncelle.ImageKey = "güncelle.png";
            this.btnBolumGuncelle.ImageList = this.ımageList1;
            this.btnBolumGuncelle.Location = new System.Drawing.Point(383, 343);
            this.btnBolumGuncelle.Name = "btnBolumGuncelle";
            this.btnBolumGuncelle.Size = new System.Drawing.Size(175, 73);
            this.btnBolumGuncelle.TabIndex = 9;
            this.btnBolumGuncelle.Text = "Güncelle";
            this.btnBolumGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBolumGuncelle.UseVisualStyleBackColor = false;
            // 
            // restoranBolum1
            // 
            this.restoranBolum1.BolumAdi = "";
            this.restoranBolum1.Durum = false;
            this.restoranBolum1.Location = new System.Drawing.Point(63, 89);
            this.restoranBolum1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.restoranBolum1.MasaSayisi = "";
            this.restoranBolum1.Name = "restoranBolum1";
            this.restoranBolum1.Size = new System.Drawing.Size(300, 208);
            this.restoranBolum1.TabIndex = 12;
            // 
            // btnEkle
            // 
            this.btnEkle.Controls.Add(this.tabPage1);
            this.btnEkle.Controls.Add(this.btnResim);
            this.btnEkle.Controls.Add(this.tpRestoranBilgileri);
            this.btnEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.Location = new System.Drawing.Point(0, 0);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.SelectedIndex = 0;
            this.btnEkle.Size = new System.Drawing.Size(1244, 535);
            this.btnEkle.TabIndex = 0;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "resimsec.png");
            this.ımageList1.Images.SetKeyName(1, "ekle.png");
            this.ımageList1.Images.SetKeyName(2, "ghfgh.png");
            this.ımageList1.Images.SetKeyName(3, "gfnfgn.jpg");
            this.ımageList1.Images.SetKeyName(4, "güncelle.png");
            this.ımageList1.Images.SetKeyName(5, "resimsec.png");
            this.ımageList1.Images.SetKeyName(6, "xcvxc.jpg");
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.Color.White;
            this.btnUrunEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunEkle.ImageKey = "gfnfgn.jpg";
            this.btnUrunEkle.ImageList = this.ımageList1;
            this.btnUrunEkle.Location = new System.Drawing.Point(19, 396);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(125, 67);
            this.btnUrunEkle.TabIndex = 10;
            this.btnUrunEkle.Text = "Ekle";
            this.btnUrunEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnUrunResim
            // 
            this.btnUrunResim.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUrunResim.ForeColor = System.Drawing.Color.Black;
            this.btnUrunResim.ImageKey = "resimsec.png";
            this.btnUrunResim.ImageList = this.ımageList1;
            this.btnUrunResim.Location = new System.Drawing.Point(19, 230);
            this.btnUrunResim.Name = "btnUrunResim";
            this.btnUrunResim.Size = new System.Drawing.Size(170, 69);
            this.btnUrunResim.TabIndex = 10;
            this.btnUrunResim.Text = "RESİM";
            this.btnUrunResim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUrunResim.UseVisualStyleBackColor = false;
            this.btnUrunResim.Click += new System.EventHandler(this.btnUrunResim_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.BackColor = System.Drawing.Color.White;
            this.btnUrunSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunSil.ImageKey = "ghfgh.png";
            this.btnUrunSil.ImageList = this.ımageList1;
            this.btnUrunSil.Location = new System.Drawing.Point(168, 396);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(102, 67);
            this.btnUrunSil.TabIndex = 9;
            this.btnUrunSil.Text = "Sil";
            this.btnUrunSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrunSil.UseVisualStyleBackColor = false;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.BackColor = System.Drawing.Color.White;
            this.btnUrunGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunGuncelle.ImageKey = "güncelle.png";
            this.btnUrunGuncelle.ImageList = this.ımageList1;
            this.btnUrunGuncelle.Location = new System.Drawing.Point(318, 396);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(185, 67);
            this.btnUrunGuncelle.TabIndex = 8;
            this.btnUrunGuncelle.Text = "Güncelle";
            this.btnUrunGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrunGuncelle.UseVisualStyleBackColor = false;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ürün Adi";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(209, 30);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(229, 43);
            this.txtUrunAdi.TabIndex = 12;
            // 
            // cbUrunAktifMi
            // 
            this.cbUrunAktifMi.AutoSize = true;
            this.cbUrunAktifMi.Location = new System.Drawing.Point(220, 354);
            this.cbUrunAktifMi.Name = "cbUrunAktifMi";
            this.cbUrunAktifMi.Size = new System.Drawing.Size(120, 41);
            this.cbUrunAktifMi.TabIndex = 13;
            this.cbUrunAktifMi.Text = "Aktif Et";
            this.cbUrunAktifMi.UseVisualStyleBackColor = true;
            // 
            // pbUrun
            // 
            this.pbUrun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUrun.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbUrun.Location = new System.Drawing.Point(209, 197);
            this.pbUrun.Name = "pbUrun";
            this.pbUrun.Size = new System.Drawing.Size(229, 151);
            this.pbUrun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUrun.TabIndex = 14;
            this.pbUrun.TabStop = false;
            // 
            // cmbKategorisi
            // 
            this.cmbKategorisi.FormattingEnabled = true;
            this.cmbKategorisi.Location = new System.Drawing.Point(209, 79);
            this.cmbKategorisi.Name = "cmbKategorisi";
            this.cmbKategorisi.Size = new System.Drawing.Size(229, 45);
            this.cmbKategorisi.TabIndex = 16;
            // 
            // Kategorisi
            // 
            this.Kategorisi.AutoSize = true;
            this.Kategorisi.Location = new System.Drawing.Point(8, 87);
            this.Kategorisi.Name = "Kategorisi";
            this.Kategorisi.Size = new System.Drawing.Size(136, 37);
            this.Kategorisi.TabIndex = 17;
            this.Kategorisi.Text = "Kategorisi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 37);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fiyatı";
            // 
            // nudFiyat
            // 
            this.nudFiyat.Location = new System.Drawing.Point(209, 139);
            this.nudFiyat.Name = "nudFiyat";
            this.nudFiyat.Size = new System.Drawing.Size(229, 43);
            this.nudFiyat.TabIndex = 18;
            // 
            // dgUrun
            // 
            this.dgUrun.AllowUserToAddRows = false;
            this.dgUrun.AllowUserToDeleteRows = false;
            this.dgUrun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUrun.Location = new System.Drawing.Point(521, 30);
            this.dgUrun.MultiSelect = false;
            this.dgUrun.Name = "dgUrun";
            this.dgUrun.RowTemplate.Height = 25;
            this.dgUrun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUrun.Size = new System.Drawing.Size(483, 300);
            this.dgUrun.TabIndex = 19;
            this.dgUrun.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUrun_CellClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.dgUrun);
            this.tabPage1.Controls.Add(this.nudFiyat);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.Kategorisi);
            this.tabPage1.Controls.Add(this.cmbKategorisi);
            this.tabPage1.Controls.Add(this.pbUrun);
            this.tabPage1.Controls.Add(this.cbUrunAktifMi);
            this.tabPage1.Controls.Add(this.txtUrunAdi);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnUrunGuncelle);
            this.tabPage1.Controls.Add(this.btnUrunSil);
            this.tabPage1.Controls.Add(this.btnUrunResim);
            this.tabPage1.Controls.Add(this.btnUrunEkle);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(1236, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "     Ürün Ekle    ";
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.BackColor = System.Drawing.Color.White;
            this.btnKategoriEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKategoriEkle.ImageKey = "gfnfgn.jpg";
            this.btnKategoriEkle.ImageList = this.ımageList1;
            this.btnKategoriEkle.Location = new System.Drawing.Point(8, 352);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(131, 73);
            this.btnKategoriEkle.TabIndex = 2;
            this.btnKategoriEkle.Text = "Ekle";
            this.btnKategoriEkle.UseVisualStyleBackColor = false;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // btnKategoriResim
            // 
            this.btnKategoriResim.BackColor = System.Drawing.Color.White;
            this.btnKategoriResim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKategoriResim.ImageKey = "resimsec.png";
            this.btnKategoriResim.ImageList = this.ımageList1;
            this.btnKategoriResim.Location = new System.Drawing.Point(20, 174);
            this.btnKategoriResim.Name = "btnKategoriResim";
            this.btnKategoriResim.Size = new System.Drawing.Size(153, 69);
            this.btnKategoriResim.TabIndex = 2;
            this.btnKategoriResim.Text = "Resim";
            this.btnKategoriResim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKategoriResim.UseVisualStyleBackColor = false;
            this.btnKategoriResim.Click += new System.EventHandler(this.btnKategoriResim_Click);
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.BackColor = System.Drawing.Color.White;
            this.btnKategoriSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKategoriSil.ImageKey = "ghfgh.png";
            this.btnKategoriSil.ImageList = this.ımageList1;
            this.btnKategoriSil.Location = new System.Drawing.Point(167, 352);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(109, 73);
            this.btnKategoriSil.TabIndex = 2;
            this.btnKategoriSil.Text = "Sil";
            this.btnKategoriSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKategoriSil.UseVisualStyleBackColor = false;
            this.btnKategoriSil.Click += new System.EventHandler(this.btnKategoriSil_Click);
            // 
            // btnKategoriGuncelle
            // 
            this.btnKategoriGuncelle.BackColor = System.Drawing.Color.White;
            this.btnKategoriGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKategoriGuncelle.ImageKey = "güncelle.png";
            this.btnKategoriGuncelle.ImageList = this.ımageList1;
            this.btnKategoriGuncelle.Location = new System.Drawing.Point(307, 352);
            this.btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            this.btnKategoriGuncelle.Size = new System.Drawing.Size(175, 73);
            this.btnKategoriGuncelle.TabIndex = 2;
            this.btnKategoriGuncelle.Text = "Güncelle";
            this.btnKategoriGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKategoriGuncelle.UseVisualStyleBackColor = false;
            this.btnKategoriGuncelle.Click += new System.EventHandler(this.btnKategoriGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kategori Adı";
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(209, 78);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(229, 43);
            this.txtKategoriAdi.TabIndex = 4;
            // 
            // cbKategoriAktifMi
            // 
            this.cbKategoriAktifMi.AutoSize = true;
            this.cbKategoriAktifMi.Location = new System.Drawing.Point(209, 295);
            this.cbKategoriAktifMi.Name = "cbKategoriAktifMi";
            this.cbKategoriAktifMi.Size = new System.Drawing.Size(120, 41);
            this.cbKategoriAktifMi.TabIndex = 5;
            this.cbKategoriAktifMi.Text = "Aktif Et";
            this.cbKategoriAktifMi.UseVisualStyleBackColor = true;
            // 
            // pbKategori
            // 
            this.pbKategori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbKategori.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbKategori.Location = new System.Drawing.Point(209, 138);
            this.pbKategori.Name = "pbKategori";
            this.pbKategori.Size = new System.Drawing.Size(229, 151);
            this.pbKategori.TabIndex = 6;
            this.pbKategori.TabStop = false;
            // 
            // dgKategori
            // 
            this.dgKategori.AllowUserToAddRows = false;
            this.dgKategori.AllowUserToDeleteRows = false;
            this.dgKategori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKategori.Location = new System.Drawing.Point(497, 56);
            this.dgKategori.MultiSelect = false;
            this.dgKategori.Name = "dgKategori";
            this.dgKategori.RowTemplate.Height = 25;
            this.dgKategori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKategori.Size = new System.Drawing.Size(556, 307);
            this.dgKategori.TabIndex = 7;
            this.dgKategori.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKategori_CellClick);
            // 
            // btnResim
            // 
            this.btnResim.BackColor = System.Drawing.Color.Silver;
            this.btnResim.Controls.Add(this.dgKategori);
            this.btnResim.Controls.Add(this.pbKategori);
            this.btnResim.Controls.Add(this.cbKategoriAktifMi);
            this.btnResim.Controls.Add(this.txtKategoriAdi);
            this.btnResim.Controls.Add(this.label1);
            this.btnResim.Controls.Add(this.btnKategoriGuncelle);
            this.btnResim.Controls.Add(this.btnKategoriSil);
            this.btnResim.Controls.Add(this.btnKategoriResim);
            this.btnResim.Controls.Add(this.btnKategoriEkle);
            this.btnResim.Location = new System.Drawing.Point(4, 46);
            this.btnResim.Name = "btnResim";
            this.btnResim.Padding = new System.Windows.Forms.Padding(3);
            this.btnResim.Size = new System.Drawing.Size(1236, 485);
            this.btnResim.TabIndex = 1;
            this.btnResim.Text = "    Kategori Ekle    ";
            // 
            // FrmAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1244, 535);
            this.ControlBox = false;
            this.Controls.Add(this.btnEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAyarlar";
            this.Text = "FrmAyarlar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tpRestoranBilgileri.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbRestoranDuzen.ResumeLayout(false);
            this.btnEkle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUrun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUrun)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKategori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKategori)).EndInit();
            this.btnResim.ResumeLayout(false);
            this.btnResim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tpRestoranBilgileri;
        private System.Windows.Forms.GroupBox gbRestoranDuzen;
        private UserControls.RestoranBolum restoranBolum1;
        private System.Windows.Forms.Button btnBolumGuncelle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnBolumSil;
        private System.Windows.Forms.Button btnBolumEkle;
        private System.Windows.Forms.ListBox lstBolumler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydetIletisim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtAdres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRestoranAdi;
        private System.Windows.Forms.TabControl btnEkle;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgUrun;
        private System.Windows.Forms.NumericUpDown nudFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Kategorisi;
        private System.Windows.Forms.ComboBox cmbKategorisi;
        private System.Windows.Forms.PictureBox pbUrun;
        private System.Windows.Forms.CheckBox cbUrunAktifMi;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button btnUrunResim;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.TabPage btnResim;
        private System.Windows.Forms.DataGridView dgKategori;
        private System.Windows.Forms.PictureBox pbKategori;
        private System.Windows.Forms.CheckBox cbKategoriAktifMi;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKategoriGuncelle;
        private System.Windows.Forms.Button btnKategoriSil;
        private System.Windows.Forms.Button btnKategoriResim;
        private System.Windows.Forms.Button btnKategoriEkle;
    }
}