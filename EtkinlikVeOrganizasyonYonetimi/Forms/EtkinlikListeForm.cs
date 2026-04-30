using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using EtkinlikVeOrganizasyonYonetimi.Database;
using EtkinlikVeOrganizasyonYonetimi.Models;

namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    public partial class EtkinlikListeForm : Form
    {
        private Kullanici _aktifKullanici;

        public EtkinlikListeForm(Kullanici kullanici)
        {
            InitializeComponent();
            _aktifKullanici = kullanici;
        }

        private void EtkinlikListeForm_Load(object sender, EventArgs e)
        {
            EtkinlikleriYukle();
        }

        private void EtkinlikleriYukle()
        {
            EtkinlikRepository repo = new EtkinlikRepository();
            List<Etkinlik> etkinlikler = repo.TumEtkinlikleriGetir();

            dgvEtkinlikler.DataSource = null;
            dgvEtkinlikler.DataSource = etkinlikler;

            // Kolon başlıklarını Türkçe yap
            if (dgvEtkinlikler.Columns.Count > 0)
            {
                dgvEtkinlikler.Columns["EtkinlikId"].HeaderText = "ID";
                dgvEtkinlikler.Columns["EtkinlikAdi"].HeaderText = "Etkinlik Adı";
                dgvEtkinlikler.Columns["TurAdi"].HeaderText = "Tür";
                dgvEtkinlikler.Columns["MekanAdi"].HeaderText = "Mekan";
                dgvEtkinlikler.Columns["BaslangicTarihi"].HeaderText = "Başlangıç";
                dgvEtkinlikler.Columns["BitisTarihi"].HeaderText = "Bitiş";
                dgvEtkinlikler.Columns["MusteriAdi"].HeaderText = "Müşteri";
                dgvEtkinlikler.Columns["Durum"].HeaderText = "Durum";
                dgvEtkinlikler.Columns["SozlesmeBedeli"].HeaderText = "Sözleşme Bedeli";

                // Gereksiz kolonları gizle
                dgvEtkinlikler.Columns["TurId"].Visible = false;
                dgvEtkinlikler.Columns["MekanId"].Visible = false;
                dgvEtkinlikler.Columns["MusteriTelefon"].Visible = false;
                dgvEtkinlikler.Columns["OlusturanKullaniciId"].Visible = false;
            }
        }

        private void btnYeniEtkinlik_Click(object sender, EventArgs e)
        {
            EtkinlikForm form = new EtkinlikForm(_aktifKullanici);
            form.ShowDialog();
            EtkinlikleriYukle(); // Form kapanınca listeyi yenile
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvEtkinlikler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz etkinliği seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int etkinlikId = (int)dgvEtkinlikler.SelectedRows[0].Cells["EtkinlikId"].Value;
            EtkinlikForm form = new EtkinlikForm(_aktifKullanici, etkinlikId);
            form.ShowDialog();
            EtkinlikleriYukle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvEtkinlikler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz etkinliği seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult sonuc = MessageBox.Show("Bu etkinliği silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                int etkinlikId = (int)dgvEtkinlikler.SelectedRows[0].Cells["EtkinlikId"].Value;
                EtkinlikRepository repo = new EtkinlikRepository();
                repo.EtkinlikSil(etkinlikId);
                EtkinlikleriYukle();
            }
        }

    }
}