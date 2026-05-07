using System;
using System.Windows.Forms;
using EtkinlikVeOrganizasyonYonetimi.Models;

namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    public partial class AnaForm : Form
    {
        private Kullanici _aktifKullanici;

        public AnaForm(Kullanici kullanici)
        {
            InitializeComponent();
            _aktifKullanici = kullanici;
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Etkinlik Yonetim Sistemi - {_aktifKullanici.KullaniciAdi} ({_aktifKullanici.Rol})";

            // Kullanici rolundeyse bazi menuler gizlensin
            if (_aktifKullanici.Rol != "Admin")
            {
                mekanYönetimiToolStripMenuItem.Visible = false;
                tedarikçiListesiToolStripMenuItem.Visible = false;
                etkinliğeTedarikçiAtaToolStripMenuItem.Visible = false;
                faturaOluşturToolStripMenuItem.Visible = false;
                kullanıcıYönetimiToolStripMenuItem.Visible = false;
                bütçeYönetimiToolStripMenuItem.Visible = false;
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Cıkmak istediginize emin misiniz?", "Cikis", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

       

        private void etkinlikListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EtkinlikListeForm form = new EtkinlikListeForm(_aktifKullanici);
            form.ShowDialog();
        }

        private void mekanYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MekanListeForm form = new MekanListeForm(_aktifKullanici);
            form.ShowDialog();
        }

        private void tedarikçiListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TedarikciListeForm form = new TedarikciListeForm(_aktifKullanici);
            form.ShowDialog();
        }

        private void etkinliğeTedarikçiAtaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TedarikciAtamaForm form = new TedarikciAtamaForm();
            form.ShowDialog();
        }

        private void bütçeYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButceForm form = new ButceForm();
            form.ShowDialog();
        }

        private void faturaOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Sadece Admin fatura oluşturabilir
            if (_aktifKullanici.Rol != "Admin")
            {
                MessageBox.Show("Fatura oluşturma yetkisine sahip değilsiniz.", "Yetki Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FaturaForm form = new FaturaForm();
            form.ShowDialog();
        }

        private void kullanıcıYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciYonetimForm form = new KullaniciYonetimForm();
            form.ShowDialog();
        }

       
       
    }
}