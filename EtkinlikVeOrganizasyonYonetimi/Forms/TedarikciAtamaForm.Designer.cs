namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    partial class TedarikciAtamaForm
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
            this.cmbEtkinlik = new System.Windows.Forms.ComboBox();
            this.cmbTedarikci = new System.Windows.Forms.ComboBox();
            this.dtpTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtNotlar = new System.Windows.Forms.TextBox();
            this.btnAta = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.dgvAtananTedarikciler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtananTedarikciler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etkinlik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tedarikçi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teslim Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Notlar";
            // 
            // cmbEtkinlik
            // 
            this.cmbEtkinlik.FormattingEnabled = true;
            this.cmbEtkinlik.Location = new System.Drawing.Point(329, 26);
            this.cmbEtkinlik.Name = "cmbEtkinlik";
            this.cmbEtkinlik.Size = new System.Drawing.Size(215, 24);
            this.cmbEtkinlik.TabIndex = 4;
            this.cmbEtkinlik.SelectedIndexChanged += new System.EventHandler(this.cmbEtkinlik_SelectedIndexChanged);
            // 
            // cmbTedarikci
            // 
            this.cmbTedarikci.FormattingEnabled = true;
            this.cmbTedarikci.Location = new System.Drawing.Point(329, 72);
            this.cmbTedarikci.Name = "cmbTedarikci";
            this.cmbTedarikci.Size = new System.Drawing.Size(215, 24);
            this.cmbTedarikci.TabIndex = 5;
            // 
            // dtpTeslimTarihi
            // 
            this.dtpTeslimTarihi.Location = new System.Drawing.Point(329, 115);
            this.dtpTeslimTarihi.Name = "dtpTeslimTarihi";
            this.dtpTeslimTarihi.Size = new System.Drawing.Size(215, 22);
            this.dtpTeslimTarihi.TabIndex = 6;
            // 
            // txtNotlar
            // 
            this.txtNotlar.Location = new System.Drawing.Point(329, 162);
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.Size = new System.Drawing.Size(215, 22);
            this.txtNotlar.TabIndex = 7;
            // 
            // btnAta
            // 
            this.btnAta.Location = new System.Drawing.Point(241, 207);
            this.btnAta.Name = "btnAta";
            this.btnAta.Size = new System.Drawing.Size(122, 30);
            this.btnAta.TabIndex = 8;
            this.btnAta.Text = "Ata";
            this.btnAta.UseVisualStyleBackColor = true;
            this.btnAta.Click += new System.EventHandler(this.btnAta_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(419, 207);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(125, 30);
            this.btnIptal.TabIndex = 9;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // dgvAtananTedarikciler
            // 
            this.dgvAtananTedarikciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtananTedarikciler.Location = new System.Drawing.Point(52, 253);
            this.dgvAtananTedarikciler.Name = "dgvAtananTedarikciler";
            this.dgvAtananTedarikciler.RowHeadersWidth = 51;
            this.dgvAtananTedarikciler.RowTemplate.Height = 24;
            this.dgvAtananTedarikciler.Size = new System.Drawing.Size(690, 185);
            this.dgvAtananTedarikciler.TabIndex = 10;
            // 
            // TedarikciAtamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Text = "TedarikciAtamaForm";
            this.Load += new System.EventHandler(this.TedarikciAtamaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtananTedarikciler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
    }
}