using System;
using System.Windows.Forms;
using Vet_To_Go.Classes;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Vet_To_Go.Forms
{
    public partial class FrmNewCustomer : Form
    {
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private BindingSource bindingSource1 = new BindingSource();
        private Customer customer = null;
        private String firstName, lastName, emailAddr, city;

        public FrmNewCustomer()
        {
            InitializeComponent();
        }

        public Customer GetNewCustomer()
        {
            this.ShowDialog();
            return customer;
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "")
            {   // SQL Injection protection
                if (!Regex.IsMatch(txtFirstName.Text, @"^[a-zA-Z.\s]{0,40}$") || !Regex.IsMatch(txtLastName.Text, @"^[a-zA-Z.\s]{0,40}$"))
                {
                    MessageBox.Show("Your input terms contain forbidden characters. \nPlease try again.",
                   "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var result = MessageBox.Show("Are you sure you wish to add " + txtFirstName.Text + " " +
                        txtLastName.Text + " as a new customer?", "Submit", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // Capitalizes name, city & email address
                        firstName = HelperClass.GetCapitalizedString(txtFirstName.Text);
                        lastName = HelperClass.GetCapitalizedString(txtLastName.Text);
                        // Checks to see if anything was entered, and if not, assigns an empty string to avoid nulls
                        if (txtEmail.Text != "")
                            emailAddr = HelperClass.GetCapitalizedString(txtEmail.Text);
                        else
                            emailAddr = "";
                        if (txtCity.Text != "")
                            city = HelperClass.GetCapitalizedString(txtCity.Text);
                        else
                            city = "";

                        customer = new Classes.Customer(firstName, lastName, emailAddr);

                        customer.Address1 = txtAddress1.Text;
                        customer.Address2 = txtAddress2.Text;
                        customer.ZipCode = txtZip.Text;
                        customer.State = txtState.Text;
                        customer.HomePhone = txtHomePhone.Text;
                        customer.CellPhone = txtCellPhone.Text;
                        customer.City = city;

                        AddNewCustomer(customer);
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("You must at least enter a first & last name.", "Missing Information", MessageBoxButtons.OK);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewCustomer(Customer cust)
        {
            String sqlStatement = "INSERT INTO Tbl_Customer (FirstName, LastName, EmailAddress, Address1, Address2, City, State, ZipCode, CellPhoneNum, HomePhoneNum) " +
                 "VALUES (@first, @last, @email, @addr1, @addr2, @city, @state, @zip, @cellNum, @homeNum);";
            try
            {
                using (var connection = new SqlConnection(HelperClass.GetConnectionString()))
                {
                    // Parameterized query for SQL Injection protection
                    SqlCommand command = new SqlCommand(sqlStatement, connection);
                    command.Parameters.AddWithValue("@first", cust.FirstName);
                    command.Parameters.AddWithValue("@last", cust.LastName);
                    command.Parameters.AddWithValue("@email", cust.EmailAddress);
                    command.Parameters.AddWithValue("@addr1", cust.Address1);
                    command.Parameters.AddWithValue("@addr2", cust.Address2);
                    command.Parameters.AddWithValue("@city", cust.City);
                    command.Parameters.AddWithValue("@state", cust.State);
                    command.Parameters.AddWithValue("@zip", cust.ZipCode);
                    command.Parameters.AddWithValue("@cellNum", cust.CellPhone);
                    command.Parameters.AddWithValue("@homeNum", cust.HomePhone);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Customer added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Something went wrong while attempting to add a user to the database. Namely: \n" + ex.Message, "SQL Exception");
            }
        }
    }
}