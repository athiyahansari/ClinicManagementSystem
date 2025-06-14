using CMS.Model;
using CMS.Utils;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows.Forms;

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
                string fullName = reader.GetString("full_name");
                string firstName = "";
                string lastName = "";

                // Split full name into first and last name
                var nameParts = fullName.Split(new[] { ' ' }, 2, System.StringSplitOptions.RemoveEmptyEntries);
                if (nameParts.Length > 0)
                    firstName = nameParts[0];
                if (nameParts.Length > 1)
                    lastName = nameParts[1];

                // Add the doctor to the list
                list.Add(new Doctor
                {
                    DoctorID = reader.GetInt32("doctor_id"),
                    UserID = reader.GetInt32("user_id"),
                    FirstName = firstName,
                    LastName = lastName,
                    Speciality = reader.GetString("specialty"),
                    Email = reader.GetString("email"),
                    PhoneNumber = reader.GetString("contact")
                });
            }
            return list;
        }

        // Adds a new doctor to the database.
        public void AddDoctor(Doctor doc)
        {
            using var conn = DBHelper.GetConnection();
            conn.Open();
            var query = @"INSERT INTO doctors (user_id, full_name, specialty, email, contact)
                          VALUES (@u, @fn, @s, @e, @p)";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@u", doc.UserID);
            cmd.Parameters.AddWithValue("@fn", $"{doc.FirstName} {doc.LastName}".Trim());
            cmd.Parameters.AddWithValue("@s", doc.Speciality);
            cmd.Parameters.AddWithValue("@e", doc.Email);
            cmd.Parameters.AddWithValue("@p", doc.PhoneNumber);
            cmd.ExecuteNonQuery();
        }

        // Updates an existing doctor's information in the database.
        public void UpdateDoctor(Doctor doc)
        {
            using var conn = DBHelper.GetConnection();
            conn.Open();
            var query = @"UPDATE doctors SET full_name=@fn, specialty=@s, email=@e, contact=@p WHERE doctor_id=@id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@fn", $"{doc.FirstName} {doc.LastName}".Trim());
            cmd.Parameters.AddWithValue("@s", doc.Speciality);
            cmd.Parameters.AddWithValue("@e", doc.Email);
            cmd.Parameters.AddWithValue("@p", doc.PhoneNumber);
            cmd.Parameters.AddWithValue("@id", doc.DoctorID);
            cmd.ExecuteNonQuery();
        }

        // Deletes a doctor from the database.
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
                // Handle foreign key constraint violation (doctor linked to appointments)
                if (ex.Number == 1451)
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

