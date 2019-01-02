using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Vet_To_Go.Classes;

namespace Vet_To_Go.Forms
{
    public partial class FrmAnimalNotes : Form
    {
        Animal animal = null;
        Boolean deletedAllNotes = false;

        public FrmAnimalNotes()
        {
            InitializeComponent();
        }

        public void OpenForm(Animal animal)
        {
            this.animal = animal;
            this.Show();
            RetrieveData();
            // Adds date before note to use as timestamp
            rtbNewNotes.Text = "" + HelperClass.FormatDate(DateTime.Now) + " -  ";
            rtbNewNotes.Select(rtbNewNotes.Text.Length - 1, 0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you wish to save this note?", "Save new notes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SaveData();
            }
        }

        private void RetrieveData()
        {
            lblHeader.Text = animal.AnimalName + "'s Notes";
            String queryString = "SELECT Notes FROM Tbl_Animal WHERE AnimalID = @animID;";

            try
            {
                using (var connection = new SqlConnection(HelperClass.GetConnectionString()))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@animID", animal.AnimalID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Cast as string handles potential null pointer
                            rtbAnimalNotes.Rtf = reader["Notes"] as string;
                        }
                    }
                }
            } catch (SqlException ex)
            {
                MessageBox.Show("Something went wrong while attempting to save notes to the database. Namely:\n" + ex.Message, "SQL Exception");
            }
        }

        private void SaveData()
        {
            String queryString = "UPDATE Tbl_Animal SET Notes = @newNotes WHERE AnimalID = @animID;";

            try
            {
                using (var connection = new SqlConnection(HelperClass.GetConnectionString()))
                {
                    connection.Open();
                    // Adds new notes to current data, then re-writes saved entry. Adds new line only if prior notes exist.
                    if (deletedAllNotes)
                        rtbAnimalNotes.AppendText(rtbNewNotes.Text);
                    else
                        rtbAnimalNotes.AppendText(rtbNewNotes.Text + "\n");

                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@animID", animal.AnimalID);
                    command.Parameters.AddWithValue("@newNotes", rtbAnimalNotes.Rtf);
                    deletedAllNotes = false;

                    command.ExecuteNonQuery();
                }
            } catch (SqlException ex)
            {
                MessageBox.Show("Something went wrong while attempting to save notes to the database. Namely:\n" + ex.Message, "SQL Exception");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbNewNotes.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteNotes_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deleting this customer's notes CANNOT be undone. \nAre you sure you wish to do this? \n(This will also clear any unsaved new notes)",
                "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                rtbNewNotes.Text = "";
                rtbAnimalNotes.Text = "";
                deletedAllNotes = true;
                SaveData();
            }
        }
    }
}