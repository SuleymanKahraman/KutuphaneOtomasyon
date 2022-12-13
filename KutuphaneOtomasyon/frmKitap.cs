using KutuphaneOtomasyon.Models;
using System;
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
                MessageBox.Show("Alanları boş bırakmayınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model = new KitapIslemModel()
            {
                KitapId = (int)dgvKitaplar.CurrentRow.Cells[0].Value,
                KitapAdi = dgvKitaplar.CurrentRow.Cells[1].Value.ToString(),
                Yazar = dgvKitaplar.CurrentRow.Cells[2].Value.ToString(),
                Tur = dgvKitaplar.CurrentRow.Cells[3].Value.ToString(),
                Sayfa = (int)dgvKitaplar.CurrentRow.Cells[4].Value,
                Uygunluk = (int)dgvKitaplar.CurrentRow.Cells[5].Value,
            };
            frmKitapGuncelle frmGuncelle = new frmKitapGuncelle(model);
            frmGuncelle.ShowDialog();
            dgvKitaplar.DataSource = helper.VeriAl("SELECT * FROM tblKitaplar");
            dgvKitaplar.ClearSelection();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                model = new KitapIslemModel()
                {
                    KitapId = (int)dgvKitaplar.CurrentRow.Cells[0].Value,
                    Uygunluk = (int)dgvKitaplar.CurrentRow.Cells[5].Value,
                };
                if (model.Uygunluk == 0)
                {
                    MessageBox.Show("Emanet Verilmiş Kitap Silinemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var result = helper.KitapSilme(model);
                    if (result)
                    {
                        MessageBox.Show($"{model.KitapId} No'lu Kitap Veri Tabanınından Silinmiştir.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Silme İşlemi Başarısız.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                dgvKitaplar.DataSource = helper.VeriAl("SELECT * FROM tblKitaplar");
                dgvKitaplar.ClearSelection();
            }

        }
    }
}