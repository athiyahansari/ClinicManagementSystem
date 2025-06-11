using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMS.Controller;
using CMS.Model;             // Assuming your User class is here
        // Assuming your LoginRepository is here
using CMS.View.Admin;
using CMS.View.Doctor;
using CMS.View.Patient;
using MySql.Data.MySqlClient;


namespace CMS.View
{
    public partial class LoginForm : Form

    {
        private LoginController loginController = new LoginController();

        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            string username = txtAdminUsername.Text.Trim();
            string password = txtAdminPassword.Text.Trim();

            var user = loginController.Login(username, password);

            if (user != null && user.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                new AdminDashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Admin login.");
            }
        }

        private void signUpbtn_Click(object sender, EventArgs e)
        {
            new NewPatient().Show();
            this.Hide();
        }

        private void btnDoctorLogin_Click(object sender, EventArgs e)
        {
            string username = txtDoctorUsername.Text.Trim();
            string password = txtDoctorPassword.Text.Trim();

            var user = loginController.Login(username, password);

            if (user != null && user.Role.Equals("Doctor", StringComparison.OrdinalIgnoreCase))
            {
                new DoctorDashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Doctor login.");
            }
        }

        private void btnPatientLogin_Click(object sender, EventArgs e)
        {
            string username = txtPatientUsername.Text.Trim();
            string password = txtPatientPassword.Text.Trim();

            var user = loginController.Login(username, password);

            if (user != null && user.Role.Equals("Patient", StringComparison.OrdinalIgnoreCase))
            {
                new PatientDashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Patient login.");
            }

        }
    }
}
