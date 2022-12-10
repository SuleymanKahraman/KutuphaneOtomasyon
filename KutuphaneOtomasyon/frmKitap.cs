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
    public partial class frmKitap : Form
    {
        private readonly DataHelper helper;
        private KitapIslemModel model;
        public frmKitap()
        {
            InitializeComponent();
            helper = new DataHelper();
        }
        private void frmKitapEkle_Load(object sender, EventArgs e)
        {
            dgvKitaplar.DataSource = helper.VeriAl("SELECT * FROM tblKitaplar");
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            model = new KitapIslemModel()
            {
                KitapAdi = txtKitapAdi.Text,
                Yazar = txtYazar.Text,
                Tur = txtTur.Text,
                Sayfa = Convert.ToInt32(txtSayfa.Text),
            };
            if (txtKitapAdi.Text == "" || txtYazar.Text == "" || txtTur.Text == "" || txtSayfa.Text == "")
            {
                MessageBox.Show("Alanları Boş BIRAKMAYINIZ!");
            }
            else
            {
                helper.KitapEkle(model);
                txtKitapAdi.Clear();
                txtYazar.Clear();
                txtTur.Clear();
                txtSayfa.Clear();
                dgvKitaplar.DataSource = helper.VeriAl("SELECT * FROM tblKitaplar");
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            model = new KitapIslemModel()
            {
                KitapId = (int)dgvKitaplar.CurrentRow.Cells[0].Value,
                Uygunluk = (int)dgvKitaplar.CurrentRow.Cells[5].Value,
            };
            if (model.Uygunluk == 0)
            {
                MessageBox.Show("Emanet Verilmiş Kitap SİLİNEMEZ.");
            }
            else
            {
                var result = helper.KitapSilme(model);
                if (result) 
                { 
                    MessageBox.Show($"{model.KitapId} No'lu Kitap Veri Tabanınından SİLİNMİŞTİR.");
                }
                else
                {
                    MessageBox.Show("Silme İşlemi BAŞARISIZ.");
                }
            }
            dgvKitaplar.DataSource = helper.VeriAl("SELECT * FROM tblKitaplar");
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            model = new KitapIslemModel()
            {
                KitapId = (int)dgvKitaplar.CurrentRow.Cells[0].Value,   
                KitapAdi = txtKitapAdi.Text,
                Yazar = txtYazar.Text,
                Tur = txtTur.Text,
                Sayfa = Convert.ToInt32(txtSayfa.Text),
                Uygunluk = (int)dgvKitaplar.CurrentRow.Cells[5].Value,
            };   
            if (model.Uygunluk == 0)
            {
                MessageBox.Show("Emanet Verilmiş Kitap GÜNCELLENEMEZ.");
            }
            else
            {
                var result = helper.KitapGuncelle(model);
                if (result) 
                {
                    MessageBox.Show("Güncelleme İşlemi BAŞARILI.");
                }
                else
                {
                    MessageBox.Show("Güncelleme İşlemi YAPILAMADI.");
                }
                
            }
            dgvKitaplar.DataSource = helper.VeriAl("SELECT * FROM tblKitaplar");
        }
        private void txtKitapAdi_TextChanged(object sender, EventArgs e)
        {
            dgvKitaplar.DataSource = helper.VeriAl($"SELECT * FROM tblKitaplar WHERE KitapAdi LIKE '{txtKitapAdi.Text}%'");
        }

        private void dgvKitaplar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKitapAdi.Text = dgvKitaplar.CurrentRow.Cells[1].Value.ToString();
            txtYazar.Text = dgvKitaplar.CurrentRow.Cells[2].Value.ToString();
            txtTur.Text = dgvKitaplar.CurrentRow.Cells[3].Value.ToString();
            txtSayfa.Text = dgvKitaplar.CurrentRow.Cells[4].Value.ToString();
            
        }
    }
}
