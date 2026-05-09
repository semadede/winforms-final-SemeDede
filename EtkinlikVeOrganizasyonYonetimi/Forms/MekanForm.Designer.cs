namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    partial class MekanForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtMekanAdi = new System.Windows.Forms.TextBox();
            this.txtKapasite = new System.Windows.Forms.TextBox();
            this.txtKapasite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKapasite_KeyPress);
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtKurulumSuresi = new System.Windows.Forms.TextBox();
            this.txtKurulumSuresi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKurulumSuresi_KeyPress);
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // label1 - Mekan Adı
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(294, 80);
            this.label1.Name = "label1";
            this.label1.Text = "Mekan Adı";

            // txtMekanAdi
            this.txtMekanAdi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMekanAdi.Location = new System.Drawing.Point(220, 105);
            this.txtMekanAdi.Name = "txtMekanAdi";
            this.txtMekanAdi.Size = new System.Drawing.Size(260, 26);

            // label2 - Kapasite
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(301, 150);
            this.label2.Name = "label2";
            this.label2.Text = "Kapasite";

            // txtKapasite
            this.txtKapasite.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKapasite.Location = new System.Drawing.Point(220, 175);
            this.txtKapasite.Name = "txtKapasite";
            this.txtKapasite.Size = new System.Drawing.Size(260, 26);

            // label3 - Adres
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(315, 220);
            this.label3.Name = "label3";
            this.label3.Text = "Adres";

            // txtAdres
            this.txtAdres.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAdres.Location = new System.Drawing.Point(220, 245);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(260, 26);

            // label4 - Kurulum Süresi
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(253, 290);
            this.label4.Name = "label4";
            this.label4.Text = "Kurulum Süresi (Saat)";

            // txtKurulumSuresi
            this.txtKurulumSuresi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKurulumSuresi.Location = new System.Drawing.Point(220, 315);
            this.txtKurulumSuresi.Name = "txtKurulumSuresi";
            this.txtKurulumSuresi.Size = new System.Drawing.Size(260, 26);

            // btnKaydet
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnKaydet.Location = new System.Drawing.Point(220, 365);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 36);
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            // btnIptal
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnIptal.Location = new System.Drawing.Point(360, 365);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(120, 36);
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);

            // MekanForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtKurulumSuresi);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtKapasite);
            this.Controls.Add(this.txtMekanAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MekanForm";
            this.Text = "Mekan Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMekanAdi;
        private System.Windows.Forms.TextBox txtKapasite;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtKurulumSuresi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
    }
}