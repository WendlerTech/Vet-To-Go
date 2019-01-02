using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Vet_To_Go.Classes;

namespace Vet_To_Go.Forms
{
    public partial class FrmNewInvoice : Form
    {
        public Boolean invoiceAdded { get; set; }
        Customer customer = null;

        public FrmNewInvoice()
        {
            InitializeComponent();
        }

        public void OpenForm(Customer cust)
        {
            customer = cust;
            lblInvoiceDate.Text = HelperClass.FormatDate(DateTime.Today);
            lblVisitDate.Text = HelperClass.FormatDate(DateTime.Today);
            invoiceAdded = false;
            this.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            invoiceAdded = false;
            this.Close();
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            if (txtInvoiceAmount.Text == "" || !Regex.IsMatch(txtInvoiceAmount.Text, @"^[0-9.]+$"))
            {
                MessageBox.Show("You must enter a valid amount.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var result = MessageBox.Show("Are you sure you wish to save this invoice?", "New Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SaveData();
                    invoiceAdded = true;
                    this.Close();
                }
            }
        }

        private void SaveData()
        {
            String invoiceQueryString = "INSERT INTO Tbl_Invoice (CustomerID, InvoiceDate, InvoiceAmount, InvoicePaid) " +
                "VALUES (@custID, @date, @amount, @isPaid) SELECT SCOPE_IDENTITY();";
            String visitQueryString = "INSERT INTO Tbl_Visit (CustomerID, InvoiceID, VisitDate, VisitNotes) " +
                "VALUES (@custID, @invoiceID, @date, @notes) SELECT SCOPE_IDENTITY();";
            String updateInvoiceString = "UPDATE Tbl_Invoice SET VisitID = @visitID WHERE InvoiceID = @invoiceID;";
            String invoiceID = "", visitID = "";

            try
            {
                using (var connection = new SqlConnection(HelperClass.GetConnectionString()))
                {
                    // Inserts new invoice
                    SqlCommand command = new SqlCommand(invoiceQueryString, connection);
                    command.Parameters.AddWithValue("@custID", customer.CustomerID);
                    command.Parameters.AddWithValue("@date", lblInvoiceDate.Text);
                    command.Parameters.AddWithValue("@amount", txtInvoiceAmount.Text);
                    if (rdbPaidYes.Checked)
                        command.Parameters.AddWithValue("@isPaid", 1);
                    else
                        command.Parameters.AddWithValue("@isPaid", 0);

                    connection.Open();
                    var value = command.ExecuteScalar();
                    // Returns new invoice number
                    if (value != null)
                        invoiceID = value.ToString();

                    // Inserts new visit
                    command.Parameters.Clear();
                    command.CommandText = visitQueryString;
                    command.Parameters.AddWithValue("@custID", customer.CustomerID);
                    command.Parameters.AddWithValue("@invoiceID", Convert.ToInt16(invoiceID));
                    command.Parameters.AddWithValue("@date", lblVisitDate.Text);
                    command.Parameters.AddWithValue("@notes", rtbNotes.Rtf);

                    value = command.ExecuteScalar();
                    // Returns new visitID
                    if (value != null)
                        visitID = value.ToString();

                    // Updates visitID into recently added invoice
                    command.Parameters.Clear();
                    command.CommandText = updateInvoiceString;
                    command.Parameters.AddWithValue("@visitID", Convert.ToInt16(visitID));
                    command.Parameters.AddWithValue("@invoiceID", Convert.ToInt16(invoiceID));

                    command.ExecuteNonQuery();

                    MessageBox.Show("New invoice saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (SqlException ex)
            {
                MessageBox.Show("An error occured while attempting to save a new invoice. Namely:\n" + ex.Message, "SQL Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cldInvoice_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblInvoiceDate.Text = cldInvoice.SelectionRange.Start.ToShortDateString();
        }

        private void cldVisit_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblVisitDate.Text = cldVisit.SelectionRange.Start.ToShortDateString();
        }
    }
}