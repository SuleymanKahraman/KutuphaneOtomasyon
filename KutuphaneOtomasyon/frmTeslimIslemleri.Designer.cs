namespace KutuphaneOtomasyon
{
    partial class frmTeslimIslemleri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeslimIslemleri));
            this.dgvTakip = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitapID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitapAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uygunluk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlimTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeslimTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeldigiTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IslemSonucu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKitapAl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKitAd = new System.Windows.Forms.TextBox();
            this.txtUyeAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpGeldigiTarih = new System.Windows.Forms.DateTimePicker();
            this.rbEmanette = new System.Windows.Forms.RadioButton();
            this.rbTeslimAlınmış = new System.Windows.Forms.RadioButton();
            this.rdb_TumunuGoster = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakip)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTakip
            // 
            this.dgvTakip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTakip.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvTakip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTakip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.UyeID,
            this.Ad,
            this.Soyad,
            this.KitapID,
            this.KitapAdi,
            this.Uygunluk,
            this.AlimTarihi,
            this.TeslimTarihi,
            this.GeldigiTarih,
            this.IslemSonucu});
            this.dgvTakip.Location = new System.Drawing.Point(16, 134);
            this.dgvTakip.Name = "dgvTakip";
            this.dgvTakip.RowHeadersWidth = 62;
            this.dgvTakip.RowTemplate.Height = 28;
            this.dgvTakip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTakip.Size = new System.Drawing.Size(1224, 326);
            this.dgvTakip.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // UyeID
            // 
            this.UyeID.DataPropertyName = "UyeID";
            this.UyeID.HeaderText = "UyeID";
            this.UyeID.MinimumWidth = 8;
            this.UyeID.Name = "UyeID";
            this.UyeID.Visible = false;
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "Ad";
            this.Ad.HeaderText = "Adı";
            this.Ad.MinimumWidth = 8;
            this.Ad.Name = "Ad";
            // 
            // Soyad
            // 
            this.Soyad.DataPropertyName = "Soyad";
            this.Soyad.HeaderText = "Soyadı";
            this.Soyad.MinimumWidth = 8;
            this.Soyad.Name = "Soyad";
            // 
            // KitapID
            // 
            this.KitapID.DataPropertyName = "KitapID";
            this.KitapID.HeaderText = "KitapID";
            this.KitapID.MinimumWidth = 8;
            this.KitapID.Name = "KitapID";
            this.KitapID.Visible = false;
            // 
            // KitapAdi
            // 
            this.KitapAdi.DataPropertyName = "KitapAdi";
            this.KitapAdi.HeaderText = "Kitap Adı";
            this.KitapAdi.MinimumWidth = 8;
            this.KitapAdi.Name = "KitapAdi";
            // 
            // Uygunluk
            // 
            this.Uygunluk.DataPropertyName = "Uygunluk";
            this.Uygunluk.HeaderText = "Uygunluk";
            this.Uygunluk.MinimumWidth = 8;
            this.Uygunluk.Name = "Uygunluk";
            this.Uygunluk.Visible = false;
            // 
            // AlimTarihi
            // 
            this.AlimTarihi.DataPropertyName = "AlimTarihi";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.AlimTarihi.DefaultCellStyle = dataGridViewCellStyle1;
            this.AlimTarihi.HeaderText = "Verildiği Tarih";
            this.AlimTarihi.MinimumWidth = 8;
            this.AlimTarihi.Name = "AlimTarihi";
            // 
            // TeslimTarihi
            // 
            this.TeslimTarihi.DataPropertyName = "TeslimTarihi";
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            this.TeslimTarihi.DefaultCellStyle = dataGridViewCellStyle2;
            this.TeslimTarihi.HeaderText = "Teslim Tarihi";
            this.TeslimTarihi.MinimumWidth = 8;
            this.TeslimTarihi.Name = "TeslimTarihi";
            // 
            // GeldigiTarih
            // 
            this.GeldigiTarih.DataPropertyName = "GeldigiTarih";
            dataGridViewCellStyle3.Format = "D";
            dataGridViewCellStyle3.NullValue = "-";
            this.GeldigiTarih.DefaultCellStyle = dataGridViewCellStyle3;
            this.GeldigiTarih.HeaderText = "Teslim Edilen Tarih";
            this.GeldigiTarih.MinimumWidth = 8;
            this.GeldigiTarih.Name = "GeldigiTarih";
            // 
            // IslemSonucu
            // 
            this.IslemSonucu.DataPropertyName = "IslemSonucu";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = null;
            this.IslemSonucu.DefaultCellStyle = dataGridViewCellStyle4;
            this.IslemSonucu.HeaderText = "Durumu";
            this.IslemSonucu.MinimumWidth = 8;
            this.IslemSonucu.Name = "IslemSonucu";
            // 
            // btnKitapAl
            // 
            this.btnKitapAl.BackColor = System.Drawing.Color.ForestGreen;
            this.btnKitapAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKitapAl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapAl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKitapAl.Location = new System.Drawing.Point(544, 595);
            this.btnKitapAl.Name = "btnKitapAl";
            this.btnKitapAl.Size = new System.Drawing.Size(238, 88);
            this.btnKitapAl.TabIndex = 13;
            this.btnKitapAl.Text = "Kitap Teslim Al";
            this.btnKitapAl.UseVisualStyleBackColor = false;
            this.btnKitapAl.Click += new System.EventHandler(this.btnKitapAl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(197, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kitap Adı:";
            // 
            // txtKitAd
            // 
            this.txtKitAd.Location = new System.Drawing.Point(292, 85);
            this.txtKitAd.Name = "txtKitAd";
            this.txtKitAd.Size = new System.Drawing.Size(295, 26);
            this.txtKitAd.TabIndex = 17;
            this.txtKitAd.TextChanged += new System.EventHandler(this.txtKitAd_TextChanged);
            // 
            // txtUyeAd
            // 
            this.txtUyeAd.Location = new System.Drawing.Point(292, 48);
            this.txtUyeAd.Name = "txtUyeAd";
            this.txtUyeAd.Size = new System.Drawing.Size(295, 26);
            this.txtUyeAd.TabIndex = 18;
            this.txtUyeAd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(208, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Üye Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(583, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Kitap Teslim Tarihi";
            // 
            // dtpGeldigiTarih
            // 
            this.dtpGeldigiTarih.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpGeldigiTarih.Location = new System.Drawing.Point(528, 550);
            this.dtpGeldigiTarih.Name = "dtpGeldigiTarih";
            this.dtpGeldigiTarih.Size = new System.Drawing.Size(270, 31);
            this.dtpGeldigiTarih.TabIndex = 21;
            // 
            // rbEmanette
            // 
            this.rbEmanette.AutoSize = true;
            this.rbEmanette.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbEmanette.Location = new System.Drawing.Point(614, 83);
            this.rbEmanette.Name = "rbEmanette";
            this.rbEmanette.Size = new System.Drawing.Size(116, 29);
            this.rbEmanette.TabIndex = 22;
            this.rbEmanette.Text = "Emanette";
            this.rbEmanette.UseVisualStyleBackColor = true;
            this.rbEmanette.CheckedChanged += new System.EventHandler(this.rbEmanette_CheckedChanged);
            // 
            // rbTeslimAlınmış
            // 
            this.rbTeslimAlınmış.AutoSize = true;
            this.rbTeslimAlınmış.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbTeslimAlınmış.Location = new System.Drawing.Point(757, 83);
            this.rbTeslimAlınmış.Name = "rbTeslimAlınmış";
            this.rbTeslimAlınmış.Size = new System.Drawing.Size(156, 29);
            this.rbTeslimAlınmış.TabIndex = 23;
            this.rbTeslimAlınmış.Text = "Teslim Alınmış";
            this.rbTeslimAlınmış.UseVisualStyleBackColor = true;
            this.rbTeslimAlınmış.CheckedChanged += new System.EventHandler(this.rbTeslimAlınmış_CheckedChanged);
            // 
            // rdb_TumunuGoster
            // 
            this.rdb_TumunuGoster.AutoSize = true;
            this.rdb_TumunuGoster.Checked = true;
            this.rdb_TumunuGoster.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdb_TumunuGoster.Location = new System.Drawing.Point(940, 83);
            this.rdb_TumunuGoster.Name = "rdb_TumunuGoster";
            this.rdb_TumunuGoster.Size = new System.Drawing.Size(167, 29);
            this.rdb_TumunuGoster.TabIndex = 24;
            this.rdb_TumunuGoster.TabStop = true;
            this.rdb_TumunuGoster.Text = "Tümünü Göster";
            this.rdb_TumunuGoster.UseVisualStyleBackColor = true;
            this.rdb_TumunuGoster.CheckedChanged += new System.EventHandler(this.rdb_TumunuGoster_CheckedChanged);
            // 
            // frmTeslimIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1257, 820);
            this.Controls.Add(this.rdb_TumunuGoster);
            this.Controls.Add(this.rbTeslimAlınmış);
            this.Controls.Add(this.rbEmanette);
            this.Controls.Add(this.dtpGeldigiTarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUyeAd);
            this.Controls.Add(this.txtKitAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKitapAl);
            this.Controls.Add(this.dgvTakip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1279, 876);
            this.Name = "frmTeslimIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Teslim İşlemleri";
            this.Load += new System.EventHandler(this.formBelirsiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTakip;
        private System.Windows.Forms.Button btnKitapAl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKitAd;
        private System.Windows.Forms.TextBox txtUyeAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpGeldigiTarih;
        private System.Windows.Forms.RadioButton rbEmanette;
        private System.Windows.Forms.RadioButton rbTeslimAlınmış;
        private System.Windows.Forms.RadioButton rdb_TumunuGoster;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uygunluk;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlimTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeslimTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeldigiTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn IslemSonucu;
    }
}