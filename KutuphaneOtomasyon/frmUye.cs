using KutuphaneOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{

    public partial class frmUye : Form
    {
        private readonly DataHelper helper;
        private UyeIslemModel model;
        public frmUye()
        {
            InitializeComponent();
            helper = new DataHelper();
            
        }

        private void frmUyeEkle_Load(object sender, EventArgs e)
        {
            VeriYukle();
            Renklendir();
        }
        private void Renklendir()
        {
            for (int i = 0; i < dgvUyeler.Rows.Count - 1; i++)
            {
                if ((int)dgvUyeler.Rows[i].Cells[4].Value >= 50)
                {
                    dgvUyeler.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            if (txtAd.Text=="" || txtSoyad.Text=="" || txtMeslek.Text=="")
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                model = new UyeIslemModel()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Meslek = txtMeslek.Text
                };
                var result = helper.UyeSorgu(model);
                if (result)
                {
                    helper.UyeEkle(model);
                    MessageBox.Show("Kayıt işlemi başarılı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Aynı İsim ve Soyisimde başka bir kullanıcı mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            txtAd.Clear();
            txtSoyad.Clear();
            txtMeslek.Clear();
            VeriYukle();
        }

        private void cezaPuanınıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgvUyeler.CurrentRow.Index;
            int uyeId = (int)dgvUyeler.CurrentRow.Cells[0].Value;
            int cezaPuani = (int)dgvUyeler.CurrentRow.Cells[4].Value;
            if(cezaPuani < 50)
            {
                MessageBox.Show("50 ve üzerindeki ceza puanları silinebilir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool result = helper.UyeCezaPuaniSifirla(uyeId);
                if (result)
                {
                    MessageBox.Show("Ceza Puanı Güncellendi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VeriYukle();
                    Renklendir();
                    dgvUyeler.Rows[selectedIndex].Selected = true;
                    dgvUyeler.Rows[selectedIndex].DefaultCellStyle.BackColor = Color.YellowGreen;
                }
                else
                {
                    MessageBox.Show("Sıfırlama işlemi sırasında bir sorun oluştu.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            
           
        }

        private void VeriYukle()
        {
            dgvUyeler.DataSource = helper.VeriAl("SELECT * FROM tblUyeler");
            dgvUyeler.ClearSelection();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgvUyeler.CurrentRow.Index;
            model = new UyeIslemModel()
            {
                Id = (int)dgvUyeler.CurrentRow.Cells[0].Value,
                Ad = dgvUyeler.CurrentRow.Cells[1].Value.ToString(),
                Soyad = dgvUyeler.CurrentRow.Cells[2].Value.ToString(),
                Meslek = dgvUyeler.CurrentRow.Cells[3].Value.ToString(),
            };
            frmUyeGuncelle frmGuncelle = new frmUyeGuncelle(model);
            frmGuncelle.ShowDialog();
            VeriYukle();
            dgvUyeler.Rows[selectedIndex].Selected = true;
            dgvUyeler.Rows[selectedIndex].DefaultCellStyle.SelectionBackColor = Color.Gray;


        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgvUyeler.CurrentRow.Index;
            model = new UyeIslemModel()
            {
                Id = (int)dgvUyeler.CurrentRow.Cells[0].Value,
            };
            var result = helper.UyeSilme(model);
            if (result)
            {
                MessageBox.Show("UyeSilme İşlemi BAŞARILI.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Silme İşlemi BAŞARISIZ.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            VeriYukle();
        }
    }
}
