using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HayvanatBahçesiFormUygulaması.UI
{
    public partial class FrmHayvan : Form
    {
        public FrmHayvan()
        {
            InitializeComponent();
        }

        private void btn_İptal(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public Hayvan Hayvan { get; set; }
        public bool Güncelleme { get; set; } = false;
        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtAd)) return;
            if (!ErrorControl(txtTürü)) return;
            if (!ErrorControl(txtKafesi)) return;
            if (!ErrorControl(txtYemi)) return;

            Hayvan.Hayvan_Ad = txtAd.Text;
            Hayvan.Turu = txtTürü.Text;
            Hayvan.Kafesi = txtKafesi.Text;
            Hayvan.Yemi = txtYemi.Text;

            DialogResult = DialogResult.OK;
        }

        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik Veya Hatalı Bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;

                }
            }
            return true;
        }

        private void FrmHayvan_Load(object sender, EventArgs e)
        {
            txtID.Text = Hayvan.ID.ToString();
            if (Güncelleme)
            {
                txtAd.Text = Hayvan.Hayvan_Ad;
                txtTürü.Text = Hayvan.Turu; 
                txtKafesi.Text = Hayvan.Kafesi;
                txtYemi.Text = Hayvan.Yemi;
            }
            
        }
    }
}
