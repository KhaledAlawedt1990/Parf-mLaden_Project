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
    public partial class frmAddUpdateNeueParfümMenge : Form
    {
        public enum enMode { addnew = 0, update =1}
        public enMode _mode = enMode.addnew;

        private readonly object _lackObject = new object();
        clsLager _parfüm;
        private int _parfümNummer;
        public frmAddUpdateNeueParfümMenge(int parfümNummer, enMode mode)
        {
            InitializeComponent();

            this._mode = mode;
            this._parfümNummer = parfümNummer;
        }

        private void _DatumEinrichten()
        {
            dtpErstellungsDatum.Format = DateTimePickerFormat.Custom;
            dtpErstellungsDatum.CustomFormat = "dd.MM.yyyy       HH:mm";
        }

        private void _setzeDatenAufStandardWerte()
        {
            _DatumEinrichten();

            txtParfümNummer.Clear();
            txtParfümName.Clear();
            txtBatchNummer.Clear();
            txtParfümCode.Clear();
            txtLagerbestand.Clear();
            dtpErstellungsDatum.Value = DateTime.Now;
        }

        private void _ladeParfümMengeDaten()
        {
            lock(_lackObject)
            {
                _parfüm = clsLager.FindLagerDatenByParfümNummer(_parfümNummer);

                if(_parfüm != null)
                {
                    txtParfümNummer.Text = _parfüm.parfümNummer.ToString();
                    txtParfümName.Text = _parfüm.parfümName;
                    txtBatchNummer.Text = _parfüm.batchNummer;
                    txtParfümCode.Text = _parfüm.parfümCode;
    
                    txtLagerbestand.Text = _parfüm.lagerbestand.ToString();
                    dtpErstellungsDatum.Value = _parfüm.erstellungsDatum;
                }
                else
                {
                    MessageBox.Show("Der gesuchte Parfüm wurde nicht gefunden.", "Fehlermeldung",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddUpdateNeueParfümMenge_Load(object sender, EventArgs e)
        {
            _setzeDatenAufStandardWerte();

            if(_mode == enMode.addnew)
            {
                _parfüm = new clsLager();
            }
            else
            {
                _ladeParfümMengeDaten();
            }
        }


        private bool _ValidiereEinFeld(TextBox txtboxName, string name)
        {
            if (string.IsNullOrEmpty(txtboxName.Text))
            {
                errorProvider1.SetError(txtboxName, $"{name} darf nicht leer sein!");
                txtboxName.BackColor = Color.LightPink;  // Hintergrundfarbe ändern
                txtboxName.BorderStyle = BorderStyle.FixedSingle;

                return false;
            }
            else
            {
                errorProvider1.SetError(txtboxName, null);
                txtboxName.BackColor = Color.White;  // Standardfarbe wiederherstellen
                txtboxName.BorderStyle = BorderStyle.FixedSingle;
            }

            return true;
        }

        private bool _ValiedereParfümMengeFelder()
        {
            bool isValid = true;

            isValid = _ValidiereEinFeld(txtParfümName, "parfümName");
            isValid &= _ValidiereEinFeld(txtBatchNummer, "batchNummer");
            isValid &= _ValidiereEinFeld(txtParfümCode, "parfümCode");
            isValid &= _ValidiereEinFeld(txtLagerbestand, "lagerbestand");
            return isValid; // Gibt zurück, ob alle Felder gültig sind
        }

        private float _istLagerbestandNummerGültig(string lagerbestand)
        {
            float lagerbestandNummer;

            if (float.TryParse(lagerbestand, out lagerbestandNummer))
            {
                return lagerbestandNummer;
            }
            else
                return -1;
        }

        private void _fülleParfümMengeDaten()
        {
            _parfüm.parfümNummer = Convert.ToInt32(txtParfümNummer.Text);
            _parfüm.parfümName = txtParfümName.Text;
            _parfüm.batchNummer = txtBatchNummer.Text;
            _parfüm.parfümCode = txtParfümCode.Text;
            _parfüm.lagerbestand = Convert.ToSingle(txtLagerbestand.Text);
            _parfüm.erstellungsDatum = dtpErstellungsDatum.Value;
        }
        private void _speicherParfümMengeDaten()
        {
           
            if (!_ValiedereParfümMengeFelder())
                return;

            if (_istLagerbestandNummerGültig(txtLagerbestand.Text.Trim()) == -1)
            {
                errorProvider1.SetError(txtLagerbestand, "Der Feld nimmt nur Nummer auf");
                return;
            }

            _fülleParfümMengeDaten();

            try
            {
                if (_parfüm.Save())
                {
                    MessageBox.Show($"Parfüm Menge erfolgreich {(_mode == enMode.addnew ? "hinzugefügt" : "aktualisiert")}", "Erfolg",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _mode = enMode.update; // wir aktualisieren den Object.

                    this.Close();
                }
                else
                    MessageBox.Show("Fehler beim Speichern ParfümMenge ist aufgetreten", "Fehlermeldung",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Überprüfen, ob der Fehler durch eine doppelte Primärnummer verursacht wurde
                if (ex.Message.Contains("PRIMARY KEY-Einschränkung") || ex.Message.Contains("Violation of PRIMARY KEY"))
                {
                    MessageBox.Show("Die eingegebene Parfümnummer existiert bereits. Bitte geben Sie eine eindeutige Nummer ein.",
                        "Doppelte Parfümnummer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Allgemeiner Fehler
                    MessageBox.Show($"Ein Fehler ist aufgetreten: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            _speicherParfümMengeDaten();
        }

        private void txtParfümNummer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
