using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EtkinlikVeOrganizasyonYonetimi.Database;
using EtkinlikVeOrganizasyonYonetimi.Models;

namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    public partial class MekanListeForm : Form
    {
        private Kullanici _aktifKullanici;

        public MekanListeForm(Kullanici kullanici)
        {
            InitializeComponent();
            _aktifKullanici = kullanici;
        }

        private void MekanListeForm_Load(object sender, EventArgs e)
        {
            MekanlariYukle();
            // Sadece Admin silebilir
            btnSil.Visible = _aktifKullanici.Rol == "Admin";
            dgvMekanlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void MekanlariYukle()
        {
            MekanRepository repo = new MekanRepository();
            List<Mekan> mekanlar = repo.TumMekanlariGetir();

            dgvMekanlar.DataSource = null;
            dgvMekanlar.DataSource = mekanlar;

            if (dgvMekanlar.Columns.Count > 0)
            {
                dgvMekanlar.Columns["MekanId"].HeaderText = "ID";
                dgvMekanlar.Columns["MekanAdi"].HeaderText = "Mekan Adi";
                dgvMekanlar.Columns["Kapasite"].HeaderText = "Kapasite";
                dgvMekanlar.Columns["Adres"].HeaderText = "Adres";
                dgvMekanlar.Columns["KurulumSuresiSaat"].HeaderText = "Kurulum Suresi (Saat)";
            }
        }

        private void btnYeniMekan_Click(object sender, EventArgs e)
        {
            MekanForm form = new MekanForm();
            form.ShowDialog();
            MekanlariYukle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvMekanlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lutfen silmek istediginiz mekani secin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult sonuc = MessageBox.Show("Bu mekani silmek istediginize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                int mekanId = (int)dgvMekanlar.SelectedRows[0].Cells["MekanId"].Value;
                MekanRepository repo = new MekanRepository();
                repo.MekanSil(mekanId);
                MekanlariYukle();
            }
        }
    }
}