using ClinicManagementSystem.Views.Patients;
using CMS.Controller;
using CMS.Model;
using CMS.View.Patient;
using System;
using System.Windows.Forms;

namespace CMS.View.Patient
{
    public partial class ViewPrescription : Form
    {
        private int _patientId; // Holds the ID of the logged-in patient

        // Default constructor
        public ViewPrescription()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.ViewPrescription_Load);
            AttachNavButtonEvents(); // Attach button click events at runtime
        }

        // Constructor with patient ID
        public ViewPrescription(int patientId)
        {
            InitializeComponent();
            _patientId = patientId;
            this.Load += new System.EventHandler(this.ViewPrescription_Load);
            AttachNavButtonEvents(); // Attach button click events at runtime
        }

        // Form Load Event - triggers when the form loads
        private void ViewPrescription_Load(object sender, EventArgs e)
        {
            dgvPrescriptions.AutoGenerateColumns = false; // This manually define DataGridView columns
            LoadPrescriptions(_patientId); // Load the patient's prescriptions
        }

        // Loads prescriptions for a given patient ID
        private void LoadPrescriptions(int patientId)
        {
            try
            {
                var controller = new PrescriptionController();
                var prescriptions = controller.GetPrescriptionsByPatientId(patientId);

                dgvPrescriptions.Rows.Clear(); // Clear existing rows before loading new data

                if (prescriptions.Count == 0)
                {
                    MessageBox.Show("No prescriptions found for this patient.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Add each prescription to the DataGridView
                foreach (var p in prescriptions)
                {
                    string doctorFullName = $"{p.Doctor.FirstName} {p.Doctor.LastName}";

                    dgvPrescriptions.Rows.Add(
                        p.PrescriptionDate.ToShortDateString(), // Prescription date
                        doctorFullName,                         // Doctor's full name
                        p.Diagnosis,                            // Diagnosis
                        p.Medicines                             // Medicines prescribed
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading prescriptions: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Attach event handlers to side navigation buttons
        private void AttachNavButtonEvents()
        {
            btnDoctor.Click += BtnDoctor_Click;
            btnAppointment.Click += BtnAppointment_Click;
            btnPrescriptions.Click += BtnPrescriptions_Click;
            btnMedicalHistory.Click += BtnMedicalHistory_Click;
            btnMyProfile.Click += BtnMyProfile_Click;
            btnLogout.Click += BtnLogout_Click;
        }

        // Navigate to Doctor form
        private void BtnDoctor_Click(object sender, EventArgs e)
        {
            // ViewDoctors doctorForm = new ViewDoctors();     // Pass patient ID if needed (_patientId)
            // doctorForm.Show();
            // this.Hide(); // Hide current form
        }

        // Navigate to Appointment form
        private void BtnAppointment_Click(object sender, EventArgs e)
        {
            // Bookappointmentform appointmentForm = new Bookappointmentform();
            // appointmentForm.Show();
            // this.Hide();
        }

        // Already on Prescription view - optionally refresh prescriptions
        private void BtnPrescriptions_Click(object sender, EventArgs e)
        {
            // LoadPrescriptions(_patientId); // Refresh data
        }

        // Navigate to Medical History form
        private void BtnMedicalHistory_Click(object sender, EventArgs e)
        {
            // ViewMedicalHistory historyForm = new ViewMedicalHistory();
            // historyForm.Show();
            // this.Hide();
        }

        // Navigate to My Profile form
        private void BtnMyProfile_Click(object sender, EventArgs e)
        {
            // Edit_Patient_Profile profileForm = new Edit_Patient_Profile();
            // profileForm.Show();
            // this.Hide();
        }

        // Log out and go back to Login form
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            // LoginForm loginForm = new LoginForm();
            // loginForm.Show();
            // this.Close(); // Close current form
        }

    }
}
