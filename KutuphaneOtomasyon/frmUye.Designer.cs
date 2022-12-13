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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUye));
            this.dgvUyeler = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meslek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CezaPuani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxUyeIslemleri = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cezaPuanınıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbUyeEkle = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblMeslek = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).BeginInit();
            this.ctxUyeIslemleri.SuspendLayout();
            this.gbUyeEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUyeler
            // 
            this.dgvUyeler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUyeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUyeler.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUyeler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ad,
            this.Soyad,
            this.Meslek,
            this.CezaPuani});
            this.dgvUyeler.ContextMenuStrip = this.ctxUyeIslemleri;
            this.dgvUyeler.Location = new System.Drawing.Point(582, 97);
            this.dgvUyeler.Name = "dgvUyeler";
            this.dgvUyeler.RowHeadersWidth = 62;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvUyeler.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUyeler.RowTemplate.Height = 28;
            this.dgvUyeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUyeler.Size = new System.Drawing.Size(924, 372);
            this.dgvUyeler.TabIndex = 11;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "UyeID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "Ad";
            this.Ad.HeaderText = "İsim";
            this.Ad.MinimumWidth = 8;
            this.Ad.Name = "Ad";
            // 
            // Soyad
            // 
            this.Soyad.DataPropertyName = "Soyad";
            this.Soyad.HeaderText = "Soy İsim";
            this.Soyad.MinimumWidth = 8;
            this.Soyad.Name = "Soyad";
            // 
            // Meslek
            // 
            this.Meslek.DataPropertyName = "Meslek";
            this.Meslek.HeaderText = "Meslek";
            this.Meslek.MinimumWidth = 8;
            this.Meslek.Name = "Meslek";
            // 
            // CezaPuani
            // 
            this.CezaPuani.DataPropertyName = "CezaPuani";
            this.CezaPuani.HeaderText = "Ceza Puanı";
            this.CezaPuani.MinimumWidth = 8;
            this.CezaPuani.Name = "CezaPuani";
            // 
            // ctxUyeIslemleri
            // 
            this.ctxUyeIslemleri.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctxUyeIslemleri.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cezaPuanınıSilToolStripMenuItem,
            this.toolStripSeparator1,
            this.güncelleToolStripMenuItem,
            this.toolStripSeparator2,
            this.silToolStripMenuItem});
            this.ctxUyeIslemleri.Name = "ctx_CezaPuani";
            this.ctxUyeIslemleri.Size = new System.Drawing.Size(207, 112);
            // 
            // cezaPuanınıSilToolStripMenuItem
            // 
            this.cezaPuanınıSilToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.cezaPuanınıSilToolStripMenuItem.Name = "cezaPuanınıSilToolStripMenuItem";
            this.cezaPuanınıSilToolStripMenuItem.Size = new System.Drawing.Size(206, 32);
            this.cezaPuanınıSilToolStripMenuItem.Text = "Ceza Puanını Sil";
            this.cezaPuanınıSilToolStripMenuItem.Click += new System.EventHandler(this.cezaPuanınıSilToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(206, 32);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(203, 6);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(206, 32);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
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
            this.gbUyeEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbUyeEkle.Location = new System.Drawing.Point(62, 86);
            this.gbUyeEkle.Name = "gbUyeEkle";
            this.gbUyeEkle.Size = new System.Drawing.Size(469, 389);
            this.gbUyeEkle.TabIndex = 14;
            this.gbUyeEkle.TabStop = false;
            this.gbUyeEkle.Text = "Üye Bilgileri";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.ForestGreen;
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKaydet.Location = new System.Drawing.Point(122, 297);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(248, 86);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Yeni Ekle";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(122, 151);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(248, 34);
            this.txtSoyad.TabIndex = 5;
            // 
            // txtMeslek
            // 
            this.txtMeslek.Location = new System.Drawing.Point(122, 225);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(248, 34);
            this.txtMeslek.TabIndex = 6;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(81, 86);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(39, 25);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(54, 155);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(66, 25);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(122, 82);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(248, 34);
            this.txtAd.TabIndex = 4;
            // 
            // lblMeslek
            // 
            this.lblMeslek.AutoSize = true;
            this.lblMeslek.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMeslek.Location = new System.Drawing.Point(44, 229);
            this.lblMeslek.Name = "lblMeslek";
            this.lblMeslek.Size = new System.Drawing.Size(76, 25);
            this.lblMeslek.TabIndex = 3;
            this.lblMeslek.Text = "Meslek:";
            // 
            // frmUye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1631, 751);
            this.Controls.Add(this.gbUyeEkle);
            this.Controls.Add(this.dgvUyeler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1396, 807);
            this.Name = "frmUye";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Üye Ekleme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUyeEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).EndInit();
            this.ctxUyeIslemleri.ResumeLayout(false);
            this.gbUyeEkle.ResumeLayout(false);
            this.gbUyeEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUyeler;
        private System.Windows.Forms.GroupBox gbUyeEkle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblMeslek;
        private System.Windows.Forms.ContextMenuStrip ctxUyeIslemleri;
        private System.Windows.Forms.ToolStripMenuItem cezaPuanınıSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meslek;
        private System.Windows.Forms.DataGridViewTextBoxColumn CezaPuani;
    }
}

