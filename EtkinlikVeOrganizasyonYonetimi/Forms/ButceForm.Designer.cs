namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    partial class ButceForm
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
            // Planlanan Butce kismi sadece sayi olacak
            this.txtPlanlananButce.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlanlananButce_KeyPress);
            this.txtGerceklesenToplam = new System.Windows.Forms.TextBox();
            this.txtFark = new System.Windows.Forms.TextBox();
            this.txtMaliyetAciklama = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            // Tutar kismi sadece sayi olacak
            this.txtTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTutar_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaliyetler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etkinlik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Planlanan Bütçe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gerçekleşen Toplam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fark";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Maliyet Açıklaması";
            
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tutar";
            // 
            // btnButceKaydet
            // 
            this.btnButceKaydet.Location = new System.Drawing.Point(156, 172);
            this.btnButceKaydet.Name = "btnButceKaydet";
            this.btnButceKaydet.Size = new System.Drawing.Size(96, 23);
            this.btnButceKaydet.TabIndex = 6;
            this.btnButceKaydet.Text = "Bütçe Kaydet";
            this.btnButceKaydet.UseVisualStyleBackColor = true;
            this.btnButceKaydet.Click += new System.EventHandler(this.btnButceKaydet_Click);
            // 
            // dgvMaliyetler
            // 
            this.dgvMaliyetler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaliyetler.Location = new System.Drawing.Point(346, 12);
            this.dgvMaliyetler.Name = "dgvMaliyetler";
            this.dgvMaliyetler.RowHeadersWidth = 51;
            this.dgvMaliyetler.RowTemplate.Height = 24;
            this.dgvMaliyetler.Size = new System.Drawing.Size(432, 315);
            this.dgvMaliyetler.TabIndex = 7;
            // 
            // btnMaliyetEkle
            // 
            this.btnMaliyetEkle.Location = new System.Drawing.Point(156, 304);
            this.btnMaliyetEkle.Name = "btnMaliyetEkle";
            this.btnMaliyetEkle.Size = new System.Drawing.Size(92, 23);
            this.btnMaliyetEkle.TabIndex = 8;
            this.btnMaliyetEkle.Text = "Maliyet Ekle";
            this.btnMaliyetEkle.UseVisualStyleBackColor = true;
            this.btnMaliyetEkle.Click += new System.EventHandler(this.btnMaliyetEkle_Click);
            // 
            // cmbEtkinlik
            // 
            this.cmbEtkinlik.FormattingEnabled = true;
            this.cmbEtkinlik.Location = new System.Drawing.Point(156, 15);
            this.cmbEtkinlik.Name = "cmbEtkinlik";
            this.cmbEtkinlik.Size = new System.Drawing.Size(136, 24);
            this.cmbEtkinlik.TabIndex = 9;
            this.cmbEtkinlik.SelectedIndexChanged += new System.EventHandler(this.cmbEtkinlik_SelectedIndexChanged);
            // 
            // txtPlanlananButce
            // 
            this.txtPlanlananButce.Location = new System.Drawing.Point(156, 51);
            this.txtPlanlananButce.Name = "txtPlanlananButce";
            this.txtPlanlananButce.Size = new System.Drawing.Size(136, 22);
            this.txtPlanlananButce.TabIndex = 10;
            // 
            // txtGerceklesenToplam
            // 
            this.txtGerceklesenToplam.Location = new System.Drawing.Point(156, 96);
            this.txtGerceklesenToplam.Name = "txtGerceklesenToplam";
            this.txtGerceklesenToplam.Size = new System.Drawing.Size(136, 22);
            this.txtGerceklesenToplam.TabIndex = 11;
            // 
            // txtFark
            // 
            this.txtFark.Location = new System.Drawing.Point(156, 133);
            this.txtFark.Name = "txtFark";
            this.txtFark.Size = new System.Drawing.Size(136, 22);
            this.txtFark.TabIndex = 12;
            // 
            // txtMaliyetAciklama
            // 
            this.txtMaliyetAciklama.Location = new System.Drawing.Point(156, 222);
            this.txtMaliyetAciklama.Name = "txtMaliyetAciklama";
            this.txtMaliyetAciklama.Size = new System.Drawing.Size(136, 22);
            this.txtMaliyetAciklama.TabIndex = 13;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(156, 267);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(136, 22);
            this.txtTutar.TabIndex = 14;
            // 
            // ButceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Text = "ButceForm";
            this.Load += new System.EventHandler(this.ButceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaliyetler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        #endregion

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