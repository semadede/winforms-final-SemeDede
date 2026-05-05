using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EtkinlikVeOrganizasyonYonetimi.Database;
using EtkinlikVeOrganizasyonYonetimi.Models;

namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    public partial class TedarikciListeForm : Form
    {
        private Kullanici _aktifKullanici;

        public TedarikciListeForm(Kullanici kullanici)
        {
            InitializeComponent();
            _aktifKullanici = kullanici;
        }

        private void TedarikciListeForm_Load(object sender, EventArgs e)
        {
            TedarikcileriYukle();
            // Sadece Admin silebilir
            btnSil.Visible = _aktifKullanici.Rol == "Admin";
        }

        private void TedarikcileriYukle()
        {
            TedarikciRepository repo = new TedarikciRepository();
            List<Tedarikci> tedarikciler = repo.TumTedarikcileriGetir();

            dgvTedarikciler.DataSource = null;
            dgvTedarikciler.DataSource = tedarikciler;

            if (dgvTedarikciler.Columns.Count > 0)
            {
                dgvTedarikciler.Columns["TedarikciId"].HeaderText = "ID";
                dgvTedarikciler.Columns["FirmaAdi"].HeaderText = "Firma Adi";
                dgvTedarikciler.Columns["KategoriAdi"].HeaderText = "Kategori";
                dgvTedarikciler.Columns["Telefon"].HeaderText = "Telefon";
                dgvTedarikciler.Columns["Aktif"].HeaderText = "Aktif";
                dgvTedarikciler.Columns["KategoriId"].Visible = false;
            }
        }

        private void btnYeniTedarikci_Click(object sender, EventArgs e)
        {
            TedarikciForm form = new TedarikciForm();
            form.ShowDialog();
            TedarikcileriYukle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvTedarikciler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lutfen silmek istediginiz tedarikciy seciniz.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult sonuc = MessageBox.Show("Bu tedarikciy silmek istediginize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                int tedarikciId = (int)dgvTedarikciler.SelectedRows[0].Cells["TedarikciId"].Value;
                TedarikciRepository repo = new TedarikciRepository();
                repo.TedarikciSil(tedarikciId);
                TedarikcileriYukle();
            }
        }
    }
}   