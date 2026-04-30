using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EtkinlikVeOrganizasyonYonetimi.Database;
using EtkinlikVeOrganizasyonYonetimi.Models;

namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    public partial class MekanListeForm : Form
    {
        public MekanListeForm()
        {
            InitializeComponent();
        }

        private void MekanListeForm_Load(object sender, EventArgs e)
        {
            MekanlariYukle();
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
                dgvMekanlar.Columns["MekanAdi"].HeaderText = "Mekan Adı";
                dgvMekanlar.Columns["Kapasite"].HeaderText = "Kapasite";
                dgvMekanlar.Columns["Adres"].HeaderText = "Adres";
                dgvMekanlar.Columns["KurulumSuresiSaat"].HeaderText = "Kurulum Süresi (Saat)";
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
                MessageBox.Show("Lütfen silmek istediğiniz mekanı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult sonuc = MessageBox.Show("Bu mekanı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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