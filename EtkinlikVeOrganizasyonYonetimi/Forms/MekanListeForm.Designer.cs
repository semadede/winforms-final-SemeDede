namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    partial class MekanListeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMekanlar = new System.Windows.Forms.DataGridView();
            this.btnYeniMekan = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMekanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMekanlar
            // 
            this.dgvMekanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMekanlar.Location = new System.Drawing.Point(1, 3);
            this.dgvMekanlar.Name = "dgvMekanlar";
            this.dgvMekanlar.RowHeadersWidth = 51;
            this.dgvMekanlar.RowTemplate.Height = 24;
            this.dgvMekanlar.Size = new System.Drawing.Size(796, 332);
            this.dgvMekanlar.TabIndex = 0;
            // 
            // btnYeniMekan
            // 
            this.btnYeniMekan.Location = new System.Drawing.Point(117, 347);
            this.btnYeniMekan.Name = "btnYeniMekan";
            this.btnYeniMekan.Size = new System.Drawing.Size(195, 71);
            this.btnYeniMekan.TabIndex = 1;
            this.btnYeniMekan.Text = "Yeni Mekan";
            this.btnYeniMekan.UseVisualStyleBackColor = true;
            this.btnYeniMekan.Click += new System.EventHandler(this.btnYeniMekan_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(466, 347);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(195, 71);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // MekanListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYeniMekan);
            this.Controls.Add(this.dgvMekanlar);
            this.Name = "MekanListeForm";
            this.Text = "MekanListeForm";
            this.Load += new System.EventHandler(this.MekanListeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMekanlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMekanlar;
        private System.Windows.Forms.Button btnYeniMekan;
        private System.Windows.Forms.Button btnSil;
    }
}