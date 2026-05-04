using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EtkinlikVeOrganizasyonYonetimi.Database;
using EtkinlikVeOrganizasyonYonetimi.Models;
using EtkinlikVeOrganizasyonYonetimi.Reports;

namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    public partial class FaturaForm : Form
    {
        public FaturaForm()
        {
            InitializeComponent();
        }

        private void FaturaForm_Load(object sender, EventArgs e)
        {
            EtkinlikRepository repo = new EtkinlikRepository();
            List<Etkinlik> etkinlikler = repo.TumEtkinlikleriGetir();
            cmbEtkinlik.DataSource = etkinlikler;
            cmbEtkinlik.DisplayMember = "EtkinlikAdi";
            cmbEtkinlik.ValueMember = "EtkinlikId";
        }

        private Etkinlik SeciliEtkinlik()
        {
            return (Etkinlik)cmbEtkinlik.SelectedItem;
        }

        private void btnFaturaOlustur_Click(object sender, EventArgs e)
        {
            if (cmbEtkinlik.SelectedItem == null)
            {
                MessageBox.Show("Lütfen etkinlik seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Etkinlik etkinlik = SeciliEtkinlik();
            ButceRepository butceRepo = new ButceRepository();
            Butce butce = butceRepo.ButceGetir(etkinlik.EtkinlikId);

            if (butce == null)
            {
                MessageBox.Show("Bu etkinlik için bütçe tanımlanmamış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal gerceklesen = butceRepo.GerceklesenToplamGetir(etkinlik.EtkinlikId);
            List<GerceklesenMaliyet> maliyetler = butceRepo.MaliyetleriGetir(etkinlik.EtkinlikId);

            PdfRaporHelper.FaturaOlustur(etkinlik, butce, gerceklesen, maliyetler);
        }

        private void btnButceRaporu_Click(object sender, EventArgs e)
        {
            if (cmbEtkinlik.SelectedItem == null)
            {
                MessageBox.Show("Lütfen etkinlik seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Etkinlik etkinlik = SeciliEtkinlik();
            ButceRepository butceRepo = new ButceRepository();
            Butce butce = butceRepo.ButceGetir(etkinlik.EtkinlikId);

            if (butce == null)
            {
                MessageBox.Show("Bu etkinlik için bütçe tanımlanmamış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal gerceklesen = butceRepo.GerceklesenToplamGetir(etkinlik.EtkinlikId);
            List<GerceklesenMaliyet> maliyetler = butceRepo.MaliyetleriGetir(etkinlik.EtkinlikId);

            PdfRaporHelper.ButceRaporuOlustur(etkinlik, butce, gerceklesen, maliyetler);
        }
    }
}