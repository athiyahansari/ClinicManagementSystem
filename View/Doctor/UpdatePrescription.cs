using CMS.Controllers;
using CMS.Model;
using System;
using System.Windows.Forms;

namespace CMS.View.Doctor
{   
    // The popup (dialog message) that appears on the main form CreatePrescription , to update the details.
    public partial class UpdatePrescription : Form
    {
        private int prescriptionId;
        private int doctorId;

        public UpdatePrescription(int prescriptionId, int patientId, string patientName, string diagnosis, string medicines, DateTime prescriptionDate, int doctorId)
        {
            InitializeComponent();
            this.prescriptionId = prescriptionId;
            this.doctorId = doctorId;

            txtPatientID.Text = patientId.ToString();
            txtPatientName.Text = patientName;
            txtDiagnosis.Text = diagnosis;
            txtMedicines.Text = medicines;
            dtpDate.Value = prescriptionDate;
        }

        // Save Button
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var updatedPrescription = new Prescriptions(
                    prescriptionId,
                    int.Parse(txtPatientID.Text),
                    doctorId,
                    txtDiagnosis.Text.Trim(),
                    txtMedicines.Text.Trim(),
                    dtpDate.Value
                );

                PrescriptionsController.UpdatePrescription(updatedPrescription);
                MessageBox.Show("Prescription updated successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating: " + ex.Message);
            }
        }

        // Cancel Button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
