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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtFiyat = new System.Windows.Forms.Label();
            this.txtYemek = new System.Windows.Forms.Label();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.txtFiyat, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtYemek, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(179, 177);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // txtFiyat
            // 
            this.txtFiyat.AutoSize = true;
            this.txtFiyat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFiyat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFiyat.Location = new System.Drawing.Point(3, 123);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(173, 54);
            this.txtFiyat.TabIndex = 0;
            this.txtFiyat.Text = "18 ₺";
            this.txtFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtYemek
            // 
            this.txtYemek.AutoSize = true;
            this.txtYemek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYemek.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtYemek.Location = new System.Drawing.Point(3, 0);
            this.txtYemek.Name = "txtYemek";
            this.txtYemek.Size = new System.Drawing.Size(173, 123);
            this.txtYemek.TabIndex = 1;
            this.txtYemek.Text = "Mercimek Çorbası";
            this.txtYemek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnYemekSecme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BtnYemekSecme";
            this.Size = new System.Drawing.Size(179, 177);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        public System.Windows.Forms.Label txtFiyat;
        public System.Windows.Forms.Label txtYemek;
    }
}
