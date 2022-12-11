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
        private KitapTeslimAlModel keeper;
        public frmTeslimIslemleri()
        {
            InitializeComponent();
            helper = new DataHelper();
            keeper = new KitapTeslimAlModel();
        }

        private void formBelirsiz_Load(object sender, EventArgs e)
        {
            dgvTakip.DataSource = helper.VeriAl("SELECT * FROM vwTakipIslem");
            dgvTakip.ClearSelection();
            //TODO: Deneme kodu
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
                GeldigiTarih = dtpGeldigiTarih.Value,
                UyeId = (int)dgvTakip.CurrentRow.Cells[1].Value,
                TakipId = (int)dgvTakip.CurrentRow.Cells[0].Value,
                KitapId = (int)dgvTakip.CurrentRow.Cells[4].Value,
                TeslimTarihi = (DateTime)dgvTakip.CurrentRow.Cells[8].Value
            };
            TimeSpan fark = model.GeldigiTarih.Subtract(model.TeslimTarihi);
            model.CezaPuani = fark.Days; 
            bool result = helper.KitapTeslimAl(model);
            if (result)
            {
                MessageBox.Show("Kitap Başarıyla Teslim Alındı.");
            }
            else
            {
                MessageBox.Show("İşlem Başarısız.");
                
            }
            dgvTakip.DataSource = helper.VeriAl("SELECT * FROM vwTakipIslem");
        }

        private void rbEmanette_CheckedChanged(object sender, EventArgs e)
        {
            dgvTakip.DataSource = helper.VeriAl("SELECT * FROM vwTakipIslem WHERE IslemSonucu = 0");
        }

        private void rbTeslimAlınmış_CheckedChanged(object sender, EventArgs e)
        {
            dgvTakip.DataSource = helper.VeriAl("SELECT * FROM vwTakipIslem WHERE IslemSonucu = 1");
        }

        private void rdb_TumunuGoster_CheckedChanged(object sender, EventArgs e)
        {
            dgvTakip.DataSource = helper.VeriAl("SELECT * FROM vwTakipIslem");

        }




        //private void Renklendir()
        //{
        //    for (int i = 0; i < dgvTakip.Rows.Count - 1; i++)
        //    {
        //        if ((bool)dgvTakip.Rows[i].Cells[10].Value)
        //        {
        //            dgvTakip.Rows[i].Cells[10].Style.BackColor = Color.Green;
        //        }
        //        else
        //        {
        //            dgvTakip.Rows[i].Cells[10].Style.BackColor = Color.Red;
        //        }
        //    }
        //}
    }
}
