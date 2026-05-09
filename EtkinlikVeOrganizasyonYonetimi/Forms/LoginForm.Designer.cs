namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    partial class LoginForm
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
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // label1 - Kullanıcı Adı
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(165, 80);
            this.label1.Text = "Kullanıcı Adı";

            // txtKullaniciAdi
            this.txtKullaniciAdi.Location = new System.Drawing.Point(100, 105);
            this.txtKullaniciAdi.Size = new System.Drawing.Size(250, 26);
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 10F);

            // label2 - Şifre
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(195, 150);
            this.label2.Text = "Şifre";

            // txtSifre
            this.txtSifre.Location = new System.Drawing.Point(100, 175);
            this.txtSifre.Size = new System.Drawing.Size(250, 26);
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSifre.PasswordChar = '*';

            // btnGiris
            this.btnGiris.Location = new System.Drawing.Point(150, 225);
            this.btnGiris.Size = new System.Drawing.Size(150, 40);
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(30, 90, 160);
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);

            // LoginForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "Etkinlik Yönetim Sistemi - Giriş";
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label1);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
    }
}