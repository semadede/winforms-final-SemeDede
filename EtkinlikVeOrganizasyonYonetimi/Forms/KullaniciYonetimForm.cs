using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EtkinlikVeOrganizasyonYonetimi.Database;
using EtkinlikVeOrganizasyonYonetimi.Models;

namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    public partial class KullaniciYonetimForm : Form
    {
        public KullaniciYonetimForm()
        {
            InitializeComponent();
        }

        private void KullaniciYonetimForm_Load(object sender, EventArgs e)
        {
            // Rol seçeneklerini doldur
            cmbRol.Items.AddRange(new string[] { "Admin", "Kullanici" });
            cmbRol.SelectedIndex = 1;

            KullanicilariYukle();

            dgvKullanicilar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void KullanicilariYukle()
        {
            KullaniciRepository repo = new KullaniciRepository();
            List<Kullanici> kullanicilar = repo.TumKullanicilariGetir();

            dgvKullanicilar.DataSource = null;
            dgvKullanicilar.DataSource = kullanicilar;

            if (dgvKullanicilar.Columns.Count > 0)
            {
                dgvKullanicilar.Columns["KullaniciId"].HeaderText = "ID";
                dgvKullanicilar.Columns["KullaniciAdi"].HeaderText = "Kullanici Adi";
                dgvKullanicilar.Columns["Rol"].HeaderText = "Rol";
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) ||
                string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Kullanici adi ve sifre bos birakilamaz.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbRol.SelectedItem == null)
            {
                MessageBox.Show("Lutfen rol secin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string rol = cmbRol.SelectedItem.ToString();

            KullaniciRepository repo = new KullaniciRepository();
            repo.KullaniciEkle(txtKullaniciAdi.Text.Trim(), txtSifre.Text.Trim(), rol);

            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            cmbRol.SelectedIndex = 1;

            MessageBox.Show("Kullanici basariyla eklendi.", "Basarili", MessageBoxButtons.OK, MessageBoxIcon.Information);
            KullanicilariYukle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvKullanicilar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lutfen silmek istediginiz kullaniciy secin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string seciliAd = dgvKullanicilar.SelectedRows[0].Cells["KullaniciAdi"].Value.ToString();

            // Admin kendini silemesin
            if (seciliAd == "admin")
            {
                MessageBox.Show("Admin hesabi silinemez.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult sonuc = MessageBox.Show("Bu kullaniciy silmek istediginize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                int kullaniciId = (int)dgvKullanicilar.SelectedRows[0].Cells["KullaniciId"].Value;
                KullaniciRepository repo = new KullaniciRepository();
                repo.KullaniciSil(kullaniciId);
                KullanicilariYukle();
            }
        }
    }
}