namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    partial class ButceForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnButceKaydet = new System.Windows.Forms.Button();
            this.dgvMaliyetler = new System.Windows.Forms.DataGridView();
            this.btnMaliyetEkle = new System.Windows.Forms.Button();
            this.cmbEtkinlik = new System.Windows.Forms.ComboBox();
            this.txtPlanlananButce = new System.Windows.Forms.TextBox();
            this.txtPlanlananButce.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlanlananButce_KeyPress);
            this.txtGerceklesenToplam = new System.Windows.Forms.TextBox();
            this.txtFark = new System.Windows.Forms.TextBox();
            this.txtMaliyetAciklama = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTutar_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaliyetler)).BeginInit();
            this.SuspendLayout();

            // label1 - Etkinlik
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Text = "Etkinlik";

            // cmbEtkinlik
            this.cmbEtkinlik.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEtkinlik.FormattingEnabled = true;
            this.cmbEtkinlik.Location = new System.Drawing.Point(180, 22);
            this.cmbEtkinlik.Name = "cmbEtkinlik";
            this.cmbEtkinlik.Size = new System.Drawing.Size(200, 26);
            this.cmbEtkinlik.SelectedIndexChanged += new System.EventHandler(this.cmbEtkinlik_SelectedIndexChanged);

            // label2 - Planlanan Bütçe
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Text = "Planlanan Bütçe";

            // txtPlanlananButce
            this.txtPlanlananButce.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPlanlananButce.Location = new System.Drawing.Point(180, 67);
            this.txtPlanlananButce.Name = "txtPlanlananButce";
            this.txtPlanlananButce.Size = new System.Drawing.Size(200, 26);

            // label3 - Gerçekleşen Toplam
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(20, 115);
            this.label3.Name = "label3";
            this.label3.Text = "Gerçekleşen Toplam";

            // txtGerceklesenToplam
            this.txtGerceklesenToplam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGerceklesenToplam.Location = new System.Drawing.Point(180, 112);
            this.txtGerceklesenToplam.Name = "txtGerceklesenToplam";
            this.txtGerceklesenToplam.Size = new System.Drawing.Size(200, 26);
            this.txtGerceklesenToplam.ReadOnly = true;
            this.txtGerceklesenToplam.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            // label4 - Fark
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(20, 160);
            this.label4.Name = "label4";
            this.label4.Text = "Fark";

            // txtFark
            this.txtFark.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFark.Location = new System.Drawing.Point(180, 157);
            this.txtFark.Name = "txtFark";
            this.txtFark.Size = new System.Drawing.Size(200, 26);
            this.txtFark.ReadOnly = true;
            this.txtFark.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            // btnButceKaydet
            this.btnButceKaydet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnButceKaydet.Location = new System.Drawing.Point(180, 205);
            this.btnButceKaydet.Name = "btnButceKaydet";
            this.btnButceKaydet.Size = new System.Drawing.Size(200, 34);
            this.btnButceKaydet.Text = "Bütçe Kaydet";
            this.btnButceKaydet.UseVisualStyleBackColor = true;
            this.btnButceKaydet.Click += new System.EventHandler(this.btnButceKaydet_Click);

            // label5 - Maliyet Açıklaması
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(20, 265);
            this.label5.Name = "label5";
            this.label5.Text = "Maliyet Açıklaması";

            // txtMaliyetAciklama
            this.txtMaliyetAciklama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaliyetAciklama.Location = new System.Drawing.Point(180, 262);
            this.txtMaliyetAciklama.Name = "txtMaliyetAciklama";
            this.txtMaliyetAciklama.Size = new System.Drawing.Size(200, 26);

            // label6 - Tutar
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(20, 310);
            this.label6.Name = "label6";
            this.label6.Text = "Tutar";

            // txtTutar
            this.txtTutar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTutar.Location = new System.Drawing.Point(180, 307);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(200, 26);

            // btnMaliyetEkle
            this.btnMaliyetEkle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMaliyetEkle.Location = new System.Drawing.Point(180, 355);
            this.btnMaliyetEkle.Name = "btnMaliyetEkle";
            this.btnMaliyetEkle.Size = new System.Drawing.Size(200, 34);
            this.btnMaliyetEkle.Text = "Maliyet Ekle";
            this.btnMaliyetEkle.UseVisualStyleBackColor = true;
            this.btnMaliyetEkle.Click += new System.EventHandler(this.btnMaliyetEkle_Click);

            // dgvMaliyetler
            this.dgvMaliyetler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaliyetler.Location = new System.Drawing.Point(420, 12);
            this.dgvMaliyetler.Name = "dgvMaliyetler";
            this.dgvMaliyetler.RowHeadersWidth = 51;
            this.dgvMaliyetler.RowTemplate.Height = 24;
            this.dgvMaliyetler.Size = new System.Drawing.Size(560, 390);
            this.dgvMaliyetler.TabIndex = 7;
            this.dgvMaliyetler.Anchor = System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Bottom
                | System.Windows.Forms.AnchorStyles.Left
                | System.Windows.Forms.AnchorStyles.Right;

            // ButceForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 420);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtMaliyetAciklama);
            this.Controls.Add(this.txtFark);
            this.Controls.Add(this.txtGerceklesenToplam);
            this.Controls.Add(this.txtPlanlananButce);
            this.Controls.Add(this.cmbEtkinlik);
            this.Controls.Add(this.btnMaliyetEkle);
            this.Controls.Add(this.dgvMaliyetler);
            this.Controls.Add(this.btnButceKaydet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ButceForm";
            this.Text = "Bütçe Yönetimi";
            this.Load += new System.EventHandler(this.ButceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaliyetler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnButceKaydet;
        private System.Windows.Forms.DataGridView dgvMaliyetler;
        private System.Windows.Forms.Button btnMaliyetEkle;
        private System.Windows.Forms.ComboBox cmbEtkinlik;
        private System.Windows.Forms.TextBox txtPlanlananButce;
        private System.Windows.Forms.TextBox txtGerceklesenToplam;
        private System.Windows.Forms.TextBox txtFark;
        private System.Windows.Forms.TextBox txtMaliyetAciklama;
        private System.Windows.Forms.TextBox txtTutar;
    }
}