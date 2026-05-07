using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EtkinlikVeOrganizasyonYonetimi.Database;
using EtkinlikVeOrganizasyonYonetimi.Models;

namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    public partial class EtkinlikForm : Form
    {
        private Kullanici _aktifKullanici;
        private int _etkinlikId;
        private List<Mekan> _mekanlar;

        public EtkinlikForm(Kullanici kullanici, int etkinlikId = 0)
        {
            InitializeComponent();
            _aktifKullanici = kullanici;
            _etkinlikId = etkinlikId;
        }

        private void EtkinlikForm_Load(object sender, EventArgs e)
        {
            // Durum seceneklerini doldur
            cmbDurum.Items.AddRange(new string[] { "Taslak", "Onaylandi", "Tamamlandi", "Iptal" });
            cmbDurum.SelectedIndex = 0;

            // Mekanlari doldur
            MekanRepository mekanRepo = new MekanRepository();
            _mekanlar = mekanRepo.TumMekanlariGetir();
            cmbMekan.DataSource = _mekanlar;
            cmbMekan.DisplayMember = "MekanAdi";
            cmbMekan.ValueMember = "MekanId";

            // Etkinlik turlerini doldur
            var turRepo = new EtkinlikTurRepository();
            var turler = turRepo.TumTurleriGetir();
            cmbTur.DataSource = turler;
            cmbTur.DisplayMember = "TurAdi";
            cmbTur.ValueMember = "TurId";

            // Musteri kullanicilari doldur
            KullaniciRepository kullaniciRepo = new KullaniciRepository();
            List<Kullanici> musteriler = kullaniciRepo.SadeceMusterileriGetir();
            cmbMusteriKullanici.DataSource = musteriler;
            cmbMusteriKullanici.DisplayMember = "KullaniciAdi";
            cmbMusteriKullanici.ValueMember = "KullaniciId";

            // Duzenleme modundaysa mevcut veriyi yukle
            if (_etkinlikId > 0)
            {
                EtkinlikRepository repo = new EtkinlikRepository();
                Etkinlik etkinlik = repo.EtkinlikGetir(_etkinlikId);

                txtEtkinlikAdi.Text = etkinlik.EtkinlikAdi;
                txtMusteriAdi.Text = etkinlik.MusteriAdi;
                txtMusteriTelefon.Text = etkinlik.MusteriTelefon;
                txtSozlesmeBedeli.Text = etkinlik.SozlesmeBedeli.ToString();
                dtpBaslangic.Value = etkinlik.BaslangicTarihi;
                dtpBitis.Value = etkinlik.BitisTarihi;
                cmbDurum.SelectedItem = etkinlik.Durum;
                cmbTur.SelectedValue = etkinlik.TurId;
                cmbMekan.SelectedValue = etkinlik.MekanId;

                if (etkinlik.MusteriKullaniciId.HasValue)
                    cmbMusteriKullanici.SelectedValue = etkinlik.MusteriKullaniciId.Value;

                this.Text = "Etkinlik Duzenle";
            }
            else
            {
                this.Text = "Yeni Etkinlik";
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEtkinlikAdi.Text) ||
                string.IsNullOrEmpty(txtMusteriAdi.Text) ||
                string.IsNullOrEmpty(txtSozlesmeBedeli.Text))
            {
                MessageBox.Show("Lutfen zorunlu alanlari doldurun.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpBitis.Value <= dtpBaslangic.Value)
            {
                MessageBox.Show("Bitis tarihi baslangic tarihinden sonra olmalidir.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtSozlesmeBedeli.Text, out decimal sozlesmeBedeli))
            {
                MessageBox.Show("Sozlesme bedeli gecerli bir sayi olmalidir.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Mekan secilenMekan = (Mekan)cmbMekan.SelectedItem;

            EtkinlikRepository repo = new EtkinlikRepository();
            bool cakismaVar = repo.CakismaVarMi(
                secilenMekan.MekanId,
                dtpBaslangic.Value,
                dtpBitis.Value,
                secilenMekan.KurulumSuresiSaat,
                _etkinlikId > 0 ? _etkinlikId : (int?)null
            );

            if (cakismaVar)
            {
                MessageBox.Show("Secilen mekan bu tarihte baska bir etkinlik icin rezerve edilmis!", "Cakisma Uyarisi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Musteri kullanici secimi
            int? musteriKullaniciId = null;
            if (cmbMusteriKullanici.SelectedItem != null)
            {
                Kullanici secilenKullanici = (Kullanici)cmbMusteriKullanici.SelectedItem;
                musteriKullaniciId = secilenKullanici.KullaniciId;
            }

            Etkinlik etkinlik = new Etkinlik
            {
                EtkinlikId = _etkinlikId,
                EtkinlikAdi = txtEtkinlikAdi.Text.Trim(),
                TurId = (int)cmbTur.SelectedValue,
                MekanId = secilenMekan.MekanId,
                BaslangicTarihi = dtpBaslangic.Value,
                BitisTarihi = dtpBitis.Value,
                MusteriAdi = txtMusteriAdi.Text.Trim(),
                MusteriTelefon = txtMusteriTelefon.Text.Trim(),
                Durum = cmbDurum.SelectedItem.ToString(),
                SozlesmeBedeli = sozlesmeBedeli,
                OlusturanKullaniciId = _aktifKullanici.KullaniciId,
                MusteriKullaniciId = musteriKullaniciId
            };

            if (_etkinlikId == 0)
                repo.EtkinlikEkle(etkinlik);
            else
                repo.EtkinlikGuncelle(etkinlik);

            MessageBox.Show("Etkinlik basariyla kaydedildi.", "Basarili", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Sozlesme bedeli ve telefon ==> sadece rakam girilebilir
        private void txtSozlesmeBedeli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txtMusteriTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
    }
}