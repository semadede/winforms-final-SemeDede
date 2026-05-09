using System;
using System.Windows.Forms;
using EtkinlikVeOrganizasyonYonetimi.Database;
using EtkinlikVeOrganizasyonYonetimi.Models;

namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    public partial class LoginForm : Form
    {
        public Kullanici GirisYapanKullanici { get; private set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KullaniciRepository repo = new KullaniciRepository();
            Kullanici kullanici = repo.GirisYap(kullaniciAdi, sifre);

            if (kullanici == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Hos geldiniz, {kullanici.KullaniciAdi}!", "Basarili", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GirisYapanKullanici = kullanici;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}