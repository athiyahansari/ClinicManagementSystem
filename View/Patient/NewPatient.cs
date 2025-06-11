using CMS.Controller;
using CMS.Model;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.View.Patient
{
    public partial class NewPatient : Form
    {
        public NewPatient()
        {
            InitializeComponent();
        }

        private void emailAddress_Click(object sender, EventArgs e)
        {

        }

        private void patientRegister_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate password match
                if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
                {
                    MessageBox.Show("Passwords do not match. Please try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate required fields
                if (string.IsNullOrWhiteSpace(FirstName.Text) ||
                    string.IsNullOrWhiteSpace(LastName.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                    cmbGender.SelectedItem == null)
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Prepare user and patient models
                User newUser = new User
                {
                    Username = txtEmail.Text.Trim(),
                    Password = txtPassword.Text.Trim()
                };

                Patients newPatient = new Patients
                {
                    FirstName = FirstName.Text.Trim(),
                    LastName = LastName.Text.Trim(),
                    Gender = cmbGender.SelectedItem.ToString(),
                    DateOfBirth = DateTimeDOB.Value,
                    Email = txtEmail.Text.Trim(),
                    PhoneNumber = txtPhoneNumber.Text.Trim()
                };

                // Pass to controller
                RegisterController controller = new RegisterController();
                string result = controller.Register(newUser, newPatient);

                if (result == "success")
                {
                    MessageBox.Show("Registration Successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current registration form

            LoginForm login = new LoginForm(); // Create an instance of the login form
            login.Show(); // Show the login form
        }
    }
}
