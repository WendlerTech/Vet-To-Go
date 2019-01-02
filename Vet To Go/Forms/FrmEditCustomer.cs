using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Vet_To_Go.Classes;

namespace Vet_To_Go.Forms
{
    public partial class FrmEditCustomer : Form
    {
        Customer customer = null;
        private FrmCustLandingPage parentForm = null;

        int customerID;

        public FrmEditCustomer()
        {
            InitializeComponent();
        }

        public FrmEditCustomer(Form parentForm)
        {
            // Uses instance of previous form to refresh populated data after edit
            this.parentForm = parentForm as FrmCustLandingPage;
            InitializeComponent();
        }

        public void OpenForm(Customer cust)
        {
            customer = cust;
            this.Show();
            PopulateData();
        }

        public Customer GetEditedCustomer()
        {
            return customer;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you wish to edit this customer? \nThis action cannot be undone.", "Confirm Edit", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                UpdateCustomer();
                // Sets newly edited properties
                customer.FirstName = txtFirstName.Text;
                customer.LastName = txtLastName.Text;
                customer.HomePhone = txtHomePhone.Text;
                customer.CellPhone = txtCellPhone.Text;
                customer.EmailAddress = txtEmail.Text;
                customer.Address1 = txtAddress1.Text;
                customer.Address2 = txtAddress2.Text;
                customer.City = txtCity.Text;
                customer.ZipCode = txtZip.Text;
                customer.State = txtState.Text;
                // Refreshes previous form with new data
                parentForm.PopulateData(customer);
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you wish to clear all entries?", "Clear", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                txtFirstName.Clear();
                txtLastName.Clear();
                txtHomePhone.Clear();
                txtCellPhone.Clear();
                txtEmail.Clear();
                txtAddress1.Clear();
                txtAddress2.Clear();
                txtCity.Clear();
                txtZip.Clear();
                txtState.Clear();
                txtFirstName.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulateData()
        {
            // Auto-fills text boxes with current information
            txtFirstName.Text = customer.FirstName;
            txtLastName.Text = customer.LastName;
            txtHomePhone.Text = customer.HomePhone;
            txtCellPhone.Text = customer.CellPhone;
            txtEmail.Text = customer.EmailAddress;
            txtAddress1.Text = customer.Address1;
            txtAddress2.Text = customer.Address2;
            txtCity.Text = customer.City;
            txtZip.Text = customer.ZipCode;
            txtState.Text = customer.State;
            customerID = customer.CustomerID;   
        }

        private void UpdateCustomer()
        {
            String queryString = "UPDATE Tbl_Customer SET FirstName = @first, LastName = @last, EmailAddress = @email, Address1 = @addr1, Address2 = @addr2, " +
                "City = @city, State = @state, ZipCode = @zip, CellPhoneNum = @cell, HomePhoneNum = @home " +
                "WHERE CustomerID = @id;";

            try
            {
                using (var connection = new SqlConnection(HelperClass.GetConnectionString()))
                {
                    // Parameterized query for SQL Injection protection
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@first", txtFirstName.Text);
                    command.Parameters.AddWithValue("@last", txtLastName.Text);
                    command.Parameters.AddWithValue("@email", txtEmail.Text);
                    command.Parameters.AddWithValue("@addr1", txtAddress1.Text);
                    command.Parameters.AddWithValue("@addr2", txtAddress2.Text);
                    command.Parameters.AddWithValue("@city", txtCity.Text);
                    command.Parameters.AddWithValue("@state", txtState.Text);
                    command.Parameters.AddWithValue("@zip", txtZip.Text);
                    command.Parameters.AddWithValue("@cell", txtCellPhone.Text);
                    command.Parameters.AddWithValue("@home", txtHomePhone.Text);
                    command.Parameters.AddWithValue("@id", customer.CustomerID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Something went wrong while attempting to edit a customer to the database. Namely: \n" + ex.Message, "SQL Exception");
            }
        }
    }
}