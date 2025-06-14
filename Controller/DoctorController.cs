using CMS.Model;
using CMS.Utils;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace CMS.Controller
{
    public class DoctorController
    {
        public List<Doctor> GetAllDoctors()
        {
            var list = new List<Doctor>();
            using var conn = DBHelper.GetConnection();
            conn.Open();
            string query = "SELECT doctor_id, user_id, full_name, specialty, email, contact FROM doctors";
            using var cmd = new MySqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Doctor
                {
                    DoctorID = reader.GetInt32("doctor_id"),
                    UserID = reader.GetInt32("user_id"),
                    FullName = reader.GetString("full_name"),
                    Speciality = reader.GetString("specialty"),
                    Email = reader.GetString("email"),
                    PhoneNo = reader.GetString("contact")
                });
            }
            return list;
        }

        public void AddDoctor(Doctor doc)
        {
            using var conn = DBHelper.GetConnection();
            conn.Open();
            var query = @"INSERT INTO doctors (user_id, full_name, specialty, email, contact)
                          VALUES (@u, @f, @s, @e, @p)";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@u", doc.UserID);
            cmd.Parameters.AddWithValue("@f", doc.FullName);
            cmd.Parameters.AddWithValue("@s", doc.Speciality);
            cmd.Parameters.AddWithValue("@e", doc.Email);
            cmd.Parameters.AddWithValue("@p", doc.PhoneNo);
            cmd.ExecuteNonQuery();
        }

        public void UpdateDoctor(Doctor doc)
        {
            using var conn = DBHelper.GetConnection();
            conn.Open();
            var query = @"UPDATE doctors SET full_name=@f, specialty=@s, email=@e, contact=@p WHERE doctor_id=@id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@f", doc.FullName);
            cmd.Parameters.AddWithValue("@s", doc.Speciality);
            cmd.Parameters.AddWithValue("@e", doc.Email);
            cmd.Parameters.AddWithValue("@p", doc.PhoneNo);
            cmd.Parameters.AddWithValue("@id", doc.DoctorID);
            cmd.ExecuteNonQuery();
        }

        public void DeleteDoctor(int id)
        {
            try
            {
                using var conn = DBHelper.GetConnection();
                conn.Open();
                var query = "DELETE FROM doctors WHERE doctor_id=@id";
                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451) // Foreign key constraint error
                {
                    MessageBox.Show("Cannot delete this doctor because they have existing appointments.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
