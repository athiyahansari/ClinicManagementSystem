using MySql.Data.MySqlClient;
using CMS.Model;
using System;

namespace CMS.Controller
{
    public class DoctorProfileController
    {
        private readonly string connectionString = "server=localhost;user id=root;password=;database=clinic_db";

        //one method
        public ViewDoctorProfile GetDoctorProfile(int doctorId)
        {
            ViewDoctorProfile profile = null;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"
            SELECT dp.*, d.full_name 
            FROM doctor_profiles dp
            JOIN doctors d ON dp.doctor_id = d.doctor_id
            WHERE dp.doctor_id = @doctorId
            LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@doctorId", doctorId);

                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        profile = new ViewDoctorProfile
                        {
                            ProfileId = Convert.ToInt32(reader["profile_id"]),
                            DoctorId = Convert.ToInt32(reader["doctor_id"]),
                            Description = reader["description"].ToString(),
                            Speciality = reader["speciality"].ToString(),
                            Email = reader["email"].ToString(),
                            Contact = reader["contact"].ToString(),
                            DoctorName = reader["full_name"].ToString() // New field
                        };
                    }
                }
            }

            return profile;
        }
    }
}

