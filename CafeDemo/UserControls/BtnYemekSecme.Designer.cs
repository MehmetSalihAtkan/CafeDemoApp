namespace CafeOtomasyonuApp.UserControls
{
    partial class BtnYemekSecme
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblLytYemek = new System.Windows.Forms.TableLayoutPanel();
            this.btnYemekSiparis = new System.Windows.Forms.Button();
            this.txtFiyat = new System.Windows.Forms.Label();
            this.tblLytYemek.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLytYemek
            // 
            this.tblLytYemek.ColumnCount = 1;
            this.tblLytYemek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytYemek.Controls.Add(this.btnYemekSiparis, 0, 0);
            this.tblLytYemek.Controls.Add(this.txtFiyat, 0, 1);
            this.tblLytYemek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytYemek.Location = new System.Drawing.Point(0, 0);
            this.tblLytYemek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblLytYemek.Name = "tblLytYemek";
            this.tblLytYemek.RowCount = 2;
            this.tblLytYemek.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblLytYemek.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblLytYemek.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLytYemek.Size = new System.Drawing.Size(179, 177);
            this.tblLytYemek.TabIndex = 3;
            // 
            // btnYemekSiparis
            // 
            this.btnYemekSiparis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnYemekSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYemekSiparis.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnYemekSiparis.Location = new System.Drawing.Point(3, 3);
            this.btnYemekSiparis.Name = "btnYemekSiparis";
            this.btnYemekSiparis.Size = new System.Drawing.Size(173, 117);
            this.btnYemekSiparis.TabIndex = 0;
            this.btnYemekSiparis.Text = "Mercimek Çorbası";
            this.btnYemekSiparis.UseVisualStyleBackColor = true;
            this.btnYemekSiparis.Click += new System.EventHandler(this.btnYemekSiparis_Click);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFiyat.AutoSize = true;
            this.txtFiyat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFiyat.Location = new System.Drawing.Point(69, 139);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(41, 21);
            this.txtFiyat.TabIndex = 3;
            this.txtFiyat.Text = "18 ₺";
            this.txtFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnYemekSecme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblLytYemek);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BtnYemekSecme";
            this.Size = new System.Drawing.Size(179, 177);
            this.tblLytYemek.ResumeLayout(false);
            this.tblLytYemek.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tblLytYemek;
        public System.Windows.Forms.Label txtFiyat;
        public System.Windows.Forms.Button btnYemekSiparis;
    }
}
