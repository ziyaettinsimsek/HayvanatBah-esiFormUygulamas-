namespace HayvanatBahçesiFormUygulaması
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnHayvanEkle = new System.Windows.Forms.ToolStripButton();
            this.btnHayvanDüzenle = new System.Windows.Forms.ToolStripButton();
            this.btnHayvanSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.btnHayvanBul = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnZiyaretciEkle = new System.Windows.Forms.ToolStripButton();
            this.btnZiyaretciDüzenle = new System.Windows.Forms.ToolStripButton();
            this.btnZiyaretciSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.btnZiyaretciAra = new System.Windows.Forms.ToolStripButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hayvanlar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 34);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(786, 384);
            this.dataGridView1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHayvanEkle,
            this.btnHayvanDüzenle,
            this.btnHayvanSil,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.btnHayvanBul});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(786, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnHayvanEkle
            // 
            this.btnHayvanEkle.Image = global::HayvanatBahçesiFormUygulaması.Properties.Resources.dog_add;
            this.btnHayvanEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHayvanEkle.Name = "btnHayvanEkle";
            this.btnHayvanEkle.Size = new System.Drawing.Size(64, 28);
            this.btnHayvanEkle.Text = "Ekle";
            this.btnHayvanEkle.Click += new System.EventHandler(this.btnHayvanEkle_Click);
            // 
            // btnHayvanDüzenle
            // 
            this.btnHayvanDüzenle.Image = global::HayvanatBahçesiFormUygulaması.Properties.Resources.dog_edit;
            this.btnHayvanDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHayvanDüzenle.Name = "btnHayvanDüzenle";
            this.btnHayvanDüzenle.Size = new System.Drawing.Size(91, 28);
            this.btnHayvanDüzenle.Text = "Düzenle";
            this.btnHayvanDüzenle.Click += new System.EventHandler(this.btnHayvanDüzenle_Click);
            // 
            // btnHayvanSil
            // 
            this.btnHayvanSil.Image = global::HayvanatBahçesiFormUygulaması.Properties.Resources.dog_remove;
            this.btnHayvanSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHayvanSil.Name = "btnHayvanSil";
            this.btnHayvanSil.Size = new System.Drawing.Size(53, 28);
            this.btnHayvanSil.Text = "Sil";
            this.btnHayvanSil.Click += new System.EventHandler(this.btnHayvanSil_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 28);
            this.toolStripLabel1.Text = "Ara";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 31);
            // 
            // btnHayvanBul
            // 
            this.btnHayvanBul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHayvanBul.Image = global::HayvanatBahçesiFormUygulaması.Properties.Resources.dog_search;
            this.btnHayvanBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHayvanBul.Name = "btnHayvanBul";
            this.btnHayvanBul.Size = new System.Drawing.Size(29, 28);
            this.btnHayvanBul.Text = "Bul";
            this.btnHayvanBul.Click += new System.EventHandler(this.btnHayvanBul_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ziyaretçiler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnZiyaretciEkle,
            this.btnZiyaretciDüzenle,
            this.btnZiyaretciSil,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.toolStripTextBox2,
            this.btnZiyaretciAra});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(786, 31);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnZiyaretciEkle
            // 
            this.btnZiyaretciEkle.Image = global::HayvanatBahçesiFormUygulaması.Properties.Resources.visitor_man_add;
            this.btnZiyaretciEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZiyaretciEkle.Name = "btnZiyaretciEkle";
            this.btnZiyaretciEkle.Size = new System.Drawing.Size(64, 28);
            this.btnZiyaretciEkle.Text = "Ekle";
            this.btnZiyaretciEkle.Click += new System.EventHandler(this.btnZiyaretciEkle_Click);
            // 
            // btnZiyaretciDüzenle
            // 
            this.btnZiyaretciDüzenle.Image = global::HayvanatBahçesiFormUygulaması.Properties.Resources.visitor_man_edit;
            this.btnZiyaretciDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZiyaretciDüzenle.Name = "btnZiyaretciDüzenle";
            this.btnZiyaretciDüzenle.Size = new System.Drawing.Size(91, 28);
            this.btnZiyaretciDüzenle.Text = "Düzenle";
            this.btnZiyaretciDüzenle.Click += new System.EventHandler(this.btnZiyaretciDüzenle_Click);
            // 
            // btnZiyaretciSil
            // 
            this.btnZiyaretciSil.Image = global::HayvanatBahçesiFormUygulaması.Properties.Resources.visitor_man_remove;
            this.btnZiyaretciSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZiyaretciSil.Name = "btnZiyaretciSil";
            this.btnZiyaretciSil.Size = new System.Drawing.Size(53, 28);
            this.btnZiyaretciSil.Text = "Sil";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(32, 28);
            this.toolStripLabel2.Text = "Ara";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(200, 31);
            // 
            // btnZiyaretciAra
            // 
            this.btnZiyaretciAra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZiyaretciAra.Image = global::HayvanatBahçesiFormUygulaması.Properties.Resources.visitor_man_search;
            this.btnZiyaretciAra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZiyaretciAra.Name = "btnZiyaretciAra";
            this.btnZiyaretciAra.Size = new System.Drawing.Size(29, 28);
            this.btnZiyaretciAra.Text = "Bul";
            this.btnZiyaretciAra.Click += new System.EventHandler(this.btnZiyaretciAra_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(786, 415);
            this.dataGridView2.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "AnaForm";
            this.Text = "Hayvanat Bahçesi";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnHayvanEkle;
        private System.Windows.Forms.ToolStripButton btnHayvanDüzenle;
        private System.Windows.Forms.ToolStripButton btnHayvanSil;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton btnHayvanBul;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnZiyaretciEkle;
        private System.Windows.Forms.ToolStripButton btnZiyaretciDüzenle;
        private System.Windows.Forms.ToolStripButton btnZiyaretciSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripButton btnZiyaretciAra;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

