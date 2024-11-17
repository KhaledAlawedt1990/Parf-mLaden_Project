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
    public partial class frmMainScreen : Form
    {
        frmLogginScreen _einLoggin;
        public frmMainScreen(frmLogginScreen einLoggin)
        {
            InitializeComponent();
            _einLoggin = einLoggin;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void parfümverwaltungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmpafümAnsicht frm = new frmpafümAnsicht();
            frm.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Benutzer ausloggen (aktiven Benutzer zurücksetzen)
            clsGlobaleKlasse.currentUser = null;

            // Login-Fenster wieder anzeigen
            if (_einLoggin != null)
            {
                _einLoggin.Show();
            }

            // Hauptfenster schließen
            this.Close();
        }
    }
}
