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
            dgvUyeler.DataSource = helper.VeriAl("SELECT * FROM tblUyeler");
        }
        private UyeIslemModel GetData()
        {
            UyeIslemModel model = new UyeIslemModel()
            {
                Id= (int)dgvUyeler.CurrentRow.Cells[0].Value,
                
            };
            return model;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            if (txtAd.Text=="" || txtSoyad.Text=="" || txtMeslek.Text=="")
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz!");
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
                    MessageBox.Show("Aynı İsim ve Soyisimde başka bir kullanıcı mevcut.");
                }
                
            }
            txtAd.Clear();
            txtSoyad.Clear();
            txtMeslek.Clear();
            dgvUyeler.DataSource = helper.VeriAl("SELECT * FROM tblUyeler");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            model = new UyeIslemModel()
            {
                Id = (int)dgvUyeler.CurrentRow.Cells[0].Value,
            };
            var result = helper.UyeSilme(model);
            if (result)
            {
                MessageBox.Show("UyeSilme İşlemi BAŞARILI.");
            }
            else
            {
                MessageBox.Show("Silme İşlemi BAŞARISIZ.");
            }
            dgvUyeler.DataSource = helper.VeriAl("SELECT * FROM tblUyeler");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            model = new UyeIslemModel()
            {
                Id = (int)dgvUyeler.CurrentRow.Cells[0].Value,
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Meslek = txtMeslek.Text
            };
            var result = helper.UyeGuncelle(model);
            if (result)
            {
                MessageBox.Show("Güncelleme İşlemi Başarılı.");
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi YAPILAMADI.");
            }
            dgvUyeler.DataSource = helper.VeriAl("SELECT * FROM tblUyeler");
        }

        private void dgvUyeler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dgvUyeler.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgvUyeler.CurrentRow.Cells[2].Value.ToString();
            txtMeslek.Text = dgvUyeler.CurrentRow.Cells[3].Value.ToString();
        }

        private void cezaPuanınıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgvUyeler.CurrentRow.Index;
            int uyeId = (int)dgvUyeler.CurrentRow.Cells[0].Value;
            bool result = helper.UyeCezaPuaniSifirla(uyeId);
            if (result)
            {
                MessageBox.Show("Sıfırlama işleminiz başarılı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvUyeler.DataSource = helper.VeriAl("SELECT * FROM tblUyeler");


                dgvUyeler.ClearSelection();
                dgvUyeler.Rows[selectedIndex].Selected = true;
                dgvUyeler.Rows[selectedIndex].DefaultCellStyle.SelectionBackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Sıfırlama işlemi sırasında bir sorun oluştu.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
