using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Vet_To_Go.Classes;

namespace Vet_To_Go.Forms
{
    public partial class FrmEditAnimal : Form
    {
        public Boolean animalUpdated { get; set; }
        Animal animal = null;
        Boolean isMale = false, isLicensed = false, isSterilized = false;

        public FrmEditAnimal()
        {
            InitializeComponent();
        }

        public void OpenForm(Animal animal)
        {
            this.animal = animal;
            RetrieveData();
            this.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            animalUpdated = false;
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you wish to update this animal's information?", "Update", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                if (rdbLicYes.Checked)
                    isLicensed = true;
                if (rdbSexMale.Checked)
                    isMale = true;
                if (rdbSterYes.Checked)
                    isSterilized = true;

                UpdateAnimal();
                animalUpdated = true;
                this.Close();
            }
        }

        private void UpdateAnimal()
        {
            String sqlStatement = "UPDATE Tbl_Animal SET SpeciesID = @species, AnimalName = @name, AnimalBreed = @breed, Weight = @weight, " +
                "Color = @color, IsMale = @isMale, IsLicensed = @isLic, IsSterilized = @isSter, ShelterOrBreeder = @shelter " +
                "WHERE AnimalID = @animID;";

            try
            {
                using (var connection = new SqlConnection(HelperClass.GetConnectionString()))
                {
                    SqlCommand command = new SqlCommand(sqlStatement, connection);
                    command.Parameters.AddWithValue("@species", cmbSpecies.SelectedIndex + 1);
                    command.Parameters.AddWithValue("@name", txtName.Text);
                    command.Parameters.AddWithValue("@breed", txtBreed.Text);
                    command.Parameters.AddWithValue("@weight", txtWeight.Text);
                    command.Parameters.AddWithValue("@color", txtColor.Text);
                    command.Parameters.AddWithValue("@isMale", isMale);
                    command.Parameters.AddWithValue("@isLic", isLicensed);
                    command.Parameters.AddWithValue("@isSter", isSterilized);
                    command.Parameters.AddWithValue("@shelter", txtShelter.Text);
                    command.Parameters.AddWithValue("@animID", animal.AnimalID);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Animal updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Something went wrong while attempting to update the animal's information. Namely:\n" + ex.Message,
                    "SQL Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void RetrieveData()
        {
            // Populates selected animal's data
            txtName.Text = animal.AnimalName;
            txtBreed.Text = animal.Breed;
            txtColor.Text = animal.Color;
            txtShelter.Text = animal.ShelterOrBreeder;
            txtWeight.Text = animal.Weight;
            cmbSpecies.SelectedIndex = animal.SpeciesID - 1;

            if (!animal.IsMale)
                rdbSexFemale.Checked = true;
            if (!animal.IsLicensed)
                rdbLicNo.Checked = true;
            if (!animal.IsSterilized)
                rdbSterNo.Checked = true;
        }

        private void cmbSpecies_Leave(object sender, EventArgs e)
        {
            // Forces user to select an item from combo box
            string speciesInput = "";
            try
            {
                speciesInput = HelperClass.GetCapitalizedString(cmbSpecies.Text);
            }
            catch (Exception)
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
    }
}