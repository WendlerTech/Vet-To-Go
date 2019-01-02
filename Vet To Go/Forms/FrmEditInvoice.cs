using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Vet_To_Go.Classes;

namespace Vet_To_Go.Forms
{
    public partial class FrmEditInvoice : Form
    {
        Customer customer = null;
        Invoice invoice = null;
        public Boolean invoiceChanged { get; set; }

        public FrmEditInvoice()
        {
            InitializeComponent();
        }

        public void OpenForm(Customer cust, Invoice inv)
        {
            customer = cust;
            invoice = inv;
            PopulateData();
            txtInvoiceAmount.Focus();
            this.ShowDialog();
        }

        private void PopulateData()
        {
            invoiceChanged = false;
            String queryString = "SELECT * FROM Tbl_Visit WHERE InvoiceID = @invoiceID;";
            DateTime visitDate = new DateTime();

            try
            {
                using (var connection = new SqlConnection(HelperClass.GetConnectionString()))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@invoiceID", invoice.InvoiceID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieves notes & visit date if not null
                            rtbNotes.Rtf = reader["VisitNotes"] as string;
                            if (!reader.IsDBNull(3))
                                visitDate = reader.GetDateTime(3);
                        }
                    }
                }
            } catch (SqlException ex)
            {
                MessageBox.Show("Something went wrong while attempting to populate data. Namely:\n" + ex.Message,
                    "SQL Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            grpBox.Text = customer.FirstName + " " + customer.LastName;
            txtInvoiceID.Text = invoice.InvoiceID.ToString();
            dtpInvoice.Value = invoice.InvoiceDate;
            dtpVisit.Value = visitDate;
            txtInvoiceAmount.Text = HelperClass.FormatMoney(invoice.Amount);
            if (invoice.IsPaid)
                rdbPaidYes.Checked = true;
            else
                rdbPaidNo.Checked = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteNotes_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you wish to delete all notes for this invoice?\nThis cannot be undone.", 
                "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                rtbNotes.Text = "";
                SaveNotes();
                invoiceChanged = true;
            }
        }

        private void btnSaveNotes_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you wish to update notes for this invoice?\nAny changes cannot be undone.",
                "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SaveNotes();
                invoiceChanged = true;
            }
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            if (txtInvoiceAmount.Text == "" || !Regex.IsMatch(txtInvoiceAmount.Text, @"^[0-9.]+$"))
            {
                MessageBox.Show("You must enter a valid amount.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var result = MessageBox.Show("Are you sure you wish to update the invoice? \nThis cannot be undone.", "Update Data",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SaveData();
                    invoiceChanged = true;
                }
            }
        }
        // Saves notes to Tbl_Visit
        private void SaveNotes()
        {
            String visitQueryString = "UPDATE Tbl_Visit SET VisitNotes = @notes WHERE InvoiceID = @invoiceID;";

            try
            {
                using (var connection = new SqlConnection(HelperClass.GetConnectionString()))
                {
                    connection.Open();
                    
                    SqlCommand command = new SqlCommand(visitQueryString, connection);
                    command.Parameters.AddWithValue("@notes", rtbNotes.Rtf);
                    command.Parameters.AddWithValue("@invoiceID", invoice.InvoiceID);

                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Something went wrong while attempting to populate data. Namely:\n" + ex.Message,
                    "SQL Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Saves invoice data to Tbl_Invoice as well as visit date to Tbl_Visit
        private void SaveData()
        {
            String invoiceQueryString = "UPDATE Tbl_Invoice SET InvoiceDate = @invoiceDate, InvoiceAmount = @amount, InvoicePaid = @isPaid " +
                "WHERE InvoiceID = @invoiceID;";
            String visitQueryString = "UPDATE Tbl_Visit SET VisitDate = @visitDate WHERE InvoiceID = @invoiceID;";

            try
            {
                using (var connection = new SqlConnection(HelperClass.GetConnectionString()))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(invoiceQueryString, connection);
                    command.Parameters.AddWithValue("@invoiceID", invoice.InvoiceID);
                    command.Parameters.AddWithValue("@invoiceDate", dtpInvoice.Value);
                    command.Parameters.AddWithValue("@amount", txtInvoiceAmount.Text);
                    if (rdbPaidYes.Checked)
                        command.Parameters.AddWithValue("@isPaid", 1);
                    else
                        command.Parameters.AddWithValue("@isPaid", 0);

                    command.ExecuteNonQuery();

                    command = new SqlCommand(visitQueryString, connection);
                    command.Parameters.AddWithValue("@visitDate", dtpVisit.Value);
                    command.Parameters.AddWithValue("@invoiceID", invoice.InvoiceID);

                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Something went wrong while attempting to populate data. Namely:\n" + ex.Message,
                    "SQL Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}