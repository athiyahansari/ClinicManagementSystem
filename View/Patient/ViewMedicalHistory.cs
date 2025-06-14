using System;
using System.Windows.Forms;
using CMS.Controller;
using CMS.Model;
using System.Collections.Generic;

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
            ViewDoctors viewDoctors = new ViewDoctors();
            viewDoctors.Show();
            this.Hide(); // Hide the current form   
        }


        //DOCTOR VIEW PROFILE BTN
        private void navprofile_Click(object sender, EventArgs e)
        {
            int doctorId = 1; // Replace this with actual dynamic doctorId when available
            CMS.View.Doctor.DocViewProfile profileForm = new CMS.View.Doctor.DocViewProfile(doctorId);
            profileForm.ShowDialog();
        }

    }
}
