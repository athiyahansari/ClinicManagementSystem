using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ClinicManagementSystem.Models;
using System.Windows.Forms;
using CMS.Model;

namespace ClinicManagementSystem.Controllers
{
    public class MedicalHistoryController
    {
        // Connect to DB using app.config connection string
        private string connectionString = System.Configuration.ConfigurationManager
            .ConnectionStrings["MySqlConnection"].ConnectionString;


        //get medical history by patient name





        public List<MedicalHistory> GetMedicalHistoryByPatientName(string fullName)
        {
            List<MedicalHistory> historyList = new List<MedicalHistory>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Step 1: Get patient_id from full name
                    string patientIdQuery = "SELECT patient_id FROM patients WHERE CONCAT(first_name, ' ', last_name) = @fullName";
                    int foundpatientId = -1;

                    string query = @"
            SELECT mh.history_id, mh.visit_date, mh.diagnosis, mh.prescription, mh.notes,
                   d.full_name AS doctor_full_name
            FROM medical_history mh
            INNER JOIN doctors d ON mh.doctor_id = d.doctor_id
            WHERE mh.patient_id = @patientId
            ORDER BY mh.visit_date DESC;
";



                    //Get patient ID from that name
                    string getIdQuery = "SELECT patient_id FROM patients WHERE CONCAT(first_name, ' ', last_name) = @fullName";
                    int patientId = -1;



                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@patientId", patientId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string doctorFirstName = reader.GetString("doctor_first_name");
                                string doctorLastName = reader.GetString("doctor_last_name");
                                string doctorFullName = doctorFirstName + " " + doctorLastName;

                                historyList.Add(new MedicalHistory
                                {
                                    HistoryID = reader.GetInt32("history_id"),
                                    PatientID = patientId,
                                    PatientName = fullName,
                                    Date = reader.GetDateTime("visit_date"),
                                    Diagnosis = reader.GetString("diagnosis"),
                                    Prescription = reader.GetString("prescription"),
                                    Notes = reader.IsDBNull(reader.GetOrdinal("notes")) ? "" : reader.GetString("notes"),
                                    DoctorName = doctorFullName
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving medical history: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return historyList;

        }
    }
}
