using CMS.Controllers;
using CMS.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace CMS.View.Doctor
{
    public partial class CreatePrescription : Form
    {
        private int currentPrescriptionID = -1;
        private int doctorID = 1; // Default doctor ID for testing

        public CreatePrescription()
        {
            InitializeComponent();
            AttachNavButtonEvents(); // Attach button click events at runtime
        }

        private void CreatePrescription_Load(object sender, EventArgs e)
        {
            LoadPrescriptionData();
        }

        private void LoadPrescriptionData()
        {
            dgvPrescriptions.Rows.Clear();

            DataTable dt = PrescriptionsController.GetPrescriptionWithPatientName(doctorID);
            foreach (DataRow row in dt.Rows)
            {
                dgvPrescriptions.Rows.Add(
                    Convert.ToDateTime(row["prescription_date"]).ToString("yyyy-MM-dd"),
                    row["patient_id"].ToString(),
                    row["patient_name"].ToString(),
                    row["diagnosis"].ToString(),
                    row["medicines"].ToString(),
                    "Update"
                );
            }
        }

        // Validation Checking
        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtPatientID.Text) || !int.TryParse(txtPatientID.Text, out _))
            {
                MessageBox.Show("Please enter a valid numeric Patient ID.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPatientName.Text))
            {
                MessageBox.Show("Patient Name cannot be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDiagnosis.Text))
            {
                MessageBox.Show("Diagnosis cannot be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMedicines.Text))
            {
                MessageBox.Show("Medicines field cannot be empty.");
                return false;
            }

            if (dtpDate.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Prescription date cannot be in the future.");
                return false;
            }

            return true;
        }

        // Add Button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            var patientId = int.Parse(txtPatientID.Text);

            if (!PrescriptionsController.PatientExists(patientId))
            {
                MessageBox.Show("Patient ID does not exist.");
                return;
            }

            var newPrescription = new Prescriptions(
                0,
                patientId,
                doctorID,
                txtDiagnosis.Text.Trim(),
                txtMedicines.Text.Trim(),
                dtpDate.Value
            );

            PrescriptionsController.AddPrescription(newPrescription);
            MessageBox.Show("Prescription added successfully.");
            LoadPrescriptionData();
            ClearForm();
        }

        // Update Button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (currentPrescriptionID == -1)
            {
                MessageBox.Show("Please select a prescription to update.");
                return;
            }

            if (!ValidateForm())
                return;

            try
            {
                var updatedPrescription = new Prescriptions(
                    currentPrescriptionID,
                    int.Parse(txtPatientID.Text),
                    doctorID,
                    txtDiagnosis.Text.Trim(),
                    txtMedicines.Text.Trim(),
                    dtpDate.Value
                );

                PrescriptionsController.UpdatePrescription(updatedPrescription);
                MessageBox.Show("Prescription updated successfully.");
                LoadPrescriptionData();
                ClearForm();
                btnAdd.Enabled = true;
                currentPrescriptionID = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating prescription: " + ex.Message);
            }
        }


        private void ClearForm()
        {
            txtPatientID.Clear();
            txtDiagnosis.Clear();
            txtMedicines.Clear();
            txtPatientName.Clear();
            dtpDate.Value = DateTime.Today;
            btnAdd.Enabled = true;
            currentPrescriptionID = -1;
        }

        private void dgvPrescriptions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPrescriptions.Columns[e.ColumnIndex].Name == "UpdateColumn")
            {
                DataGridViewRow row = dgvPrescriptions.Rows[e.RowIndex];

                int patientId = int.Parse(row.Cells["ptID"].Value.ToString());
                string patientName = row.Cells["PtName"].Value.ToString();
                string diagnosis = row.Cells["disease"].Value.ToString();
                string medicines = row.Cells["medicine"].Value.ToString();
                DateTime date = Convert.ToDateTime(row.Cells["date"].Value);

                int prescriptionId = PrescriptionsController.GetPrescriptionID(doctorID, patientId, date);
                if (prescriptionId == -1)
                {
                    MessageBox.Show("Prescription ID not found.");
                    return;
                }

                using (var updateForm = new UpdatePrescription(
                    prescriptionId,
                    patientId,
                    patientName,
                    diagnosis,
                    medicines,
                    date,
                    doctorID
                ))
                {
                    if (updateForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadPrescriptionData();
                    }
                }
            }
        }

        private void txtDiagnosis_TextChanged(object sender, EventArgs e)
        {
            // Optional logic
      
        }

        // Attach event handlers to side navigation buttons
        private void AttachNavButtonEvents()
        {
            btnMyAppointments.Click += BtnAppointments_Click;
            btnPrescriptions.Click += BtnPrescriptions_Click;
            btnMyProfile.Click += BtnMyProfile_Click;
            btnLogout.Click += BtnLogout_Click;
        }

        // Navigate to Appointments form
        private void BtnAppointments_Click(object sender, EventArgs e)
        {
             //AppointmentSchedule appointmentForm = new AppointmentSchedule();   
             //appointmentForm.Show();
             //this.Hide(); // Hide current form
        }

        // Already on Prescription create - optionally refresh prescriptions
        private void BtnPrescriptions_Click(object sender, EventArgs e)
        {
            //LoadPrescriptionData(); // Refresh data
        }

        // Navigate to My Profile form
        private void BtnMyProfile_Click(object sender, EventArgs e)
        {
             //DocViewProfile profileForm = new DocViewProfile();
             //profileForm.Show();
             //this.Hide();
        }

        // Log out and go back to Login form
        private void BtnLogout_Click(object sender, EventArgs e)
        {
             //LoginForm loginForm = new LoginForm();
             //loginForm.Show();
             //this.Close(); // Close current form
        }

    }
}

   


