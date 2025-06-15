using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Model
{
    // Doctor inherits shared properties from Person
    public class Doctor : Person
    {
        public int DoctorID { get; set; }     // Maps to `doctor_id` in DB
        public int UserID { get; set; }       // Foreign key to users table
        public string Speciality { get; set; } = string.Empty; // Specific to Doctor

        // Implementation of abstract method from Person
        public override void SaveToDataStore()
        {
            // Add logic here to save the doctor data to DB
            // For now, just a placeholder
        }
    }
}