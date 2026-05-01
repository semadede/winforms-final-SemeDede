using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EtkinlikVeOrganizasyonYonetimi.Database;
using EtkinlikVeOrganizasyonYonetimi.Models;

namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    public partial class TedarikciForm : Form
    {
        public TedarikciForm()
        {
            InitializeComponent();
        }

        private void TedarikciForm_Load(object sender, EventArgs e)
        {
            // Kategorileri veritabanından doldur
            KategoriRepository repo = new KategoriRepository();
            List<Kategori> kategoriler = repo.TumKategorileriGetir();
            cmbKategori.DataSource = kategoriler;
            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.ValueMember = "KategoriId";

            // Varsayılan olarak aktif işaretli gelsin
            chkAktif.Checked = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirmaAdi.Text))
            {
                MessageBox.Show("Firma adı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Tedarikci tedarikci = new Tedarikci
            {
                FirmaAdi = txtFirmaAdi.Text.Trim(),
                KategoriId = (int)cmbKategori.SelectedValue,
                Telefon = txtTelefon.Text.Trim(),
                Aktif = chkAktif.Checked
            };

            TedarikciRepository repo = new TedarikciRepository();
            repo.TedarikciEkle(tedarikci);

            MessageBox.Show("Tedarikçi başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}