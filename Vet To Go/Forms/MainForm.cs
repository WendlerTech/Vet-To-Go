using System;
using System.Windows.Forms;
using Vet_To_Go.Forms;
using System.Text.RegularExpressions;

namespace Vet_To_Go
{
    public partial class MainForm : Form
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String phoneNum { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnNewCust_Click(object sender, EventArgs e)
        {
            FrmNewCustomer newCustForm = new FrmNewCustomer();
            newCustForm.GetNewCustomer();
        }

        private void btnQueries_Click(object sender, EventArgs e)
        {
            FrmQueries queriesFrm = new FrmQueries();            
            queriesFrm.OpenForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // SQL Injection protection
            if (!Regex.IsMatch(txtFirstName.Text, @"^[a-zA-Z.\s]{0,40}$") || !Regex.IsMatch(txtLastName.Text, @"^[a-zA-Z.\s]{0,40}$"))
            {
                MessageBox.Show("Your search terms contain forbidden characters. \nPlease try again.", 
                    "Invalid Entry", MessageBoxButtons.OK);
            }
            else
            {
                firstName = txtFirstName.Text;
                lastName = txtLastName.Text;
                phoneNum = txtPhoneNum.Text;
                
                FrmViewCustomer viewCust = new FrmViewCustomer();
                this.Hide();
                viewCust.OpenForm(firstName, lastName, phoneNum);
                this.Show();
                this.Focus();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNum.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you wish to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void btnDatabaseStats_Click(object sender, EventArgs e)
        {
            FrmDatabaseStats dbStatsFrm = new FrmDatabaseStats();
            dbStatsFrm.OpenForm();
        }
    }
}