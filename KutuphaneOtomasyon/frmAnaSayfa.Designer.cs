﻿namespace KutuphaneOtomasyon
{
    partial class frmAnaSayfa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUyeIsmi = new System.Windows.Forms.TextBox();
            this.txtKitapIsmi = new System.Windows.Forms.TextBox();
            this.dgvUye = new System.Windows.Forms.DataGridView();
            this.dgvKitap = new System.Windows.Forms.DataGridView();
            this.dtpAlim = new System.Windows.Forms.DateTimePicker();
            this.btnKitapVer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmanetGun = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uyelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teslimİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYazarFiltre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTeslimTarih = new System.Windows.Forms.TextBox();
            this.dgvViewtakip = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitap)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewtakip)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üye İsmi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(674, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı";
            // 
            // txtUyeIsmi
            // 
            this.txtUyeIsmi.Location = new System.Drawing.Point(195, 179);
            this.txtUyeIsmi.Name = "txtUyeIsmi";
            this.txtUyeIsmi.Size = new System.Drawing.Size(312, 26);
            this.txtUyeIsmi.TabIndex = 2;
            this.txtUyeIsmi.TextChanged += new System.EventHandler(this.txtUyeIsmi_TextChanged);
            // 
            // txtKitapIsmi
            // 
            this.txtKitapIsmi.Location = new System.Drawing.Point(779, 179);
            this.txtKitapIsmi.Name = "txtKitapIsmi";
            this.txtKitapIsmi.Size = new System.Drawing.Size(304, 26);
            this.txtKitapIsmi.TabIndex = 3;
            this.txtKitapIsmi.TextChanged += new System.EventHandler(this.txtKitapIsmi_TextChanged);
            // 
            // dgvUye
            // 
            this.dgvUye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUye.Location = new System.Drawing.Point(74, 214);
            this.dgvUye.Name = "dgvUye";
            this.dgvUye.RowHeadersWidth = 62;
            this.dgvUye.RowTemplate.Height = 28;
            this.dgvUye.Size = new System.Drawing.Size(476, 233);
            this.dgvUye.TabIndex = 4;
            // 
            // dgvKitap
            // 
            this.dgvKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitap.Location = new System.Drawing.Point(656, 214);
            this.dgvKitap.Name = "dgvKitap";
            this.dgvKitap.RowHeadersWidth = 62;
            this.dgvKitap.RowTemplate.Height = 28;
            this.dgvKitap.Size = new System.Drawing.Size(517, 233);
            this.dgvKitap.TabIndex = 5;
            // 
            // dtpAlim
            // 
            this.dtpAlim.Location = new System.Drawing.Point(227, 526);
            this.dtpAlim.Name = "dtpAlim";
            this.dtpAlim.Size = new System.Drawing.Size(261, 26);
            this.dtpAlim.TabIndex = 6;
            // 
            // btnKitapVer
            // 
            this.btnKitapVer.Location = new System.Drawing.Point(556, 360);
            this.btnKitapVer.Name = "btnKitapVer";
            this.btnKitapVer.Size = new System.Drawing.Size(94, 87);
            this.btnKitapVer.TabIndex = 8;
            this.btnKitapVer.Text = "Kitap Ver";
            this.btnKitapVer.UseVisualStyleBackColor = true;
            this.btnKitapVer.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 571);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Emanet Gün Sayısı:";
            // 
            // txtEmanetGun
            // 
            this.txtEmanetGun.Location = new System.Drawing.Point(227, 571);
            this.txtEmanetGun.Name = "txtEmanetGun";
            this.txtEmanetGun.Size = new System.Drawing.Size(261, 26);
            this.txtEmanetGun.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.kitaplarToolStripMenuItem,
            this.uyelerToolStripMenuItem,
            this.teslimİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1561, 33);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(150, 34);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // kitaplarToolStripMenuItem
            // 
            this.kitaplarToolStripMenuItem.Name = "kitaplarToolStripMenuItem";
            this.kitaplarToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.kitaplarToolStripMenuItem.Text = "Kitaplar";
            this.kitaplarToolStripMenuItem.Click += new System.EventHandler(this.kitaplarToolStripMenuItem_Click);
            // 
            // uyelerToolStripMenuItem
            // 
            this.uyelerToolStripMenuItem.Name = "uyelerToolStripMenuItem";
            this.uyelerToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.uyelerToolStripMenuItem.Text = "Uyeler";
            this.uyelerToolStripMenuItem.Click += new System.EventHandler(this.uyelerToolStripMenuItem_Click);
            // 
            // teslimİşlemleriToolStripMenuItem
            // 
            this.teslimİşlemleriToolStripMenuItem.Name = "teslimİşlemleriToolStripMenuItem";
            this.teslimİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(146, 29);
            this.teslimİşlemleriToolStripMenuItem.Text = "Teslim İşlemleri";
            this.teslimİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.teslimİşlemleriToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(674, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Yazar";
            // 
            // txtYazarFiltre
            // 
            this.txtYazarFiltre.Location = new System.Drawing.Point(779, 141);
            this.txtYazarFiltre.Name = "txtYazarFiltre";
            this.txtYazarFiltre.Size = new System.Drawing.Size(304, 26);
            this.txtYazarFiltre.TabIndex = 14;
            this.txtYazarFiltre.TextChanged += new System.EventHandler(this.txtYazarFiltre_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 612);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Teslim Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 532);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Alım Tarihi:";
            // 
            // txtTeslimTarih
            // 
            this.txtTeslimTarih.Location = new System.Drawing.Point(227, 612);
            this.txtTeslimTarih.Name = "txtTeslimTarih";
            this.txtTeslimTarih.Size = new System.Drawing.Size(261, 26);
            this.txtTeslimTarih.TabIndex = 18;
            this.txtTeslimTarih.TextChanged += new System.EventHandler(this.txtTeslimTarih_TextChanged);
            // 
            // dgvViewtakip
            // 
            this.dgvViewtakip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewtakip.Location = new System.Drawing.Point(556, 485);
            this.dgvViewtakip.Name = "dgvViewtakip";
            this.dgvViewtakip.RowHeadersWidth = 62;
            this.dgvViewtakip.RowTemplate.Height = 28;
            this.dgvViewtakip.Size = new System.Drawing.Size(617, 208);
            this.dgvViewtakip.TabIndex = 19;
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 927);
            this.Controls.Add(this.dgvViewtakip);
            this.Controls.Add(this.txtTeslimTarih);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYazarFiltre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmanetGun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKitapVer);
            this.Controls.Add(this.dtpAlim);
            this.Controls.Add(this.dgvKitap);
            this.Controls.Add(this.dgvUye);
            this.Controls.Add(this.txtKitapIsmi);
            this.Controls.Add(this.txtUyeIsmi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAnaSayfa";
            this.Text = "frmTakipIslemleri";
            this.Load += new System.EventHandler(this.frmTakipIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitap)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewtakip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUyeIsmi;
        private System.Windows.Forms.TextBox txtKitapIsmi;
        private System.Windows.Forms.DataGridView dgvUye;
        private System.Windows.Forms.DataGridView dgvKitap;
        private System.Windows.Forms.DateTimePicker dtpAlim;
        private System.Windows.Forms.Button btnKitapVer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmanetGun;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uyelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teslimİşlemleriToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYazarFiltre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTeslimTarih;
        private System.Windows.Forms.DataGridView dgvViewtakip;
    }
}