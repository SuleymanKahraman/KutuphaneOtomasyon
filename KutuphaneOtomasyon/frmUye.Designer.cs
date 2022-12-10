namespace KutuphaneOtomasyon
{
    partial class frmUye
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
            this.dgvUyeler = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.gbUyeEkle = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblMeslek = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).BeginInit();
            this.gbUyeEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUyeler
            // 
            this.dgvUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUyeler.Location = new System.Drawing.Point(563, 86);
            this.dgvUyeler.Name = "dgvUyeler";
            this.dgvUyeler.RowHeadersWidth = 62;
            this.dgvUyeler.RowTemplate.Height = 28;
            this.dgvUyeler.Size = new System.Drawing.Size(481, 298);
            this.dgvUyeler.TabIndex = 11;
            this.dgvUyeler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUyeler_CellDoubleClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(635, 409);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(113, 41);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(852, 409);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(109, 41);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // gbUyeEkle
            // 
            this.gbUyeEkle.Controls.Add(this.btnKaydet);
            this.gbUyeEkle.Controls.Add(this.txtSoyad);
            this.gbUyeEkle.Controls.Add(this.txtMeslek);
            this.gbUyeEkle.Controls.Add(this.lblAd);
            this.gbUyeEkle.Controls.Add(this.lblSoyad);
            this.gbUyeEkle.Controls.Add(this.txtAd);
            this.gbUyeEkle.Controls.Add(this.lblMeslek);
            this.gbUyeEkle.Location = new System.Drawing.Point(97, 86);
            this.gbUyeEkle.Name = "gbUyeEkle";
            this.gbUyeEkle.Size = new System.Drawing.Size(384, 364);
            this.gbUyeEkle.TabIndex = 14;
            this.gbUyeEkle.TabStop = false;
            this.gbUyeEkle.Text = "Üye Bilgileri";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(140, 297);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(72, 41);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(121, 150);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(248, 26);
            this.txtSoyad.TabIndex = 5;
            // 
            // txtMeslek
            // 
            this.txtMeslek.Location = new System.Drawing.Point(121, 224);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(248, 26);
            this.txtMeslek.TabIndex = 6;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(6, 82);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(33, 20);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(6, 150);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(58, 20);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(121, 82);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(248, 26);
            this.txtAd.TabIndex = 4;
            // 
            // lblMeslek
            // 
            this.lblMeslek.AutoSize = true;
            this.lblMeslek.Location = new System.Drawing.Point(5, 224);
            this.lblMeslek.Name = "lblMeslek";
            this.lblMeslek.Size = new System.Drawing.Size(59, 20);
            this.lblMeslek.TabIndex = 3;
            this.lblMeslek.Text = "Meslek";
            // 
            // frmUye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 751);
            this.Controls.Add(this.gbUyeEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dgvUyeler);
            this.Name = "frmUye";
            this.Text = "ÜYE EKLEME";
            this.Load += new System.EventHandler(this.frmUyeEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).EndInit();
            this.gbUyeEkle.ResumeLayout(false);
            this.gbUyeEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUyeler;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox gbUyeEkle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblMeslek;
    }
}

