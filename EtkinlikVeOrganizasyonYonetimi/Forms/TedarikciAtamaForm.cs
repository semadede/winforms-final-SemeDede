using EtkinlikVeOrganizasyonYonetimi.Database;
using EtkinlikVeOrganizasyonYonetimi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    public partial class TedarikciAtamaForm : Form
    {
        public TedarikciAtamaForm()
        {
            InitializeComponent();
        }

        private void TedarikciAtamaForm_Load(object sender, EventArgs e)
        {
            // Etkinlikleri doldur
            EtkinlikRepository etkinlikRepo = new EtkinlikRepository();
            List<Etkinlik> etkinlikler = etkinlikRepo.TumEtkinlikleriGetir();
            cmbEtkinlik.DataSource = etkinlikler;
            cmbEtkinlik.DisplayMember = "EtkinlikAdi";
            cmbEtkinlik.ValueMember = "EtkinlikId";

            // Tedarikçileri doldur
            TedarikciRepository tedarikciRepo = new TedarikciRepository();
            List<Tedarikci> tedarikciler = tedarikciRepo.TumTedarikcileriGetir();
            cmbTedarikci.DataSource = tedarikciler;
            cmbTedarikci.DisplayMember = "FirmaAdi";
            cmbTedarikci.ValueMember = "TedarikciId";

            // Etkinlik seçilince atananları yükle
            AtananlariYukle();
        }

        private void cmbEtkinlik_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtananlariYukle();
        }

        private void AtananlariYukle()
        {
            if (cmbEtkinlik.SelectedValue == null || !(cmbEtkinlik.SelectedValue is int)) return;
            int etkinlikId = Convert.ToInt32(cmbEtkinlik.SelectedValue);
            EtkinlikTedarikciRepository repo = new EtkinlikTedarikciRepository();
            List<EtkinlikTedarikci> atananlar = repo.EtkinlikTedarikcileriniGetir(etkinlikId);

            dgvAtananTedarikciler.DataSource = null;
            dgvAtananTedarikciler.DataSource = atananlar;

            if (dgvAtananTedarikciler.Columns.Count > 0)
            {
                dgvAtananTedarikciler.Columns["Id"].Visible = false;
                dgvAtananTedarikciler.Columns["EtkinlikId"].Visible = false;
                dgvAtananTedarikciler.Columns["TedarikciId"].Visible = false;
                dgvAtananTedarikciler.Columns["FirmaAdi"].HeaderText = "Firma";
                dgvAtananTedarikciler.Columns["TeslimTarihi"].HeaderText = "Teslim Tarihi";
                dgvAtananTedarikciler.Columns["TeslimOnaylandi"].HeaderText = "Onaylandı";
                dgvAtananTedarikciler.Columns["Durum"].HeaderText = "Durum";
                dgvAtananTedarikciler.Columns["Notlar"].HeaderText = "Notlar";
            }
        }

        private void btnAta_Click(object sender, EventArgs e)
        {
            if (cmbEtkinlik.SelectedValue == null || cmbTedarikci.SelectedValue == null)
            {
                MessageBox.Show("Lütfen etkinlik ve tedarikçi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int etkinlikId = (int)cmbEtkinlik.SelectedValue;
            int tedarikciId = (int)cmbTedarikci.SelectedValue;

            // 48 saat uyarısı kontrolü
            EtkinlikRepository etkinlikRepo = new EtkinlikRepository();
            Etkinlik etkinlik = etkinlikRepo.EtkinlikGetir(etkinlikId);

            TimeSpan kalanSure = etkinlik.BaslangicTarihi - DateTime.Now;
            if (kalanSure.TotalHours < 48)
            {
                DialogResult uyari = MessageBox.Show(
                    $"Etkinliğe {kalanSure.TotalHours:F0} saat kaldı! Bu kadar kısa sürede tedarikçi atamak istediğinize emin misiniz?",
                    "48 Saat Uyarısı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (uyari == DialogResult.No) return;
            }

            EtkinlikTedarikci atama = new EtkinlikTedarikci
            {
                EtkinlikId = etkinlikId,
                TedarikciId = tedarikciId,
                TeslimTarihi = dtpTeslimTarihi.Value,
                TeslimOnaylandi = false,
                Notlar = txtNotlar.Text.Trim(),
                Durum = "Beklemede"
            };

            EtkinlikTedarikciRepository repo = new EtkinlikTedarikciRepository();
            repo.TedarikciAta(atama);

            MessageBox.Show("Tedarikçi başarıyla atandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AtananlariYukle();
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvAtananTedarikciler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lutfen silmek istediginiz atamay secin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult sonuc = MessageBox.Show("Bu atamay silmek istediginize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                int id = (int)dgvAtananTedarikciler.SelectedRows[0].Cells["Id"].Value;
                EtkinlikTedarikciRepository repo = new EtkinlikTedarikciRepository();
                repo.AtamaSil(id);
                AtananlariYukle();
            }
        }


        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}