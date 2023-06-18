using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HayvanatBahçesiFormUygulaması.UI;
using HayvanatBahçesiFormUygulaması.BL;

namespace HayvanatBahçesiFormUygulaması
{
    public partial class AnaForm : Form
    {
        public Hayvan Hayvan { get; set; }
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btnHayvanEkle_Click(object sender, EventArgs e)
        {
            FrmHayvan frmHayvan = new FrmHayvan()
            {
                Text = "Hayvan Ekle",
                Hayvan = new Hayvan() { ID = Guid.NewGuid() },
            };

        tekrar:
            var sonuc = frmHayvan.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.HayvanEkle(frmHayvan.Hayvan);
                if (b)
                {

                    DataSet ds = BLogic.Hayvangetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];

                }
                else
                    goto tekrar;
            }
        }

        private void btnHayvanDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            FrmHayvan frmHayvan = new FrmHayvan()
            {
                Text = "Hayvan Güncelle",
                Güncelleme = true,
                Hayvan = new Hayvan()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Hayvan_Ad = row.Cells[1].Value.ToString(),
                    Turu = row.Cells[2].Value.ToString(),
                    Kafesi = row.Cells[3].Value.ToString(),
                    Yemi = row.Cells[4].Value.ToString(),
                },
            };
            var sonuc = frmHayvan.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.HayvanGüncelle(frmHayvan.Hayvan);
                if (b)
                {

                    row.Cells[1].Value = frmHayvan.Hayvan.Hayvan_Ad;
                    row.Cells[2].Value = frmHayvan.Hayvan.Turu;
                    row.Cells[3].Value = frmHayvan.Hayvan.Kafesi;
                    row.Cells[4].Value = frmHayvan.Hayvan.Yemi;

                }

            }
        }

        private void btnHayvanBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.Hayvangetir(toolStripTextBox1.Text);
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            DataSet ds1 = BLogic.Hayvangetir("");
            if (ds1 != null)
                dataGridView1.DataSource = ds1.Tables[0];
            DataSet ds2 = BLogic.ziyaretcilergetir("");
            if (ds2 != null)
                dataGridView2.DataSource = ds2.Tables[0];

        }

        private void btnHayvanSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi Onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.HayvanSil(ID);
                if (b)
                {

                    DataSet ds = BLogic.Hayvangetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];

                }

            }
        }

        private void btnZiyaretciEkle_Click(object sender, EventArgs e)
        {
            Frmziyaretciler frm = new Frmziyaretciler()
            {
                Text = "ziyaretciler Ekle",
                ziyaretciler = new ziyaretciler() { ID = Guid.NewGuid() },
            };

        tekrar:
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.ziyaretcilerEkle(frm.ziyaretciler);
                if (b)
                {

                    DataSet ds = BLogic.ziyaretcilergetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];

                }
                else
                    goto tekrar;
            }

        }

        private void btnZiyaretciAra_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.Hayvangetir(toolStripTextBox1.Text);
            if (ds != null)
                dataGridView2.DataSource = ds.Tables[1];
        }

        private void btnZiyaretciDüzenle_Click(object sender, EventArgs e)
        {

        }
    }
}
