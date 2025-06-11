using System;

namespace CMS.Model
{
    // Doctor inherits shared properties from Person
    public class Doctor : Person
    {
        public int DoctorID { get; set; }     // Maps to `doctor_id` in DB
        public int UserID { get; set; }       // Foreign key to users table
        public string Speciality { get; set; } // Specific to Doctor
    }
}
