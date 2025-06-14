using CMS.Model;

using CMS.Utils;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CMS.Controllers
{
    public class PrescriptionsController
    {
        public static List<Prescriptions> GetPrescriptionsByDoctor(int doctorId)
        {
            List<Prescriptions> prescriptions = new List<Prescriptions>();
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT p.prescription_id, p.patient_id, p.diagnosis, p.medicines, 
                                        p.prescription_date
                                 FROM prescriptions p
                                 WHERE p.doctor_id = @DoctorID";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DoctorID", doctorId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Create a Prescriptions object and add to list
                            prescriptions.Add(new Prescriptions(
                                reader.GetInt32("prescription_id"),
                                reader.GetInt32("patient_id"),
                                doctorId,
                                reader.GetString("diagnosis"),
                                reader.GetString("medicines"),
                                reader.GetDateTime("prescription_date")
                            ));
                        }
                    }
                }
            }
            return prescriptions;
        }

        public static DataTable GetPrescriptionWithPatientName(int doctorId)
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT p.prescription_id, p.prescription_date, p.patient_id,
                                        pt.first_name AS patient_name, p.diagnosis, p.medicines
                                 FROM prescriptions p
                                 JOIN patients pt ON p.patient_id = pt.patient_id
                                 WHERE p.doctor_id = @DoctorID";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DoctorID", doctorId);
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);  // Fill DataTable with query result
                        return dt;
                    }
                }
            }
        }

        // Adds a new prescription record to the database.
        public static void AddPrescription(Prescriptions p)
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO prescriptions (patient_id, doctor_id, diagnosis, medicines, prescription_date)
                                 VALUES (@PatientID, @DoctorID, @Diagnosis, @Medicines, @PrescriptionDate)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PatientID", p.PatientID);
                    cmd.Parameters.AddWithValue("@DoctorID", p.DoctorID);
                    cmd.Parameters.AddWithValue("@Diagnosis", p.Diagnosis);
                    cmd.Parameters.AddWithValue("@Medicines", p.Medicines);
                    cmd.Parameters.AddWithValue("@PrescriptionDate", p.PrescriptionDate);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Updates an existing prescription in the database.
        public static void UpdatePrescription(Prescriptions p)
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE prescriptions
                                 SET patient_id = @PatientID,
                                     diagnosis = @Diagnosis,
                                     medicines = @Medicines,
                                     prescription_date = @PrescriptionDate
                                 WHERE prescription_id = @PrescriptionID";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PatientID", p.PatientID);
                    cmd.Parameters.AddWithValue("@Diagnosis", p.Diagnosis);
                    cmd.Parameters.AddWithValue("@Medicines", p.Medicines);
                    cmd.Parameters.AddWithValue("@PrescriptionDate", p.PrescriptionDate);
                    cmd.Parameters.AddWithValue("@PrescriptionID", p.PrescriptionID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Gets the prescription ID for a specific doctor, patient, and date.
        public static int GetPrescriptionID(int doctorID, int patientID, DateTime date)
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT prescription_id 
                 FROM prescriptions 
                 WHERE doctor_id = @DoctorID AND patient_id = @PatientID AND DATE(prescription_date) = @Date";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DoctorID", doctorID);
                    cmd.Parameters.AddWithValue("@PatientID", patientID);
                    cmd.Parameters.AddWithValue("@Date", date.Date);

                    var result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }

        //Checks if a patient with the given ID exists in the database.
        public static bool PatientExists(int patientId)
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM patients WHERE patient_id = @PatientID";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PatientID", patientId);
                    var result = Convert.ToInt32(cmd.ExecuteScalar());
                    return result > 0;
                }
            }
        }

    }
}
