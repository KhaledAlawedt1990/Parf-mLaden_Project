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
        clsEinkauf _einkaufsDaten;
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
            dtpErstellungsDatum.CustomFormat = "dd.MM.yyyy          HH:mm";
        }

        private void _setzeEinkaufsDatenAufStandardWerte()
        {
            _DatumEinrichten();

            txtParfümNummer.Clear();
            txtParfümName.Clear();
            txtBatchNummer.Clear();
            txtParfümCode.Clear();
            txtLagerbestand.Clear();
            dtpErstellungsDatum.Value = DateTime.Now;
        }

        private void _ladeEinkaufsDaten()
        {
            lock(_lackObject)
            {
                try
                {
                    _einkaufsDaten = clsEinkauf.FindEinkaufDatenByParfümNummer(_parfümNummer);
                     
                    if(_einkaufsDaten == null)
                    {
                        MessageBox.Show("Der gesuchte EinkaufsDaten wurde nicht gefunden.", "Fehlermeldung",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                   
                    txtParfümNummer.Text = _einkaufsDaten.parfümNummer.ToString();
                    txtParfümName.Text = _einkaufsDaten.parfümName;
                    txtBatchNummer.Text = _einkaufsDaten.batchNummer;
                    txtParfümCode.Text = _einkaufsDaten.parfümCode;

                    txtLagerbestand.Text = _einkaufsDaten.lagerbestand.ToString();
                    dtpErstellungsDatum.Value = _einkaufsDaten.erstellungsDatum;
                    
                  
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show($"Ein unerwarteter Fehler ist aufgetreten: {ex.Message}", "Fehler",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show($"Ein Formatierungsfehler ist aufgetreten: {ex.Message}", "Fehler",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ein allgemeiner Fehler ist aufgetreten: {ex.Message}", "Fehler",
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
            _setzeEinkaufsDatenAufStandardWerte();

            if(_mode == enMode.addnew)
            {
                _einkaufsDaten = new clsEinkauf();
            }
            else
            {
                _ladeEinkaufsDaten();
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

        private bool _ValiedereEinkaufsdatenMenge()
        {
            bool isValid = true;

            isValid = _ValidiereEinFeld(txtParfümName, "ParfümName");
            isValid &= _ValidiereEinFeld(txtBatchNummer, "BatchNummer");
            isValid &= _ValidiereEinFeld(txtParfümCode, "ParfümCode");
            isValid &= _ValidiereEinFeld(txtNeueMenge, "EinkaufsMenge");
            return isValid; // Gibt zurück, ob alle Felder gültig sind
        }

        private float _HatNeueMengeGültigeNummer(string neueMenge)
        {
            float MengeNummer;

            if (float.TryParse(neueMenge, out MengeNummer))
            {
                return MengeNummer;
            }
            else
                return -1;
        }

        private void _fülleEinkaufsdaten()
        {
            _einkaufsDaten.parfümNummer = Convert.ToInt32(txtParfümNummer.Text);
            _einkaufsDaten.parfümName = txtParfümName.Text;
            _einkaufsDaten.batchNummer = txtBatchNummer.Text;
            _einkaufsDaten.parfümCode = txtParfümCode.Text;
            _einkaufsDaten.lagerbestand = _einkaufsDaten.lagerbestand + Convert.ToSingle(txtNeueMenge.Text.Trim()); // Hier addieren wir die neue Menge!!!!!
            _einkaufsDaten.erstellungsDatum = dtpErstellungsDatum.Value;
        }
        private void _speicherEinkaufsdaten()
        {
           
            if (!_ValiedereEinkaufsdatenMenge())
                return;

            if (_HatNeueMengeGültigeNummer(txtNeueMenge.Text.Trim()) == -1)
            {
                errorProvider1.SetError(txtNeueMenge, "Der Feld nimmt nur Nummer auf");
                return;
            }

            _fülleEinkaufsdaten();

            try
            {
                if (_einkaufsDaten.Save())
                {
                    MessageBox.Show($"Einkauf Daten erfolgreich {(_mode == enMode.addnew ? "hinzugefügt" : "aktualisiert")}", "Erfolg",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _mode = enMode.update; // wir aktualisieren den Object.

                    this.Close();
                    
                }
                else
                    MessageBox.Show("Fehler beim Speichern der Einkaufsdaten ist aufgetreten", "Fehlermeldung",
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
            _speicherEinkaufsdaten();
        }

        private void txtParfümNummer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
