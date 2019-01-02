using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Vet_To_Go.Classes;

namespace Vet_To_Go.Forms
{
    public partial class FrmSterilizedAnimals : Form
    {
        int selectedSpeciesID;
        int customerID;
        Boolean resultsFound = false;
        private SqlDataAdapter dataAdapter = null;
        private BindingSource bindSource = new BindingSource();

        public FrmSterilizedAnimals()
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
            selectedSpeciesID = cmbSpeciesPicker.SelectedIndex;
        }

        private void RetrieveData(int speciesID)
        {
            // If combobox index is 0, all species was selected, returning a queryString to select all species.
            // If any other index is chosen, species-defining queryString is used.
            String queryString = GetQueryString(speciesID);
            Boolean specificSpecies = true;
            if (speciesID == 0)
                specificSpecies = false;
            else
                specificSpecies = true;

            try
            {
                using (var connection = new SqlConnection(HelperClass.GetConnectionString()))
                {
                    dataAdapter = new SqlDataAdapter(queryString, connection);
                    // Adds species parameter if non-0 index was chosen
                    if (specificSpecies)
                        dataAdapter.SelectCommand.Parameters.AddWithValue("@speciesID", speciesID);

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
                MessageBox.Show("An error occured while attempting to retrieve unsterilized animals. Namely:\n" + ex.Message, "SQL Exception",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private String GetQueryString(int speciesID)
        {
            // Default string selects all species
            String queryString = "SELECT T1.CustomerID, T1.AnimalName, T1.AnimalBreed, T2.FirstName, T2.LastName FROM Tbl_Animal T1 " +
                "INNER JOIN Tbl_Customer T2 ON T1.CustomerID = T2.CustomerID WHERE T1.IsSterilized = 0;";
            if (speciesID != 0)
            {
                queryString = "SELECT T1.CustomerID, T1.AnimalName, T1.AnimalBreed, T2.FirstName, T2.LastName FROM Tbl_Animal T1 " +
                    "INNER JOIN Tbl_Customer T2 ON T1.CustomerID = T2.CustomerID WHERE T1.IsSterilized = 0 AND T1.SpeciesID = @speciesID;";
            }

            return queryString;
        }

        private void FormatData()
        {
            grdView.DataSource = bindSource;

            grdView.Columns[0].Visible = false;

            grdView.Columns[1].HeaderText = "Animal Name";
            grdView.Columns[2].HeaderText = "Breed";
            grdView.Columns[3].HeaderText = "Owner First Name";
            grdView.Columns[4].HeaderText = "Owner Last Name";

            grdView.Columns[1].MinimumWidth = 136;
            grdView.Columns[2].MinimumWidth = 135;
            grdView.Columns[3].MinimumWidth = 135;
            grdView.Columns[4].MinimumWidth = 135;

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
                RetrieveData(selectedSpeciesID);
                FormatData();
            }
        }

        private void grdView_SelectionChanged(object sender, EventArgs e)
        {
            if (grdView.SelectedRows.Count > 0)
                customerID = Convert.ToInt16(grdView.SelectedRows[0].Cells[0].Value.ToString());
        }
    }
}