namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    partial class TedarikciForm
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
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            // Telefon kismi sadece sayi girilebilir
            this.txtTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefon_KeyPress);
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(75, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firma Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(75, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(75, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon";
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Location = new System.Drawing.Point(162, 66);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(220, 22);
            this.txtFirmaAdi.TabIndex = 3;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(162, 153);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(220, 22);
            this.txtTelefon.TabIndex = 4;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(162, 110);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(220, 24);
            this.cmbKategori.TabIndex = 5;
            // 
            // chkAktif
            // 
            this.chkAktif.AutoSize = true;
            this.chkAktif.Location = new System.Drawing.Point(328, 194);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(54, 20);
            this.chkAktif.TabIndex = 6;
            this.chkAktif.Text = "Aktif";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(162, 231);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(102, 33);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(270, 231);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(112, 33);
            this.btnIptal.TabIndex = 8;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // TedarikciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.chkAktif);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtFirmaAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TedarikciForm";
            this.Text = "TedarikciForm";
            this.Load += new System.EventHandler(this.TedarikciForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirmaAdi;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
    }
}