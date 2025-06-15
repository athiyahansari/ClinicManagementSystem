using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.View.Admin
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void dash_appointments_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminbookappointment adminbookappointment = new adminbookappointment();
            adminbookappointment.Show();
            this.Hide();
        }

        private void dash_appointmenttrends_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reportadmin reportadmin = new Reportadmin();
            reportadmin.Show();
            this.Hide();
        }

        private void dash_newdoctors_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageDoctors manageDoctors = new ManageDoctors();
            manageDoctors.Show();
            this.Hide();
        }

        private void navdoc_Click(object sender, EventArgs e)
        {
            ManageDoctors manageDoctors = new ManageDoctors();
            manageDoctors.Show();
            this.Hide();
        }

        private void navreports_Click(object sender, EventArgs e)
        {
            Reportadmin reportadmin = new Reportadmin();
            reportadmin.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
