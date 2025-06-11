using CMS.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Model;


namespace CMS.Controller
{
    internal class LoginController
    {
        public User Login(string username, string password)
        {
            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT user_id, username, password, role FROM users WHERE BINARY username = @username AND BINARY password = @password";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username.Trim());
                    cmd.Parameters.AddWithValue("@password", password.Trim());

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                UserId = Convert.ToInt32(reader["user_id"]),
                                Username = reader["username"].ToString(),
                                Password = reader["password"].ToString(),
                                Role = reader["role"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}
