using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace CMS.Model
{
    public class Patients:Person
    {
        public string PatientId { get; set; }
        public int Id { get; set; }  // Add this line!
        public string Gender { get; set; } // Could be an enum for better type safety

        public Patients() : base()
        {
            // Default constructor, calls base class constructor
        }

        public Patients(string patientId, string firstName, string lastName, DateTime dateOfBirth, string phoneNumber, string email, string gender)
            : base(firstName, lastName, dateOfBirth, phoneNumber, email) // Call base class constructor
        {
            PatientId = patientId;
            Gender = gender;
        }

        // Override IsValid to add patient-specific validation
        public override bool IsValid() // Polymorphism: specific implementation for Patient
        {
            if (string.IsNullOrWhiteSpace(PatientId) ||
                string.IsNullOrWhiteSpace(Gender))
            {
                return false;
            }
            return base.IsValid(); // Call base class validation as well
        }

        // Implementation of the abstract method from Person (Polymorphism)
        public override void SaveToDataStore()
        {
            // In a real application, this would interact with a database or API
            // For now, it's just a placeholder demonstrating where the save logic goes.
            Console.WriteLine($"Saving Patient Profile for: {FirstName} {LastName} (ID: {PatientId})");
            // Example:
            // DataAccessLayer.SavePatient(this);
            // This could involve encrypting sensitive data before saving (Encryption concept, if needed)
        }

        // Example of a patient-specific method
        public string GetPatientSummary()
        {
            return $"Patient ID: {PatientId}, Name: {FirstName} {LastName}, Gender: {Gender}";
        }
    }
}



