using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Vet_To_Go.Classes;

namespace Vet_To_Go.Forms
{
    public partial class FrmEmailList : Form
    {
        private SqlDataAdapter dataAdapter = null;
        private BindingSource bindingSource = new BindingSource();
        private int customerID;
        Boolean resultsFound = false;

        public FrmEmailList()
        {
            InitializeComponent();
        }

        public void OpenForm()
        {
            this.ShowDialog();
        }

        private void RetrieveData()
        {
            String queryString = "SELECT * FROM Tbl_Customer WHERE EmailAddress IS NOT NULL AND EmailAddress != '';";

            try
            {
                using (var connection = new SqlConnection(HelperClass.GetConnectionString()))
                {
                    dataAdapter = new SqlDataAdapter(queryString, connection);

                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    bindingSource.DataSource = table;

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
            } catch (SqlException ex)
            {
                MessageBox.Show("Something went wrong while attempting to retrieve the email list. Namely:\n" + ex.Message, 
                    "SQL Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatData()
        {
            grdView.Columns[0].Visible = false;
            grdView.Columns[4].Visible = false;
            grdView.Columns[5].Visible = false;
            grdView.Columns[6].Visible = false;
            grdView.Columns[7].Visible = false;
            grdView.Columns[8].Visible = false;
            grdView.Columns[9].Visible = false;
            grdView.Columns[10].Visible = false;
            grdView.Columns[11].Visible = false;

            grdView.Columns[1].HeaderText = "First Name";
            grdView.Columns[2].HeaderText = "Last Name";
            grdView.Columns[3].HeaderText = "Email Address";

            grdView.Columns[1].MinimumWidth = 160;
            grdView.Columns[2].MinimumWidth = 160;
            grdView.Columns[3].MinimumWidth = 204;

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

            if (resultsFound && grdView.SelectedRows.Count > 0)
            {
                // Auto-selects first row to avoid null pointers
                grdView.FirstDisplayedCell.Selected = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMassEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stub feature to be added on-demand.", "Demo only", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnViewCust_Click(object sender, EventArgs e)
        {
            if (resultsFound == true && grdView.SelectedRows.Count > 0)
            {
                customerID = Convert.ToInt16(grdView.SelectedRows[0].Cells[0].Value.ToString());
                FrmCustLandingPage landingPageFrm = new FrmCustLandingPage();
                this.Hide();
                landingPageFrm.OpenForm(customerID);
                this.Show();
            }
        }

        private void btnClipboard_Click(object sender, EventArgs e)
        {
            if (resultsFound == true && grdView.SelectedRows.Count > 0)
            {
                string clipboardText = grdView.SelectedRows[0].Cells[3].Value.ToString();
                Clipboard.SetText(clipboardText);
                MessageBox.Show("Copied to clipboard:\n" + clipboardText, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmEmailList_Load(object sender, EventArgs e)
        {
            grdView.DataSource = bindingSource;
            RetrieveData();
            FormatData();
        }
    }
}