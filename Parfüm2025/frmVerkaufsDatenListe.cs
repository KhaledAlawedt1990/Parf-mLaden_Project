using Busnisse_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Toolkit.Uwp.Notifications;
using Windows.ApplicationModel.UserDataTasks;




namespace Parfüm2025
{
    public partial class frmVerkaufsDatenListe : Form
    {
        DataTable _dtverkaufsDaten;
        BindingSource _bindingSource;
        private readonly object _lockObject = new object();
        private float _neueLagerBestad = -1;
        private int _parfümNummer = -1;
        public frmVerkaufsDatenListe()
        {
            InitializeComponent();
            _bindingSource = new BindingSource();
        }
        private void _setzeVerkaufsDaten()
        {
            _dtverkaufsDaten = clsVerkauf.GetVerkaufsRecordProSeite(100, 1);
            _bindingSource.DataSource = _dtverkaufsDaten;
            dgvVerkaufsDaten.DataSource = _bindingSource;
            //dgvVerkaufsDaten.Columns["LagerbestandInGramm"].DefaultCellStyle.BackColor = Color.Gold;

            _setzePassendeFarbeFürLagerbestand();
            lblRecord.Text = _bindingSource.Count.ToString();
        }


        private void _setzePassendeFarbeFürLagerbestand()
        {
            foreach (DataGridViewRow row in dgvVerkaufsDaten.Rows)
            {
                if (row.Cells["LagerbestandInGramm"].Value != null) // Sicherstellen, dass die Zelle nicht null ist
                {
                    // Konvertiere den Zellwert in einen float
                    float lagerbestand = _ToFloat(row.Cells["LagerbestandInGramm"].Value.ToString());

                    // Beispiel: Verwende den lagerbestand-Wert
                    if (lagerbestand < 50)
                    {
                        row.Cells["LagerbestandInGramm"].Style.BackColor = Color.Red;
                        row.Cells["LagerbestandInGramm"].Style.ForeColor = Color.White; // Weißer Text
                    }
                    else
                    {
                        row.Cells["LagerbestandInGramm"].Style.BackColor = Color.White;
                        row.Cells["LagerbestandInGramm"].Style.ForeColor = Color.Black; // Schwarzer Text
                    }
                }
            }
        }
 
        private void btnAktualisereVerkaufsDaten_Click(object sender, EventArgs e)
        {
            _setzeVerkaufsDaten();
        }
        private void frmVerkaufsDatenListe_Load(object sender, EventArgs e)
        {
            cbFilterbei.SelectedIndex = 0;
            cbFilterbei.DropDownStyle = ComboBoxStyle.DropDownList; //verhindert die Combobox Einträge zu ändern.


            _setzeVerkaufsDaten();
        }

        private void _Filteranwenden()
        {
            string filterspalte = cbFilterbei.SelectedItem.ToString();
            string filterwert = txtFilerwert.Text.Trim();

            lock (_lockObject)
            {
                if(filterspalte == "erstellungsDatum")
                {
                    DateTime selectedDate = dtpErstellungsdatum.Value.Date; // Nur das Datum, keine Zeit

                    // Start- und Endzeit des Tages
                    DateTime startOfDay = selectedDate;
                    DateTime endOfDay = selectedDate.AddDays(1).AddTicks(-1);

                    // Formatieren der Werte für den Filter
                    string startFormatted = startOfDay.ToString("MM/dd/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                    string endFormatted = endOfDay.ToString("MM/dd/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

                    // Filter setzen für den gesamten Tag
                    _bindingSource.Filter = $"{filterspalte} >= #{startFormatted}# AND {filterspalte} <= #{endFormatted}#";
                    //_bindingSource.Filter = $"{filterspalte} = #{startFormatted}#";
                    return;
                }

                if (!string.IsNullOrEmpty(filterwert))
                {
                    if (filterspalte == "ParfümNummer" || filterspalte == "BelegID")
                    {

                        _bindingSource.Filter = $"{filterspalte} = {filterwert}";
                    }
                    else if (filterspalte == "KundenName")
                    {                  
                        _bindingSource.Filter = $"{filterspalte} Like '{filterwert}%'";
                    }                  
                }
                else
                {
                    _bindingSource.Filter = string.Empty;
                }
                
                lblRecord.Text = _bindingSource.Count.ToString();
            }
        }
        private void txtFilerwert_TextChanged(object sender, EventArgs e)
        {
            _Filteranwenden();
        }

        private void cbFilterbei_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterbei.SelectedItem.ToString() == "erstellungsDatum")
            {
                dtpErstellungsdatum.Visible = true;
                dtpErstellungsdatum.Focus();
                txtFilerwert.Visible = false;

            }
            else
            {
                dtpErstellungsdatum.Visible = false;
                txtFilerwert.Visible = true;
                _bindingSource.Filter = string.Empty;
            }

