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
    public partial class FrmBileter : Form
    {
        public FrmBileter()
        {
            InitializeComponent();
        }
        public Hayvan Hayvan { get; set; }
        public ziyaretciler ziyaretciler  { get; set; }
        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public biletler biletler { get; set; }
        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtBiletNumarasi)) return;
            if (!ErrorControl(txtBiletFiyati)) return;

            biletler.Bilet_Numarası = txtBiletNumarasi.Text;
            biletler.Bilet_Fiyatı = txtBiletFiyati.Text;


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

        private void FrmBileter_Load(object sender, EventArgs e)
        {

        }
    }
}
