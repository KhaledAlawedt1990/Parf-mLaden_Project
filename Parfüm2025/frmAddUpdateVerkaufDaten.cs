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

namespace Parfüm2025
{
    public partial class frmAddUpdateVerkaufDaten : Form
    {
        public enum enMode { addnew = 0, update = 1 }
        public enMode _mode = enMode.addnew;

        private readonly object _lackObject = new object();
        private readonly object _autoComplateLock = new object();
        clsVerkauf  _verkaufsDaten;
        private int _verkaufsID;
        public frmAddUpdateVerkaufDaten(int verkaufsID, enMode mode)
        {
            InitializeComponent();
            this._verkaufsID= verkaufsID;
            this._mode = mode;
        }

        private void _DatumEinrichten()
        {
            dtpErstellungsDatum.Format = DateTimePickerFormat.Custom;
            dtpErstellungsDatum.CustomFormat = "dd.MM.yyyy          HH:mm";
        }

        private void _setzeVerkaufsDatenAufStandardWerte()
        {
            _DatumEinrichten();

            txtVerkaufsID.Text = "-1";
            txtParfümNummer.Clear();
            txtKundeName.Clear();
            txtVerkaufsMenge.Clear();
            txtLagerbestand.Clear();
            txtNormalPreis.Clear();
            txtGesamtPreis.Clear();
            dtpErstellungsDatum.Value = DateTime.Now;
        }

        private void _ladeVerkaufsDaten()
        {
            lock (_lackObject)
            {
                _verkaufsDaten = clsVerkauf.Find(_verkaufsID);

                if (_verkaufsDaten != null)
                {
                    txtVerkaufsID.Text = _verkaufsDaten.verkaufsID.ToString();
                    txtParfümNummer.Text = _verkaufsDaten.parfümNummer.ToString();
                    txtKundeName.Text = _verkaufsDaten.kundeInfos.Vollname;
                    txtVerkaufsMenge.Text = _verkaufsDaten.verkaufsMenge.ToString();
                    txtLagerbestand.Text = clsEinkauf.FindEinkaufDatenByParfümNummer(_verkaufsDaten.parfümNummer).lagerbestand.ToString();

                    txtNormalPreis.Text = _verkaufsDaten.normalPreis.ToString();
                    txtGesamtPreis.Text = _verkaufsDaten.ToString();
                    dtpErstellungsDatum.Value = _verkaufsDaten.erstellungsDatum;
                }
                else
                {
                    MessageBox.Show("Der gesuchte VerkaufsDaten wurde nicht gefunden.", "Fehlermeldung",
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
        private void _fülleVerkaufsdaten()
        {
             
            _verkaufsDaten.parfümNummer = Convert.ToInt32(txtParfümNummer.Text);
            _verkaufsDaten.kundeID = clsKunde.FindKundeByPersonName(txtKundeName.Text.Trim()).kundeID;
            _verkaufsDaten.verkaufsMenge = Convert.ToSingle(txtVerkaufsMenge.Text.Trim());

            float neueLagerbestand = Convert.ToSingle(txtLagerbestand.Text.Trim()) - Convert.ToSingle(txtVerkaufsMenge.Text.Trim());
            _verkaufsDaten.lagerbestand = neueLagerbestand; ; // hier subtraieren die verkaufsMenge .

            _verkaufsDaten.normalPreis = Convert.ToSingle(txtNormalPreis.Text.Trim()); 

            _verkaufsDaten.gesamtPreis = Convert.ToSingle(_verkaufsDaten.normalPreis * 1.19); // Mit Seteuer dazu.

            _verkaufsDaten.erstellungsDatum = dtpErstellungsDatum.Value;
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
            if (!_ExistiertParfümNummer())
                return;

            if (!_ValiedereVerkaufsdatenMenge())
                return;

            if (_HatNeueMengeGültigeNummer(txtVerkaufsMenge.Text.Trim()) == -1)
            {
                errorProvider1.SetError(txtVerkaufsMenge, "Der Feld nimmt nur Nummer auf");
                return;
            }

            if (_HatNeueMengeGültigeNummer(txtNormalPreis.Text.Trim()) == -1)
            {
                errorProvider1.SetError(txtNormalPreis, "Der Feld nimmt nur Nummer auf");
                return;
            }

            _fülleVerkaufsdaten();

            if (_verkaufsDaten.Save() && clsEinkauf.UpdateLagerbestand(_verkaufsDaten.parfümNummer, _verkaufsDaten.lagerbestand))
            {
                MessageBox.Show($"Verkauf Daten erfolgreich {(_mode == enMode.addnew ? "hinzugefügt" : "aktualisiert")}", "Erfolg",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                _mode = enMode.update; // wir aktualisieren den Object.
                txtVerkaufsID.Text = _verkaufsDaten.verkaufsID.ToString();
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
            else
            {
                _ladeVerkaufsDaten();
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
                    txtLagerbestand.Clear();
            }
            else
                txtLagerbestand.Clear();
        }

        private void txtNormalPreis_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNormalPreis.Text.Trim()))
            {
                float normalPreis = Convert.ToSingle(txtNormalPreis.Text.Trim());
                float gesamtPreis = Convert.ToSingle(normalPreis * 1.19);
                txtGesamtPreis.Text = gesamtPreis.ToString();
            }
            else
                txtGesamtPreis.Clear();
        }
        private void _AvlBaumImplementierung()
        {
            DataTable kundenName = clsKunde.GetAllKundeName();
            if (kundenName == null)
                return;

            AVLTree tree = new AVLTree();

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

        }

        private void lbVorschläge_Click(object sender, EventArgs e)
        {
           txtKundeName.Focus();
            //wir setzen den ausgewählten Vorschlag in das "txtFilterBeiName" Textfeld und verbergen wir  die listboxw
            if (lbVorschläge.SelectedItems != null)
            {
                txtKundeName.Text = lbVorschläge.SelectedItem.ToString();
                lbVorschläge.Visible = false;
            }
        }
    }
}
