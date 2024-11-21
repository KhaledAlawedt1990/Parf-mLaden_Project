using clsHilfsMethoden;
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
            if (clsPermissionService.HatBerechtigung(clsGlobaleKlasse.currentUser.permissionNum, clsPermissionService.ParfuemVerwaltung))
            {
                frmpafümAnsicht frm = new frmpafümAnsicht();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Sie haben nicht die erforderlichen Berechtigungen, um auf diese Funktion zuzugreifen. Bitte wenden Sie sich an den Administrator, um die erforderlichen Rechte zu erhalten.",
                "Zugriff verweigert",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            //// Benutzer ausloggen (aktiven Benutzer zurücksetzen)
            //clsGlobaleKlasse.currentUser = null;

            //// Login-Fenster wieder anzeigen
            //if (_einLoggin != null)
            //{
            //    _einLoggin.Show();
            //}
        }

        private void frmMainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Benutzer ausloggen (aktiven Benutzer zurücksetzen)
            if(clsGlobaleKlasse.currentUser != null)
                  clsGlobaleKlasse.currentUser = null;
            
            // Anwendung vollständig beenden
            //Application.Exit();
     
            this.Close();
        }

        private void mitarbeiterverwaltungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsPermissionService.HatBerechtigung(clsGlobaleKlasse.currentUser.permissionNum, clsPermissionService.MitarbeiterVerwaltung))
            {
                frmMitarbeiterListe frm = new frmMitarbeiterListe();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Sie haben nicht die erforderlichen Berechtigungen, um auf diese Funktion zuzugreifen. Bitte wenden Sie sich an den Administrator, um die erforderlichen Rechte zu erhalten.",
               "Zugriff verweigert",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
        }

        private void kundeverwaltungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(clsPermissionService.HatBerechtigung(clsGlobaleKlasse.currentUser.permissionNum, clsPermissionService.KundenVerwaltung))
            {
                frmKundeListe frm = new frmKundeListe();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Sie haben nicht die erforderlichen Berechtigungen, um auf diese Funktion zuzugreifen. Bitte wenden Sie sich an den Administrator, um die erforderlichen Rechte zu erhalten.",
               "Zugriff verweigert",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
        }

        private void userverwaltungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsPermissionService.HatBerechtigung(clsGlobaleKlasse.currentUser.permissionNum, clsPermissionService.KundenVerwaltung))
            {
                frmUserListe frm = new frmUserListe();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Sie haben nicht die erforderlichen Berechtigungen, um auf diese Funktion zuzugreifen. Bitte wenden Sie sich an den Administrator, um die erforderlichen Rechte zu erhalten.",
               "Zugriff verweigert",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
        }
    }
}
