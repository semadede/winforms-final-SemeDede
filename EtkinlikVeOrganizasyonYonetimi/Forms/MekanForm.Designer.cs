namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    partial class MekanForm
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
            this.txtMekanAdi = new System.Windows.Forms.TextBox();
            this.txtKapasite = new System.Windows.Forms.TextBox();
            // kapasite kismi sadece rakam girilir!
            this.txtKapasite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKapasite_KeyPress);
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtKurulumSuresi = new System.Windows.Forms.TextBox();
            // kurulum kismi sadece rakam girilir!
            this.txtKurulumSuresi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKurulumSuresi_KeyPress);
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mekan Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kapasite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kurulum Süresi (Saat)";
         
            // 
            // txtMekanAdi
            // 
            this.txtMekanAdi.Location = new System.Drawing.Point(243, 73);
            this.txtMekanAdi.Name = "txtMekanAdi";
            this.txtMekanAdi.Size = new System.Drawing.Size(202, 22);
            this.txtMekanAdi.TabIndex = 4;
            // 
            // txtKapasite
            // 
            this.txtKapasite.Location = new System.Drawing.Point(243, 144);
            this.txtKapasite.Name = "txtKapasite";
            this.txtKapasite.Size = new System.Drawing.Size(202, 22);
            this.txtKapasite.TabIndex = 5;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(243, 212);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(202, 22);
            this.txtAdres.TabIndex = 6;
            // 
            // txtKurulumSuresi
            // 
            this.txtKurulumSuresi.Location = new System.Drawing.Point(243, 286);
            this.txtKurulumSuresi.Name = "txtKurulumSuresi";
            this.txtKurulumSuresi.Size = new System.Drawing.Size(202, 22);
            this.txtKurulumSuresi.TabIndex = 7;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(243, 344);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 34);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(342, 344);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(103, 34);
            this.btnIptal.TabIndex = 9;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // MekanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtKurulumSuresi);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtKapasite);
            this.Controls.Add(this.txtMekanAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MekanForm";
            this.Text = "MekanForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMekanAdi;
        private System.Windows.Forms.TextBox txtKapasite;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtKurulumSuresi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
    }
}