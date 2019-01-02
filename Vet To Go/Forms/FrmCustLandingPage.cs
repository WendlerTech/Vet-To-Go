using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Vet_To_Go.Classes;

namespace Vet_To_Go.Forms
{
    public partial class FrmCustLandingPage : Form
    {
        int customerID;
        Customer customer = null;

        public FrmCustLandingPage()
        {
            InitializeComponent();
        }

        public void OpenForm(int custID)
        {
            customerID = custID;
            RetrieveData();
            PopulateData(customer);
            this.ShowDialog();
        }

        private void RetrieveData()
        {
            String queryString = "SELECT * FROM Tbl_Customer WHERE CustomerID = @custID;";
            
            try
            {
                using (var connection = new SqlConnection(HelperClass.GetConnectionString()))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@custID", customerID);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {                       
                        customer = new Classes.Customer();
                        customer.CustomerID = reader.GetInt32(0);
                        customer.FirstName = HelperClass.GetNotNullString(reader, 1);
                        customer.LastName = HelperClass.GetNotNullString(reader, 2);
                        customer.EmailAddress = HelperClass.GetNotNullString(reader, 3);
                        customer.Address1 = HelperClass.GetNotNullString(reader, 4);
                        customer.Address2 = HelperClass.GetNotNullString(reader, 5);
                        customer.City = HelperClass.GetNotNullString(reader, 6);
                        customer.State = HelperClass.GetNotNullString(reader, 7);
                        customer.ZipCode = HelperClass.GetNotNullString(reader, 8);
                        customer.CellPhone = HelperClass.GetNotNullString(reader, 9);
                        customer.HomePhone = HelperClass.GetNotNullString(reader, 10);
                    }                    
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Something went wrong while attempting to access the database. Namely:\n" + ex.Message, "SQL Exception");
            }
        }

        public void PopulateData(Customer customer)
        {
            lblNameHeader.Text = GetCustName();
            lblAddress1.Text = customer.Address1;
            lblAddress2.Text = customer.Address2;
            lblCity.Text = customer.City;
            lblState.Text = customer.State;
            lblZipCode.Text = customer.ZipCode;

            lblHomePhone.Text = customer.HomePhone;
            lblCellPhone.Text = customer.CellPhone;
            lblEmail.Text = customer.EmailAddress;
        }

        private String GetCustName()
        {
            return customer.FirstName + " " + customer.LastName; 
        }

        private void btnSearchAgain_Click(object sender, EventArgs e)
        {
            // Closes current dialog, un-hides previous form
            this.Close();
        }

        private void btnEditCustInfo_Click(object sender, EventArgs e)
        {
            FrmEditCustomer editCustFrm = new FrmEditCustomer(this);
            editCustFrm.OpenForm(customer);
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            FrmCustomerNotes frmNotes = new FrmCustomerNotes();
            frmNotes.OpenForm(customer.CustomerID);
        }

        private void btnViewAnimals_Click(object sender, EventArgs e)
        {
            FrmViewAnimal viewAnimalFrm = new FrmViewAnimal();
            viewAnimalFrm.OpenForm(customer, GetCustName());
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            FrmInvoices invoicesFrm = new FrmInvoices();
            this.Hide();
            invoicesFrm.OpenForm(customer);
            this.Show();
        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            FrmNewInvoice newInvoiceFrm = new FrmNewInvoice();
            newInvoiceFrm.OpenForm(customer);
        }
    }
}