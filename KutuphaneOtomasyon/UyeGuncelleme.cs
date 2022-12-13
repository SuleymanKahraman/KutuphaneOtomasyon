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
    public partial class frmUyeGuncelle : Form
    {
        private UyeIslemModel model;
        private DataHelper helper;
        public frmUyeGuncelle(UyeIslemModel model)
        {
            InitializeComponent();
            this.model = model;
            helper = new DataHelper();
        }

        private void UyeGuncelleme_Load(object sender, EventArgs e)
        {
            txtAd.Text = model.Ad;
            txtSoyad.Text = model.Soyad;
            txtMeslek.Text = model.Meslek;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text =="" && txtSoyad.Text=="" && txtMeslek.Text == "")
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz!", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                model.Ad = txtAd.Text;
                model.Soyad = txtSoyad.Text;
                model.Meslek = txtMeslek.Text;  
                var result = helper.UyeGuncelle(model);
                if (result)
                {
                    MessageBox.Show("Güncelleme İşlemi Başarılı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Güncelleme İşlemi Yapılamadı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();   
            }
            
        }
    }
}
