using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Vet_To_Go.Classes;

namespace Vet_To_Go.Forms
{
    public partial class FrmVisitsByDate : Form
    {
        int customerID;
        int invoiceID;
        Customer cust = null;
        Invoice invoice = null;
        Boolean resultsFound = false;
        private SqlDataAdapter dataAdapter = null;
        private BindingSource bindSource = new BindingSource();
        public FrmVisitsByDate()
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
            // Selects fields from 3 tables, then joins them together as follows:
            // Tbl_Visit joins Tbl_Invoice based on their InvoiceID relationship
            // Tbl_Customer then joins Tbl_Invoice based on their CustomerID relationship
            // Results are then filtered by matching user-selected visit date.
            String queryString = "SELECT T1.CustomerID, T1.VisitID, T1.VisitDate, T3.FirstName, T3.LastName, T2.InvoiceAmount, T2.InvoicePaid, T2.InvoiceID, T2.InvoiceDate " +
                "FROM Tbl_Visit T1 INNER JOIN Tbl_Invoice T2 ON T1.InvoiceID = T2.InvoiceID INNER JOIN Tbl_Customer T3 ON T3.CustomerID = T2.CustomerID " +
                "WHERE T1.VisitDate = @visitDate;";

            try
            {
                using (var connection = new SqlConnection(HelperClass.GetConnectionString()))
                {
                    dataAdapter = new SqlDataAdapter(queryString, connection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@visitDate", dtpDate.Value.ToShortDateString());
                    SqlCommandBuilder command = new SqlCommandBuilder(dataAdapter);

                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    bindSource.DataSource = table;

                    // Checks whether or not anything was returned to avoid null pointer
                    if (table.Rows.Count < 1)
                    {
                        resultsFound = false;
                    }
                    else
                    {
                        resultsFound = true;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occured while attempting to retrieve visit data. Namely:\n" + ex.Message, "SQL Exception",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatData()
        {
            grdView.DataSource = bindSource;

            grdView.Columns[0].Visible = false;
            grdView.Columns[1].Visible = false;
            grdView.Columns[2].Visible = false;
            grdView.Columns[7].Visible = false;
            grdView.Columns[8].Visible = false;

            grdView.Columns[3].HeaderText = "First Name";
            grdView.Columns[4].HeaderText = "Last Name";
            grdView.Columns[5].HeaderText = "Invoice Amount";
            grdView.Columns[6].HeaderText = "Invoice Paid";

            grdView.Columns[3].MinimumWidth = 135;
            grdView.Columns[4].MinimumWidth = 135;
            grdView.Columns[5].MinimumWidth = 145;
            grdView.Columns[6].MinimumWidth = 125;

            grdView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
            grdView.Columns[5].DefaultCellStyle.Format = "###,##0.00";
            grdView.MultiSelect = false;

            // Sets colors for gridview
            grdView.RowHeadersVisible = false;
            System.Drawing.Color columColor = System.Drawing.Color.FromArgb(82, 117, 150);
            System.Drawing.Color highlightColor = System.Drawing.Color.FromArgb(99, 166, 229);
            grdView.DefaultCellStyle.SelectionBackColor = highlightColor;
            grdView.ColumnHeadersDefaultCellStyle.BackColor = columColor;
            grdView.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            grdView.EnableHeadersVisualStyles = false;

            if (resultsFound)
            {
                // Auto-selects first row to avoid null pointers
                grdView.FirstDisplayedCell.Selected = true;
            }
        }

        private void btnViewCust_Click(object sender, EventArgs e)
        {
            if (resultsFound == true && grdView.SelectedRows.Count > 0)
            {
                FrmCustLandingPage landingPageFrm = new FrmCustLandingPage();
                this.Hide();
                landingPageFrm.OpenForm(customerID);
                this.Show();
            }
        }

        private void btnViewInvoice_Click(object sender, EventArgs e)
        {
            if (resultsFound == true && grdView.SelectedRows.Count > 0)
            {
                // Creates new Customer & Invoice objects based on current selection, then passes them into FrmEditInvoice
                cust = new Customer();
                invoice = new Invoice();
                cust.CustomerID = customerID;
                cust.FirstName = grdView.SelectedRows[0].Cells[3].Value.ToString();
                cust.LastName = grdView.SelectedRows[0].Cells[4].Value.ToString();
                invoice.InvoiceID = invoiceID;
                invoice.InvoiceDate = Convert.ToDateTime(grdView.SelectedRows[0].Cells[8].Value);
                invoice.Amount = Convert.ToDecimal(grdView.SelectedRows[0].Cells[5].Value.ToString());
                invoice.IsPaid = Convert.ToBoolean(grdView.SelectedRows[0].Cells[6].Value);

                FrmEditInvoice editInvoiceFrm = new FrmEditInvoice();
                editInvoiceFrm.OpenForm(cust, invoice);
                // Re-populates gridview if changes were saved
                if (editInvoiceFrm.invoiceChanged)
                    RetrieveData();
            }
        }

        private void grdView_SelectionChanged(object sender, EventArgs e)
        {
            if (grdView.SelectedRows.Count > 0)
            {
                customerID = Convert.ToInt16(grdView.SelectedRows[0].Cells[0].Value.ToString());
                invoiceID = Convert.ToInt16(grdView.SelectedRows[0].Cells[7].Value.ToString());
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            RetrieveData();
            FormatData();
        }
    }
}