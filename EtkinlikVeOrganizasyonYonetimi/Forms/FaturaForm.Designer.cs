namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    partial class FaturaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEtkinlik = new System.Windows.Forms.ComboBox();
            this.btnFaturaOlustur = new System.Windows.Forms.Button();
            this.btnButceRaporu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(366, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etkinlik";
            // 
            // cmbEtkinlik
            // 
            this.cmbEtkinlik.FormattingEnabled = true;
            this.cmbEtkinlik.Location = new System.Drawing.Point(226, 186);
            this.cmbEtkinlik.Name = "cmbEtkinlik";
            this.cmbEtkinlik.Size = new System.Drawing.Size(343, 24);
            this.cmbEtkinlik.TabIndex = 1;
            // 
            // btnFaturaOlustur
            // 
            this.btnFaturaOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFaturaOlustur.Location = new System.Drawing.Point(226, 229);
            this.btnFaturaOlustur.Name = "btnFaturaOlustur";
            this.btnFaturaOlustur.Size = new System.Drawing.Size(160, 34);
            this.btnFaturaOlustur.TabIndex = 2;
            this.btnFaturaOlustur.Text = "Fatura PDF Oluştur";
            this.btnFaturaOlustur.UseVisualStyleBackColor = true;
            this.btnFaturaOlustur.Click += new System.EventHandler(this.btnFaturaOlustur_Click);
            // 
            // btnButceRaporu
            // 
            this.btnButceRaporu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnButceRaporu.Location = new System.Drawing.Point(409, 230);
            this.btnButceRaporu.Name = "btnButceRaporu";
            this.btnButceRaporu.Size = new System.Drawing.Size(160, 33);
            this.btnButceRaporu.TabIndex = 3;
            this.btnButceRaporu.Text = "Bütçe Raporu PDF";
            this.btnButceRaporu.UseVisualStyleBackColor = true;
            this.btnButceRaporu.Click += new System.EventHandler(this.btnButceRaporu_Click);
            // 
            // FaturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnButceRaporu);
            this.Controls.Add(this.btnFaturaOlustur);
            this.Controls.Add(this.cmbEtkinlik);
            this.Controls.Add(this.label1);
            this.Name = "FaturaForm";
            this.Text = "FaturaForm";
            this.Load += new System.EventHandler(this.FaturaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEtkinlik;
        private System.Windows.Forms.Button btnFaturaOlustur;
        private System.Windows.Forms.Button btnButceRaporu;
    }
}