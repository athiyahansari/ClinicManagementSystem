using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManagementSystem.Views.Patients;
using CMS.Controller;
using CMS.Model;
using CMS.View.Doctor;
using CMS.View.Patient;




namespace CMS.View.Patient
{
    public partial class ViewDoctors : Form

    {
        private readonly DoctorsController doctorController;

        public ViewDoctors()

        {
            InitializeComponent();
            doctorController = new DoctorsController();

        }

        private void ViewDoctor_Load(object sender, EventArgs e)

        {
            LoadDoctorList();
        }

        private void LoadDoctorList()

        {
            List<Model.Doctors> doctors = doctorController.GetAllDoctors();
            dgvDoctors.DataSource = doctors;
        }

        private void label1_Click(object sender, EventArgs e)// View Doctor
        {
            ViewDoctors viewDoctorForm = new ViewDoctors();
            viewDoctorForm.Show();
            this.Hide();
        }

        private void navdoc_Click(object sender, EventArgs e)
        {
            LoadDoctorList(); // From navdoc button
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        



        private void navmedicalhistory_Click(object sender, EventArgs e)//Medical History

        {
            ViewMedicalHistory historyForm = new ViewMedicalHistory();
            historyForm.Show();
            this.Hide(); // Hide the current form

        }

        private void navappointment_Click(object sender, EventArgs e)// Appointments
        {
            Bookappointmentform appointmentForm = new Bookappointmentform();
            appointmentForm.Show();
            this.Hide(); // Hide the current form
        }

        private void navprescription_Click(object sender, EventArgs e)// Prescription
        {
            ViewPrescription prescriptionForm = new ViewPrescription();
            prescriptionForm.Show();
            this.Hide(); // Hide the current form

        }

        private void navprofile_Click(object sender, EventArgs e) //My profile
        {
            Edit_Patient_Profile profileForm = new Edit_Patient_Profile();
            profileForm.Show();
            this.Hide(); // Hide the current form

        }

        private void logout_Click(object sender, EventArgs e)// Logout
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide(); // Hide the current form

        }
    }
}


