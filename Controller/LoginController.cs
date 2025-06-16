//using CMS.Utils;
//using MySql.Data.MySqlClient;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using CMS.Model;


//namespace CMS.Controller
//{
//    internal class LoginController
//    {
//        public User Login(string username, string password)
//        {
//            using (MySqlConnection conn = DBHelper.GetConnection())
//            {
//                conn.Open();
//                string query = "SELECT user_id, username, password, role FROM users WHERE BINARY username = @username AND BINARY password = @password";

//                using (MySqlCommand cmd = new MySqlCommand(query, conn))
//                {
//                    cmd.Parameters.AddWithValue("@username", username.Trim());
//                    cmd.Parameters.AddWithValue("@password", password.Trim());

//                    using (MySqlDataReader reader = cmd.ExecuteReader())
//                    {
//                        if (reader.Read())
//                        {
//                            return new User
//                            {
//                                UserId = Convert.ToInt32(reader["user_id"]),
//                                Username = reader["username"].ToString(),
//                                Password = reader["password"].ToString(),
//                                Role = reader["role"].ToString()
//                            };
//                        }
//                    }
//                }
//            }

//            return null;
//        }
//    }
//}


using MySql.Data.MySqlClient;
using CMS.Model;
using System;

namespace CMS.Controller
{
    public class LoginController
    {
        private readonly string connectionString = "server=localhost;user id=root;password=;database=clinic_db";

        public User Login(string username, string password)
        {
            User user = null;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT u.user_id, u.username, u.role, d.doctor_id " +
                               "FROM users u " +
                               "LEFT JOIN doctors d ON u.user_id = d.user_id " +
                               "WHERE u.username = @username AND u.password = @password LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new User
                        {
                            UserId = Convert.ToInt32(reader["user_id"]),
                            Username = reader["username"].ToString(),
                            Role = reader["role"].ToString(),
                            DoctorId = reader["doctor_id"] != DBNull.Value ? Convert.ToInt32(reader["doctor_id"]) : (int?)null
                        };
                    }
                }
            }

            return user;
        }
    }
}

