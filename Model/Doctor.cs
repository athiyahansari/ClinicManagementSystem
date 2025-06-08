using CMS.Controller;
using CMS.Model;
using CMS.Utils;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Model
{
    // Derived from Person
    public class Doctor : Person
    {
        public int DoctorID { get; set; }
        public string Speciality { get; set; }
        public int UserID { get; set; }
        public User Account { get; set; }

        public Doctor()
        {
            Account = new User();
        }
    }
}

