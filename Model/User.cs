using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace CMS.Model
{
    public  class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }  // Same as Email
        public string Password { get; set; }
        public string Role { get; set; } = "patients";
        public string PasswordHash { get; set; }

        // Add DoctorId (nullable since only doctors will have it)
        public int? DoctorId { get; set; }

        public DateTime CreatedAt { get; set; }


        public static string HashPassword(string plainPassword)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(plainPassword));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }




        }

        public bool VerifyPassword(string plainPassword)
        {
            return HashPassword(plainPassword) == PasswordHash;
        }

        public bool IsValidForRegistration()
        {
            if (string.IsNullOrWhiteSpace(Username) ||
                string.IsNullOrWhiteSpace(PasswordHash) ||
                string.IsNullOrWhiteSpace(Role))
            {
                return false;
            }
            return true;
        }




    }

}
