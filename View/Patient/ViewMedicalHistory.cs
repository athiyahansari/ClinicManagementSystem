using System;
using System.Windows.Forms;
using ClinicManagementSystem.Controllers;

namespace ClinicManagementSystem.Views.Patients
{
    public partial class ViewMedicalHistory : Form
    {
        private MedicalHistoryController controller;

        public ViewMedicalHistory()
        {
            InitializeComponent();
            controller = new MedicalHistoryController();

            // Attach the event handler for the Load button
            btnLoad.Click += BtnLoad_Click;
            this.Load += ViewMedicalHistory_Load;
        }

        private void ViewMedicalHistory_Load(object sender, EventArgs e)
        {
            // Optional: any initialization on form load
        }

        // Button click event - just calls the load method
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            LoadMedicalHistory();//good practice
        }

        // Method to load medical history into the DataGridView
        private void LoadMedicalHistory()
        {
            // Clear existing rows first
            dvgMedicalHistory.Rows.Clear();

            // Get patient name from textbox
            string patientName = txtPatientName.Text.Trim();

            // Extracting Data from DB

            if (string.IsNullOrEmpty(patientName))
            {
                MessageBox.Show("Please enter a patient name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var historyList = controller.GetMedicalHistoryByPatientName(patientName);

            if (historyList.Count == 0)
            {
                MessageBox.Show($"No medical history found for: {patientName}", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var history in historyList)
            {
                dvgMedicalHistory.Rows.Add(
                    history.PatientName,
                    history.Date.ToString("yyyy-MM-dd"),
                    history.Diagnosis,
                    history.Prescription,
                    history.Notes
                );
            }
        }

        private void dvgMedicalHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
