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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUyeler = new System.Windows.Forms.DataGridView();
            this.ctx_CezaPuani = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cezaPuanınıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.ctx_CezaPuani.SuspendLayout();
            this.gbUyeEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUyeler
            // 
            this.dgvUyeler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUyeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUyeler.ContextMenuStrip = this.ctx_CezaPuani;
            this.dgvUyeler.Location = new System.Drawing.Point(357, 63);
            this.dgvUyeler.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUyeler.Name = "dgvUyeler";
            this.dgvUyeler.RowHeadersWidth = 62;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgvUyeler.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUyeler.RowTemplate.Height = 28;
            this.dgvUyeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUyeler.Size = new System.Drawing.Size(524, 194);
            this.dgvUyeler.TabIndex = 11;
            this.dgvUyeler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUyeler_CellDoubleClick);
            // 
            // ctx_CezaPuani
            // 
            this.ctx_CezaPuani.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cezaPuanınıSilToolStripMenuItem});
            this.ctx_CezaPuani.Name = "ctx_CezaPuani";
            this.ctx_CezaPuani.Size = new System.Drawing.Size(158, 26);
            // 
            // cezaPuanınıSilToolStripMenuItem
            // 
            this.cezaPuanınıSilToolStripMenuItem.Name = "cezaPuanınıSilToolStripMenuItem";
            this.cezaPuanınıSilToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.cezaPuanınıSilToolStripMenuItem.Text = "Ceza Puanını Sil";
            this.cezaPuanınıSilToolStripMenuItem.Click += new System.EventHandler(this.cezaPuanınıSilToolStripMenuItem_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(357, 268);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(149, 27);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSil.Location = new System.Drawing.Point(732, 268);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(149, 27);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
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
            this.gbUyeEkle.Location = new System.Drawing.Point(41, 56);
            this.gbUyeEkle.Margin = new System.Windows.Forms.Padding(2);
            this.gbUyeEkle.Name = "gbUyeEkle";
            this.gbUyeEkle.Padding = new System.Windows.Forms.Padding(2);
            this.gbUyeEkle.Size = new System.Drawing.Size(288, 253);
            this.gbUyeEkle.TabIndex = 14;
            this.gbUyeEkle.TabStop = false;
            this.gbUyeEkle.Text = "Üye Bilgileri";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(81, 193);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(167, 27);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(81, 98);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(167, 20);
            this.txtSoyad.TabIndex = 5;
            // 
            // txtMeslek
            // 
            this.txtMeslek.Location = new System.Drawing.Point(81, 146);
            this.txtMeslek.Margin = new System.Windows.Forms.Padding(2);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(167, 20);
            this.txtMeslek.TabIndex = 6;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(30, 56);
            this.lblAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(23, 13);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(30, 101);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(40, 13);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(81, 53);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(167, 20);
            this.txtAd.TabIndex = 4;
            // 
            // lblMeslek
            // 
            this.lblMeslek.AutoSize = true;
            this.lblMeslek.Location = new System.Drawing.Point(29, 149);
            this.lblMeslek.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMeslek.Name = "lblMeslek";
            this.lblMeslek.Size = new System.Drawing.Size(41, 13);
            this.lblMeslek.TabIndex = 3;
            this.lblMeslek.Text = "Meslek";
            // 
            // frmUye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 488);
            this.Controls.Add(this.gbUyeEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dgvUyeler);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ÜYE EKLEME";
            this.Load += new System.EventHandler(this.frmUyeEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).EndInit();
            this.ctx_CezaPuani.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip ctx_CezaPuani;
        private System.Windows.Forms.ToolStripMenuItem cezaPuanınıSilToolStripMenuItem;
    }
}

