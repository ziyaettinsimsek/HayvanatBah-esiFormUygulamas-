namespace HayvanatBahçesiFormUygulaması.UI
{
    partial class FrmBileter
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
            this.components = new System.ComponentModel.Container();
            this.btnTamam = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.txtBiletFiyati = new System.Windows.Forms.TextBox();
            this.txtBiletNumarasi = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Soyisim = new System.Windows.Forms.Label();
            this.İsim = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(185, 111);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(75, 29);
            this.btnTamam.TabIndex = 3;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            // 
            // btnİptal
            // 
            this.btnİptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnİptal.Location = new System.Drawing.Point(266, 111);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 29);
            this.btnİptal.TabIndex = 4;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            // 
            // txtBiletFiyati
            // 
            this.txtBiletFiyati.Location = new System.Drawing.Point(152, 72);
            this.txtBiletFiyati.Name = "txtBiletFiyati";
            this.txtBiletFiyati.Size = new System.Drawing.Size(189, 22);
            this.txtBiletFiyati.TabIndex = 2;
            // 
            // txtBiletNumarasi
            // 
            this.txtBiletNumarasi.Location = new System.Drawing.Point(152, 40);
            this.txtBiletNumarasi.Name = "txtBiletNumarasi";
            this.txtBiletNumarasi.Size = new System.Drawing.Size(189, 22);
            this.txtBiletNumarasi.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(152, 12);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(189, 22);
            this.txtID.TabIndex = 0;
            // 
            // Soyisim
            // 
            this.Soyisim.AutoSize = true;
            this.Soyisim.Location = new System.Drawing.Point(57, 69);
            this.Soyisim.Name = "Soyisim";
            this.Soyisim.Size = new System.Drawing.Size(68, 16);
            this.Soyisim.TabIndex = 34;
            this.Soyisim.Text = "Bilet Fiyatı";
            // 
            // İsim
            // 
            this.İsim.AutoSize = true;
            this.İsim.Location = new System.Drawing.Point(31, 40);
            this.İsim.Name = "İsim";
            this.İsim.Size = new System.Drawing.Size(94, 16);
            this.İsim.TabIndex = 35;
            this.İsim.Text = "Bilet Numarası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmBileter
            // 
            this.AcceptButton = this.btnTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnİptal;
            this.ClientSize = new System.Drawing.Size(363, 171);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.txtBiletFiyati);
            this.Controls.Add(this.txtBiletNumarasi);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.Soyisim);
            this.Controls.Add(this.İsim);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmBileter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmBileter";
            this.Load += new System.EventHandler(this.FrmBileter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.TextBox txtBiletFiyati;
        private System.Windows.Forms.TextBox txtBiletNumarasi;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label Soyisim;
        private System.Windows.Forms.Label İsim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}