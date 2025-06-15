using System;
using System.Windows.Forms;
using CMS.Controller;
using CMS.Model;
using System.Collections.Generic;
using CMS.View.Doctor;
using CMS.View.Patient;

namespace ClinicManagementSystem.Views.Patients
{
    public partial class ViewMedicalHistory : Form
    {
        private MedicalHistoryController controller;

        public ViewMedicalHistory()
        {
            InitializeComponent();
            controller = new MedicalHistoryController();
            btnLoad.Click += BtnLoad_Click;
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            string patientName = txtPatientName.Text.Trim();
            if (string.IsNullOrEmpty(patientName))
            {
                MessageBox.Show("Please enter a patient name.");
                return;
            }

            LoadMedicalHistory(patientName);
        }

        private void LoadMedicalHistory(string patientName)
        {
            dgvHistory.Rows.Clear();
            List<(MedicalHistory, string doctorName)> history = controller.GetMedicalHistoryByPatientName(patientName);

            if (history.Count == 0)
            {
                MessageBox.Show("No medical history found for this patient.");
                return;
            }

            foreach (var (record, doctorName) in history)
            {
                dgvHistory.Rows.Add(
                    record.VisitDate.ToString("yyyy-MM-dd"),
                    record.Diagnosis,
                    record.Prescription,
                    record.Notes,
                    doctorName
                );
            }
        }

        private void ViewMedicalHistory_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void navdoc_Click(object sender, EventArgs e)
        {
              
        }


        //DOCTOR VIEW PROFILE BTN
        //private void navprofile_Click(object sender, EventArgs e)
        //{
        //    int doctorId = 1; // Replace this with actual dynamic doctorId later
        //    CMS.View.Doctor.DocViewProfile profileForm = new CMS.View.Doctor.DocViewProfile(doctorId);
        //    profileForm.ShowDialog();
        //}





    



        private void navmedicalhistory_Click(object sender, EventArgs e)//Medical History

        {
            //ViewMedicalHistory historyForm = new ViewMedicalHistory();
            //historyForm.Show();
            //this.Hide(); // Hide the current form

        }

        private void navappointment_Click(object sender, EventArgs e)// Appointments
        {
            //Bookappointments appointmentForm = new Bookappointments();
            //appointmentForm.Show();
            //this.Hide(); // Hide the current form
        }

        private void navprescription_Click(object sender, EventArgs e)// Prescription
        {
            //ViewPrescription prescriptionForm = new ViewPrescription();
            //prescriptionForm.Show();
            //this.Hide(); // Hide the current form

        }

        private void navprofile_Click(object sender, EventArgs e) //My profile
        {
            //Edit_Patient_Profile profileForm = new Edit_Patient_Profile();
            //profileForm.Show();
            //this.Hide(); // Hide the current form

        }

        private void logout_Click(object sender, EventArgs e)// Logout
        {
            //LoginForm loginForm = new LoginForm();
            //loginForm.Show();
            //this.Hide(); // Hide the current form

        }








        private void dgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
