namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    partial class EtkinlikListeForm
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
            this.dgvEtkinlikler = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnYeniEtkinlik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtkinlikler)).BeginInit();
            this.SuspendLayout();

            // dgvEtkinlikler
            this.dgvEtkinlikler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtkinlikler.Location = new System.Drawing.Point(2, 3);
            this.dgvEtkinlikler.Name = "dgvEtkinlikler";
            this.dgvEtkinlikler.RowHeadersWidth = 51;
            this.dgvEtkinlikler.RowTemplate.Height = 24;
            this.dgvEtkinlikler.Size = new System.Drawing.Size(1180, 580);
            this.dgvEtkinlikler.TabIndex = 0;
            this.dgvEtkinlikler.Anchor = System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Bottom
                | System.Windows.Forms.AnchorStyles.Left
                | System.Windows.Forms.AnchorStyles.Right;

            // btnSil
            this.btnSil.Location = new System.Drawing.Point(963, 600);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(215, 33);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Anchor = System.Windows.Forms.AnchorStyles.Bottom
                | System.Windows.Forms.AnchorStyles.Right;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);

            // btnDuzenle
            this.btnDuzenle.Location = new System.Drawing.Point(493, 600);
            this.btnDuzenle.Anchor = System.Windows.Forms.AnchorStyles.Bottom
                | System.Windows.Forms.AnchorStyles.Left;
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(215, 33);
            this.btnDuzenle.TabIndex = 5;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);

            // btnYeniEtkinlik
            this.btnYeniEtkinlik.Location = new System.Drawing.Point(2, 600);
            this.btnYeniEtkinlik.Anchor = System.Windows.Forms.AnchorStyles.Bottom
                | System.Windows.Forms.AnchorStyles.Left;
            this.btnYeniEtkinlik.Name = "btnYeniEtkinlik";
            this.btnYeniEtkinlik.Size = new System.Drawing.Size(215, 33);
            this.btnYeniEtkinlik.TabIndex = 6;
            this.btnYeniEtkinlik.Text = "Yeni Etkinlik";
            this.btnYeniEtkinlik.UseVisualStyleBackColor = true;
            this.btnYeniEtkinlik.Click += new System.EventHandler(this.btnYeniEtkinlik_Click);

            // EtkinlikListeForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.btnYeniEtkinlik);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgvEtkinlikler);
            this.Name = "EtkinlikListeForm";
            this.Text = "Etkinlik Listesi";
            this.Load += new System.EventHandler(this.EtkinlikListeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtkinlikler)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvEtkinlikler;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnYeniEtkinlik;
    }
}