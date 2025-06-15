using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMS.View.Doctor;
using CMS.Controller;
using CMS.Model;
using CMS.Utils;

namespace CMS.View.Doctor
{
    public partial class DoctorDashboard : Form
    {
        public DoctorDashboard()
        {
            InitializeComponent();
        }



        private void dash_upcomingappointments_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppointmentSchedule appointmentSchedule = new AppointmentSchedule();
            appointmentSchedule.Show();
            this.Hide();
        }

        private void dash_pres_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreatePrescription createPrescription = new CreatePrescription();
            createPrescription.Show();
            this.Hide();
        }

        private void navprofile_Click(object sender, EventArgs e)
        {
            DocViewProfile docViewProfile = new DocViewProfile();
            docViewProfile.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void navprescription_Click(object sender, EventArgs e)
        {
            CreatePrescription createPrescription = new CreatePrescription();   
            createPrescription.Show();
            this.Hide();
        }
    }
}
