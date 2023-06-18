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
    public partial class FrmCalisan : Form
    {
        public FrmCalisan()
        {
            InitializeComponent();
        }
        public Hayvan Hayvan { get; set; }
        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public Calisan Calisan { get; set; }
        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtCalisanİsim)) return;
            if (!ErrorControl(txtCalisanSoyisim)) return;
            if (!ErrorControl(maskedtxtTelefon)) return;
            if (!ErrorControl(txtPozisyon)) return;

            Calisan.Calisan_İsim = txtCalisanİsim.Text;
            Calisan.Calisan_Soyisim = txtCalisanSoyisim.Text;
            Calisan.Calisan_Telefon = maskedtxtTelefon.Text;
            Calisan.Pozisyon = txtPozisyon.Text;
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
    }
}
