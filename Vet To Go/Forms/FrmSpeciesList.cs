using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Vet_To_Go.Classes;

namespace Vet_To_Go.Forms
{
    public partial class FrmSpeciesList : Form
    {
        private int speciesID;
        private int customerID;
        private SqlDataAdapter dataAdapter = null;
        private BindingSource bindingSource = new BindingSource();
        Boolean resultsFound = false;

        public FrmSpeciesList()
        {
            InitializeComponent();
        }

        public void OpenForm()
        {
            this.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void cmbSpeciesPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            speciesID = cmbSpeciesPicker.SelectedIndex + 1;
        }

        private void RetrieveData(int speciesID)
        {
            String animalQueryString = "SELECT T1.AnimalName, T1.AnimalBreed, T2.FirstName, T2.LastName, T2.CustomerID FROM Tbl_Animal T1 " +
                "INNER JOIN Tbl_Customer T2 ON T1.CustomerID = T2.CustomerID WHERE T1.SpeciesID = @speciesID";

            try
            {
                using (var connection = new SqlConnection(HelperClass.GetConnectionString()))
                {
                    dataAdapter = new SqlDataAdapter(animalQueryString, connection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@speciesID", speciesID);

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
                MessageBox.Show("Something went wrong while attempting to gather species data. Namely:\n" + ex.Message,
                    "SQL Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatData()
        {
            grdView.DataSource = bindingSource;

            grdView.Columns[4].Visible = false;

            grdView.Columns[0].HeaderText = "Animal Name";
            grdView.Columns[1].HeaderText = "Animal Breed";
            grdView.Columns[2].HeaderText = "Owner First Name";
            grdView.Columns[3].HeaderText = "Owner Last Name";

            grdView.Columns[0].MinimumWidth = 135;
            grdView.Columns[1].MinimumWidth = 136;
            grdView.Columns[2].MinimumWidth = 135;
            grdView.Columns[3].MinimumWidth = 135;

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

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (cmbSpeciesPicker.SelectedItem != null)
            {
                RetrieveData(speciesID);
                FormatData();
            }
        }

        private void grdView_SelectionChanged(object sender, EventArgs e)
        {
            if (resultsFound == true && grdView.SelectedRows.Count > 0)
                customerID = Convert.ToInt16(grdView.SelectedRows[0].Cells[4].Value.ToString());
        }
    }
}