using CMS.Model;
using CMS.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace CMS.Controller
{
    // Static class for handling database operations related to prescriptions
    public static class PrescriptionController
    {
        /// <summary>
        /// Adds a new prescription to the database.
        /// </summary>
        public static void AddPrescription(Prescription p)
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO Prescriptions 
                                (PatientID, DoctorID, Diagnosis, Medicines, PrescriptionDate) 
                                VALUES (@PatientID, @DoctorID, @Diagnosis, @Medicines, @Date)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PatientID", p.PatientID);
                cmd.Parameters.AddWithValue("@DoctorID", p.DoctorID);
                cmd.Parameters.AddWithValue("@Diagnosis", p.Diagnosis);
                cmd.Parameters.AddWithValue("@Medicines", p.Medicines);
                cmd.Parameters.AddWithValue("@Date", p.PrescriptionDate);

                cmd.ExecuteNonQuery(); // Executes the INSERT command
            }
        }

        // Updates an existing prescription by ID.
   
        public static void UpdatePrescription(Prescription p)
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE Prescriptions 
                                 SET PatientID = @PatientID, 
                                     Diagnosis = @Diagnosis, 
                                     Medicines = @Medicines, 
                                     PrescriptionDate = @Date 
                                 WHERE PrescriptionID = @ID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PatientID", p.PatientID);
                cmd.Parameters.AddWithValue("@Diagnosis", p.Diagnosis);
                cmd.Parameters.AddWithValue("@Medicines", p.Medicines);
                cmd.Parameters.AddWithValue("@Date", p.PrescriptionDate);
                cmd.Parameters.AddWithValue("@ID", p.PrescriptionID);

                cmd.ExecuteNonQuery(); // Executes the UPDATE command
            }
        }

     
        // Deletes a prescription by its ID.
      
        public static void DeletePrescription(int id)
        {
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Prescriptions WHERE PrescriptionID = @ID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);

                cmd.ExecuteNonQuery(); // Executes the DELETE command
            }
        }

     
        // Gets all prescriptions written by a specific doctor.
    
        public static List<Prescription> GetPrescriptionsByDoctor(int doctorID)
        {
            List<Prescription> list = new List<Prescription>();

            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Prescriptions WHERE DoctorID = @DoctorID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DoctorID", doctorID);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Prescription p = new Prescription
                        {
                            PrescriptionID = Convert.ToInt32(reader["PrescriptionID"]),
                            PatientID = Convert.ToInt32(reader["PatientID"]),
                            DoctorID = Convert.ToInt32(reader["DoctorID"]),
                            Diagnosis = reader["Diagnosis"].ToString(),
                            Medicines = reader["Medicines"].ToString(),
                            PrescriptionDate = Convert.ToDateTime(reader["PrescriptionDate"])
                        };
                        list.Add(p);
                    }
                }
            }

            return list;
        }
    }
}
