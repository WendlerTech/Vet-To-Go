using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Vet_To_Go.Classes;

namespace Vet_To_Go.Forms
{
    public partial class FrmViewCustomer : Form
    {
        private SqlDataAdapter dataAdapter = null;
        private BindingSource bindingSource = new BindingSource();
        private String firstName, lastName, phoneNum;
        private String selectedFirst, selectedLast;
        private bool resultsFound = false;
        public int selectedCustomerID = 0;

        public FrmViewCustomer()
        {
            InitializeComponent();
        }

        private void FrmViewCustomer_Load(object sender, EventArgs e)
        {
            grdView.DataSource = bindingSource;
            RetrieveData();
            FormatData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (resultsFound == true && grdView.CurrentRow.Cells.Count > 0) // Null check
            {
                selectedCustomerID = Convert.ToInt16(grdView.SelectedRows[0].Cells[0].Value.ToString());
                this.Hide(); // Hides window until CustLandingPage is closed
                FrmCustLandingPage landingPage = new FrmCustLandingPage();
                landingPage.OpenForm(selectedCustomerID);
                this.Show();
            }
        }

        private void grdView_SelectionChanged(object sender, EventArgs e)
        {
            // Updates currently selected customer label in real-time
            if (resultsFound == true && grdView.SelectedRows.Count > 0) // Null check
            {
                selectedFirst = grdView.SelectedRows[0].Cells[1].Value.ToString();
                selectedLast = grdView.SelectedRows[0].Cells[2].Value.ToString();
                lblSelectedCust.Text = selectedFirst + " " + selectedLast;
            }            
        }

        public void OpenForm(String first, String last, String phone)
        {
            firstName = first;
            lastName = last;
            phoneNum = phone;
            this.ShowDialog();
        }

        private void RetrieveData()
        {
            string queryString = "SELECT * FROM Tbl_Customer WHERE LastName = @last OR FirstName = @first OR CellPhoneNum = @cellNum OR HomePhoneNum = @homeNum;";

            try
            {
                using (var connection = new SqlConnection(HelperClass.GetConnectionString()))
                {
                    connection.Open();

                    dataAdapter = new SqlDataAdapter(queryString, connection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@last", lastName);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@first", firstName);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@cellNum", phoneNum);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@homeNum", phoneNum);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    bindingSource.DataSource = table;

                    // Checks to see if anything was actually returned, so as to avoid null pointers
                    if (table.Rows.Count < 1)
                    {
                        resultsFound = false;
                    } else
                    {
                        resultsFound = true;
                    }                       
                }
            } catch (SqlException ex)
            {
                MessageBox.Show("Something went wrong while attempting to access the database. Namely:\n" + ex.Message, "SQL Exception",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatData()
        {
            // Only makes certain columns visible and formats them
            grdView.Columns[0].Visible = false;
            grdView.Columns[3].Visible = false;
            grdView.Columns[4].Visible = false;
            grdView.Columns[5].Visible = false;
            grdView.Columns[6].Visible = false;
            grdView.Columns[7].Visible = false;
            grdView.Columns[8].Visible = false;
            grdView.Columns[11].Visible = false;

            grdView.Columns[1].HeaderText = "First Name";
            grdView.Columns[2].HeaderText = "Last Name";
            grdView.Columns[9].HeaderText = "Cell Phone";
            grdView.Columns[10].HeaderText = "Home Phone";

            grdView.Columns[1].MinimumWidth = 120;
            grdView.Columns[2].MinimumWidth = 120;
            grdView.Columns[9].MinimumWidth = 85;
            grdView.Columns[10].MinimumWidth = 85;

            grdView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader); // Resizes columns to fit new content   

            // Sets colors for gridview
            grdView.RowHeadersVisible = false;
            System.Drawing.Color columnColor = System.Drawing.Color.FromArgb(82, 117, 150);
            System.Drawing.Color highlightColor = System.Drawing.Color.FromArgb(99, 166, 229);
            grdView.DefaultCellStyle.SelectionBackColor = highlightColor;
            grdView.ColumnHeadersDefaultCellStyle.BackColor = columnColor;
            grdView.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            grdView.EnableHeadersVisualStyles = false;

            grdView.MultiSelect = false;  // Only allows 1 row to be selected at once
            if (resultsFound)
            {
                grdView.FirstDisplayedCell.Selected = true;  // Auto-selects first row to avoid null pointers
            }
        }
    }
}