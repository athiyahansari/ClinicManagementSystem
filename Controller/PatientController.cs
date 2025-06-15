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
        private Edit_Patient_Profile _view;
        private Patients _model;

        // ✅ Default constructor for Manage_Patient
        public PatientController()
        {
            _model = new Patients();
        }

        // Constructor for Edit_Patient_Profile
        public PatientController(Edit_Patient_Profile view, Patients patient)
        {
            _view = view;
            _model = new Patients();
            LoadInitialPatientProfile(patient);
        }
        public PatientController(Edit_Patient_Profile view)
        {
            _view = view;
            _model = new Patients();
        }


        public void LoadInitialPatientProfile(Patients patient)
        {
            if (patient == null || string.IsNullOrEmpty(patient.PatientId))
            {
                _view.DisplayMessage("No patient selected for editing!", "Error", MessageBoxIcon.Error);
                _view.CloseForm();
                return;
            }

            _model = patient;
            _view.LoadPatientData(_model);
        }

        public void SavePatientProfile()
        {
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
                        _view.DisplayMessage("Not Allowed\nThis screen is only for editing an existing patient. Cannot create a new one here.", "Warning", MessageBoxIcon.Warning);
                        return;
                    }
                    UpdatePatient(_model);
                    _view.DisplayMessage("Patient profile saved successfully!", "Success", MessageBoxIcon.Information);
                    _view.CloseForm();
                }
                catch (Exception ex)
                {
                    _view.DisplayMessage($"An error occurred while saving: {ex.Message}", "Error", MessageBoxIcon.Error);
                }
            }
            else
            {
                _view.DisplayMessage("Please fill in all required fields and ensure data is valid.", "Validation Error", MessageBoxIcon.Warning);
            }
        }

        public void CancelEdit()
        {
            _view.DisplayMessage("Edit cancelled.", "Cancelled", MessageBoxIcon.Information);
            _view.CloseForm();
        }

        public List<Patients> GetAllPatients()
        {
            List<Patients> patients = new List<Patients>();
            using (MySqlConnection con = DBHelper.GetConnection())
            {
                string query = "SELECT * FROM patients";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Patients p = new Patients
                    {
                        PatientId = reader["patient_id"].ToString(),
                        UserId = Convert.ToInt32(reader["user_id"]),
                        FirstName = reader["first_name"].ToString(),
                        LastName = reader["last_name"].ToString(),
                        Email = reader["email"].ToString(),
                        Gender = reader["gender"].ToString(),
                        PhoneNumber = reader["phonenumber"].ToString(),
                      


                        DateOfBirth = reader["date_of_birth"] != DBNull.Value
                    ? Convert.ToDateTime(reader["date_of_birth"])
                    : DateTime.Today
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
                WHERE patient_id = @id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@first", p.FirstName);
                cmd.Parameters.AddWithValue("@last", p.LastName);
                cmd.Parameters.AddWithValue("@email", p.Email);
                cmd.Parameters.AddWithValue("@gender", p.Gender);
                cmd.Parameters.AddWithValue("@dob", p.DateOfBirth);
                cmd.Parameters.AddWithValue("@phone", p.PhoneNumber);
                cmd.Parameters.AddWithValue("@id", p.PatientId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeletePatient(int id)
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






