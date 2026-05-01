using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EtkinlikVeOrganizasyonYonetimi.Database;
using EtkinlikVeOrganizasyonYonetimi.Models;

namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    public partial class TedarikciListeForm : Form
    {
        public TedarikciListeForm()
        {
            InitializeComponent();
        }

        private void TedarikciListeForm_Load(object sender, EventArgs e)
        {
            TedarikcileriYukle();
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
                dgvTedarikciler.Columns["FirmaAdi"].HeaderText = "Firma Adı";
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
                MessageBox.Show("Lütfen silmek istediğiniz tedarikçiyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult sonuc = MessageBox.Show("Bu tedarikçiyi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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