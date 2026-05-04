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
            this.Text = $"Etkinlik Yönetim Sistemi - {_aktifKullanici.KullaniciAdi} ({_aktifKullanici.Rol})";
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void etkinlikYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void etkinlikListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EtkinlikListeForm form = new EtkinlikListeForm(_aktifKullanici);
            form.ShowDialog();
        }

        private void mekanYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MekanListeForm form = new MekanListeForm();
            form.ShowDialog();
        }

        private void tedarikçiListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TedarikciListeForm form = new TedarikciListeForm();
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
            FaturaForm form = new FaturaForm();
            form.ShowDialog();
        }
    }
}