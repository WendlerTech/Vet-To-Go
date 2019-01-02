using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Vet_To_Go.Classes;

namespace Vet_To_Go.Forms
{
    public partial class FrmCustomerNotes : Form
    {
        int customerID;
        Boolean deletedAllNotes = false;

        public FrmCustomerNotes()
        {
            InitializeComponent();
        }

        public void OpenForm(int custID)
        {
            customerID = custID;
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
            String queryString = "SELECT CustomerNotes FROM Tbl_Customer WHERE CustomerID = @custID;";

            try
            {
                using (var connection = new SqlConnection(HelperClass.GetConnectionString()))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@custID", customerID);
                    
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Cast as string handles potential null pointer
                            rtbCustNotes.Rtf = reader["CustomerNotes"] as string;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Something went wrong while attempting to access the database. Namely:\n" + ex.Message, "SQL Exception");
            }
        }

        private void SaveData()
        {
            String queryString = "UPDATE Tbl_Customer SET CustomerNotes = @newNotes WHERE CustomerID = @custID;";

            try
            {
                using (var connection = new SqlConnection(HelperClass.GetConnectionString()))
                {
                    connection.Open();
                    // Adds new notes to current data, then re-writes saved entry. Adds new line only if prior notes exist.
                    if (deletedAllNotes)
                        rtbCustNotes.AppendText(rtbNewNotes.Text);
                    else
                        rtbCustNotes.AppendText(rtbNewNotes.Text + "\n");
                    
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@custID", customerID);
                    command.Parameters.AddWithValue("@newNotes", rtbCustNotes.Rtf);
                    deletedAllNotes = false;

                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Something went wrong while attempting to save notes to the database. Namely:\n" + ex.Message, "SQL Exception");
            }
        }

        private void btnDeleteNotes_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deleting this customer's notes CANNOT be undone. \nAre you sure you wish to do this? \n(This will also clear any unsaved new notes)", 
                "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                rtbNewNotes.Text = "";
                rtbCustNotes.Text = "";
                deletedAllNotes = true;
                SaveData();
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
    }
}