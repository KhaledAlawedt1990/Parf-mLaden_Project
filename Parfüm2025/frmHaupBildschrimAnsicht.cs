using clsHilfsMethoden;
using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parfüm2025
{
    public partial class frmHaupBildschrimAnsicht : Form
    {
        private float _neuerLagerbestand = -1;
        private int _parfümNummer = -1;
        public frmHaupBildschrimAnsicht()
        {
            InitializeComponent();
        }
        private void clsHaupBildschrimAnsicht_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Benutzer ausloggen (aktiven Benutzer zurücksetzen)
            if (clsGlobaleKlasse.currentUser != null)
                clsGlobaleKlasse.currentUser = null;

            // Anwendung vollständig beenden
            //Application.Exit();

            this.Close();
        }

        private void parfümAnsichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsPermissionService.HatBerechtigung(clsGlobaleKlasse.currentUser.permissionNum, clsPermissionService.ParfuemVerwaltung))
            {
                frmpafümAnsicht frm = new frmpafümAnsicht();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sie haben nicht die erforderlichen Berechtigungen, um auf diese Funktion zuzugreifen. Bitte wenden Sie sich an den Administrator, um die erforderlichen Rechte zu erhalten.",
                    "Zugriff verweigert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void kundeAnsichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsPermissionService.HatBerechtigung(clsGlobaleKlasse.currentUser.permissionNum, clsPermissionService.KundenVerwaltung))
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

        private void mitarbeiterAnsichtToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void benutzerAnsichtToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void einkaufAnsichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsPermissionService.HatBerechtigung(clsGlobaleKlasse.currentUser.permissionNum, clsPermissionService.LagerVerwaltung))
            {
                frmEinkaufsDatenListe frm = new frmEinkaufsDatenListe();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Sie haben nicht die erforderlichen Berechtigungen, um auf diese Funktion zuzugreifen. Bitte wenden Sie sich an den Administrator, um die erforderlichen Rechte zu erhalten.",
               "Zugriff verweigert",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
        }

        private void verkaufAnsichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsPermissionService.HatBerechtigung(clsGlobaleKlasse.currentUser.permissionNum, clsPermissionService.LagerVerwaltung))
            {
                frmVerkaufsDatenListe frm = new frmVerkaufsDatenListe();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Sie haben nicht die erforderlichen Berechtigungen, um auf diese Funktion zuzugreifen. Bitte wenden Sie sich an den Administrator, um die erforderlichen Rechte zu erhalten.",
               "Zugriff verweigert",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
        }

        private void ausloggenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HinzufügeNeueParfümtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddUpdateNewPerfum frm = new frmAddUpdateNewPerfum(-1);
            frm.ShowDialog();
        }

        private void hinzufügeNeuenKundenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateNeueKunde frm = new frmAddUpdateNeueKunde(-1, false);
            frm.ShowDialog();
        }

        private void hinzufügeNeuenMitarbeiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateNeueMitarbeiter frm = new frmAddUpdateNeueMitarbeiter(-1, false);
            frm.ShowDialog();
        }

        private void hinzufügeNeuenEinkaufToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateNeueParfümMenge frm = new frmAddUpdateNeueParfümMenge(-1, frmAddUpdateNeueParfümMenge.enMode.addnew);
            frm.ShowDialog();
        }

        private void hinzufügeNeuenVerkaufToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateVerkaufDaten frm = new frmAddUpdateVerkaufDaten(-1, frmAddUpdateVerkaufDaten.enMode.addnew);
            frm.lagerbestandAktualisiert +=  _ÜberprüfeLagerbestand;
            frm.ShowDialog();

            if(_neuerLagerbestand < 50 && _parfümNummer != -1)
            {
                _SetzeNotifikation();
            }
        }

        private void _ÜberprüfeLagerbestand(object sender, float neuerLagerbestand, int parfümNummer)
        {
            _neuerLagerbestand = neuerLagerbestand;
            _parfümNummer = parfümNummer;
        }

        private void _SetzeNotifikation()
        {
            new ToastContentBuilder()
                 .AddText("Achtung: Niedriger Lagerbestand!")
                   .AddText($"Der Lagerbestand für die ParfümNummer {_parfümNummer} ist unter 50 gefallen. Bitte prüfen Sie die Bestände.")
                   .SetToastDuration(ToastDuration.Long) // Toast länger anzeigen
                     .Show();

            _neuerLagerbestand = -1;  // neuelagerbestand zurücksetzen
            _parfümNummer = -1;    // parfümNummer zurücksetzen 
        }
    }
}
