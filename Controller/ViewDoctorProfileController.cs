using MySql.Data.MySqlClient;
using CMS.Model;
using System;

namespace CMS.Controller
{
    public class DoctorProfileController
    {
        private readonly string connectionString = "server=localhost;user id=root;password=;database=clinic_db";

        public DoctorProfile GetDoctorProfile(int doctorId)
        {
            DoctorProfile profile = null;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM doctor_profiles WHERE doctor_id = @doctorId LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@doctorId", doctorId);

                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        profile = new DoctorProfile
                        {
                            ProfileId = Convert.ToInt32(reader["profile_id"]),
                            DoctorId = Convert.ToInt32(reader["doctor_id"]),
                            Description = reader["description"].ToString(),
                            Speciality = reader["speciality"].ToString(),
                            Email = reader["email"].ToString(),
                            Contact = reader["contact"].ToString()
                        };
                    }
                }
            }

            return profile;
        }
    }
}
