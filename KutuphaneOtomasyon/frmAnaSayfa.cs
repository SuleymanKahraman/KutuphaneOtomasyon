using KutuphaneOtomasyon.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class frmAnaSayfa : Form
    {
        private readonly DataHelper helper;

        public frmAnaSayfa()
        {
            InitializeComponent();
            helper = new DataHelper();
        }

        private void Renklendir()
        {
            for (int i = 0; i < dgvKitap.Rows.Count - 1; i++)
            {
                if ((int)dgvKitap.Rows[i].Cells[5].Value == 1)
                {
                    dgvKitap.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    dgvKitap.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }

            for (int i = 0; i < dgvUye.Rows.Count - 1; i++)
            {
                if ((int)dgvUye.Rows[i].Cells[4].Value >= 50)
                {
                    dgvUye.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void frmTakipIslemleri_Load(object sender, EventArgs e)
        {
            VerileriYukle();
        }

        private void txtUyeIsmi_TextChanged(object sender, EventArgs e)
        {
            dgvUye.DataSource = helper.VeriAl("SELECT * FROM tblUyeler WHERE Ad LIKE '" + txtUyeIsmi.Text + "%'");
        }

        private void txtKitapIsmi_TextChanged(object sender, EventArgs e)
        {
            dgvKitap.DataSource = helper.VeriAl("SELECT * FROM tblKitaplar WHERE KitapAdi LIKE '" + txtKitapIsmi.Text + "%'");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtEmanetGun.Text != "")
            {
                if (int.Parse(txtEmanetGun.Text) <= 60)
                {
                    KitapVerModel model = new KitapVerModel()
                    {
                        UyeId = (int)dgvUye.CurrentRow.Cells[0].Value,
                        CezaPuani = (int)dgvUye.CurrentRow.Cells[4].Value,
                        KitapId = (int)dgvKitap.CurrentRow.Cells[0].Value,
                        Uygunluk = (int)dgvKitap.CurrentRow.Cells[5].Value,
                        AlimTarihi = DateTime.Today,
                        TeslimTarihi = DateTime.Today.AddDays(int.Parse(txtEmanetGun.Text))
                    };
                    if (model.CezaPuani >= 50)
                    {
                        MessageBox.Show($"{model.UyeId} No'lu Kullanıcının ceza puanı kitap teslimine uygun değildir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        var result = helper.KitapVer(model);
                        if (result)
                        {
                            txtTeslimTarih.Text = model.TeslimTarihi.ToString("dddd, dd MMMM yyyy");
                        }
                        else
                        {
                            txtEmanetGun.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Emanet Gün Sayısı 60 günden fazla olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Emanet Verilecek Gün Sayısını Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            VerileriYukle();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKitap frmKitap = new frmKitap();
            frmKitap.ShowDialog();
            frmKitap.Dispose();
        }

        private void uyelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUye frmUye = new frmUye();
            frmUye.ShowDialog();
            frmUye.Dispose();
            VerileriYukle();
        }

        private void teslimİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeslimIslemleri frmTeslimIslemleri = new frmTeslimIslemleri();
            frmTeslimIslemleri.ShowDialog();
            frmTeslimIslemleri.Dispose();
            VerileriYukle();
        }

        private void VerileriYukle()
        {
            dgvUye.DataSource = helper.VeriAl("SELECT * FROM tblUyeler");
            dgvKitap.DataSource = helper.VeriAl("SELECT * FROM tblKitaplar");
            dgvKitap.ClearSelection();
            dgvUye.ClearSelection();
            Renklendir();
        }

        private void txtYazarFiltre_TextChanged(object sender, EventArgs e)
        {
            dgvKitap.DataSource = helper.VeriAl("SELECT * FROM tblKitaplar WHERE Yazar LIKE '" + txtYazarFiltre.Text + "%'");
        }

        private void txtTeslimTarih_TextChanged(object sender, EventArgs e)
        {
        }
    }
}