using Busnisse_Layer;
using iText.StyledXmlParser.Node;
using iText.Svg.Utils;
using iTextSharp.text.xml;
using ParfümDb_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.ApplicationModel.VoiceCommands;

namespace Parfüm2025
{
    public partial class frmProdukts: Form
    {
        enum enMode { Addnew = 1, Update = 2}
        enMode _Mode;
        clsLieferungen _lieferungen;
        BindingSource _bindingSource;
        public frmProdukts()
        {
            InitializeComponent();
            _bindingSource = new BindingSource();
        }
        private void _ResetDefaultValues()
        {
            txtProduktName.Clear();
            txtGekaufteMenge.Clear();
            txtGelieferteMenge.Clear();
            txtTotoMenge.Clear();
            txtAnKunde.Clear();
            rbHauptGeschäft.Checked = false;
            rbDezGeschäft.Checked = false;
        }

        private void _LoadProduktDataFromDatabase()
        {
            DataTable dt = clsLieferungen.GetAllLieferungen();
            if (dt != null && dt.Rows.Count > 0)
            {
                _bindingSource.DataSource = dt;
                dgvProdukts.DataSource = _bindingSource;
            }
            else
                dgvProdukts.DataSource = null;
        }
        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            _ResetDefaultValues();
        }
        private void btnKaufen_Click(object sender, EventArgs e)
        {
            frmAddUpdateProdukts frm = new frmAddUpdateProdukts(null);
            frm.ShowDialog();

            _LoadProduktDataFromDatabase();
        }

        private void btnAktualisieren_Click(object sender, EventArgs e)
        {
            string produktName = dgvProdukts.CurrentRow.Cells[1].Value.ToString();
            clsProdukte produkts = clsProdukte.FindByProduktName(produktName);
            if (produkts == null)
            {
                MessageBox.Show("Keiner Produkt wurde gefunden", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmAddUpdateProdukts frm = new frmAddUpdateProdukts(produkts);
            frm.ShowDialog();

            _LoadProduktDataFromDatabase();
        }

        private void frmProdukts_Load(object sender, EventArgs e)
        {
            _LoadProduktDataFromDatabase();
        }

        private void btnVerkaufen_Click(object sender, EventArgs e)
        {
            frmLiefereProdukt lieferung = new frmLiefereProdukt();
            lieferung.ShowDialog();
           
            _LoadProduktDataFromDatabase();
        }

        private void dgvProdukts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAnzeigen_Click(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            string ProduktName = dgvProdukts.CurrentRow.Cells[1].Value.ToString();
            clsProdukte produktes = clsProdukte.FindByProduktName(ProduktName);
            if(produktes == null)
            {
                MessageBox.Show("Keiner Produkt wurde gefunden", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int lieferungID = (int)dgvProdukts.CurrentRow.Cells[0].Value;
            clsLieferungen lieferung = clsLieferungen.FindByLieferungID(lieferungID);
            if (lieferung == null)
            {
                MessageBox.Show("Keine Lieferung wurde gefunden", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _Anzeigen(produktes,lieferung);
        }
        private void _Anzeigen(clsProdukte produktes, clsLieferungen lieferung)
        {
            txtProduktName.Text = produktes.ProduktName;
            txtAnKunde.Text = lieferung.KundeName;    
            txtGekaufteMenge.Text = produktes.GekaufteMenge.ToString();
            txtGelieferteMenge.Text = lieferung.GelieferteMenge.ToString();
            txtTotoMenge.Text = produktes.Total.ToString();

            if (lieferung.HauptGechäft== true)
                rbHauptGeschäft.Checked = true;
            else if(lieferung.DezGeschäft == true)
                rbDezGeschäft.Checked = true;
        }

        private void btLoeschen_Click(object sender, EventArgs e)
        {
            int lieferungID = (int)dgvProdukts.CurrentRow.Cells[0].Value;
            bool warnung = MessageBox.Show("Sind Sie sicher, Sie möchten diesen Vorgang durchführen", "Warnung", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes;

            if (!warnung)
                return;

            if(clsLieferungen.DeleteLieferungen(lieferungID))
            {
                //MessageBox.Show($"Produkt mit der ID [ {lieferungID} ] wurde erfolgreich entfernt", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _LoadProduktDataFromDatabase();
                _ResetDefaultValues();
            }
            else
                MessageBox.Show($"Fehler bei der Entfernung des Produktes mit der ID {lieferungID} ist aufgetreten", "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbFilterbei_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterbei.SelectedIndex != -1)
            {
                txtFilerwert.Clear();
                txtFilerwert.Focus();
            }
        }

        private void _FilterAnwenden()
        {
            string filterWert = txtFilerwert.Text.Trim();
            string filterSpalte = cbFilterbei.Text;

            if (string.IsNullOrEmpty(filterWert))
            {
                _bindingSource.Filter = null;
                return;
            }

            if (filterSpalte == "LieferungID")
                _bindingSource.Filter = $"{filterSpalte} = {filterWert}";
            else if (filterSpalte == "ProduktName")
                _bindingSource.Filter = $"{filterSpalte} Like '{filterWert}%'";
            else
                _bindingSource.Filter = null;
        }
        private void txtFilerwert_TextChanged(object sender, EventArgs e)
        {
            string filterSpalte = cbFilterbei.Text;
            string filterWert = txtFilerwert.Text.Trim();
            if (!string.IsNullOrEmpty(filterWert) && filterSpalte == "LieferungID" && !_IsNummer(filterWert))
            {
                MessageBox.Show("Bitte geben Sie eine gültige Nummer ein", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
                _FilterAnwenden();
        }
        private bool _IsNummer(string eingabe)
        {
            return int.TryParse(eingabe, out int _);
        }
    }
}
