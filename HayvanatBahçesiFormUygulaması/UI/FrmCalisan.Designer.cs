namespace HayvanatBahçesiFormUygulaması.UI
{
    partial class FrmCalisan
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
            this.txtPozisyon = new System.Windows.Forms.TextBox();
            this.txtCalisanSoyisim = new System.Windows.Forms.TextBox();
            this.txtCalisanİsim = new System.Windows.Forms.TextBox();
            this.Pozisyon = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Telefon = new System.Windows.Forms.Label();
            this.Soyisim = new System.Windows.Forms.Label();
            this.Calisanİsim = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedtxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(114, 209);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(75, 23);
            this.btnTamam.TabIndex = 5;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnİptal.Location = new System.Drawing.Point(195, 209);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 23);
            this.btnİptal.TabIndex = 6;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // txtPozisyon
            // 
            this.txtPozisyon.Location = new System.Drawing.Point(92, 152);
            this.txtPozisyon.Name = "txtPozisyon";
            this.txtPozisyon.Size = new System.Drawing.Size(189, 22);
            this.txtPozisyon.TabIndex = 4;
            // 
            // txtCalisanSoyisim
            // 
            this.txtCalisanSoyisim.Location = new System.Drawing.Point(92, 82);
            this.txtCalisanSoyisim.Name = "txtCalisanSoyisim";
            this.txtCalisanSoyisim.Size = new System.Drawing.Size(189, 22);
            this.txtCalisanSoyisim.TabIndex = 2;
            // 
            // txtCalisanİsim
            // 
            this.txtCalisanİsim.Location = new System.Drawing.Point(92, 50);
            this.txtCalisanİsim.Name = "txtCalisanİsim";
            this.txtCalisanİsim.Size = new System.Drawing.Size(189, 22);
            this.txtCalisanİsim.TabIndex = 1;
            // 
            // Pozisyon
            // 
            this.Pozisyon.AutoSize = true;
            this.Pozisyon.Location = new System.Drawing.Point(24, 152);
            this.Pozisyon.Name = "Pozisyon";
            this.Pozisyon.Size = new System.Drawing.Size(62, 16);
            this.Pozisyon.TabIndex = 7;
            this.Pozisyon.Text = "Pozisyon";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(92, 22);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(189, 22);
            this.txtID.TabIndex = 0;
            // 
            // Telefon
            // 
            this.Telefon.AutoSize = true;
            this.Telefon.Location = new System.Drawing.Point(31, 118);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(53, 16);
            this.Telefon.TabIndex = 9;
            this.Telefon.Text = "Telefon";
            // 
            // Soyisim
            // 
            this.Soyisim.AutoSize = true;
            this.Soyisim.Location = new System.Drawing.Point(31, 82);
            this.Soyisim.Name = "Soyisim";
            this.Soyisim.Size = new System.Drawing.Size(55, 16);
            this.Soyisim.TabIndex = 10;
            this.Soyisim.Text = "Soyisim";
            // 
            // Calisanİsim
            // 
            this.Calisanİsim.AutoSize = true;
            this.Calisanİsim.Location = new System.Drawing.Point(45, 53);
            this.Calisanİsim.Name = "Calisanİsim";
            this.Calisanİsim.Size = new System.Drawing.Size(31, 16);
            this.Calisanİsim.TabIndex = 11;
            this.Calisanİsim.Text = "İsim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            // 
            // maskedtxtTelefon
            // 
            this.maskedtxtTelefon.Location = new System.Drawing.Point(92, 118);
            this.maskedtxtTelefon.Name = "maskedtxtTelefon";
            this.maskedtxtTelefon.Size = new System.Drawing.Size(189, 22);
            this.maskedtxtTelefon.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmCalisan
            // 
            this.AcceptButton = this.btnTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnİptal;
            this.ClientSize = new System.Drawing.Size(315, 290);
            this.Controls.Add(this.maskedtxtTelefon);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.txtPozisyon);
            this.Controls.Add(this.txtCalisanSoyisim);
            this.Controls.Add(this.txtCalisanİsim);
            this.Controls.Add(this.Pozisyon);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.Soyisim);
            this.Controls.Add(this.Calisanİsim);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmCalisan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCalisan";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.TextBox txtPozisyon;
        private System.Windows.Forms.TextBox txtCalisanSoyisim;
        private System.Windows.Forms.TextBox txtCalisanİsim;
        private System.Windows.Forms.Label Pozisyon;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label Telefon;
        private System.Windows.Forms.Label Soyisim;
        private System.Windows.Forms.Label Calisanİsim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedtxtTelefon;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}