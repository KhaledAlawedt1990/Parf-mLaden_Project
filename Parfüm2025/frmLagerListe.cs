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
    public partial class frmLagerListe : Form
    {
        DataTable _dtParfüm;
        BindingSource _bindingSource;
        public frmLagerListe()
        {
            InitializeComponent();
            _bindingSource = new BindingSource();
        }

        private void btnHinzufügeNeueMenge_Click(object sender, EventArgs e)
        {
            frmAddUpdateNeueParfümMenge frm = new frmAddUpdateNeueParfümMenge(-1, frmAddUpdateNeueParfümMenge.enMode.addnew);
            frm.ShowDialog();
        }

        private void _setzeParfümMengeDaten()
        {
            _dtParfüm = clsLager.GetAllLagerDaten();
            _bindingSource.DataSource = _dtParfüm;
            dgvLager.DataSource = _bindingSource;
        }
        private void frmLagerListe_Load(object sender, EventArgs e)
        {
            _setzeParfümMengeDaten();
        }
    }
}
