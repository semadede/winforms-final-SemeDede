namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    partial class MekanListeForm
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
            this.dgvMekanlar = new System.Windows.Forms.DataGridView();
            this.btnYeniMekan = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMekanlar)).BeginInit();
            this.SuspendLayout();

            // dgvMekanlar
            this.dgvMekanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMekanlar.Location = new System.Drawing.Point(2, 3);
            this.dgvMekanlar.Name = "dgvMekanlar";
            this.dgvMekanlar.RowHeadersWidth = 51;
            this.dgvMekanlar.RowTemplate.Height = 24;
            this.dgvMekanlar.Size = new System.Drawing.Size(1180, 580);
            this.dgvMekanlar.TabIndex = 0;
            this.dgvMekanlar.Anchor = System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Bottom
                | System.Windows.Forms.AnchorStyles.Left
                | System.Windows.Forms.AnchorStyles.Right;

            // btnYeniMekan
            this.btnYeniMekan.Location = new System.Drawing.Point(2, 600);
            this.btnYeniMekan.Name = "btnYeniMekan";
            this.btnYeniMekan.Size = new System.Drawing.Size(215, 33);
            this.btnYeniMekan.TabIndex = 1;
            this.btnYeniMekan.Text = "Yeni Mekan";
            this.btnYeniMekan.UseVisualStyleBackColor = true;
            this.btnYeniMekan.Anchor = System.Windows.Forms.AnchorStyles.Bottom
                | System.Windows.Forms.AnchorStyles.Left;
            this.btnYeniMekan.Click += new System.EventHandler(this.btnYeniMekan_Click);

            // btnSil
            this.btnSil.Location = new System.Drawing.Point(963, 600);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(215, 33);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Anchor = System.Windows.Forms.AnchorStyles.Bottom
                | System.Windows.Forms.AnchorStyles.Right;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);

            // MekanListeForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYeniMekan);
            this.Controls.Add(this.dgvMekanlar);
            this.Name = "MekanListeForm";
            this.Text = "Mekan Listesi";
            this.Load += new System.EventHandler(this.MekanListeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMekanlar)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvMekanlar;
        private System.Windows.Forms.Button btnYeniMekan;
        private System.Windows.Forms.Button btnSil;
    }
}