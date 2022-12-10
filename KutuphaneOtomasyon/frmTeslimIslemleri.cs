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
        private KitapAlModel keeper;
        public frmTeslimIslemleri()
        {
            InitializeComponent();
            helper = new DataHelper();
            keeper = new KitapAlModel();
        }

        private void formBelirsiz_Load(object sender, EventArgs e)
        {
            dgvTakip.DataSource = helper.VeriAl("SELECT * FROM vwTakipIslem WHERE IslemSonucu = 0");
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
            KitapAlModel model = new KitapAlModel()
            {
                GeldigiTarih = dtpGeldigiTarih.Value,
                UyeId = (int)dgvTakip.CurrentRow.Cells[1].Value,
                KitapId = (int)dgvTakip.CurrentRow.Cells[4].Value,
                TeslimTarihi = (DateTime)dgvTakip.CurrentRow.Cells[8].Value
            };
            TimeSpan fark = model.GeldigiTarih.Subtract(model.TeslimTarihi);
            model.CezaPuani = Convert.ToInt32(fark.Days); 
            var result = helper.KitapAl(model);
            if (result)
            {
                MessageBox.Show("Kitap Başarıyla Teslim Alındı.");
                this.Close();
            }
            else
            {
                MessageBox.Show("İşlem Başarısız.");
                
            }
            Application.Restart();
        }

        private void rbEmanette_CheckedChanged(object sender, EventArgs e)
        {
            dgvTakip.DataSource = helper.VeriAl("SELECT * FROM vwTakipIslem WHERE IslemSonucu = 0");
        }

        private void rbTeslimAlınmış_CheckedChanged(object sender, EventArgs e)
        {
            dgvTakip.DataSource = helper.VeriAl("SELECT * FROM vwTakipIslem WHERE IslemSonucu = 1");
        }
    }
}
