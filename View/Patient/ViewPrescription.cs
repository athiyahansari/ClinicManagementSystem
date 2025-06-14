using CMS.Controller;
using CMS.Model;
using System;
using System.Windows.Forms;

namespace CMS.View.Patient
{
    public partial class ViewPrescription : Form
    {
        private int _patientId;

        public ViewPrescription()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.ViewPrescription_Load);
        }

        public ViewPrescription(int patientId)
        {
            InitializeComponent();
            _patientId = patientId;
            this.Load += new System.EventHandler(this.ViewPrescription_Load);
        }

        // Form Load Event
        private void ViewPrescription_Load(object sender, EventArgs e)
        {
            // Make sure DataGridView is not auto-generating columns
            dgvPrescriptions.AutoGenerateColumns = false;

            // Load prescriptions for the patient
            LoadPrescriptions(_patientId);
        }

        // Load prescription data from controller
        private void LoadPrescriptions(int patientId)
        {
            var controller = new PrescriptionController();
            var prescriptions = controller.GetPrescriptionsByPatientId(patientId);

            // Clear previous rows
            dgvPrescriptions.Rows.Clear();

            // Add each prescription as a new row
            foreach (var p in prescriptions)
            {
                dgvPrescriptions.Rows.Add(
             p.PrescriptionDate.ToShortDateString(),
             p.Doctor.FullName,
            p.Diagnosis,
            p.Medicines
 );

            }
        }

        // Handle Back button click
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
