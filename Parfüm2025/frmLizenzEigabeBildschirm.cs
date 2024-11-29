using Busnisse_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parfüm2025
{
    public partial class frmLizenzEigabeBildschirm : Form
    {
        private bool _IsLezenzKeyValid = false;
        public frmLizenzEigabeBildschirm()
        {
            InitializeComponent();
        }

        private void frmLizenzEigabeBildschirm_Load(object sender, EventArgs e)
        {
            txtKeyFeld.Select();
        }

        private void btnForfahren_Click(object sender, EventArgs e)
        {
            string schluessel = txtKeyFeld.Text.Trim();

            if(string.IsNullOrEmpty(schluessel) || !clsProduktKey.AddnewProduktKay(schluessel))
            {
                MessageBox.Show("Der Lizenzschlüssel konnte nicht verifiziert werden. " +
                   "Bitte überprüfen Sie den eingegebenen Schlüssel oder wenden Sie sich an den Support, " +
                   "um einen gültigen Lizenzschlüssel zu erhalten.",
                   "Lizenz erforderlich", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                _IsLezenzKeyValid = false;
            }
            else
            {
                Properties.Settings.Default.LizenzKey = schluessel;
                Properties.Settings.Default.Save();

                _IsLezenzKeyValid = true;
                this.Close();
            }
        }

        public bool GetValidKey()
        {
            return _IsLezenzKeyValid;
        }
        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
