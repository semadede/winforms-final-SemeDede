namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    partial class FaturaForm
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
            this.cmbEtkinlik = new System.Windows.Forms.ComboBox();
            this.btnFaturaOlustur = new System.Windows.Forms.Button();
            this.btnButceRaporu = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // label1 - Etkinlik
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(225, 140);
            this.label1.Name = "label1";
            this.label1.Text = "Etkinlik Seçin";

            // cmbEtkinlik
            this.cmbEtkinlik.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEtkinlik.FormattingEnabled = true;
            this.cmbEtkinlik.Location = new System.Drawing.Point(150, 175);
            this.cmbEtkinlik.Name = "cmbEtkinlik";
            this.cmbEtkinlik.Size = new System.Drawing.Size(360, 26);

            // btnFaturaOlustur
            this.btnFaturaOlustur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnFaturaOlustur.Location = new System.Drawing.Point(150, 225);
            this.btnFaturaOlustur.Name = "btnFaturaOlustur";
            this.btnFaturaOlustur.Size = new System.Drawing.Size(170, 40);
            this.btnFaturaOlustur.Text = "Fatura PDF Oluştur";
            this.btnFaturaOlustur.UseVisualStyleBackColor = true;
            this.btnFaturaOlustur.Click += new System.EventHandler(this.btnFaturaOlustur_Click);

            // btnButceRaporu
            this.btnButceRaporu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnButceRaporu.Location = new System.Drawing.Point(340, 225);
            this.btnButceRaporu.Name = "btnButceRaporu";
            this.btnButceRaporu.Size = new System.Drawing.Size(170, 40);
            this.btnButceRaporu.Text = "Bütçe Raporu PDF";
            this.btnButceRaporu.UseVisualStyleBackColor = true;
            this.btnButceRaporu.Click += new System.EventHandler(this.btnButceRaporu_Click);

            // FaturaForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 400);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Controls.Add(this.btnButceRaporu);
            this.Controls.Add(this.btnFaturaOlustur);
            this.Controls.Add(this.cmbEtkinlik);
            this.Controls.Add(this.label1);
            this.Name = "FaturaForm";
            this.Text = "Fatura Oluştur";
            this.Load += new System.EventHandler(this.FaturaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEtkinlik;
        private System.Windows.Forms.Button btnFaturaOlustur;
        private System.Windows.Forms.Button btnButceRaporu;
    }
}