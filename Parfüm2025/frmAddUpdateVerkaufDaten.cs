using Busnisse_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using clsHilfsMethoden;
using System.Data.SqlClient;

namespace Parfüm2025
{
    public partial class frmAddUpdateVerkaufDaten : Form
    {
        public enum enMode { addnew = 0, update = 1, SeheDetails = 2}
        public enMode _mode = enMode.addnew;

        private readonly object _lackObject = new object();
        private readonly object _autoComplateLock = new object();
        clsVerkauf  _verkaufsDaten;
        private int _belegID;

        public delegate void  Databack(object senden, float lagerbestand, int parfümNummer);
        public event Databack lagerbestandAktualisiert;
        public frmAddUpdateVerkaufDaten(int belegID, enMode mode)
        {
            InitializeComponent();
            this._belegID= belegID;
            this._mode = mode;
        }

        private void _DatumEinrichten()
        {
            dtpErstellungsDatum.Format = DateTimePickerFormat.Custom;
            dtpErstellungsDatum.CustomFormat = "dd.MM.yyyy   HH:mm";
        }

        private void _setzeVerkaufsDatenAufStandardWerte()
        {
            _DatumEinrichten();

            txtBelegID.Text = "-1";
            txtParfümNummer.Clear();
            txtKundeName.Clear();
            txtVerkaufsMenge.Clear();
            txtLagerbestand.Text = "0";
            txtNormalPreis.Clear();
            txtGesamtPreis.Clear();
            dtpErstellungsDatum.Value = DateTime.Now;
        }

