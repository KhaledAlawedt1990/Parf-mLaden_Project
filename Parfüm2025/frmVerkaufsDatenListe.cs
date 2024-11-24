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
    public partial class frmVerkaufsDatenListe : Form
    {
        DataTable _dtverkaufsDaten;
        BindingSource _bindingSource;
        public frmVerkaufsDatenListe()
        {
            InitializeComponent();
            _bindingSource = new BindingSource();
        }

        private void _setzeVerkaufsDaten()
        {
            _dtverkaufsDaten = clsVerkauf.GetAllVerkaufDaten();
            _bindingSource.DataSource = _dtverkaufsDaten;
            dgvVerkaufsDaten.DataSource = _bindingSource;
        }

        private void btnHinzufügeVerkaufsDaten_Click(object sender, EventArgs e)
        {
            frmAddUpdateVerkaufDaten frm = new frmAddUpdateVerkaufDaten(-1, frmAddUpdateVerkaufDaten.enMode.addnew);
            frm.ShowDialog();

            _setzeVerkaufsDaten();
        }

        private void btnAktualisereVerkaufsDaten_Click(object sender, EventArgs e)
        {
            _setzeVerkaufsDaten();
        }

        private void frmVerkaufsDatenListe_Load(object sender, EventArgs e)
        {
            _setzeVerkaufsDaten();
        }
    }
}
