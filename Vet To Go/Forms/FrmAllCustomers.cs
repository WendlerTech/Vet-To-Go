using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Vet_To_Go.Classes;

namespace Vet_To_Go.Forms
{
    public partial class FrmAllCustomers : Form
    {
        int customerID;
        Boolean resultsFound = false;
        private SqlDataAdapter dataAdapter = null;
        private BindingSource bindSource = new BindingSource();

        public FrmAllCustomers()
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
                landingPageFrm.OpenForm(customerID);
            }
        }

        private void FrmAllCustomers_Load(object sender, EventArgs e)
        {
            RetrieveData();
            FormatData();
        }

        private void grdView_SelectionChanged(object sender, EventArgs e)
        {
            if (grdView.SelectedRows.Count > 0)
            {
                customerID = Convert.ToInt16(grdView.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void RetrieveData()
        {
            String queryString = "SELECT CustomerID, FirstName, LastName, City, State FROM Tbl_Customer;";

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
                MessageBox.Show("An error occured while attempting to retrieve all customers. Namely:\n" + ex.Message, "SQL Exception",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatData()
        {
            grdView.DataSource = bindSource;

            grdView.Columns[0].Visible = false;

            grdView.Columns[1].HeaderText = "First Name";
            grdView.Columns[2].HeaderText = "Last Name";
            grdView.Columns[3].HeaderText = "City";
            grdView.Columns[4].HeaderText = "State";

            grdView.Columns[1].MinimumWidth = 133;
            grdView.Columns[2].MinimumWidth = 133;
            grdView.Columns[3].MinimumWidth = 135;
            grdView.Columns[4].MinimumWidth = 123;

            grdView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
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
    }
}