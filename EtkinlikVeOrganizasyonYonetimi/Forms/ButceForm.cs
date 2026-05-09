using EtkinlikVeOrganizasyonYonetimi.Database;
using EtkinlikVeOrganizasyonYonetimi.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    public partial class ButceForm : Form
    {
        public ButceForm()
        {
            InitializeComponent();
        }

        private void ButceForm_Load(object sender, EventArgs e)
        {
            EtkinlikRepository repo = new EtkinlikRepository();
            List<Etkinlik> etkinlikler = repo.TumEtkinlikleriGetir();
            cmbEtkinlik.DataSource = etkinlikler;
            cmbEtkinlik.DisplayMember = "EtkinlikAdi";
            cmbEtkinlik.ValueMember = "EtkinlikId";

            dgvMaliyetler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private int SeciliEtkinlikId()
        {
            Etkinlik secilen = (Etkinlik)cmbEtkinlik.SelectedItem;
            return secilen.EtkinlikId;
        }

        private void cmbEtkinlik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEtkinlik.SelectedItem == null) return;
            int etkinlikId = SeciliEtkinlikId();
            ButceyiYukle(etkinlikId);
            MaliyetleriYukle(etkinlikId);
        }

        private void ButceyiYukle(int etkinlikId)
        {
            ButceRepository repo = new ButceRepository();
            Butce butce = repo.ButceGetir(etkinlikId);

            if (butce != null)
            {
                txtPlanlananButce.Text = butce.PlanlananButce.ToString();
                HesaplaVeGoster(etkinlikId, butce.PlanlananButce);
            }
            else
            {
                txtPlanlananButce.Text = "";
                txtGerceklesenToplam.Text = "";
                txtFark.Text = "";
            }
        }

        private void HesaplaVeGoster(int etkinlikId, decimal planlananButce)
        {
            ButceRepository repo = new ButceRepository();
            decimal gerceklesen = repo.GerceklesenToplamGetir(etkinlikId);
            decimal fark = planlananButce - gerceklesen;
            decimal asimYuzdesi = planlananButce > 0 ? (gerceklesen / planlananButce) * 100 : 0;

            txtGerceklesenToplam.Text = gerceklesen.ToString("N2") + " TL";
            txtFark.Text = fark.ToString("N2") + " TL";

            if (asimYuzdesi > 115)
            {
                txtFark.BackColor = System.Drawing.Color.LightCoral;
                MessageBox.Show($"Bütçe %{asimYuzdesi - 100:F0} oranında aşıldı! Yönetici onayı gerekiyor.",
                    "Bütçe Aşımı Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtFark.BackColor = System.Drawing.Color.LightGreen;
            }
        }

        private void MaliyetleriYukle(int etkinlikId)
        {
            ButceRepository repo = new ButceRepository();
            List<GerceklesenMaliyet> maliyetler = repo.MaliyetleriGetir(etkinlikId);

            dgvMaliyetler.DataSource = null;
            dgvMaliyetler.DataSource = maliyetler;

            if (dgvMaliyetler.Columns.Count > 0)
            {
                dgvMaliyetler.Columns["MaliyetId"].Visible = false;
                dgvMaliyetler.Columns["ButceId"].Visible = false;
                dgvMaliyetler.Columns["Aciklama"].HeaderText = "Açıklama";
                dgvMaliyetler.Columns["Tutar"].HeaderText = "Tutar";
                dgvMaliyetler.Columns["Tarih"].HeaderText = "Tarih";
            }
        }

        private void btnButceKaydet_Click(object sender, EventArgs e)
        {
            if (cmbEtkinlik.SelectedItem == null)
            {
                MessageBox.Show("Lütfen etkinlik seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPlanlananButce.Text, out decimal planlananButce))
            {
                MessageBox.Show("Geçerli bir bütçe tutarı girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int etkinlikId = SeciliEtkinlikId();
            ButceRepository repo = new ButceRepository();
            repo.ButceKaydet(etkinlikId, planlananButce);

            MessageBox.Show("Bütçe kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HesaplaVeGoster(etkinlikId, planlananButce);
        }

        private void btnMaliyetEkle_Click(object sender, EventArgs e)
        {
            if (cmbEtkinlik.SelectedItem == null)
            {
                MessageBox.Show("Lütfen etkinlik seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtMaliyetAciklama.Text))
            {
                MessageBox.Show("Açıklama boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtTutar.Text, out decimal tutar))
            {
                MessageBox.Show("Geçerli bir tutar girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int etkinlikId = SeciliEtkinlikId();
            ButceRepository repo = new ButceRepository();
            Butce butce = repo.ButceGetir(etkinlikId);

            if (butce == null)
            {
                MessageBox.Show("Önce bütçe planı oluşturun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GerceklesenMaliyet maliyet = new GerceklesenMaliyet
            {
                ButceId = butce.ButceId,
                Aciklama = txtMaliyetAciklama.Text.Trim(),
                Tutar = tutar,
                Tarih = DateTime.Now
            };

            repo.MaliyetEkle(maliyet);

            txtMaliyetAciklama.Text = "";
            txtTutar.Text = "";

            MaliyetleriYukle(etkinlikId);
            HesaplaVeGoster(etkinlikId, butce.PlanlananButce);
        }

        private void txtPlanlananButce_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
    }
}