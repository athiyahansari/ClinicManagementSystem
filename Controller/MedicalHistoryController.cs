using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using ClinicManagementSystem.Models;

namespace ClinicManagementSystem.Controllers
{
    public class MedicalHistoryController
    {
        
        //connect to db for app.config
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

        public List<MedicalHistory> GetMedicalHistoryByPatientName(string patientName)
        {
            List<MedicalHistory> historyList = new List<MedicalHistory>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Step 1: Get patient ID from patients table
                string getPatientIdQuery = "SELECT id FROM patients WHERE name = @name LIMIT 1";
                int patientId = -1;

                using (MySqlCommand cmd = new MySqlCommand(getPatientIdQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@name", patientName);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        patientId = Convert.ToInt32(result);
                    else
                        return historyList; // patient not found
                }

                // Step 2: Get medical history
                string query = @"SELECT mh.id, mh.patient_id, p.name, mh.diagnosis, mh.treatment, mh.date 
                                 FROM medical_history mh 
                                 INNER JOIN patients p ON mh.patient_id = p.id 
                                 WHERE mh.patient_id = @patientId";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@patientId", patientId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            historyList.Add(new MedicalHistory
                            {
                                HistoryID = reader.GetInt32("id"),
                                PatientID = reader.GetInt32("patient_id"),
                                PatientName = reader.GetString("name"),
                                Diagnosis = reader.GetString("diagnosis"),
                                Treatment = reader.GetString("treatment"),
                                Date = reader.GetDateTime("date")
                            });
                        }
                    }
                }
            }

            return historyList;
        }
    }
}
