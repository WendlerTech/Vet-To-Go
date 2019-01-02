using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Vet_To_Go.Classes;

namespace Vet_To_Go.Forms
{
    public partial class FrmNewAnimal : Form
    {
        public Boolean animalAdded { get; set; }
        int customerID;
        int selectedSpeciesID = 0;
        String selectedSpecies = "";
        String name = "", breed = "", color = "", shelter = "", weight = "";
        Boolean isMale = true, isLicensed = true, isSterilized = true;
        Animal newAnimal = null;
        
        public FrmNewAnimal()
        {
            InitializeComponent();
        }

        public void OpenForm(int custID)
        {
            customerID = custID;
            this.ShowDialog();
        }

        private void txtWeight_Leave(object sender, EventArgs e)
        {
            if (txtWeight.Text.Equals(""))
            {
                // Do nothing, user can leave entry blank
            }
            else if (!Regex.IsMatch(txtWeight.Text, @"^[0-9]+$"))
            {
                // Ensures a number is entered
                MessageBox.Show("Invalid entry. Please enter a number.", "Bad Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWeight.Text = "";
                txtWeight.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            animalAdded = false;
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you wish to clear all entries?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                txtName.Text = "";
                txtBreed.Text = "";
                txtColor.Text = "";
                txtShelter.Text = "";
                txtWeight.Text = "";
                rdbSexMale.Select();
                rdbLicYes.Select();
                rdbSterYes.Select();
            }
        }

        private void cmbSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Assigns species ID from combobox index real-time
            selectedSpecies = cmbSpecies.SelectedItem.ToString();
            selectedSpeciesID = cmbSpecies.SelectedIndex + 1;
        }

        private void cmbSpecies_Leave(object sender, EventArgs e)
        {
            // Forces user to select an item from combo box
            string speciesInput = "";
            try
            {
                speciesInput = HelperClass.GetCapitalizedString(cmbSpecies.Text);
            } catch (Exception)
            {
                // Capitalizes user input to bypass error message
            }
            if (!cmbSpecies.Items.Contains(cmbSpecies.Text) && !cmbSpecies.Items.Contains(speciesInput))
            {
                MessageBox.Show("You must select a species from the drop-down list", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbSpecies.Text = "";
                cmbSpecies.Focus();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && cmbSpecies.SelectedItem != null)
            {
                // Capitalizes everything
                name = HelperClass.GetCapitalizedString(txtName.Text);
                if (txtBreed.Text != "")
                    breed = HelperClass.GetCapitalizedString(txtBreed.Text);
                if (txtColor.Text != "")
                    color = HelperClass.GetCapitalizedString(txtColor.Text);
                if (txtShelter.Text != "")
                    shelter = HelperClass.GetCapitalizedString(txtShelter.Text);
                if (txtWeight.Text != "")
                    weight = txtWeight.Text;

                // Assigns radio button choices
                if (rdbLicYes.Checked)
                    isLicensed = true;
                else
                    isLicensed = false;
                if (rdbSexMale.Checked)
                    isMale = true;
                else
                    isMale = false;
                if (rdbSterYes.Checked)
                    isSterilized = true;
                else
                    isSterilized = false;            

                var result = MessageBox.Show("Are you sure you wish to add " + name + " as a new animal?", "Submit", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    newAnimal = new Animal(customerID, name, selectedSpecies);
                    newAnimal.Breed = breed;
                    newAnimal.Color = color;
                    newAnimal.ShelterOrBreeder = shelter;
                    newAnimal.Weight = weight;
                    newAnimal.SpeciesID = selectedSpeciesID;
                    newAnimal.IsLicensed = isLicensed;
                    newAnimal.IsMale = isMale;
                    newAnimal.IsSterilized = isSterilized;

                    AddNewAnimal(newAnimal);
                    animalAdded = true;
                    this.Close();
                }
            } else
            {
                MessageBox.Show("Please enter a name & select a species", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNewAnimal(Animal animal)
        {
            String sqlStatement = "INSERT INTO Tbl_Animal (SpeciesID, CustomerID, AnimalName, AnimalBreed, Weight, Color, IsMale, IsLicensed, IsSterilized, ShelterOrBreeder) " +
                "VALUES (@species, @custID, @name, @breed, @weight, @color, @isMale, @isLic, @isSter, @shelter);";

            try
            {
                using (var connection = new SqlConnection(HelperClass.GetConnectionString()))
                {
                    SqlCommand command = new SqlCommand(sqlStatement, connection);
                    command.Parameters.AddWithValue("@species", animal.SpeciesID);
                    command.Parameters.AddWithValue("@custID", animal.OwnerID);
                    command.Parameters.AddWithValue("@name", animal.AnimalName);
                    command.Parameters.AddWithValue("@breed", animal.Breed);
                    command.Parameters.AddWithValue("@weight", animal.Weight);
                    command.Parameters.AddWithValue("@color", animal.Color);
                    command.Parameters.AddWithValue("@isMale", animal.IsMale);
                    command.Parameters.AddWithValue("@isLic", animal.IsLicensed);
                    command.Parameters.AddWithValue("@isSter", animal.IsSterilized);
                    command.Parameters.AddWithValue("@shelter", animal.ShelterOrBreeder);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show(name + " added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (SqlException ex)
            {
                MessageBox.Show("Something went wrong while attempting to add an animal to the database. Namely:\n" + ex.Message, 
                    "SQL Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}