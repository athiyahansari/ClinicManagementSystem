using CMS.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace CMS.Controller
{
    public class MedicalHistoryController
    {
        private readonly string connectionString = "server=localhost;user id=root;password=;database=clinic_db";

        // Now returns a list of tuples (MedicalHistory, DoctorName)
        public List<(MedicalHistory, string)> GetMedicalHistoryByPatientName(string fullName)
        {
            var historyList = new List<(MedicalHistory, string)>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        mh.*, d.full_name AS doctor_name
                    FROM 
                        medical_history mh
                    JOIN 
                        patients p ON mh.patient_id = p.patient_id
                    JOIN 
                        doctors d ON mh.doctor_id = d.doctor_id
                    WHERE 
                        CONCAT(p.first_name, ' ', p.last_name) = @fullName";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fullName", fullName);
                conn.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var history = new MedicalHistory
                        {
                            HistoryId = Convert.ToInt32(reader["history_id"]),
                            PatientId = Convert.ToInt32(reader["patient_id"]),
                            DoctorId = Convert.ToInt32(reader["doctor_id"]),
                            VisitDate = Convert.ToDateTime(reader["visit_date"]),
                            Diagnosis = reader["diagnosis"].ToString(),
                            Prescription = reader["prescription"].ToString(),
                            Notes = reader["notes"].ToString()
                        };

                        string doctorName = reader["doctor_name"].ToString();
                        historyList.Add((history, doctorName));
                    }
                }
            }

            return historyList;
        }
    }
}
