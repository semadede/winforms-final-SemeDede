namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    partial class TedarikciListeForm
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
            this.dgvTedarikciler = new System.Windows.Forms.DataGridView();
            this.btnYeniTedarikci = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTedarikciler)).BeginInit();
            this.SuspendLayout();

            // dgvTedarikciler
            this.dgvTedarikciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTedarikciler.Location = new System.Drawing.Point(2, 3);
            this.dgvTedarikciler.Name = "dgvTedarikciler";
            this.dgvTedarikciler.RowHeadersWidth = 51;
            this.dgvTedarikciler.RowTemplate.Height = 24;
            this.dgvTedarikciler.Size = new System.Drawing.Size(1180, 580);
            this.dgvTedarikciler.TabIndex = 0;
            this.dgvTedarikciler.Anchor = System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Bottom
                | System.Windows.Forms.AnchorStyles.Left
                | System.Windows.Forms.AnchorStyles.Right;

            // btnYeniTedarikci
            this.btnYeniTedarikci.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnYeniTedarikci.Location = new System.Drawing.Point(2, 600);
            this.btnYeniTedarikci.Name = "btnYeniTedarikci";
            this.btnYeniTedarikci.Size = new System.Drawing.Size(215, 33);
            this.btnYeniTedarikci.TabIndex = 1;
            this.btnYeniTedarikci.Text = "Yeni Tedarikçi";
            this.btnYeniTedarikci.UseVisualStyleBackColor = true;
            this.btnYeniTedarikci.Anchor = System.Windows.Forms.AnchorStyles.Bottom
                | System.Windows.Forms.AnchorStyles.Left;
            this.btnYeniTedarikci.Click += new System.EventHandler(this.btnYeniTedarikci_Click);

            // btnSil
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSil.Location = new System.Drawing.Point(983, 600);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(215, 33);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Anchor = System.Windows.Forms.AnchorStyles.Bottom
                | System.Windows.Forms.AnchorStyles.Right;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);

            // TedarikciListeForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYeniTedarikci);
            this.Controls.Add(this.dgvTedarikciler);
            this.Name = "TedarikciListeForm";
            this.Text = "Tedarikçi Listesi";
            this.Load += new System.EventHandler(this.TedarikciListeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTedarikciler)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvTedarikciler;
        private System.Windows.Forms.Button btnYeniTedarikci;
        private System.Windows.Forms.Button btnSil;
    }
}