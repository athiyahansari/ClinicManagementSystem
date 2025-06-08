using CMS.Model;
using CMS.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Controller
{
    public class PrescriptionController
    {
        // Get list of prescriptions for a specific patient
        public List<Prescription> GetPrescriptionsByPatientId(int patientId)
        {
            var prescriptions = new List<Prescription>(); // List to store results

            using (var conn = DBHelper.GetConnection()) // Get MySQL connection
            {
                conn.Open();

                // SQL to join Prescriptions and Doctors to get doctor name
                string query = @"SELECT p.PrescriptionID, p.PrescriptionDate, p.Diagnosis, p.Medicines,
                                        d.DoctorID, d.Name AS DoctorName
                                 FROM Prescriptions p
                                 JOIN Doctors d ON p.DoctorID = d.DoctorID
                                 WHERE p.PatientID = @patientId";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@patientId", patientId); // Prevent SQL injection

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var prescription = new Prescription
                            {
                                PrescriptionID = Convert.ToInt32(reader["PrescriptionID"]),
                                PrescriptionDate = Convert.ToDateTime(reader["PrescriptionDate"]),
                                Diagnosis = reader["Diagnosis"].ToString(),
                                Medicines = reader["Medicines"].ToString(),
                                Doctor = new Doctor
                                {
                                    Id = Convert.ToInt32(reader["DoctorID"]),
                                    Name = reader["DoctorName"].ToString()
                                }
                            };

                            prescriptions.Add(prescription); // Add to list
                        }
                    }
                }
            }

            return prescriptions; // Return list to caller
        }
    }
}