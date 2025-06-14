
using CMS.Model;
using CMS;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace CMS.Controller
{
    public class DoctorController
    {
        private readonly Database db;

        public DoctorController()
        {
            db = new Database();
        }

        public List<Doctor> GetAllDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();
            string query = "SELECT * FROM doctors";

            try
            {
                DataTable dt = db.ExecuteQuery(query);
                foreach (DataRow row in dt.Rows)
                {
                    Doctor doctor = new Doctor
                    {
                        DoctorId = Convert.ToInt32(row["doctor_id"]),
                        UserId = Convert.ToInt32(row["user_id"]),
                        FullName = row["full_name"].ToString(),
                        Specialty = row["specialty"].ToString(),
                        Consultation = Convert.ToDecimal(row["consultation"]),
                        TotalPatients = Convert.ToInt32(row["total_patients"]),
                        Email = row["email"].ToString(),
                        Contact = row["contact"].ToString(),
                        CreatedAt = Convert.ToDateTime(row["created_at"])
                    };
                    doctors.Add(doctor);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Failed to fetch doctors: " + ex.Message);
            }

            return doctors;
        }

        public DoctorProfile GetDoctorProfileById(int doctorId)
        {
            string query = $"SELECT * FROM doctor_profiles WHERE doctor_id = {doctorId} LIMIT 1";
            DoctorProfile profile = null;

            try
            {
                DataTable dt = db.ExecuteQuery(query);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    profile = new DoctorProfile
                    {
                        ProfileId = Convert.ToInt32(row["profile_id"]),
                        DoctorId = Convert.ToInt32(row["doctor_id"]),
                        Description = row["description"].ToString(),
                        Speciality = row["speciality"].ToString(),
                        Email = row["email"].ToString(),
                        Contact = row["contact"].ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Failed to fetch doctor profile: " + ex.Message); //Incase the database name, columns dont exist or has been changed.
            }

            return profile;
        }
    }
}