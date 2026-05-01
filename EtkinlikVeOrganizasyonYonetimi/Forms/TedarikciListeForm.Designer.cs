namespace EtkinlikVeOrganizasyonYonetimi.Forms
{
    partial class TedarikciListeForm
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
            this.dgvTedarikciler = new System.Windows.Forms.DataGridView();
            this.btnYeniTedarikci = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTedarikciler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTedarikciler
            // 
            this.dgvTedarikciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTedarikciler.Location = new System.Drawing.Point(12, 12);
            this.dgvTedarikciler.Name = "dgvTedarikciler";
            this.dgvTedarikciler.RowHeadersWidth = 51;
            this.dgvTedarikciler.RowTemplate.Height = 24;
            this.dgvTedarikciler.Size = new System.Drawing.Size(776, 350);
            this.dgvTedarikciler.TabIndex = 0;
            // 
            // btnYeniTedarikci
            // 
            this.btnYeniTedarikci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniTedarikci.Location = new System.Drawing.Point(142, 368);
            this.btnYeniTedarikci.Name = "btnYeniTedarikci";
            this.btnYeniTedarikci.Size = new System.Drawing.Size(241, 70);
            this.btnYeniTedarikci.TabIndex = 1;
            this.btnYeniTedarikci.Text = "Yeni Tedarikçi";
            this.btnYeniTedarikci.UseVisualStyleBackColor = true;
            this.btnYeniTedarikci.Click += new System.EventHandler(this.btnYeniTedarikci_Click);
     
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(408, 368);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(241, 70);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // TedarikciListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYeniTedarikci);
            this.Controls.Add(this.dgvTedarikciler);
            this.Name = "TedarikciListeForm";
            this.Text = "TedarikciListeForm";
            this.Load += new System.EventHandler(this.TedarikciListeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTedarikciler)).EndInit();
            this.ResumeLayout(false);


        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTedarikciler;
        private System.Windows.Forms.Button btnYeniTedarikci;
        private System.Windows.Forms.Button btnSil;
    }
}