using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Vet_To_Go.Classes;

namespace Vet_To_Go.Forms
{
    public partial class FrmInvoices : Form
    {
        Customer customer = null;
        Invoice invoice = null;
        Boolean resultsFound = false;
        private SqlDataAdapter dataAdapter = null;
        private BindingSource bindingSource = new BindingSource();

        public FrmInvoices()
        {
            InitializeComponent();
        }

        private void FrmInvoices_Load(object sender, EventArgs e)
        {
            grdView.DataSource = bindingSource;
            RetrieveData();
            FormatData();
        }

        public void OpenForm(Customer cust)
        {
            customer = cust;
            this.ShowDialog();
        }

        private void RetrieveData()
        {
            String queryString = "SELECT * FROM Tbl_Invoice WHERE CustomerID = @custID;";

            try
            {
                using (var connection = new SqlConnection(HelperClass.GetConnectionString()))
                {
                    dataAdapter = new SqlDataAdapter(queryString, connection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@custID", customer.CustomerID);
                    SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(dataAdapter);

                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    bindingSource.DataSource = table;

                    // Checks to see if anything was actually returned, so as to avoid null pointers
                    if (table.Rows.Count < 1)
                        resultsFound = false;
                    else
                        resultsFound = true;
                }
            } catch (SqlException ex)
            {
                MessageBox.Show("Something went wrong while attempting to access the database. Namely:\n" + ex.Message, "SQL Exception",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatData()
        {
            lblHeader.Text = customer.FirstName + " " + customer.LastName + "'s Invoices";
            grdView.Columns[0].Visible = false;
            grdView.Columns[1].Visible = false;
            grdView.Columns[2].Visible = false;

            grdView.Columns[3].HeaderText = "Invoice Date";
            grdView.Columns[4].HeaderText = "Amount";
            grdView.Columns[5].HeaderText = "Paid off?";

            grdView.Columns[3].MinimumWidth = 235;
            grdView.Columns[4].MinimumWidth = 235;
            grdView.Columns[5].MinimumWidth = 135;

            grdView.Columns[4].DefaultCellStyle.Format = "0.00";
            grdView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);

            // Sets colors for gridview
            grdView.RowHeadersVisible = false;
            System.Drawing.Color columColor = System.Drawing.Color.FromArgb(82, 117, 150);
            System.Drawing.Color highlightColor = System.Drawing.Color.FromArgb(99, 166, 229);
            grdView.DefaultCellStyle.SelectionBackColor = highlightColor;
            grdView.ColumnHeadersDefaultCellStyle.BackColor = columColor;
            grdView.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            grdView.EnableHeadersVisualStyles = false;

            grdView.MultiSelect = false;
            if (resultsFound)
            {
                grdView.FirstDisplayedCell.Selected = true;
            }
        }

        private Invoice GetCurrentInvoice()
        {
            // Creates & returns a new invoice object based on currently selected row
            invoice = new Invoice();
            invoice.InvoiceID = Convert.ToInt16(grdView.SelectedRows[0].Cells[0].Value.ToString());
            invoice.CustomerID = Convert.ToInt16(grdView.SelectedRows[0].Cells[1].Value.ToString());
            invoice.VisitID = Convert.ToInt16(grdView.SelectedRows[0].Cells[2].Value.ToString());
            invoice.InvoiceDate = Convert.ToDateTime(grdView.SelectedRows[0].Cells[3].Value);
            invoice.Amount = Convert.ToDecimal(grdView.SelectedRows[0].Cells[4].Value.ToString());
            invoice.IsPaid = Convert.ToBoolean(grdView.SelectedRows[0].Cells[5].Value);

            return invoice;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            if (resultsFound && grdView.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you wish to delete this invoice?\nThere is NO way to undo this action.",
                    "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int invoiceNum = Convert.ToInt16(grdView.SelectedRows[0].Cells[0].Value.ToString());
                    String queryString = "DELETE FROM Tbl_Invoice WHERE InvoiceID = @invoice;";
                    String visitQueryString = "DELETE FROM Tbl_Visit WHERE InvoiceID = @invoice";

                    try
                    {
                        using (var connection = new SqlConnection(HelperClass.GetConnectionString()))
                        {                            
                            SqlCommand command = new SqlCommand(visitQueryString, connection);
                            command.Parameters.AddWithValue("@invoice", invoiceNum);

                            connection.Open();
                            command.ExecuteNonQuery();

                            command.CommandText = queryString;
                            command.ExecuteNonQuery();

                            MessageBox.Show("Invoice deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RetrieveData();
                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Something went wrong while attempting to delete an invoice. Namely:\n" + ex.Message,
                            "SQL Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnViewInvoice_Click(object sender, EventArgs e)
        {
            if (resultsFound == true && grdView.SelectedRows.Count > 0)
            {
                FrmEditInvoice editInvoiceFrm = new FrmEditInvoice();
                editInvoiceFrm.OpenForm(customer, GetCurrentInvoice());
                if (editInvoiceFrm.invoiceChanged)
                {
                    RetrieveData();
                    FormatData();
                }                
            }
        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            FrmNewInvoice newInvoiceFrm = new FrmNewInvoice();
            newInvoiceFrm.OpenForm(customer);
            if (newInvoiceFrm.invoiceAdded)
            {
                RetrieveData();
                FormatData();
            }
        }
    }
}