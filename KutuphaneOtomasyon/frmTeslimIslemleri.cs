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
    public partial class frmTeslimIslemleri : Form
    {
        private readonly DataHelper helper;
        public frmTeslimIslemleri()
        {
            InitializeComponent();
            helper = new DataHelper();
        }

        private void formBelirsiz_Load(object sender, EventArgs e)
        {
            dgvTakip.DataSource = helper.VeriAl("SELECT * FROM vwTakipIslem");
            dgvTakip.ClearSelection();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dgvTakip.DataSource = helper.VeriAl("SELECT * FROM vwTakipIslem WHERE Ad LIKE '" + txtUyeAd.Text + "%'");
        }

        private void txtKitAd_TextChanged(object sender, EventArgs e)
        {
            dgvTakip.DataSource= helper.VeriAl("SELECT * FROM vwTakipIslem WHERE KitapAdi LIKE '" + txtKitAd.Text + "%'");
        }
        private void btnKitapAl_Click(object sender, EventArgs e)
        {
            KitapTeslimAlModel model = new KitapTeslimAlModel()
            {
                TakipId = (int)dgvTakip.CurrentRow.Cells[0].Value,
                UyeId = (int)dgvTakip.CurrentRow.Cells[1].Value,
                KitapId = (int)dgvTakip.CurrentRow.Cells[4].Value,
                CezaPuani = (int)dgvTakip.CurrentRow.Cells[6].Value,
                TeslimTarihi = (DateTime)dgvTakip.CurrentRow.Cells[8].Value,
                GeldigiTarih = dtpGeldigiTarih.Value,
                IslemSonuc = (int)dgvTakip.CurrentRow.Cells[10].Value,

            };
            if(model.IslemSonuc != 0)
            {
                MessageBox.Show("Kitap daha önce teslim edilmiş.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                TimeSpan fark = model.GeldigiTarih.Subtract(model.TeslimTarihi);
                model.CezaPuani += fark.Days;
                bool result = helper.KitapTeslimAl(model);
                if (result)
                {
                    MessageBox.Show("Kitap Başarıyla Teslim Alındı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("İşlem Başarısız.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                
            }
            if (rbEmanette.Checked)
            {
                rbEmanette_CheckedChanged(null,null);
            }
            else
            {
                rdb_TumunuGoster_CheckedChanged(null, null);
            }
        }

        private void rbEmanette_CheckedChanged(object sender, EventArgs e)
        {
            dgvTakip.DataSource = helper.VeriAl("SELECT * FROM vwTakipIslem WHERE IslemSonucu = 0");
            dgvTakip.ClearSelection();
        }

        private void rbTeslimAlınmış_CheckedChanged(object sender, EventArgs e)
        {
            dgvTakip.DataSource = helper.VeriAl("SELECT * FROM vwTakipIslem WHERE IslemSonucu = 1");
            dgvTakip.ClearSelection();
        }

        private void rdb_TumunuGoster_CheckedChanged(object sender, EventArgs e)
        {
            dgvTakip.DataSource = helper.VeriAl("SELECT * FROM vwTakipIslem");
            dgvTakip.ClearSelection();

        }
    }
}
