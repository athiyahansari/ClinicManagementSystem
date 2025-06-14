using CMS.Model;
using CMS.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace CMS.Controller
{
    public class PrescriptionController
    {
        // Get list of prescriptions for a specific patient
        public List<Prescription> GetPrescriptionsByPatientId(int patientId)
        {
            var prescriptions = new List<Prescription>();

            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        p.prescription_id, 
                        p.prescription_date, 
                        p.diagnosis, 
                        p.medicines,
                        d.doctor_id, 
                        d.full_name AS doctor_name
                    FROM prescriptions p
                    JOIN doctors d ON p.doctor_id = d.doctor_id
                    WHERE p.patient_id = @patientId";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@patientId", patientId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var prescription = new Prescription
                            {
                                //PrescriptionID = Convert.ToInt32(reader["prescription_id"]),
                                PrescriptionDate = Convert.ToDateTime(reader["prescription_date"]),
                                Diagnosis = reader["diagnosis"].ToString(),
                                Medicines = reader["medicines"].ToString(),
                                Doctor = new Doctor
                                {
                                    Id = Convert.ToInt32(reader["doctor_id"]),
                                    Name = reader["doctor_name"].ToString() // Corrected here
                                }
                            };

                            prescriptions.Add(prescription);
                        }
                    }
                }
            }

            return prescriptions;
        }
    }
}
