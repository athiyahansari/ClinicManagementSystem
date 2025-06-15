using CMS.Model;
using CMS.Utils;
using CMS.View;
using CMS.View.Patient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Controller
{

    public class PatientController
    {
        // Changed to directly reference the concrete form type
        private Edit_Patient_Profile _view;
        private Patients _model;

        // Default constructor for Manage_Patient (does not need a view specific to editing)
        public PatientController()
        {
            _model = new Patients();
        }

        // Constructor for Edit_Patient_Profile when adding a NEW patient
        // The view (Edit_Patient_Profile form) itself is passed here.
        public PatientController(Edit_Patient_Profile view) // Direct reference
        {
            _view = view;
            _model = new Patients(); // Initialize an empty model for new patient
        }

        // Constructor for Edit_Patient_Profile when editing an EXISTING patient
        // The view and the existing patient data are passed.
        public PatientController(Edit_Patient_Profile view, Patients patient) // Direct reference
        {
            _view = view;
            _model = patient; // Assign the provided patient to the model
            LoadInitialPatientProfile(patient); // Load this patient's data into the view
        }

        public void LoadInitialPatientProfile(Patients patient)
        {
            // IMPORTANT: Ensure _view is not null before trying to use it.
            if (_view == null)
            {
                MessageBox.Show("Internal Error: The patient edit form was not properly initialized.", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (patient == null || string.IsNullOrEmpty(patient.PatientId))
            {
                _view.DisplayMessage("No patient selected for editing!", "Error", MessageBoxIcon.Error);
                _view.CloseForm();
                return;
            }

            // The model is already set in the constructor for editing.
            // Now, tell the view to load this model's data into its controls.
            _view.LoadPatientData(_model);
        }

        public void SavePatientProfile()
        {
            // Always check _view for null before using it
            if (_view == null)
            {
                MessageBox.Show("Internal Error: Form view is not initialized for saving.", "Error", (MessageBoxButtons)MessageBoxIcon.Error);
                return;
            }

            // Populate the model from the view's properties.
            // These properties must exist in your Edit_Patient_Profile form.
            _model.FirstName = _view.FirstName;
            _model.LastName = _view.LastName;
            _model.DateOfBirth = _view.PatientDateOfBirth;
            _model.PhoneNumber = _view.PatientPhoneNumber;
            _model.Email = _view.Email;
            _model.Gender = _view.Gender;

            if (_model.IsValid())
            {
                try
                {
                    if (string.IsNullOrEmpty(_model.PatientId))
                    {
                        // This branch is for adding a new patient.
                        // Based on your previous code, you wanted to prevent adding from the edit screen.
                        _view.DisplayMessage("Not Allowed\nThis screen is only for editing existing patients. Use 'Add' to create a new one.", "Warning", MessageBoxIcon.Warning);
                        return;
                        // If you DID want to allow adding from this screen, you would call AddPatient(_model) here.
                    }
                    else
                    {
                        // PatientId exists, so update the existing patient
                        UpdatePatient(_model);
                        _view.DisplayMessage("Patient profile saved successfully!", "Success", MessageBoxIcon.Information);
                        _view.CloseForm();
                    }
                }
                catch (Exception ex)
                {
                    _view.DisplayMessage($"An error occurred while saving: {ex.Message}", "Error", MessageBoxIcon.Error);
                }
            }
            else
            {
                // Display validation errors if the model is not valid
                _view.DisplayMessage("Please fill in all required fields and ensure data is valid.", "Validation Error", MessageBoxIcon.Warning);
            }
        }

        public void CancelEdit()
        {
            if (_view != null)
            {
                _view.DisplayMessage("Edit cancelled.", "Cancelled", MessageBoxIcon.Information);
                _view.CloseForm();
            }
        }

        public List<Patients> GetAllPatients()
        {
            List<Patients> patients = new List<Patients>();
            using (MySqlConnection con = DBHelper.GetConnection())
            {
                // Ensure all columns are explicitly selected for clarity and to match model properties
                string query = "SELECT patient_id, user_id, first_name, last_name, gender, date_of_birth, email, phonenumber FROM patients";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Patients p = new Patients
                    {
                        PatientId = reader["patient_id"].ToString(),
                        UserId = reader["user_id"] != DBNull.Value ? Convert.ToInt32(reader["user_id"]) : 0, // Handle DBNull for int
                        FirstName = reader["first_name"].ToString(),
                        LastName = reader["last_name"].ToString(),
                        Email = reader["email"].ToString(),
                        Gender = reader["gender"].ToString(),
                        PhoneNumber = reader["phonenumber"].ToString(),
                        DateOfBirth = reader["date_of_birth"] != DBNull.Value
                            ? Convert.ToDateTime(reader["date_of_birth"])
                            : DateTime.Today // Default date if DBNull
                    };
                    patients.Add(p);
                }
            }
            return patients;
        }

        public void AddPatient(Patients p)
        {
            using (MySqlConnection con = DBHelper.GetConnection())
            {
                string query = @"INSERT INTO patients
    (patient_id, first_name, last_name, email, gender, date_of_birth, phonenumber)
    VALUES (@id, @first, @last, @email, @gender, @dob, @phone)";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", p.PatientId);
                cmd.Parameters.AddWithValue("@first", p.FirstName);
                cmd.Parameters.AddWithValue("@last", p.LastName);
                cmd.Parameters.AddWithValue("@email", p.Email);
                cmd.Parameters.AddWithValue("@gender", p.Gender);
                cmd.Parameters.AddWithValue("@dob", p.DateOfBirth);
                cmd.Parameters.AddWithValue("@phone", p.PhoneNumber);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdatePatient(Patients p)
        {
            using (MySqlConnection con = DBHelper.GetConnection())
            {
                string query = @"UPDATE patients SET
                first_name = @first,
                last_name = @last,
                email = @email,
                gender = @gender,
                date_of_birth = @dob,
                phonenumber = @phone
                WHERE patient_id = @id"; // Make sure 'patient_id' matches your DB column name
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@first", p.FirstName);
                cmd.Parameters.AddWithValue("@last", p.LastName);
                cmd.Parameters.AddWithValue("@email", p.Email);
                cmd.Parameters.AddWithValue("@gender", p.Gender);
                cmd.Parameters.AddWithValue("@dob", p.DateOfBirth);
                cmd.Parameters.AddWithValue("@phone", p.PhoneNumber);
                cmd.Parameters.AddWithValue("@id", p.PatientId); // Ensure PatientId is part of the WHERE clause
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeletePatient(string id) // Changed to string as patient_id is string
        {
            using (MySqlConnection con = DBHelper.GetConnection())
            {
                string query = "DELETE FROM patients WHERE patient_id = @id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}









