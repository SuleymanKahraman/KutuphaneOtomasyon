using KutuphaneOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void frmTakipIslemleri_Load(object sender, EventArgs e)
        {
            dgvUye.DataSource = helper.VeriAl("SELECT * FROM tblUyeler");
            dgvKitap.DataSource = helper.VeriAl("SELECT * FROM tblKitaplar");
            
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
                        MessageBox.Show($"{model.UyeId} No'lu Kullanıcının ceza puanı kitap teslimine uygun değildir.");
                    }
                    else
                    {
                        var result = helper.KitapVer(model);
                        if (result)
                        {
                            txtTeslimTarih.Text = model.TeslimTarihi.ToString("dddd, dd MMMM yyyy");
                            dgvViewtakip.DataSource = helper.VeriAl("SELECT * FROM vwTakipIslem WHERE UyeID LIKE '" + model.UyeId + "'");
                        }
                        else
                        {
                            txtEmanetGun.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Emanet Gün Sayısı 60 günden fazla olamaz!");
                }
            }
            else
            {
                MessageBox.Show("Emanet Verilecek Gün Sayısını Giriniz!");
            }
            dgvUye.DataSource = helper.VeriAl("SELECT * FROM tblUyeler");
            dgvKitap.DataSource = helper.VeriAl("SELECT * FROM tblKitaplar");
            //Application.Restart();

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
        }

        private void teslimİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeslimIslemleri formBelirsiz = new frmTeslimIslemleri();
            formBelirsiz.ShowDialog();

        }

        private void txtYazarFiltre_TextChanged(object sender, EventArgs e)
        {
            dgvKitap.DataSource = helper.VeriAl("SELECT * FROM tblKitaplar WHERE Yazar LIKE '" +txtYazarFiltre.Text+ "%'");
        }

        private void txtTeslimTarih_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
