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
    internal class RegisterController
    {

        public string Register(User user, Patients patient)
        {
            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();

                    // Check if user already exists
                    string checkQuery = "SELECT COUNT(*) FROM user WHERE username = @username";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@username", user.Username);

                    long count = (long)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        return "Email is already registered.";
                    }

                    MySqlTransaction transaction = conn.BeginTransaction();

                    // Insert into user table
                    string insertUserQuery = "INSERT INTO user (username, password, role) VALUES (@username, @password, @role)";
                    MySqlCommand cmdUser = new MySqlCommand(insertUserQuery, conn, transaction);
                    cmdUser.Parameters.AddWithValue("@username", user.Username);
                    cmdUser.Parameters.AddWithValue("@password", user.Password);
                    cmdUser.Parameters.AddWithValue("@role", user.Role);
                    cmdUser.ExecuteNonQuery();

                    int userId = (int)cmdUser.LastInsertedId;

                    // Insert into patient table
                    string insertPatientQuery = @"INSERT INTO patient (user_id, first_name, last_name, gender, date_of_birth, email, phonenumber) 
                                                  VALUES (@user_id, @first_name, @last_name, @gender, @dob, @email, @phone)";
                    MySqlCommand cmdPatient = new MySqlCommand(insertPatientQuery, conn, transaction);
                    cmdPatient.Parameters.AddWithValue("@user_id", userId);
                    cmdPatient.Parameters.AddWithValue("@first_name", patient.FirstName);
                    cmdPatient.Parameters.AddWithValue("@last_name", patient.LastName);
                    cmdPatient.Parameters.AddWithValue("@gender", patient.Gender);
                    cmdPatient.Parameters.AddWithValue("@dob", patient.DateOfBirth);
                    cmdPatient.Parameters.AddWithValue("@email", patient.Email);
                    cmdPatient.Parameters.AddWithValue("@phone", patient.PhoneNumber);
                    cmdPatient.ExecuteNonQuery();

                    transaction.Commit();
                    return "success";
                }
                catch (Exception ex)
                {
                    return $"An error occurred: {ex.Message}";
                }
            }
        }
    }
}
