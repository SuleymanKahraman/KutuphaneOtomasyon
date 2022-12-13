using KutuphaneOtomasyon.Models;
using System;

using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class frmKitapGuncelle : Form
    {
        private KitapIslemModel model;
        private DataHelper helper;
        public frmKitapGuncelle(KitapIslemModel model)
        {
            InitializeComponent();
            this.model = model;
            helper = new DataHelper();
        }

        private void frmKitapGuncelle_Load(object sender, EventArgs e)
        {
            txtKitapAdi.Text = model.KitapAdi;
            txtSayfa.Text = model.Sayfa.ToString();
            txtTur.Text = model.Tur;
            txtYazar.Text = model.Yazar;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (model.Uygunluk == 0)
            {
                MessageBox.Show("Emanet Verilmiş Kitap Güncellenemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                model.KitapAdi = txtKitapAdi.Text;
                model.Yazar = txtYazar.Text;
                model.Tur = txtTur.Text;
                model.Sayfa = int.Parse(txtSayfa.Text);
                var result = helper.KitapGuncelle(model);
                if (result)
                {
                    MessageBox.Show("Güncelleme İşlemi Başarılı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Güncelleme İşlemi Yapılamadı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
