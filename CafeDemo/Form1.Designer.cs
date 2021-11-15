
namespace CafeDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnMasalar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Controls.Add(this.btnRaporlar);
            this.panel1.Controls.Add(this.btnAyarlar);
            this.panel1.Controls.Add(this.btnMasalar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.White;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKapat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKapat.ImageKey = "asdasd.jpg";
            this.btnKapat.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(0, 351);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(105, 99);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKapat.UseMnemonic = false;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Button-Delete-icon (1).ico");
            this.ımageList1.Images.SetKeyName(1, "110000045311153.jpg");
            this.ımageList1.Images.SetKeyName(2, "215617.png");
            this.ımageList1.Images.SetKeyName(3, "Settings.ico");
            this.ımageList1.Images.SetKeyName(4, "unnamed.png");
            this.ımageList1.Images.SetKeyName(5, "masa.png");
            this.ımageList1.Images.SetKeyName(6, "kapat.png");
            this.ımageList1.Images.SetKeyName(7, "yeni1.png");
            this.ımageList1.Images.SetKeyName(8, "rapor 2.png");
            this.ımageList1.Images.SetKeyName(9, "asdasd.jpg");
            this.ımageList1.Images.SetKeyName(10, "sdfssf.png");
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.BackColor = System.Drawing.Color.White;
            this.btnRaporlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRaporlar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRaporlar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRaporlar.ImageKey = "sdfssf.png";
            this.btnRaporlar.ImageList = this.ımageList1;
            this.btnRaporlar.Location = new System.Drawing.Point(0, 198);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(105, 99);
            this.btnRaporlar.TabIndex = 2;
            this.btnRaporlar.Text = "RAPORLAR";
            this.btnRaporlar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRaporlar.UseVisualStyleBackColor = false;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.BackColor = System.Drawing.Color.White;
            this.btnAyarlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAyarlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAyarlar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAyarlar.ImageKey = "yeni1.png";
            this.btnAyarlar.ImageList = this.ımageList1;
            this.btnAyarlar.Location = new System.Drawing.Point(0, 99);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(105, 99);
            this.btnAyarlar.TabIndex = 1;
            this.btnAyarlar.Text = "AYARLAR";
            this.btnAyarlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAyarlar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAyarlar.UseVisualStyleBackColor = false;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnMasalar
            // 
            this.btnMasalar.BackColor = System.Drawing.Color.White;
            this.btnMasalar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMasalar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMasalar.ImageKey = "110000045311153.jpg";
            this.btnMasalar.ImageList = this.ımageList1;
            this.btnMasalar.Location = new System.Drawing.Point(0, 0);
            this.btnMasalar.Name = "btnMasalar";
            this.btnMasalar.Size = new System.Drawing.Size(105, 99);
            this.btnMasalar.TabIndex = 0;
            this.btnMasalar.Text = "MASALAR";
            this.btnMasalar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMasalar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMasalar.UseVisualStyleBackColor = false;
            this.btnMasalar.Click += new System.EventHandler(this.btnMasalar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMasalar;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

