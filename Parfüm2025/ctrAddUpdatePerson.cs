using Busnisse_Layer;
using clsHilfsMethoden;
using System;
using System.CodeDom;
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
    public partial class ctrAddUpdatePerson : UserControl
    {
        public ctrAddUpdatePerson()
        {
            InitializeComponent();
        }

        ////Declare a delegate
        //public delegate void DataBackEventHandler(object sender, int personID);
        ////declare an event using the delegate
        //public event DataBackEventHandler DataBack;

        //define a custom event handler delegate with parameters
        public event Action<int> OnSelectedPerson;
        //Create a protected methode to raise the event with a parameters
        protected virtual void SelectedPerson(int personID)
        {
            Action<int> handler = OnSelectedPerson;
            if (handler != null)
            {
                handler(personID);  // Rais the event with the parameter.
            }
        }

        private enum enMode { addnew = 0, update = 1 }
        enMode _mode = enMode.addnew;

        public clsPerson mitarbeiter;

        private readonly object _lockObject = new object();
        private void _GeburtsdatumEinrichten()
        {
            dtpGeburtstag.Format = DateTimePickerFormat.Custom;
            dtpGeburtstag.CustomFormat = "dd.MM.yyyy";
        }
 
        public void HandlePersondaten(int personID)
        {
            if (personID != -1)
            {
                _mode = enMode.update;  
                _ladePersonDaten(personID);
            }
            else
            { 
                _mode = enMode.addnew;
                mitarbeiter = new clsPerson();
            }

        }
        private void _füllePersonDaten()
        {
            mitarbeiter.Vorname = txtVorname.Text;
            mitarbeiter.Nachname = txtNachname.Text;
            mitarbeiter.GeburtsTag = dtpGeburtstag.Value;
            mitarbeiter.Geschlecht = Convert.ToChar(cbGeschlecht.SelectedItem.ToString());
            mitarbeiter.SteuerID = txtSteuerID.Text;
            mitarbeiter.Email = txtEmail.Text;
            mitarbeiter.Straße = txtStrasse.Text;
            mitarbeiter.Stadt = txtStadt.Text;
            mitarbeiter.Land = cbLand.SelectedItem.ToString();
            mitarbeiter.Telefon = txtTelefon.Text;
        }

        private void ctrAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetAufStandardWerte();
        }

        public void _GetPersonDetails(int personID)
        {
            _ladePersonDaten(personID);
        }
        private void _ladePersonDaten(int personID)
        {
            try
            {
                mitarbeiter = clsPerson.Find(personID);

                if (mitarbeiter != null)
                {
                    txtVorname.Text = mitarbeiter.Vorname;
                    txtNachname.Text = mitarbeiter.Nachname;
                    dtpGeburtstag.Value = mitarbeiter.GeburtsTag;
                    cbGeschlecht.SelectedItem = mitarbeiter.Geschlecht.ToString();
                    txtSteuerID.Text = mitarbeiter.SteuerID;
                    txtEmail.Text = mitarbeiter.Email;
                    txtStrasse.Text = mitarbeiter.Straße;
                    txtStadt.Text = mitarbeiter.Stadt;
                    cbLand.SelectedItem = mitarbeiter.Land;
                    txtTelefon.Text = mitarbeiter.Telefon;
                }
                else
                {
                    MessageBox.Show("Diese Person existiert leider nicht in System!", "Fehlermeldung",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            { 
              throw new Exception ($"Fehler beim Laden der Personendaten für ID {personID}: {ex.Message}");
            }
        }

        private void _ResetAufStandardWerte()
        {
            _GeburtsdatumEinrichten();
            _FülleLandComboBoxMitLändern();
            txtVorname.Clear();
            txtNachname.Clear();
            dtpGeburtstag.Value = DateTime.Now;
            cbGeschlecht.SelectedIndex = 0;
            txtSteuerID.Clear();
            txtEmail.Clear();
            txtStadt.Clear();
            txtStrasse.Clear();
            txtTelefon.Clear();
        }
        private void _FülleLandComboBoxMitLändern()
        {
            string[] europäischeLänder = {
                            "Albanien", "Andorra", "Belgien", "Bosnien und Herzegowina", "Bulgarien",
                             "Dänemark", "Deutschland", "Estland", "Finnland", "Frankreich",
                               "Griechenland", "Irland", "Island", "Italien", "Kasachstan",
                               "Kosovo", "Kroatien", "Lettland", "Liechtenstein", "Litauen",
                                 "Luxemburg", "Malta", "Moldawien", "Monaco", "Montenegro",
                              "Niederlande", "Nordmazedonien", "Norwegen", "Österreich", "Polen",
                             "Portugal", "Rumänien", "Russland", "San Marino", "Schweden",
                             "Schweiz", "Serbien", "Slowakei", "Slowenien", "Spanien",
                             "Tschechien", "Türkei", "Ukraine", "Ungarn", "Vatikanstadt",
                              "Vereinigtes Königreich", "Weißrussland", "Zypern"
                                       };

            AVLTree tree = new AVLTree();

            foreach (string land in europäischeLänder)
            {
                cbLand.Items.Add(land);
            }
            cbLand.SelectedItem = "Deutschland";
        }


        private void _SetError(TextBox textbox, string errorMessage)
        {
            errorProvider1.SetError(textbox, errorMessage);
            textbox.BackColor = string.IsNullOrEmpty(errorMessage) ? Color.White : Color.LightPink;
        }
        private bool _ValidiereEinFeld(TextBox txtboxName, string name)
        {
            if (string.IsNullOrEmpty(txtboxName.Text))
            {
                _SetError(txtboxName, $"{name} darf nicht leer sein!");
                return false;
            }
        
            _SetError(txtboxName, null);
            return true;
        }

        private bool _ValiederePersonFelder()
        {
            bool isValid = true;

            isValid = _ValidiereEinFeld(txtVorname, "Vorname");
            isValid &= _ValidiereEinFeld(txtNachname, "Nachname");
            isValid &= _ValidiereEinFeld(txtSteuerID, "SteuerID");
            isValid &= _ValidiereEinFeld(txtEmail, "Email");
            isValid &= _ValidiereEinFeld(txtStrasse, "Strasse");
            isValid &= _ValidiereEinFeld(txtStadt, "Stadt");

            return isValid; // Gibt zurück, ob alle Felder gültig sind
        }

        private bool _ValidiereEmail()
        {
            if (!clsValidierung.ValidateEmail(txtEmail.Text.Trim()))
            {
                _SetError(txtEmail, "Bitte geben Sie eine gültige E-Mail-Adresse ein!");
                return false;
            }

            _SetError(txtEmail, null);
            return true;
        }

        private bool _IstValidiert()
        {
            if (!_ValiederePersonFelder() || !_ValidiereEmail())
                return false;
            else
                return true;
        }
        public bool speicherePersonDaten()
        {

            lock (_lockObject)
            {
                if (!_IstValidiert())
                    return false;

                _füllePersonDaten();
                if (!mitarbeiter.Save())
                    return false;

                if (OnSelectedPerson != null)
                {
                    SelectedPerson(mitarbeiter.PersonID);
                }
                return true;
            }

        }

    }
}
