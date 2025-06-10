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
            LoadMedicalHistory();
        }

        // Method to load medical history into the DataGridView
        private void LoadMedicalHistory()
        {
            // Clear existing rows first
            dvgMedicalHistory.Rows.Clear();

            // Get patient name from textbox
            string patientName = txtPatientName.Text.Trim();

            // Dummy data - replace this with actual DB query and data loading logic
            if (patientName.Equals("John Doe", StringComparison.OrdinalIgnoreCase))
            {
                dvgMedicalHistory.Rows.Add("John Doe", "2025-01-10", "Flu", "Dr. Smith", "Tamiflu", "Rest and hydrate");
                dvgMedicalHistory.Rows.Add("John Doe", "2025-02-15", "Cold", "Dr. Brown", "Paracetamol", "Stay warm");
            }
            else
            {
                MessageBox.Show($"No medical history found for: {patientName}", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