            if (cbFilterbei.SelectedIndex != -1)
            {
                txtFilerwert.Clear();
                txtFilerwert.Focus();
            }
            
            lblRecord.Text = _bindingSource.Count.ToString();
        }

        private void txtFilerwert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterbei.SelectedItem.ToString() == "ParfümNummer" || cbFilterbei.SelectedItem.ToString() == "BelegID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void seheVerkaufToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int belegID = (int)dgvVerkaufsDaten.CurrentRow.Cells[0].Value;
            frmAddUpdateVerkaufDaten frm = new frmAddUpdateVerkaufDaten(belegID, frmAddUpdateVerkaufDaten.enMode.SeheDetails);
            frm.ShowDialog();             
        }

        private void btnHinzufügeVerkaufsDaten_Click(object sender, EventArgs e)
        {
            frmAddUpdateVerkaufDaten frm = new frmAddUpdateVerkaufDaten(-1, frmAddUpdateVerkaufDaten.enMode.addnew);
            frm.lagerbestandAktualisiert += _ÜberprüfeLagerbestand;

            frm.ShowDialog();

            if (_neueLagerBestad < 50 && _neueLagerBestad != -1)
            {
                _SetzeNotifikation();
            }

            _setzeVerkaufsDaten();
        }
        private void aktualisiereVerkaufdatentoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int belegID = (int)dgvVerkaufsDaten.CurrentRow.Cells[0].Value;
            frmAddUpdateVerkaufDaten frm = new frmAddUpdateVerkaufDaten(belegID, frmAddUpdateVerkaufDaten.enMode.update);

            frm.lagerbestandAktualisiert += _ÜberprüfeLagerbestand; // Der Neue Lagerbestand zurückkiegen.
            frm.ShowDialog();

            if (_neueLagerBestad < 50 && _neueLagerBestad != -1)
            {
                _SetzeNotifikation();
            }

            _setzeVerkaufsDaten();
        }

        private void _SetzeNotifikation()
        {
            new ToastContentBuilder()
                 .AddText("Achtung: Niedriger Lagerbestand!")
                   .AddText($"Der Lagerbestand für die ParfümNummer {_parfümNummer} ist unter 50 gefallen. Bitte prüfen Sie die Bestände.")
                   .SetToastDuration(ToastDuration.Long) // Toast länger anzeigen
                     .Show();

            _neueLagerBestad = -1;  // neuelagerbestand zurücksetzen
            _parfümNummer = -1;    // parfümNummer zurücksetzen 
        }
        private void _ÜberprüfeLagerbestand(object sender, float lagerbestand, int parfümNummer)
        {
            _neueLagerBestad = lagerbestand;
            _parfümNummer = parfümNummer;

        }

        private void entferneVerkaufsdatenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int belegID = (int)dgvVerkaufsDaten.CurrentRow.Cells[0].Value;

            clsVerkauf verkaufdaten = clsVerkauf.Find(belegID);

            bool result = (MessageBox.Show("Sind Sie sicher, Sie möchten diesen Vorgang durchführen?", "Hinweis",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes);

            if (!result)
                return;

            if (result && verkaufdaten != null && verkaufdaten.Delete())
            {
                MessageBox.Show("Verkaufsdaten erfolgreich entfernt", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _setzeVerkaufsDaten();
            }
            else
                MessageBox.Show("Fehler beim Entfernen der Verkaufsdaten ist aufgetreten.", "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private float _ToFloat(string text)
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

        private void dtpErstellungsdatum_ValueChanged(object sender, EventArgs e)
        {
            _Filteranwenden();
        }

        private void erstelleEineVorlageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDruckvorschau frm = new frmDruckvorschau();
            frm.ShowDialog();
        }
    }
}
