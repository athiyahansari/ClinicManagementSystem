using CMS.Controller;
using CMS.Model;
using CMS.Utils;
using CMS.View.Patient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CMS.View.Admin
{
    public partial class Manage_Patient : Form
    {
        PatientController controller = new PatientController();

        public Manage_Patient()
        {
            InitializeComponent();
            LoadPatientsIntoGrid();
            LoadPatients();



        }

        private void LoadPatientsIntoGrid()
        {
            dataGridViewPatients.Rows.Clear();
            List<Patients> patients = controller.GetAllPatients();

            foreach (var p in patients)
            {
                dataGridViewPatients.Rows.Add(p.PatientId, p.FirstName, p.LastName, p.Email);
            }

            // Hide patient_id column if it exists
            if (dataGridViewPatients.Columns["Patient_Id"] != null)
                dataGridViewPatients.Columns["Patient_Id"].Visible = false;
        }
        private void LoadPatients()
        {
            List<Patients> patients = controller.GetAllPatients();
            dataGridViewPatients.Rows.Clear();

            foreach (var p in patients)
            {
                dataGridViewPatients.Rows.Add(p.PatientId, p.FirstName, p.LastName, p.Email);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new Edit_Patient_Profile();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadPatientsIntoGrid(); // ✅ instead of LoadPatients()
            }

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (dataGridViewPatients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a patient.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow = dataGridViewPatients.SelectedRows[0];

            // Safely get the patient ID
            if (selectedRow.Cells["Patient_Id"].Value == null)
            {
                MessageBox.Show("Selected patient does not have a valid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string id = selectedRow.Cells["Patient_Id"].Value.ToString();

            // Get the full patient object
            var patient = controller.GetAllPatients().Find(p => p.PatientId == id);

            if (patient != null)
            {
                var form = new Edit_Patient_Profile(patient); // 🧠 Make sure Edit_Patient_Profile has this constructor
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadPatients(); // ✅ Refresh the patient list after editing
                }
            }
            else
            {
                MessageBox.Show("Patient not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a patient to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ensure this column name matches exactly what's in your DataGridView's 'Name' property for the Patient ID column.
            // I'm using "Patient_Id" as per your last stated code, but verify it against your DataGridView's column 'Name' property.
            string Patient_Id_From_Grid = dataGridViewPatients.SelectedRows[0].Cells["Patient_Id"].Value.ToString();


            using (MySqlConnection con = DBHelper.GetConnection())
            {
                con.Open();

                // 1. Delete dependent notifications (which depend on appointments)
                string deleteNotificationsQuery = "DELETE FROM notifications WHERE appointment_id IN (SELECT appointment_id FROM appointments WHERE patient_id = @patientId)";
                using (MySqlCommand cmdNotifications = new MySqlCommand(deleteNotificationsQuery, con))
                {
                    cmdNotifications.Parameters.AddWithValue("@patientId", Patient_Id_From_Grid);
                    cmdNotifications.ExecuteNonQuery();
                }

                // 2. Delete all appointments for the patient (which depend on patients)
                string deleteAppointmentsQuery = "DELETE FROM appointments WHERE patient_id = @patientId";
                using (MySqlCommand cmdAppointments = new MySqlCommand(deleteAppointmentsQuery, con))
                {
                    cmdAppointments.Parameters.AddWithValue("@patientId", Patient_Id_From_Grid);
                    cmdAppointments.ExecuteNonQuery();
                }

                // 3. Delete dependent medical history records (which depend on patients)
                string deleteMedicalHistoryQuery = "DELETE FROM medical_history WHERE patient_id = @patientId"; // Assuming patient_id in medical_history
                using (MySqlCommand cmdMedicalHistory = new MySqlCommand(deleteMedicalHistoryQuery, con))
                {
                    cmdMedicalHistory.Parameters.AddWithValue("@patientId", Patient_Id_From_Grid);
                    cmdMedicalHistory.ExecuteNonQuery();
                }

                // ----------------------------------------------------------------------
                // NEW STEP: 4. Delete dependent prescriptions records (which depend on patients)
                string deletePrescriptionsQuery = "DELETE FROM prescriptions WHERE patient_id = @patientId"; // Assuming patient_id in prescriptions
                using (MySqlCommand cmdPrescriptions = new MySqlCommand(deletePrescriptionsQuery, con))
                {
                    cmdPrescriptions.Parameters.AddWithValue("@patientId", Patient_Id_From_Grid);
                    cmdPrescriptions.ExecuteNonQuery();
                }
                // ----------------------------------------------------------------------

                // 5. Delete the patient itself
                // Confirm the column name in the `patients` table for the WHERE clause (e.g., Patient_Id or patient_id)
                // Confirm the parameter name (@Patient_Id or @patientId)
                string deletePatientQuery = "DELETE FROM patients WHERE Patient_Id = @Patient_Id";
                using (MySqlCommand cmdPatient = new MySqlCommand(deletePatientQuery, con))
                {
                    cmdPatient.Parameters.AddWithValue("@Patient_Id", Patient_Id_From_Grid);
                    cmdPatient.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Patient removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadPatientsIntoGrid(); // refresh grid
        }






        private void dataGridViewPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMyprofile_Click(object sender, EventArgs e)
        {
            this.Hide();  // Hide the current form
            Edit_Patient_Profile profileForm = new Edit_Patient_Profile();
            profileForm.ShowDialog();
            this.Show(); // Show again after profile closes
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();  // Hide the current form
            LoginForm profileForm = new LoginForm();
            profileForm.ShowDialog();
            this.Show(); // Show again after profile closes
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();  // Hide the current form
            adminbookappointment profileForm = new adminbookappointment();
            profileForm.ShowDialog();
            this.Show(); // Show again after profile closes
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            this.Hide();  // Hide the current form
            ViewDoctors profileForm = new ViewDoctors();
            profileForm.ShowDialog();
            this.Show(); // Show again after profile closes

        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            this.Hide();  // Hide the current form
            Manage_Patient profileForm = new Manage_Patient();
            profileForm.ShowDialog();
            this.Show(); // Show again after profile closes
        }
    }
}
