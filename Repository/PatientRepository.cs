using CMS.Model;
using CMS.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Repository
{
    internal class PatientRepository
    {
        public List<Patients> GetAllPatients()
        {
            List<Patients> patients = new List<Patients>();
            using (MySqlConnection con = DBHelper.GetConnection())
            {
                string query = "SELECT patient_id, first_name, last_name,  email FROM Patients";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Patients p = new Patients
                    {
                        Id = Convert.ToInt32(reader["patient_id"]),
                        FirstName = reader["first_name"].ToString(),
                        LastName = reader["last_name"].ToString(),

                        Email = reader["email"].ToString()
                    };
                    patients.Add(p);
                }
            }
            return patients;
        }

        public void DeletePatient(int id)
        {
            using (MySqlConnection con = DBHelper.GetConnection())
            {
                string query = "DELETE FROM Patients WHERE patient_id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        // Get a single patient by ID
        public Patients GetPatientById(int id)
        {
            Patients patient = null;
            using (MySqlConnection con = DBHelper.GetConnection())
            {
                string query = "SELECT patient_id, first_name, last_name, email FROM Patients WHERE patient_id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        patient = new Patients
                        {
                            Id = Convert.ToInt32(reader["patient_id"]),
                            FirstName = reader["first_name"].ToString(),
                            LastName = reader["last_name"].ToString(),
                            Email = reader["email"].ToString()
                        };
                    }
                }
            }
            return patient;
        }
        // Update a patient
        public void UpdatePatient(Patients p)
        {
            using (MySqlConnection con = DBHelper.GetConnection())
            {
                string query = "UPDATE Patients SET first_name = @FirstName, last_name = @LastName, email = @Email WHERE patient_id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FirstName", p.FirstName);
                cmd.Parameters.AddWithValue("@LastName", p.LastName);
                cmd.Parameters.AddWithValue("@Email", p.Email);
                cmd.Parameters.AddWithValue("@Id", p.Id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }


    }
}

