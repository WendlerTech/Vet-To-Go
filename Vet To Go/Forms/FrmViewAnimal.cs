using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Vet_To_Go.Classes;

namespace Vet_To_Go.Forms
{
    public partial class FrmViewAnimal : Form
    {
        int animalID = 0;
        String customerName;
        Customer customer = null;
        Animal animal = null;
        bool resultsFound = false;
        private SqlDataAdapter dataAdapter = null;
        private BindingSource bindingSource = new BindingSource();

        public FrmViewAnimal()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void OpenForm(Customer cust, String custName)
        {
            customer = cust;
            customerName = custName;
            grdView.DataSource = bindingSource;
            RetrieveData();
            this.Show();
            PopulateData();
        } 

        private void RetrieveData()
        {
            string queryString = "SELECT * FROM Tbl_Animal WHERE CustomerID = @custID";

            try
            {
                using (var connection = new SqlConnection(HelperClass.GetConnectionString()))
                {
                    dataAdapter = new SqlDataAdapter(queryString, connection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@custID", customer.CustomerID);

                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);                    

                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    bindingSource.DataSource = table;

                    // Checks whether or not anything was returned to avoid null pointer
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
                MessageBox.Show("Something went wrong while attempting to access the database. Namely:\n" + ex.Message, 
                    "SQL Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateData()
        {
            lblHeader.Text = customerName + "'s Animals";
            grdView.Columns[0].Visible = false;
            grdView.Columns[1].Visible = false;
            grdView.Columns[2].Visible = false;
            grdView.Columns[6].Visible = false;
            grdView.Columns[7].Visible = false;
            grdView.Columns[10].Visible = false;
            grdView.Columns[11].Visible = false;

            grdView.Columns[3].HeaderText = "Name";
            grdView.Columns[4].HeaderText = "Breed";
            grdView.Columns[5].HeaderText = "Weight";
            grdView.Columns[8].HeaderText = "Licensed";
            grdView.Columns[9].HeaderText = "Sterilized";

            grdView.Columns[3].MinimumWidth = 140;
            grdView.Columns[4].MinimumWidth = 140;
            grdView.Columns[5].MinimumWidth = 115;
            grdView.Columns[8].MinimumWidth = 73;
            grdView.Columns[9].MinimumWidth = 73;

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

        private Animal GetSelectedAnimal()
        {
            if (resultsFound == true && grdView.SelectedRows.Count > 0)
            {
                // Creates & returns an animal object based on currently selected row
                animal = new Animal();
                animal.AnimalID = Convert.ToInt16(grdView.SelectedRows[0].Cells[0].Value.ToString());
                animal.SpeciesID = Convert.ToInt16(grdView.SelectedRows[0].Cells[1].Value.ToString());
                animal.OwnerID = customer.CustomerID;
                animal.AnimalName = grdView.SelectedRows[0].Cells[3].Value.ToString();
                animal.Breed = grdView.SelectedRows[0].Cells[4].Value.ToString();
                animal.Weight = grdView.SelectedRows[0].Cells[5].Value.ToString();
                animal.Color = grdView.SelectedRows[0].Cells[6].Value.ToString();
                animal.ShelterOrBreeder = grdView.SelectedRows[0].Cells[10].Value.ToString();
                animal.IsMale = Convert.ToBoolean(grdView.SelectedRows[0].Cells[7].Value);
                animal.IsLicensed = Convert.ToBoolean(grdView.SelectedRows[0].Cells[8].Value);
                animal.IsSterilized = Convert.ToBoolean(grdView.SelectedRows[0].Cells[9].Value);

                return animal;
            } else
            {
                return animal = new Animal();
            }
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            FrmNewAnimal newAnimalFrm = new FrmNewAnimal();
            newAnimalFrm.OpenForm(customer.CustomerID);
            // Checks if any changes were made before re-populating
            if (newAnimalFrm.animalAdded)
            {
                RetrieveData();
                PopulateData();
            }
        }

        private void btnEditAnimal_Click(object sender, EventArgs e)
        {

            if (resultsFound == true && grdView.SelectedRows.Count > 0)
            {
                FrmEditAnimal editAnimalFrm = new FrmEditAnimal();
                editAnimalFrm.OpenForm(GetSelectedAnimal());
                // Checks if any changes were made before re-populating
                if (editAnimalFrm.animalUpdated)
                {
                    RetrieveData();
                    PopulateData();
                }
            }
        }

        private void grdView_SelectionChanged(object sender, EventArgs e)
        {
            // After null check, assigns animalID value based on selected row
            if (resultsFound == true && grdView.SelectedRows.Count > 0)
            {
                animalID = Convert.ToInt16(grdView.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnViewNotes_Click(object sender, EventArgs e)
        {
            if (resultsFound == true && grdView.SelectedRows.Count > 0)
            {
                FrmAnimalNotes animalNotesFrm = new FrmAnimalNotes();
                animalNotesFrm.OpenForm(GetSelectedAnimal());
            }
        }
    }
}