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
            dgvPrescriptions.AutoGenerateColumns = false;
            LoadPrescriptions(_patientId);
        }

        // Load prescription data from controller
        private void LoadPrescriptions(int patientId)
        {
            var controller = new PrescriptionController();
            var prescriptions = controller.GetPrescriptionsByPatientId(patientId);

            dgvPrescriptions.Rows.Clear();

            foreach (var p in prescriptions)
            {
                string doctorFullName = $"{p.Doctor.FirstName} {p.Doctor.LastName}";
                dgvPrescriptions.Rows.Add(
                    p.PrescriptionDate.ToShortDateString(),
                    doctorFullName,
                    p.Diagnosis,
                    p.Medicines
                );
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