        private void _ladeVerkaufsDaten()
        {
            lock (_lackObject)
            {
                try
                {
                    _verkaufsDaten = clsVerkauf.Find(_belegID);

                    if (_verkaufsDaten == null)
                    {
                        MessageBox.Show("Die Verkaufsdaten konnten nicht gefunden werden.", "Fehler",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    txtBelegID.Text = _verkaufsDaten.belegID.ToString();
                    txtParfümNummer.Text = _verkaufsDaten.parfümNummer.ToString();
                    txtKundeName.Text = _verkaufsDaten.kundeInfos.Vollname;
                    txtVerkaufsMenge.Text = _verkaufsDaten.verkaufsMenge.ToString();
                    // Lagerbestand abrufen
                    txtLagerbestand.Text = clsEinkauf.FindEinkaufDatenByParfümNummer(_verkaufsDaten.parfümNummer).lagerbestand.ToString();
                    // Preise formatieren
                    txtNormalPreis.Text = _verkaufsDaten.normalPreis.ToString("C", CultureInfo.GetCultureInfo("de-DE"));
                    txtGesamtPreis.Text = _verkaufsDaten.gesamtPreis.ToString("C", CultureInfo.GetCultureInfo("de-DE"));
                    dtpErstellungsDatum.Value = _verkaufsDaten.erstellungsDatum;

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

        private bool _ValiedereVerkaufsdatenMenge()
        {
            bool isValid = true;

            isValid = _ValidiereEinFeld(txtParfümNummer, "ParfümNummer");
            isValid &= _ValidiereEinFeld(txtKundeName, "KundeName");
            isValid &= _ValidiereEinFeld(txtVerkaufsMenge, "VerkaufsMenge");
            isValid &= _ValidiereEinFeld(txtNormalPreis, "NormalPreis");
        
            return isValid; // Gibt zurück, ob alle Felder gültig sind
        }


        private bool _fülleVerkaufsdaten()
        {
             
            _verkaufsDaten.parfümNummer = Convert.ToInt32(txtParfümNummer.Text);

            clsKunde kundedatem = clsKunde.FindKundeByPersonName(txtKundeName.Text.Trim());
            if(kundedatem == null)
            {
                MessageBox.Show("Dieser Kunde existiert leider nicht im system.\nBitte geben Sie einen gültigen Kunden ein.","Fehlermeldung",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            _verkaufsDaten.kundeID = kundedatem.kundeID ;
            _verkaufsDaten.verkaufsMenge = Convert.ToSingle(txtVerkaufsMenge.Text.Trim());

           
            float lagerbestand = Convert.ToSingle(txtLagerbestand.Text.Trim());
            float verkaufsMenge = Convert.ToSingle(txtVerkaufsMenge.Text.Trim());

            if(lagerbestand < verkaufsMenge)
            {
                MessageBox.Show("Die Verkaufsmenge überschreitet den Lagerbestand. Bitte passen Sie die Menge an.",
                  "Warnung",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);
                return false;
            }
            float neueLagerbestand = lagerbestand - verkaufsMenge;
            _verkaufsDaten.lagerbestand = neueLagerbestand; ; // hier subtraieren die verkaufsMenge .

            
            _verkaufsDaten.normalPreis = _ExtractNumber(txtNormalPreis.Text.Trim()) ; 
            _verkaufsDaten.gesamtPreis = _ExtractNumber(txtGesamtPreis.Text.Trim()); // Mit Seteuer dazu.
            _verkaufsDaten.erstellungsDatum = dtpErstellungsDatum.Value;

            return true;
        }

        private float _ExtractNumber(string text)
        {
            // Entfernt alle Tausendertrennzeichen (Punkte in deutscher Kultur)
            string cleanedInput = text.Replace(".", "");

            // Filtert nur Ziffern und das Dezimaltrennzeichen (Komma für de-DE)
            string numericPart = new string(cleanedInput.Where(c => char.IsDigit(c) || c == ',').ToArray());

            // Ersetzt das Komma durch einen Punkt (falls notwendig)
            numericPart = numericPart.Replace(',', '.');

            // Versucht, die gefilterte Zeichenkette in eine Zahl umzuwandeln
            if (float.TryParse(numericPart, NumberStyles.Float, CultureInfo.InvariantCulture, out float number))
            {
                return number;
            }
            else
            {
                MessageBox.Show($"Die Eingabe '{text}' enthält keine gültige Zahl.");
                return 0f;
            }
        }
        private bool _ExistiertParfümNummer()
        {
            int parfümNummer = Convert.ToInt32(txtParfümNummer.Text.Trim());

            if(!clsParfüm.IstParfümNummerVergeben(parfümNummer))
            {
                MessageBox.Show("Diese Parfümnummer existiert nicht in der Parfümliste.", "Fehlermeldung",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;   
        }
        private void _speicherEinkaufsdaten()
        {
            if (!_ValiedereVerkaufsdatenMenge())
                return;

            if (!_ExistiertParfümNummer())
                return;


            if (_ExtractNumber(txtVerkaufsMenge.Text.Trim()) == 0f)
            {
                errorProvider1.SetError(txtVerkaufsMenge, "Der Feld nimmt nur Nummer auf");
                return;
            }

            if (_ExtractNumber(txtNormalPreis.Text.Trim()) == 0f)
            {
                errorProvider1.SetError(txtNormalPreis, "Der Feld nimmt nur Nummer auf");
                return;
            }

            if(!_fülleVerkaufsdaten())
                return;

            if (_verkaufsDaten.Save() && clsEinkauf.UpdateLagerbestand(_verkaufsDaten.parfümNummer, _verkaufsDaten.lagerbestand))
            {
                MessageBox.Show($"Verkauf Daten erfolgreich {(_mode == enMode.addnew ? "hinzugefügt" : "aktualisiert")}", "Erfolg",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                _mode = enMode.update; // wir aktualisieren den Object.
                txtBelegID.Text = _verkaufsDaten.belegID.ToString();

                this.lagerbestandAktualisiert?.Invoke(this, _verkaufsDaten.lagerbestand, _verkaufsDaten.parfümNummer);

                this.Close();

            }
            else
                MessageBox.Show("Fehler beim Speichern der Verkaufsdaten ist aufgetreten", "Fehlermeldung",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmAddUpdateVerkaufDaten_Load(object sender, EventArgs e)
        {
            
            _setzeVerkaufsDatenAufStandardWerte();

            if (_mode == enMode.addnew)
            {
                _verkaufsDaten = new clsVerkauf();
            }
            else if(_mode == enMode.update)
            {
                _ladeVerkaufsDaten();
                lbVorschläge.Visible = false;
            }
            else
            {
                _ladeVerkaufsDaten();
                btnSpeichern.Enabled = false;
                lbVorschläge.Visible = !(_mode == enMode.SeheDetails);
            }
        }

        private void txtParfümNummer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            _speicherEinkaufsdaten();
        }

        private void txtParfümNummer_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtParfümNummer.Text.Trim()))
            {
                int parfümNum = Convert.ToInt32(txtParfümNummer.Text.Trim());
                clsEinkauf einkaufsdaten = clsEinkauf.FindEinkaufDatenByParfümNummer(parfümNum);
                if (einkaufsdaten != null)
                {
                    txtLagerbestand.Text = einkaufsdaten.lagerbestand.ToString();
                }
                else
                    txtLagerbestand.Text = "0";
            }
            else
                txtLagerbestand.Clear();
        }

        private void txtNormalPreis_TextChanged(object sender, EventArgs e)
       {
            string formattedPrice = txtNormalPreis.Text.Trim();
            float normalPreise;
            if (!string.IsNullOrEmpty(txtNormalPreis.Text.Trim()))
            {
                if (float.TryParse(formattedPrice, NumberStyles.Currency, CultureInfo.GetCultureInfo("de-DE"), out normalPreise))
                {
                    float gesamtPreis = Convert.ToSingle(normalPreise * 1.19);
                    txtGesamtPreis.Text = gesamtPreis.ToString("C", CultureInfo.GetCultureInfo("de-DE"));
                }
            }
            else
                txtGesamtPreis.Clear();
        }
        private void _AvlBaumImplementierung()
        {
            DataTable kundenName = clsKunde.GetAllKundeName();
            if (kundenName == null)
                return;

            AutoComplete.AVLTree tree = new AutoComplete.AVLTree();

            foreach (DataRow row in kundenName.Rows)
            {
                tree.Insert(row["Vollname"].ToString());
            }

            string perfix = txtKundeName.Text.Trim();
            var completions = tree.AutoComplete(perfix);

            //wir aktualisieren die listbox, um vorschläge anzuzeigen.
            UpdateAutoCompleteListeBox(completions);

        }

        private void UpdateAutoCompleteListeBox(IEnumerable<string> completions)
        {
            lock (_autoComplateLock)
            {
                lbVorschläge.Items.Clear();

                //wir füllen dann die listebox mit vorschlägen
                foreach (var suggestion in completions)
                {
                    lbVorschläge.Items.Add(suggestion.ToString());
                }

                if (!string.IsNullOrEmpty(txtKundeName.Text.Trim()))
                {
                    //die liste wird angezeigt, wenn da Vorschläge gibt.
                    lbVorschläge.Visible = lbVorschläge.Items.Count > 0;
                }
                else
                {
                    lbVorschläge.Items.Clear();
                    lbVorschläge.Visible = false;
                }
            }
        }
        private void txtKundeName_TextChanged(object sender, EventArgs e)
        {
            _AvlBaumImplementierung();
        }

        private void lbVorschläge_SelectedIndexChanged(object sender, EventArgs e)
        {
            //// Überprüfen, ob etwas ausgewählt wurde
            //if (lbVorschläge.SelectedItem != null)
            //{
            //    string selectedItem = lbVorschläge.SelectedItem.ToString();
            //    MessageBox.Show($"Ausgewählt: {selectedItem}");
            //}
            //else
            //{
            //    // Keine Aktion notwendig, weil nichts ausgewählt wurde
            //    MessageBox.Show("Kein Eintrag ausgewählt!", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
        }

        private void lbVorschläge_Click(object sender, EventArgs e)
        {
            if (lbVorschläge.Items.Count == 0)
            {
                MessageBox.Show("Die Liste ist leer.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //wir setzen den ausgewählten Vorschlag in das "txtFilterBeiName" Textfeld und verbergen wir  die listboxw
            if (lbVorschläge.SelectedItem != null)
            {
                string selectedItem = lbVorschläge.SelectedItem.ToString();
                txtKundeName.Text = selectedItem;
                MessageBox.Show($"Ausgewählt: {selectedItem}");
                lbVorschläge.Visible = false;
            }
            else
            {
                MessageBox.Show("Kein gültiger Eintrag ausgewählt.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
