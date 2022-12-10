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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakip)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTakip
            // 
            this.dgvTakip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTakip.Location = new System.Drawing.Point(133, 134);
            this.dgvTakip.Name = "dgvTakip";
            this.dgvTakip.RowHeadersWidth = 62;
            this.dgvTakip.RowTemplate.Height = 28;
            this.dgvTakip.Size = new System.Drawing.Size(786, 326);
            this.dgvTakip.TabIndex = 8;
            // 
            // btnKitapAl
            // 
            this.btnKitapAl.Location = new System.Drawing.Point(402, 536);
            this.btnKitapAl.Name = "btnKitapAl";
            this.btnKitapAl.Size = new System.Drawing.Size(238, 87);
            this.btnKitapAl.TabIndex = 13;
            this.btnKitapAl.Text = "Kitap Teslim Al";
            this.btnKitapAl.UseVisualStyleBackColor = true;
            this.btnKitapAl.Click += new System.EventHandler(this.btnKitapAl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kitap Adı:";
            // 
            // txtKitAd
            // 
            this.txtKitAd.Location = new System.Drawing.Point(220, 101);
            this.txtKitAd.Name = "txtKitAd";
            this.txtKitAd.Size = new System.Drawing.Size(295, 26);
            this.txtKitAd.TabIndex = 17;
            this.txtKitAd.TextChanged += new System.EventHandler(this.txtKitAd_TextChanged);
            // 
            // txtUyeAd
            // 
            this.txtUyeAd.Location = new System.Drawing.Point(220, 65);
            this.txtUyeAd.Name = "txtUyeAd";
            this.txtUyeAd.Size = new System.Drawing.Size(295, 26);
            this.txtUyeAd.TabIndex = 18;
            this.txtUyeAd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Üye Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Kitap Teslim Tarihi";
            // 
            // dtpGeldigiTarih
            // 
            this.dtpGeldigiTarih.Location = new System.Drawing.Point(386, 500);
            this.dtpGeldigiTarih.Name = "dtpGeldigiTarih";
            this.dtpGeldigiTarih.Size = new System.Drawing.Size(270, 26);
            this.dtpGeldigiTarih.TabIndex = 21;
            // 
            // rbEmanette
            // 
            this.rbEmanette.AutoSize = true;
            this.rbEmanette.Checked = true;
            this.rbEmanette.Location = new System.Drawing.Point(551, 96);
            this.rbEmanette.Name = "rbEmanette";
            this.rbEmanette.Size = new System.Drawing.Size(104, 24);
            this.rbEmanette.TabIndex = 22;
            this.rbEmanette.TabStop = true;
            this.rbEmanette.Text = "Emanette";
            this.rbEmanette.UseVisualStyleBackColor = true;
            this.rbEmanette.CheckedChanged += new System.EventHandler(this.rbEmanette_CheckedChanged);
            // 
            // rbTeslimAlınmış
            // 
            this.rbTeslimAlınmış.AutoSize = true;
            this.rbTeslimAlınmış.Location = new System.Drawing.Point(704, 96);
            this.rbTeslimAlınmış.Name = "rbTeslimAlınmış";
            this.rbTeslimAlınmış.Size = new System.Drawing.Size(133, 24);
            this.rbTeslimAlınmış.TabIndex = 23;
            this.rbTeslimAlınmış.TabStop = true;
            this.rbTeslimAlınmış.Text = "Teslim Alınmış";
            this.rbTeslimAlınmış.UseVisualStyleBackColor = true;
            this.rbTeslimAlınmış.CheckedChanged += new System.EventHandler(this.rbTeslimAlınmış_CheckedChanged);
            // 
            // frmTeslimIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 675);
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
            this.Name = "frmTeslimIslemleri";
            this.Text = "TESLİM İŞLEMLERİ";
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
    }
}