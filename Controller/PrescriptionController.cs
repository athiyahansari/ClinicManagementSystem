using CMS.Controller;
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

            try
            {
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
                            d.full_name
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
                                var doctorFullName = reader["full_name"].ToString();
                                string firstName = "";
                                string lastName = "";

                                if (!string.IsNullOrWhiteSpace(doctorFullName))
                                {
                                    var names = doctorFullName.Split(' ');
                                    firstName = names[0];
                                    lastName = names.Length > 1 ? string.Join(" ", names, 1, names.Length - 1) : "";
                                }

                                var prescription = new Prescription
                                {
                                    PrescriptionID = Convert.ToInt32(reader["prescription_id"]),
                                    PrescriptionDate = Convert.ToDateTime(reader["prescription_date"]),
                                    Diagnosis = reader["diagnosis"].ToString(),
                                    Medicines = reader["medicines"].ToString(),
                                    Doctor = new Doctor
                                    {
                                        DoctorID = Convert.ToInt32(reader["doctor_id"]),
                                        FirstName = firstName,
                                        LastName = lastName
                                    }
                                };

                                prescriptions.Add(prescription);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Optionally log the error or rethrow
                throw new Exception("Error retrieving prescriptions: " + ex.Message, ex);
            }

            return prescriptions;
        }
    }
}


