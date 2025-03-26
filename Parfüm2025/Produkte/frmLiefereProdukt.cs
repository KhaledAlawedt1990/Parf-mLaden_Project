using Busnisse_Layer;
using ParfümDb_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Parfüm2025
{
    public partial class frmLiefereProdukt: Form
    {
        enum enMode { Addnew = 1, Update = 2 }
        enMode _Mode;

        clsLieferungen _lieferungen;
        public frmLiefereProdukt()
        {
            InitializeComponent();
        }

        private void btnSchließen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LadeProduktDaten()
        {
            cbProduktName.Items.Clear(); // Verhindert doppelte Einträge

            DataTable dt = clsProdukte.GetAllProdukte();
            if (dt != null && dt.Rows.Count > 0) // Prüfen, ob Daten vorhanden sind
            {
                foreach (DataRow row in dt.Rows)
                {
                    cbProduktName.Items.Add(row["ProduktName"].ToString());
                }
            }

        }
        private void _LadeKundeDaten()
        {
            cbKunde.Items.Clear(); // Verhindert doppelte Einträge

            DataTable dt = clsKunde.GetAllKundeName();
            if (dt != null && dt.Rows.Count > 0)
            {
              
                foreach (DataRow row in dt.Rows)
                {
                    cbKunde.Items.Add(row["Vollname"]);
                }
            }

        }
        private void _ResetDefaultValues()
        {
            _Mode = enMode.Addnew;
            txtTotoMenge.Clear();
            txtGelieferteMenge.Clear();
            rbDezGeschäft.Checked = false;
            rbHauptGeschäft.Checked = false;
        }

        private bool _IsValidInput(TextBox textbox, string message)
        {
            if (string.IsNullOrEmpty(textbox.Text))
            {
                errorProvider1.SetError(textbox, message);
                textbox.BackColor = Color.LightPink;
                return false;
            }
            else
            {
                errorProvider1.SetError(textbox, null);
                textbox.BackColor = Color.White;
                return true;
            }
        }
        private bool _CheckInputs()
        {
            bool isvalid = true;
            isvalid &= _IsValidInput(txtGelieferteMenge, "Gelieferte Menge darf nicht leer sein.");
            return isvalid;
        }
        private bool _FillProduktData()
        {
            if (_Mode == enMode.Addnew)
            {
                _lieferungen= new clsLieferungen();
            }

            _lieferungen.ProduktID = clsProdukte.FindByProduktName(cbProduktName.Text).ProduktID;
            int gelieferteMenge = Convert.ToInt32(txtGelieferteMenge.Text);
            int totalMenge = Convert.ToInt32(txtTotoMenge.Text);
            if(gelieferteMenge > totalMenge)
            {
                MessageBox.Show("Die lieferende Menge überschreitet die TotalMenge, Bitte überprüfen Sie das lager der Produkte", "Warnung",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
           _lieferungen.GelieferteMenge  = gelieferteMenge;
            _lieferungen.KundeID = clsKunde.FindKundeByPersonName(cbKunde.Text).kundeID; 
            if (rbHauptGeschäft.Checked)
                _lieferungen.HauptGechäft = true;
            else if(rbDezGeschäft.Checked)
                _lieferungen.DezGeschäft = true;

            return true;
        }
        private void _LoadData()
        {
            clsProdukte produkte = clsProdukte.FindByProduktID(_lieferungen.ProduktID);
            if (produkte != null)
            {
                cbProduktName.Text = produkte.ProduktName;
                txtTotoMenge.Text = produkte.Total.ToString();
            }
         
           
            txtGelieferteMenge.Text = _lieferungen.GelieferteMenge.ToString();
            cbKunde.Text = _lieferungen.KundeID.ToString();
            if (_lieferungen.HauptGechäft == true)
                rbHauptGeschäft.Checked = true;
            else if (_lieferungen.DezGeschäft == true)
                   rbDezGeschäft.Checked = true;
            // txtGekaufteMenge.Text = _produkts.GekaufteMenge.ToString();  
        }
        private void btnLiefern_Click(object sender, EventArgs e)
        {
            if (!_CheckInputs())
            {
                MessageBox.Show("Bitte füllen Sie alle erforderlichen Felder aus.",
                    "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_FillProduktData())
                return;
                 

            if (_lieferungen.Save())
            {
                clsProdukte produkte = clsProdukte.FindByProduktID(_lieferungen.ProduktID);
                if (produkte != null)
                {
                    int? updatedMenge = produkte.Total - _lieferungen.GelieferteMenge;
                    if (!clsProdukte.UpdateProdukteByID(produkte.ProduktID, produkte.ProduktName,
                     produkte.GekaufteMenge , updatedMenge))
                    {
                        MessageBox.Show("Totalmenge wurde nicht richtig aktualisieret", "Warnung",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                _Mode = enMode.Update;
                //MessageBox.Show("Die Lieferung wurde erfolgreich gespeichert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Fehler beim Speichern der Lieferung. Bitte prüfen Sie die Eingaben und versuchen Sie es erneut.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLiefereProdukt_Load(object sender, EventArgs e)
        {
            _LadeProduktDaten();
            _LadeKundeDaten();

            if (_lieferungen != null)
            {
                _Mode = enMode.Update;
                _LoadData();
            }
            else
                _ResetDefaultValues();
            
        }

        private void cbProduktName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? Total =  clsProdukte.FindByProduktName(cbProduktName.Text).Total;
            txtTotoMenge.Text = Total.ToString();
        }
    }
}
