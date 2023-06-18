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
    public partial class Frmziyaretciler : Form
    {
        public Frmziyaretciler()
        {
            InitializeComponent();
        }
        public Hayvan Hayvan { get; set; }
        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public ziyaretciler ziyaretciler { get; set; }
        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtZiyaretciİsim)) return;
            if (!ErrorControl(txtZiyaretciSoyisim)) return;
            if (!ErrorControl(txtZiyaretciYasi)) return;
            if (!ErrorControl(maskedtxtZiyaretciTelefon)) return;

            ziyaretciler.Ziyaretci_İsim = txtZiyaretciİsim.Text;
            ziyaretciler.Ziyaretci_Soyisim = txtZiyaretciSoyisim.Text;
            ziyaretciler.Ziyaretci_Yasi = txtZiyaretciYasi.Text;
            ziyaretciler.Ziyaretci_Telefon = maskedtxtZiyaretciTelefon.Text;

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
            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
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

        private void btnTamam_Click_1(object sender, EventArgs e)
        {
            if (!ErrorControl(txtZiyaretciİsim)) return;
            if (!ErrorControl(txtZiyaretciSoyisim)) return;
            if (!ErrorControl(txtZiyaretciYasi)) return;
            if (!ErrorControl(maskedtxtZiyaretciTelefon)) return;

            ziyaretciler.Ziyaretci_İsim = txtZiyaretciİsim.Text;
            ziyaretciler.Ziyaretci_Soyisim = txtZiyaretciSoyisim.Text;
            ziyaretciler.Ziyaretci_Yasi = txtZiyaretciYasi.Text;
            ziyaretciler.Ziyaretci_Telefon = maskedtxtZiyaretciTelefon.Text;

            ziyaretciler.HayvanID = Guid.Parse(ziyaretcihayvantxt.Text);
            DialogResult = DialogResult.OK;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnhayvansec_Click(object sender, EventArgs e)
        {
            Hayvanlar frm = new Hayvanlar();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ziyaretcihayvantxt.Text = frm.Hayvan.ID.ToString();
            }
        }
    }
}
