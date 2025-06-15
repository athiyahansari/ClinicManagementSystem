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
    {// This controller instance is for managing the patient list (e.g., GetAllPatients)
        PatientController _listController = new PatientController(); // <-- This is your controller instance
                                                                     // ...
        public Manage_Patient()
        {
            InitializeComponent();
            SetupDataGridViewColumns(); // Properly set up DataGridView columns
            LoadPatientsIntoGrid(); // Load data initially when the form opens
        }
        private void SetupDataGridViewColumns()
        {
            // Clear any existing columns from designer or previous runs to avoid duplicates
            dataGridViewPatients.Columns.Clear();

            // Add columns programmatically. The 'Name' property is crucial for accessing cells.
            dataGridViewPatients.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Patient_Id", HeaderText = "Patient ID", Visible = false }); // Hidden but used for logic
            dataGridViewPatients.Columns.Add(new DataGridViewTextBoxColumn() { Name = "First_Name", HeaderText = "First Name" });
            dataGridViewPatients.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Last_Name", HeaderText = "Last Name" });
            dataGridViewPatients.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Email", HeaderText = "Email" });
            dataGridViewPatients.Columns.Add(new DataGridViewTextBoxColumn() { Name = "DateOfBirth", HeaderText = "Date of Birth" });
            dataGridViewPatients.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Gender", HeaderText = "Gender" });
            dataGridViewPatients.Columns.Add(new DataGridViewTextBoxColumn() { Name = "PhoneNumber", HeaderText = "Phone Number" });

            // Optional: Auto-size columns to fill available space
            foreach (DataGridViewColumn col in dataGridViewPatients.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
            private void LoadPatientsIntoGrid()
        {
            dataGridViewPatients.Rows.Clear(); // Clear existing rows before reloading
            List<Patients> patients = _listController.GetAllPatients(); // Get all patients from controller

            foreach (var p in patients)
            {
                // Add all patient properties to the corresponding columns in the DataGridView
                dataGridViewPatients.Rows.Add(
                    p.PatientId,
                    p.FirstName,
                    p.LastName,
                    p.Email,
                    p.DateOfBirth.ToShortDateString(), // Format date for display (e.g., 1/1/2000)
                    p.Gender,
                    p.PhoneNumber
                );
            }
        }
        private void LoadPatients()
        {
            List<Patients> patients = _listController.GetAllPatients();
            dataGridViewPatients.Rows.Clear();

            foreach (var p in patients)
            {
                dataGridViewPatients.Rows.Add(p.PatientId, p.FirstName, p.LastName, p.Email ,p.DateOfBirth,p.PhoneNumber);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Open the Edit_Patient_Profile form for adding a new patient
            var form = new Edit_Patient_Profile(); // This uses the constructor for new patients (no Patient object passed)
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadPatientsIntoGrid(); // Refresh the grid if a new patient was successfully added
            }

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {


            if (dataGridViewPatients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a patient to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dataGridViewPatients.SelectedRows[0];

            // Safely get the patient ID from the hidden "Patient_Id" column
            if (selectedRow.Cells["Patient_Id"].Value == null)
            {
                MessageBox.Show("Selected patient does not have a valid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string patientIdToEdit = selectedRow.Cells["Patient_Id"].Value.ToString();

            // Retrieve the full patient object using the controller's data access method.
            // This ensures you have all patient details, even those not displayed in the grid.
            var patientToEdit = _listController.GetAllPatients().Find(p => p.PatientId == patientIdToEdit);

            if (patientToEdit != null)
            {
                // Open the Edit_Patient_Profile form, passing the existing patient object
                var form = new Edit_Patient_Profile(patientToEdit); // This uses the constructor for editing existing patients
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadPatientsIntoGrid(); // Refresh the grid after a successful edit
                }
            }
            else
            {
                MessageBox.Show("Patient not found in the database. It might have been deleted by another user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a patient to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridViewPatients.SelectedRows[0].Cells["Patient_Id"].Value == null)
            {
                MessageBox.Show("Selected patient does not have a valid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string patientIdToDelete = dataGridViewPatients.SelectedRows[0].Cells["Patient_Id"].Value.ToString();

            DialogResult confirmResult = MessageBox.Show(
                "Are you sure you want to delete this patient and ALL associated data (appointments, medical history, prescriptions, notifications)? This action cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // Use a transaction for atomic deletion of related data to maintain data integrity
                    using (MySqlConnection con = DBHelper.GetConnection())
                    {
                        con.Open();
                        MySqlTransaction transaction = con.BeginTransaction(); // Start a database transaction

                        try
                        {
                            // Delete dependent records in correct order (children before parents)
                            // 1. Delete notifications related to appointments of this patient
                            string deleteNotificationsQuery = "DELETE FROM notifications WHERE appointment_id IN (SELECT appointment_id FROM appointments WHERE patient_id = @patientId)";
                            using (MySqlCommand cmdNotifications = new MySqlCommand(deleteNotificationsQuery, con, transaction))
                            {
                                cmdNotifications.Parameters.AddWithValue("@patientId", patientIdToDelete);
                                cmdNotifications.ExecuteNonQuery();
                            }

                            // 2. Delete all appointments for this patient
                            string deleteAppointmentsQuery = "DELETE FROM appointments WHERE patient_id = @patientId";
                            using (MySqlCommand cmdAppointments = new MySqlCommand(deleteAppointmentsQuery, con, transaction))
                            {
                                cmdAppointments.Parameters.AddWithValue("@patientId", patientIdToDelete);
                                cmdAppointments.ExecuteNonQuery();
                            }

                            // 3. Delete medical history records for this patient
                            string deleteMedicalHistoryQuery = "DELETE FROM medical_history WHERE patient_id = @patientId";
                            using (MySqlCommand cmdMedicalHistory = new MySqlCommand(deleteMedicalHistoryQuery, con, transaction))
                            {
                                cmdMedicalHistory.Parameters.AddWithValue("@patientId", patientIdToDelete);
                                cmdMedicalHistory.ExecuteNonQuery();
                            }

                            // 4. Delete prescriptions records for this patient
                            string deletePrescriptionsQuery = "DELETE FROM prescriptions WHERE patient_id = @patientId";
                            using (MySqlCommand cmdPrescriptions = new MySqlCommand(deletePrescriptionsQuery, con, transaction))
                            {
                                cmdPrescriptions.Parameters.AddWithValue("@patientId", patientIdToDelete);
                                cmdPrescriptions.ExecuteNonQuery();
                            }

                            // 5. Finally, delete the patient record itself
                            string deletePatientQuery = "DELETE FROM patients WHERE patient_id = @patientId"; // Ensure this column name matches your DB
                            using (MySqlCommand cmdPatient = new MySqlCommand(deletePatientQuery, con, transaction))
                            {
                                cmdPatient.Parameters.AddWithValue("@patientId", patientIdToDelete);
                                cmdPatient.ExecuteNonQuery();
                            }

                            transaction.Commit(); // Commit all changes if successful
                            MessageBox.Show("Patient and all related data removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback(); // Rollback if any error occurs
                            MessageBox.Show($"An error occurred during deletion: {ex.Message}\nChanges have been rolled back.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"A database connection error occurred: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadPatientsIntoGrid(); // Refresh the grid to reflect the current state (after deletion or rollback)
            }
        }
    






        private void dataGridViewPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // This event handler can be left empty if you don't need specific logic
            // when a user clicks on the content of a cell.
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
