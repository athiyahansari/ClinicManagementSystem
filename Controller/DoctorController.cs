using CMS.Model;
using CMS.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace CMS.Controller
{
    public class DoctorController
    {
        // Retrieve all doctors from database
        public List<Doctor> GetAllDoctors()
        {
            var list = new List<Doctor>();
            using var conn = DBHelper.GetConnection();
            conn.Open();

            string query = "SELECT DoctorID, UserID, FullName, Speciality, Email, PhoneNo FROM doctors";
            using var cmd = new MySqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Doctor
                {
                    DoctorID = reader.GetInt32("DoctorID"),
                    UserID = reader.GetInt32("UserID"),
                    FullName = reader.GetString("FullName"),
                    Speciality = reader.GetString("Speciality"),
                    Email = reader.GetString("Email"),
                    PhoneNo = reader.GetString("PhoneNo")
                });
            }
            return list;
        }

        // Add a new doctor
        public void AddDoctor(Doctor doc)
        {
            using var conn = DBHelper.GetConnection();
            conn.Open();
            var query = @"INSERT INTO doctors 
                (UserID, FullName, Speciality, Email, PhoneNo) 
                VALUES (@u, @f, @s, @e, @p)";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@u", doc.UserID);
            cmd.Parameters.AddWithValue("@f", doc.FullName);
            cmd.Parameters.AddWithValue("@s", doc.Speciality);
            cmd.Parameters.AddWithValue("@e", doc.Email);
            cmd.Parameters.AddWithValue("@p", doc.PhoneNo);
            cmd.ExecuteNonQuery();
        }

        // Update an existing doctor
        public void UpdateDoctor(Doctor doc)
        {
            using var conn = DBHelper.GetConnection();
            conn.Open();
            var query = @"UPDATE doctors SET 
                FullName=@f, Speciality=@s, Email=@e, PhoneNo=@p 
                WHERE DoctorID=@id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@f", doc.FullName);
            cmd.Parameters.AddWithValue("@s", doc.Speciality);
            cmd.Parameters.AddWithValue("@e", doc.Email);
            cmd.Parameters.AddWithValue("@p", doc.PhoneNo);
            cmd.Parameters.AddWithValue("@id", doc.DoctorID);
            cmd.ExecuteNonQuery();
        }

        // Delete a doctor by ID
        public void DeleteDoctor(int id)
        {
            using var conn = DBHelper.GetConnection();
            conn.Open();
            var query = "DELETE FROM doctors WHERE DoctorID=@id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
