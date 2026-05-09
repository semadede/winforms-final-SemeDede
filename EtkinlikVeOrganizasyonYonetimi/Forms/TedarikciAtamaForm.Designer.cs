namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    partial class TedarikciAtamaForm
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
            this.cmbEtkinlik = new System.Windows.Forms.ComboBox();
            this.cmbTedarikci = new System.Windows.Forms.ComboBox();
            this.dtpTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtNotlar = new System.Windows.Forms.TextBox();
            this.btnAta = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.dgvAtananTedarikciler = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtananTedarikciler)).BeginInit();
            this.SuspendLayout();

            // label1 - Etkinlik
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Text = "Etkinlik";

            // cmbEtkinlik
            this.cmbEtkinlik.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEtkinlik.FormattingEnabled = true;
            this.cmbEtkinlik.Location = new System.Drawing.Point(140, 32);
            this.cmbEtkinlik.Name = "cmbEtkinlik";
            this.cmbEtkinlik.Size = new System.Drawing.Size(350, 26);
            this.cmbEtkinlik.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cmbEtkinlik.SelectedIndexChanged += new System.EventHandler(this.cmbEtkinlik_SelectedIndexChanged);

            // label2 - Tedarikçi
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Text = "Tedarikçi";

            // cmbTedarikci
            this.cmbTedarikci.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTedarikci.FormattingEnabled = true;
            this.cmbTedarikci.Location = new System.Drawing.Point(140, 77);
            this.cmbTedarikci.Name = "cmbTedarikci";
            this.cmbTedarikci.Size = new System.Drawing.Size(350, 26);
            this.cmbTedarikci.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // label3 - Teslim Tarihi
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(20, 125);
            this.label3.Name = "label3";
            this.label3.Text = "Teslim Tarihi";

            // dtpTeslimTarihi
            this.dtpTeslimTarihi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTeslimTarihi.Location = new System.Drawing.Point(140, 122);
            this.dtpTeslimTarihi.Name = "dtpTeslimTarihi";
            this.dtpTeslimTarihi.Size = new System.Drawing.Size(350, 26);
            this.dtpTeslimTarihi.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // label4 - Notlar
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(20, 170);
            this.label4.Name = "label4";
            this.label4.Text = "Notlar";

            // txtNotlar
            this.txtNotlar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNotlar.Location = new System.Drawing.Point(140, 167);
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.Size = new System.Drawing.Size(350, 26);
            this.txtNotlar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // btnAta
            this.btnAta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAta.Location = new System.Drawing.Point(20, 215);
            this.btnAta.Name = "btnAta";
            this.btnAta.Size = new System.Drawing.Size(120, 34);
            this.btnAta.Text = "Ata";
            this.btnAta.UseVisualStyleBackColor = true;
            this.btnAta.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.btnAta.Click += new System.EventHandler(this.btnAta_Click);

            // btnSil
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSil.Location = new System.Drawing.Point(150, 215);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(120, 34);
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);

            // btnIptal
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnIptal.Location = new System.Drawing.Point(370, 215);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(120, 34);
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);

            // dgvAtananTedarikciler
            this.dgvAtananTedarikciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtananTedarikciler.Location = new System.Drawing.Point(2, 265);
            this.dgvAtananTedarikciler.Name = "dgvAtananTedarikciler";
            this.dgvAtananTedarikciler.RowHeadersWidth = 51;
            this.dgvAtananTedarikciler.RowTemplate.Height = 24;
            this.dgvAtananTedarikciler.Size = new System.Drawing.Size(1180, 350);
            this.dgvAtananTedarikciler.TabIndex = 10;
            this.dgvAtananTedarikciler.Anchor = System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Bottom
                | System.Windows.Forms.AnchorStyles.Left
                | System.Windows.Forms.AnchorStyles.Right;

            // TedarikciAtamaForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgvAtananTedarikciler);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnAta);
            this.Controls.Add(this.txtNotlar);
            this.Controls.Add(this.dtpTeslimTarihi);
            this.Controls.Add(this.cmbTedarikci);
            this.Controls.Add(this.cmbEtkinlik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TedarikciAtamaForm";
            this.Text = "Etkinliğe Tedarikçi Ata";
            this.Load += new System.EventHandler(this.TedarikciAtamaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtananTedarikciler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEtkinlik;
        private System.Windows.Forms.ComboBox cmbTedarikci;
        private System.Windows.Forms.DateTimePicker dtpTeslimTarihi;
        private System.Windows.Forms.TextBox txtNotlar;
        private System.Windows.Forms.Button btnAta;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.DataGridView dgvAtananTedarikciler;
        private System.Windows.Forms.Button btnSil;
    }
}