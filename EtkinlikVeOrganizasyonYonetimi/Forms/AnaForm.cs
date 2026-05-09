using EtkinlikVeOrganizasyonYonetimi.Database;
using EtkinlikVeOrganizasyonYonetimi.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

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
            this.WindowState = FormWindowState.Maximized;

            if (_aktifKullanici.Rol != "Admin")
            {
                mekanYönetimiToolStripMenuItem.Visible = false;
                tedarikçiListesiToolStripMenuItem.Visible = false;
                etkinliğeTedarikçiAtaToolStripMenuItem.Visible = false;
                faturaOluşturToolStripMenuItem.Visible = false;
                kullanıcıYönetimiToolStripMenuItem.Visible = false;
                bütçeYönetimiToolStripMenuItem.Visible = false;
            }

            DashboardYukle();
        }

        private void DashboardYukle()
        {
            // Önceki paneli temizle
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                if (this.Controls[i] is Panel)
                    this.Controls.RemoveAt(i);
            }

            try
            {
                Panel pnlDashboard = new Panel
                {
                    Dock = DockStyle.Fill,
                    BackColor = Color.FromArgb(245, 247, 250),
                    Padding = new Padding(30)
                };

                int dikeyY = this.ClientSize.Height / 2 - 80;

                Label lblHosgel = new Label
                {
                    Text = $"Hoş geldiniz, {_aktifKullanici.KullaniciAdi}  ({_aktifKullanici.Rol})",
                    Font = new Font("Segoe UI", 13f, FontStyle.Bold),
                    ForeColor = Color.FromArgb(30, 90, 160),
                    AutoSize = false,
                    Width = this.ClientSize.Width,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(0, dikeyY - 70)
                };

                Label lblTarih = new Label
                {
                    Text = DateTime.Now.ToString("dd MMMM yyyy, dddd", new CultureInfo("tr-TR")),
                    Font = new Font("Segoe UI", 9f),
                    ForeColor = Color.Gray,
                    AutoSize = false,
                    Width = this.ClientSize.Width,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(0, dikeyY - 40)
                };

                pnlDashboard.Controls.Add(lblHosgel);
                pnlDashboard.Controls.Add(lblTarih);

                if (_aktifKullanici.Rol == "Admin")
                    AdminKartlariEkle(pnlDashboard, dikeyY);
                else
                    KullaniciKartlariEkle(pnlDashboard, dikeyY);

                this.Controls.Add(pnlDashboard);
                pnlDashboard.BringToFront();
                menuStrip1.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dashboard yüklenemedi: " + ex.Message);
            }
        }

        private void AdminKartlariEkle(Panel pnl, int dikeyY)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                int toplam, yaklasan, onayli;

                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Etkinlikler", conn))
                    toplam = (int)cmd.ExecuteScalar();

                using (var cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Etkinlikler WHERE BaslangicTarihi BETWEEN GETDATE() AND DATEADD(DAY,7,GETDATE())", conn))
                    yaklasan = (int)cmd.ExecuteScalar();

                using (var cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Etkinlikler WHERE Durum = 'Onaylandi'", conn))
                    onayli = (int)cmd.ExecuteScalar();

                int kartGenislik = 170;
                int aralik = 20;
                int toplamGenislik = (kartGenislik * 3) + (aralik * 2);
                int baslangicX = (this.ClientSize.Width - toplamGenislik) / 2;

                pnl.Controls.Add(KartOlustur("Toplam Etkinlik", toplam.ToString(), Color.FromArgb(30, 90, 160), new Point(baslangicX, dikeyY)));
                pnl.Controls.Add(KartOlustur("Yaklaşan (7 gün)", yaklasan.ToString(), Color.FromArgb(230, 126, 34), new Point(baslangicX + kartGenislik + aralik, dikeyY)));
                pnl.Controls.Add(KartOlustur("Onaylı Etkinlik", onayli.ToString(), Color.FromArgb(39, 174, 96), new Point(baslangicX + (kartGenislik + aralik) * 2, dikeyY)));
            }
        }

        private void KullaniciKartlariEkle(Panel pnl, int dikeyY)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                int benimEtkinlik, benimYaklasan;
                string sonrakiAd = "-";
                string sonrakiTarih = "-";

                using (var cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Etkinlikler WHERE MusteriKullaniciId = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", _aktifKullanici.KullaniciId);
                    benimEtkinlik = (int)cmd.ExecuteScalar();
                }

                using (var cmd = new SqlCommand(
                    @"SELECT COUNT(*) FROM Etkinlikler 
                      WHERE MusteriKullaniciId = @id 
                      AND BaslangicTarihi BETWEEN GETDATE() AND DATEADD(DAY,7,GETDATE())", conn))
                {
                    cmd.Parameters.AddWithValue("@id", _aktifKullanici.KullaniciId);
                    benimYaklasan = (int)cmd.ExecuteScalar();
                }

                using (var cmd = new SqlCommand(
                    @"SELECT TOP 1 EtkinlikAdi, BaslangicTarihi 
                      FROM Etkinlikler 
                      WHERE MusteriKullaniciId = @id AND BaslangicTarihi >= GETDATE()
                      ORDER BY BaslangicTarihi ASC", conn))
                {
                    cmd.Parameters.AddWithValue("@id", _aktifKullanici.KullaniciId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            sonrakiAd = reader["EtkinlikAdi"].ToString();
                            sonrakiTarih = Convert.ToDateTime(reader["BaslangicTarihi"])
                                .ToString("dd MMM yyyy", new CultureInfo("tr-TR"));
                        }
                    }
                }

                int kartGenislik = 170;
                int sonrakiGenislik = 220;
                int aralik = 20;
                int toplamGenislik = (kartGenislik * 2) + sonrakiGenislik + (aralik * 2);
                int baslangicX = (this.ClientSize.Width - toplamGenislik) / 2;

                pnl.Controls.Add(KartOlustur("Etkinliklerim", benimEtkinlik.ToString(), Color.FromArgb(30, 90, 160), new Point(baslangicX, dikeyY)));
                pnl.Controls.Add(KartOlustur("Yaklaşan (7 gün)", benimYaklasan.ToString(), Color.FromArgb(230, 126, 34), new Point(baslangicX + kartGenislik + aralik, dikeyY)));

                Panel kartSonraki = new Panel
                {
                    Width = sonrakiGenislik,
                    Height = 90,
                    BackColor = Color.White,
                    Location = new Point(baslangicX + (kartGenislik + aralik) * 2, dikeyY),
                    BorderStyle = BorderStyle.FixedSingle
                };

                kartSonraki.Controls.Add(new Label
                {
                    Text = sonrakiAd,
                    Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                    ForeColor = Color.FromArgb(39, 174, 96),
                    AutoSize = false,
                    Width = 195,
                    Location = new Point(14, 14)
                });
                kartSonraki.Controls.Add(new Label
                {
                    Text = sonrakiTarih,
                    Font = new Font("Segoe UI", 8.5f),
                    ForeColor = Color.Gray,
                    AutoSize = true,
                    Location = new Point(14, 38)
                });
                kartSonraki.Controls.Add(new Label
                {
                    Text = "Sonraki Etkinliğim",
                    Font = new Font("Segoe UI", 8.5f),
                    ForeColor = Color.Gray,
                    AutoSize = true,
                    Location = new Point(14, 60)
                });

                pnl.Controls.Add(kartSonraki);
            }
        }

        private Panel KartOlustur(string baslik, string deger, Color renk, Point konum)
        {
            Panel kart = new Panel
            {
                Width = 170,
                Height = 90,
                BackColor = Color.White,
                Location = konum,
                BorderStyle = BorderStyle.FixedSingle
            };

            kart.Controls.Add(new Label
            {
                Text = deger,
                Font = new Font("Segoe UI", 22f, FontStyle.Bold),
                ForeColor = renk,
                AutoSize = true,
                Location = new Point(14, 14)
            });

            kart.Controls.Add(new Label
            {
                Text = baslik,
                Font = new Font("Segoe UI", 8.5f),
                ForeColor = Color.Gray,
                AutoSize = true,
                Location = new Point(14, 58)
            });

            return kart;
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
            DashboardYukle();
        }

        private void mekanYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MekanListeForm form = new MekanListeForm(_aktifKullanici);
            form.ShowDialog();
            DashboardYukle();
        }

        private void tedarikçiListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TedarikciListeForm form = new TedarikciListeForm(_aktifKullanici);
            form.ShowDialog();
            DashboardYukle();
        }

        private void etkinliğeTedarikçiAtaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TedarikciAtamaForm form = new TedarikciAtamaForm();
            form.ShowDialog();
            DashboardYukle();
        }

        private void bütçeYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButceForm form = new ButceForm();
            form.ShowDialog();
            DashboardYukle();
        }

        private void faturaOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
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