using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Vet_To_Go.Classes;

namespace Vet_To_Go.Forms
{
    public partial class FrmDatabaseStats : Form
    {
        private int totalCust, totalAnimal, totalInvoice, totalVisit, totalRecords;

        public FrmDatabaseStats()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void OpenForm()
        {
            this.ShowDialog();
        }

        private void RetrieveData()
        {
            String custQuery = "SELECT COUNT(*) FROM Tbl_Customer";
            String animalQuery = "SELECT COUNT(*) FROM Tbl_Animal";
            String invoiceQuery = "SELECT COUNT(*) FROM Tbl_Invoice";
            String visitQuery = "SELECT COUNT(*) FROM Tbl_Visit";

            try
            {
                using (var connection = new SqlConnection(HelperClass.GetConnectionString()))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(custQuery, connection);
                    totalCust = Convert.ToInt16(command.ExecuteScalar());

                    command.CommandText = animalQuery;
                    totalAnimal = Convert.ToInt16(command.ExecuteScalar());

                    command.CommandText = invoiceQuery;
                    totalInvoice = Convert.ToInt16(command.ExecuteScalar());

                    command.CommandText = visitQuery;
                    totalVisit = Convert.ToInt16(command.ExecuteScalar());

                    totalRecords = totalCust + totalAnimal + totalInvoice + totalVisit;
                }
            } catch (SqlException ex)
            {
                MessageBox.Show("Something went wrong while attempting to populate database totals. Namely:\n" + ex.Message, 
                    "SQL Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatData()
        {
            lblCustomer.Text = totalCust.ToString();
            lblAnimal.Text = totalAnimal.ToString();
            lblInvoice.Text = totalInvoice.ToString();
            lblVisit.Text = totalVisit.ToString();
            lblTotal.Text = totalRecords.ToString();
        }

        private void FrmDatabaseStats_Load(object sender, EventArgs e)
        {
            RetrieveData();
            FormatData();
        }
    }
}