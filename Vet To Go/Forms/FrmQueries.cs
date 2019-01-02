using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vet_To_Go.Forms
{
    public partial class FrmQueries : Form
    {
        public FrmQueries()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void OpenForm()
        {
            this.Show();
        }

        private void btnEmailList_Click(object sender, EventArgs e)
        {
            FrmEmailList emailListFrm = new FrmEmailList();
            this.Hide();
            emailListFrm.OpenForm();
            this.Show();
        }

        private void btnSpeciesList_Click(object sender, EventArgs e)
        {
            FrmSpeciesList speciesListFrm = new FrmSpeciesList();
            this.Hide();
            speciesListFrm.OpenForm();
            this.Show();
        }

        private void btnLicense_Click(object sender, EventArgs e)
        {
            FrmLicensedAnimals unlicensedFrm = new FrmLicensedAnimals();
            this.Hide();
            unlicensedFrm.OpenForm();
            this.Show();
        }

        private void btnSterilize_Click(object sender, EventArgs e)
        {
            FrmSterilizedAnimals sterilizedFrm = new FrmSterilizedAnimals();
            this.Hide();
            sterilizedFrm.OpenForm();
            this.Show();
        }

        private void btnUnpaidInvoices_Click(object sender, EventArgs e)
        {
            FrmUnpaidInvoices unpaidInvoiceFrm = new FrmUnpaidInvoices();
            this.Hide();
            unpaidInvoiceFrm.OpenForm();
            this.Show();
        }

        private void btnAllCust_Click(object sender, EventArgs e)
        {
            FrmAllCustomers allCustomersFrm = new FrmAllCustomers();
            this.Hide();
            allCustomersFrm.OpenForm();
            this.Show();
        }

        private void btnVisitsByDate_Click(object sender, EventArgs e)
        {
            FrmVisitsByDate visitsFrm = new FrmVisitsByDate();
            visitsFrm.OpenForm();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            FrmDatabaseStats statsFrm = new FrmDatabaseStats();
            this.Hide();
            statsFrm.OpenForm();
            this.Show();
        }
    }
}