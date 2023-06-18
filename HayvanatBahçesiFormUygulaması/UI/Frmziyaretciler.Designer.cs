namespace HayvanatBahçesiFormUygulaması.UI
{
    partial class Frmziyaretciler
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
            this.maskedtxtZiyaretciTelefon = new System.Windows.Forms.MaskedTextBox();
            this.btnTamam = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.txtZiyaretciYasi = new System.Windows.Forms.TextBox();
            this.txtZiyaretciSoyisim = new System.Windows.Forms.TextBox();
            this.txtZiyaretciİsim = new System.Windows.Forms.TextBox();
            this.Pozisyon = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Telefon = new System.Windows.Forms.Label();
            this.Soyisim = new System.Windows.Forms.Label();
            this.İsim = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ziyaretcihayvantxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnhayvansec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedtxtZiyaretciTelefon
            // 
            this.maskedtxtZiyaretciTelefon.Location = new System.Drawing.Point(150, 171);
            this.maskedtxtZiyaretciTelefon.Name = "maskedtxtZiyaretciTelefon";
            this.maskedtxtZiyaretciTelefon.Size = new System.Drawing.Size(189, 22);
            this.maskedtxtZiyaretciTelefon.TabIndex = 4;
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(186, 212);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(75, 23);
            this.btnTamam.TabIndex = 5;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click_1);
            // 
            // btnİptal
            // 
            this.btnİptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnİptal.Location = new System.Drawing.Point(267, 212);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 23);
            this.btnİptal.TabIndex = 6;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            // 
            // txtZiyaretciYasi
            // 
            this.txtZiyaretciYasi.Location = new System.Drawing.Point(150, 140);
            this.txtZiyaretciYasi.Name = "txtZiyaretciYasi";
            this.txtZiyaretciYasi.Size = new System.Drawing.Size(189, 22);
            this.txtZiyaretciYasi.TabIndex = 3;
            // 
            // txtZiyaretciSoyisim
            // 
            this.txtZiyaretciSoyisim.Location = new System.Drawing.Point(150, 104);
            this.txtZiyaretciSoyisim.Name = "txtZiyaretciSoyisim";
            this.txtZiyaretciSoyisim.Size = new System.Drawing.Size(189, 22);
            this.txtZiyaretciSoyisim.TabIndex = 2;
            // 
            // txtZiyaretciİsim
            // 
            this.txtZiyaretciİsim.Location = new System.Drawing.Point(150, 72);
            this.txtZiyaretciİsim.Name = "txtZiyaretciİsim";
            this.txtZiyaretciİsim.Size = new System.Drawing.Size(189, 22);
            this.txtZiyaretciİsim.TabIndex = 1;
            // 
            // Pozisyon
            // 
            this.Pozisyon.AutoSize = true;
            this.Pozisyon.Location = new System.Drawing.Point(25, 174);
            this.Pozisyon.Name = "Pozisyon";
            this.Pozisyon.Size = new System.Drawing.Size(107, 16);
            this.Pozisyon.TabIndex = 20;
            this.Pozisyon.Text = "Ziyaretçi Telefon";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(150, 9);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(189, 22);
            this.txtID.TabIndex = 0;
            // 
            // Telefon
            // 
            this.Telefon.AutoSize = true;
            this.Telefon.Location = new System.Drawing.Point(44, 140);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(88, 16);
            this.Telefon.TabIndex = 21;
            this.Telefon.Text = "Ziyaretçi Yaşı";
            // 
            // Soyisim
            // 
            this.Soyisim.AutoSize = true;
            this.Soyisim.Location = new System.Drawing.Point(23, 104);
            this.Soyisim.Name = "Soyisim";
            this.Soyisim.Size = new System.Drawing.Size(109, 16);
            this.Soyisim.TabIndex = 22;
            this.Soyisim.Text = "Ziyaretçi Soyisim";
            // 
            // İsim
            // 
            this.İsim.AutoSize = true;
            this.İsim.Location = new System.Drawing.Point(47, 75);
            this.İsim.Name = "İsim";
            this.İsim.Size = new System.Drawing.Size(85, 16);
            this.İsim.TabIndex = 23;
            this.İsim.Text = "Ziyaretçi İsim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ziyaretcihayvantxt
            // 
            this.ziyaretcihayvantxt.Location = new System.Drawing.Point(150, 44);
            this.ziyaretcihayvantxt.Name = "ziyaretcihayvantxt";
            this.ziyaretcihayvantxt.ReadOnly = true;
            this.ziyaretcihayvantxt.Size = new System.Drawing.Size(189, 22);
            this.ziyaretcihayvantxt.TabIndex = 25;
            this.ziyaretcihayvantxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Hayvan_id";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnhayvansec
            // 
            this.btnhayvansec.Location = new System.Drawing.Point(356, 42);
            this.btnhayvansec.Name = "btnhayvansec";
            this.btnhayvansec.Size = new System.Drawing.Size(103, 27);
            this.btnhayvansec.TabIndex = 27;
            this.btnhayvansec.Text = "Hayvan seç";
            this.btnhayvansec.UseVisualStyleBackColor = true;
            this.btnhayvansec.Click += new System.EventHandler(this.btnhayvansec_Click);
            // 
            // Frmziyaretciler
            // 
            this.AcceptButton = this.btnTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnİptal;
            this.ClientSize = new System.Drawing.Size(517, 247);
            this.Controls.Add(this.btnhayvansec);
            this.Controls.Add(this.ziyaretcihayvantxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedtxtZiyaretciTelefon);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.txtZiyaretciYasi);
            this.Controls.Add(this.txtZiyaretciSoyisim);
            this.Controls.Add(this.txtZiyaretciİsim);
            this.Controls.Add(this.Pozisyon);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.Soyisim);
            this.Controls.Add(this.İsim);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Frmziyaretciler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frmziyaretciler";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedtxtZiyaretciTelefon;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.TextBox txtZiyaretciYasi;
        private System.Windows.Forms.TextBox txtZiyaretciSoyisim;
        private System.Windows.Forms.TextBox txtZiyaretciİsim;
        private System.Windows.Forms.Label Pozisyon;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label Telefon;
        private System.Windows.Forms.Label Soyisim;
        private System.Windows.Forms.Label İsim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox ziyaretcihayvantxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnhayvansec;
    }
}