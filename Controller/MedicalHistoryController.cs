using CMS.Model;
using CMS.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace CMS.Controller
{
    public class MedicalHistoryController
    {
        public List<Patient> GetAllPatients()
        {
            List<Patient> patients = new List<Patient>();
            string query = "SELECT * FROM patients";

            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = new Patient
                            {
                                PatientId = Convert.ToInt32(reader["patient_id"]),
                                UserId = Convert.ToInt32(reader["user_id"]),
                                FirstName = reader["first_name"].ToString(),
                                LastName = reader["last_name"].ToString(),
                                Gender = reader["gender"].ToString(),
                                DateOfBirth = Convert.ToDateTime(reader["date_of_birth"]),
                                Email = reader["email"].ToString(),
                                CreatedAt = Convert.ToDateTime(reader["created_at"]),
                                UpdatedAt = reader["updated_at"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["updated_at"])
                            };
                            patients.Add(patient);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Failed to fetch patients: " + ex.Message);
                }
            }

            return patients;
        }

        public List<MedicalHistory> GetMedicalHistoryByPatientId(int patientId)
        {
            List<MedicalHistory> historyList = new List<MedicalHistory>();
            string query = "SELECT * FROM medical_history WHERE patient_id = @patientId";

            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@patientId", patientId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MedicalHistory history = new MedicalHistory
                                {
                                    HistoryId = Convert.ToInt32(reader["history_id"]),
                                    PatientId = Convert.ToInt32(reader["patient_id"]),
                                    DoctorId = Convert.ToInt32(reader["doctor_id"]),
                                    VisitDate = Convert.ToDateTime(reader["visit_date"]),
                                    Diagnosis = reader["diagnosis"].ToString(),
                                    Prescription = reader["prescription"].ToString(),
                                    Notes = reader["notes"].ToString()
                                };
                                historyList.Add(history);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Failed to fetch medical history: " + ex.Message);
                }
            }

            return historyList;
        }
    }
}