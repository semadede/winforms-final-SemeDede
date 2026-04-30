using System;
using System.Windows.Forms;
using EtkinlikVeOrganizasyonYonetimi.Database;
using EtkinlikVeOrganizasyonYonetimi.Models;

namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    public partial class MekanForm : Form
    {
        public MekanForm()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Boş alan kontrolü
            if (string.IsNullOrEmpty(txtMekanAdi.Text) ||
                string.IsNullOrEmpty(txtKapasite.Text) ||
                string.IsNullOrEmpty(txtKurulumSuresi.Text))
            {
                MessageBox.Show("Lütfen zorunlu alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kapasite sayı kontrolü
            if (!int.TryParse(txtKapasite.Text, out int kapasite))
            {
                MessageBox.Show("Kapasite geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kurulum süresi sayı kontrolü
            if (!int.TryParse(txtKurulumSuresi.Text, out int kurulumSuresi))
            {
                MessageBox.Show("Kurulum süresi geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Mekan mekan = new Mekan
            {
                MekanAdi = txtMekanAdi.Text.Trim(),
                Kapasite = kapasite,
                Adres = txtAdres.Text.Trim(),
                KurulumSuresiSaat = kurulumSuresi
            };

            MekanRepository repo = new MekanRepository();
            repo.MekanEkle(mekan);

            MessageBox.Show("Mekan başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}