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
            this.dgvTakip = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakip)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTakip
            // 
            this.dgvTakip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dgvTakip.Location = new System.Drawing.Point(11, 87);
            this.dgvTakip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTakip.Name = "dgvTakip";
            this.dgvTakip.RowHeadersWidth = 62;
            this.dgvTakip.RowTemplate.Height = 28;
            this.dgvTakip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTakip.Size = new System.Drawing.Size(816, 212);
            this.dgvTakip.TabIndex = 8;
            // 
            // btnKitapAl
            // 
            this.btnKitapAl.Location = new System.Drawing.Point(363, 387);
            this.btnKitapAl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKitapAl.Name = "btnKitapAl";
            this.btnKitapAl.Size = new System.Drawing.Size(159, 57);
            this.btnKitapAl.TabIndex = 13;
            this.btnKitapAl.Text = "Kitap Teslim Al";
            this.btnKitapAl.UseVisualStyleBackColor = true;
            this.btnKitapAl.Click += new System.EventHandler(this.btnKitapAl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kitap Adı:";
            // 
            // txtKitAd
            // 
            this.txtKitAd.Location = new System.Drawing.Point(195, 55);
            this.txtKitAd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKitAd.Name = "txtKitAd";
            this.txtKitAd.Size = new System.Drawing.Size(198, 20);
            this.txtKitAd.TabIndex = 17;
            this.txtKitAd.TextChanged += new System.EventHandler(this.txtKitAd_TextChanged);
            // 
            // txtUyeAd
            // 
            this.txtUyeAd.Location = new System.Drawing.Point(195, 31);
            this.txtUyeAd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUyeAd.Name = "txtUyeAd";
            this.txtUyeAd.Size = new System.Drawing.Size(198, 20);
            this.txtUyeAd.TabIndex = 18;
            this.txtUyeAd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Üye Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 346);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Kitap Teslim Tarihi";
            // 
            // dtpGeldigiTarih
            // 
            this.dtpGeldigiTarih.Location = new System.Drawing.Point(352, 363);
            this.dtpGeldigiTarih.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpGeldigiTarih.Name = "dtpGeldigiTarih";
            this.dtpGeldigiTarih.Size = new System.Drawing.Size(181, 20);
            this.dtpGeldigiTarih.TabIndex = 21;
            // 
            // rbEmanette
            // 
            this.rbEmanette.AutoSize = true;
            this.rbEmanette.Location = new System.Drawing.Point(415, 51);
            this.rbEmanette.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbEmanette.Name = "rbEmanette";
            this.rbEmanette.Size = new System.Drawing.Size(70, 17);
            this.rbEmanette.TabIndex = 22;
            this.rbEmanette.Text = "Emanette";
            this.rbEmanette.UseVisualStyleBackColor = true;
            this.rbEmanette.CheckedChanged += new System.EventHandler(this.rbEmanette_CheckedChanged);
            // 
            // rbTeslimAlınmış
            // 
            this.rbTeslimAlınmış.AutoSize = true;
            this.rbTeslimAlınmış.Location = new System.Drawing.Point(517, 51);
            this.rbTeslimAlınmış.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbTeslimAlınmış.Name = "rbTeslimAlınmış";
            this.rbTeslimAlınmış.Size = new System.Drawing.Size(90, 17);
            this.rbTeslimAlınmış.TabIndex = 23;
            this.rbTeslimAlınmış.Text = "Teslim Alınmış";
            this.rbTeslimAlınmış.UseVisualStyleBackColor = true;
            this.rbTeslimAlınmış.CheckedChanged += new System.EventHandler(this.rbTeslimAlınmış_CheckedChanged);
            // 
            // rdb_TumunuGoster
            // 
            this.rdb_TumunuGoster.AutoSize = true;
            this.rdb_TumunuGoster.Checked = true;
            this.rdb_TumunuGoster.Location = new System.Drawing.Point(628, 51);
            this.rdb_TumunuGoster.Margin = new System.Windows.Forms.Padding(2);
            this.rdb_TumunuGoster.Name = "rdb_TumunuGoster";
            this.rdb_TumunuGoster.Size = new System.Drawing.Size(98, 17);
            this.rdb_TumunuGoster.TabIndex = 24;
            this.rdb_TumunuGoster.TabStop = true;
            this.rdb_TumunuGoster.Text = "Tümünü Göster";
            this.rdb_TumunuGoster.UseVisualStyleBackColor = true;
            this.rdb_TumunuGoster.CheckedChanged += new System.EventHandler(this.rdb_TumunuGoster_CheckedChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // UyeID
            // 
            this.UyeID.DataPropertyName = "UyeID";
            this.UyeID.HeaderText = "UyeID";
            this.UyeID.Name = "UyeID";
            this.UyeID.Visible = false;
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "Ad";
            this.Ad.HeaderText = "Adı";
            this.Ad.Name = "Ad";
            // 
            // Soyad
            // 
            this.Soyad.DataPropertyName = "Soyad";
            this.Soyad.HeaderText = "Soyadı";
            this.Soyad.Name = "Soyad";
            // 
            // KitapID
            // 
            this.KitapID.DataPropertyName = "KitapID";
            this.KitapID.HeaderText = "KitapID";
            this.KitapID.Name = "KitapID";
            this.KitapID.Visible = false;
            // 
            // KitapAdi
            // 
            this.KitapAdi.DataPropertyName = "KitapAdi";
            this.KitapAdi.HeaderText = "Kitap Adı";
            this.KitapAdi.Name = "KitapAdi";
            // 
            // Uygunluk
            // 
            this.Uygunluk.DataPropertyName = "Uygunluk";
            this.Uygunluk.HeaderText = "Uygunluk";
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
            this.AlimTarihi.Name = "AlimTarihi";
            // 
            // TeslimTarihi
            // 
            this.TeslimTarihi.DataPropertyName = "TeslimTarihi";
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            this.TeslimTarihi.DefaultCellStyle = dataGridViewCellStyle2;
            this.TeslimTarihi.HeaderText = "Teslim Tarihi";
            this.TeslimTarihi.Name = "TeslimTarihi";
            // 
            // GeldigiTarih
            // 
            this.GeldigiTarih.DataPropertyName = "GeldigiTarih";
            dataGridViewCellStyle3.Format = "D";
            dataGridViewCellStyle3.NullValue = "-";
            this.GeldigiTarih.DefaultCellStyle = dataGridViewCellStyle3;
            this.GeldigiTarih.HeaderText = "Teslim Edilen Tarih";
            this.GeldigiTarih.Name = "GeldigiTarih";
            // 
            // IslemSonucu
            // 
            this.IslemSonucu.DataPropertyName = "IslemSonucu";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = null;
            this.IslemSonucu.DefaultCellStyle = dataGridViewCellStyle4;
            this.IslemSonucu.HeaderText = "Durumu";
            this.IslemSonucu.Name = "IslemSonucu";
            // 
            // frmTeslimIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 533);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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