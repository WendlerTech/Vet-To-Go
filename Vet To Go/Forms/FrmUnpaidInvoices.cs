using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Vet_To_Go.Classes;

namespace Vet_To_Go.Forms
{
    public partial class FrmUnpaidInvoices : Form
    {
        int customerID;
        int invoiceID;
        Customer cust = null;
        Invoice invoice = null;
        Boolean resultsFound = false;
        private SqlDataAdapter dataAdapter = null;
        private BindingSource bindSource = new BindingSource();

        public FrmUnpaidInvoices()
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
                cust.FirstName = grdView.SelectedRows[0].Cells[4].Value.ToString();
                cust.LastName = grdView.SelectedRows[0].Cells[5].Value.ToString();
                invoice.InvoiceID = invoiceID;
                invoice.InvoiceDate = Convert.ToDateTime(grdView.SelectedRows[0].Cells[2].Value);
                invoice.Amount = Convert.ToDecimal(grdView.SelectedRows[0].Cells[3].Value.ToString());
                invoice.IsPaid = false;

                FrmEditInvoice editInvoiceFrm = new FrmEditInvoice();                
                editInvoiceFrm.OpenForm(cust, invoice);
                if (editInvoiceFrm.invoiceChanged)
                    RetrieveData();
            }
        }

        private void grdView_SelectionChanged(object sender, EventArgs e)
        {
            if (grdView.SelectedRows.Count > 0)
            {
                customerID = Convert.ToInt16(grdView.SelectedRows[0].Cells[0].Value.ToString());
                invoiceID = Convert.ToInt16(grdView.SelectedRows[0].Cells[1].Value.ToString());
            }
        }

        private void RetrieveData()
        {
            String queryString = "SELECT T1.CustomerID, T1.InvoiceID, T1.InvoiceDate, T1.InvoiceAmount, T2.FirstName, T2.LastName FROM Tbl_Invoice T1 " +
                "INNER JOIN Tbl_Customer T2 ON T1.CustomerID = T2.CustomerID WHERE T1.InvoicePaid = 0;";          

            try
            {
                using (var connection = new SqlConnection(HelperClass.GetConnectionString()))
                {
                    dataAdapter = new SqlDataAdapter(queryString, connection);

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
                MessageBox.Show("An error occured while attempting to retrieve unpaid invoices. Namely:\n" + ex.Message, "SQL Exception",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatData()
        {
            grdView.DataSource = bindSource;

            grdView.Columns[0].Visible = false;
            grdView.Columns[1].Visible = false;

            grdView.Columns[2].HeaderText = "Invoice Date";
            grdView.Columns[3].HeaderText = "Amount";
            grdView.Columns[4].HeaderText = "First Name";
            grdView.Columns[5].HeaderText = "Last Name";

            grdView.Columns[2].MinimumWidth = 134;
            grdView.Columns[3].MinimumWidth = 130;
            grdView.Columns[4].MinimumWidth = 130;
            grdView.Columns[5].MinimumWidth = 130;

            grdView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
            grdView.Columns[3].DefaultCellStyle.Format = "0.00";
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

        private void FrmUnpaidInvoices_Load(object sender, EventArgs e)
        {
            RetrieveData();
            FormatData();
        }
    }
}