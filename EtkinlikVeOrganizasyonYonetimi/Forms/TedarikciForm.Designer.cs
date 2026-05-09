namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    partial class TedarikciForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefon_KeyPress);
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // label1 - Firma Adı
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(210, 80);
            this.label1.Name = "label1";
            this.label1.Text = "Firma Adı";

            // txtFirmaAdi
            this.txtFirmaAdi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFirmaAdi.Location = new System.Drawing.Point(180, 105);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(260, 26);

            // label2 - Kategori
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(215, 150);
            this.label2.Name = "label2";
            this.label2.Text = "Kategori";

            // cmbKategori
            this.cmbKategori.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(180, 175);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(260, 26);

            // label3 - Telefon
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(215, 220);
            this.label3.Name = "label3";
            this.label3.Text = "Telefon";

            // txtTelefon
            this.txtTelefon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTelefon.Location = new System.Drawing.Point(180, 245);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(260, 26);

            // chkAktif
            this.chkAktif.AutoSize = true;
            this.chkAktif.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkAktif.Location = new System.Drawing.Point(280, 290);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Text = "Aktif";
            this.chkAktif.UseVisualStyleBackColor = true;

            // btnKaydet
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnKaydet.Location = new System.Drawing.Point(180, 335);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 36);
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            // btnIptal
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnIptal.Location = new System.Drawing.Point(320, 335);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(120, 36);
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);

            // TedarikciForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 420);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.chkAktif);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtFirmaAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TedarikciForm";
            this.Text = "Tedarikçi Ekle";
            this.Load += new System.EventHandler(this.TedarikciForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirmaAdi;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
    }
}