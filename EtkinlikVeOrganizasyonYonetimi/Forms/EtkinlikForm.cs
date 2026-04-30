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
        private int _etkinlikId; // 0 ise yeni kayıt, > 0 ise düzenleme
        private List<Mekan> _mekanlar;

        public EtkinlikForm(Kullanici kullanici, int etkinlikId = 0)
        {
            InitializeComponent();
            _aktifKullanici = kullanici;
            _etkinlikId = etkinlikId;
        }

        private void EtkinlikForm_Load(object sender, EventArgs e)
        {
            // Durum seçeneklerini doldur
            cmbDurum.Items.AddRange(new string[] { "Taslak", "Onaylandi", "Tamamlandi", "Iptal" });
            cmbDurum.SelectedIndex = 0;

            // Türleri veritabanından doldur
            MekanRepository mekanRepo = new MekanRepository();
            _mekanlar = mekanRepo.TumMekanlariGetir();
            cmbMekan.DataSource = _mekanlar;
            cmbMekan.DisplayMember = "MekanAdi";
            cmbMekan.ValueMember = "MekanId";

            // Etkinlik türlerini doldur
            var turRepo = new EtkinlikTurRepository();
            var turler = turRepo.TumTurleriGetir();
            cmbTur.DataSource = turler;
            cmbTur.DisplayMember = "TurAdi";
            cmbTur.ValueMember = "TurId";

            // Düzenleme modundaysa mevcut veriyi yükle
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

                this.Text = "Etkinlik Düzenle";
            }
            else
            {
                this.Text = "Yeni Etkinlik";
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Boş alan kontrolü
            if (string.IsNullOrEmpty(txtEtkinlikAdi.Text) ||
                string.IsNullOrEmpty(txtMusteriAdi.Text) ||
                string.IsNullOrEmpty(txtSozlesmeBedeli.Text))
            {
                MessageBox.Show("Lütfen zorunlu alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tarih kontrolü
            if (dtpBitis.Value <= dtpBaslangic.Value)
            {
                MessageBox.Show("Bitiş tarihi başlangıç tarihinden sonra olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sözleşme bedeli sayı kontrolü
            if (!decimal.TryParse(txtSozlesmeBedeli.Text, out decimal sozlesmeBedeli))
            {
                MessageBox.Show("Sözleşme bedeli geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçilen mekanın kurulum süresini al
            Mekan secilenMekan = (Mekan)cmbMekan.SelectedItem;

            // Çakışma kontrolü
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
                MessageBox.Show("Seçilen mekan bu tarihte başka bir etkinlik için rezerve edilmiş!", "Çakışma Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
                OlusturanKullaniciId = _aktifKullanici.KullaniciId
            };

            if (_etkinlikId == 0)
                repo.EtkinlikEkle(etkinlik);
            else
                repo.EtkinlikGuncelle(etkinlik);

            MessageBox.Show("Etkinlik başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}