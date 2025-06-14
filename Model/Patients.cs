using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;


namespace CMS.Model
{
    public class Patients:Person
    {
        public string PatientId { get; set; }  // 👈 Update to string
        public int Id { get; set; }  // Add this line!
        public string Gender { get; set; } // Could be an enum for better type safety
        public DateTime CreatedAt { get; set; } // Corresponds to created_at in DB
        public DateTime UpdatedAt { get; set; } // Corresponds to updated_at in DB

        public int UserId { get; set; }


        public Patients() : base()
        {
            // Default constructor, calls base class constructor
        }

        public Patients(int patientId, int userId, string firstName, string lastName, DateTime dateOfBirth, string phoneNumber, string email, string gender)
           : base(firstName, lastName, dateOfBirth, phoneNumber, email)
        {
            PatientId = PatientId;
            UserId = userId;
            Gender = gender;
        }

        public override bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(FirstName) ||
                string.IsNullOrWhiteSpace(LastName) ||
                string.IsNullOrWhiteSpace(PhoneNumber) ||
                string.IsNullOrWhiteSpace(Email) ||
                string.IsNullOrWhiteSpace(Gender))
            {
                return false;
            }

            return true;
        }

        // Implementation of the abstract method from Person (Polymorphism)
        public override void SaveToDataStore()
        {
            // In a real application, this would interact with a database or API
            // For now, it's just a placeholder demonstrating where the save logic goes.
            Console.WriteLine($"SaveToDataStore() called for Patient {FirstName} {LastName}. " +
                              $"Actual persistence for new patient is handled by RegisterController.");
            // Example:
            // DataAccessLayer.SavePatient(this);
            // This could involve encrypting sensitive data before saving (Encryption concept, if needed)
        }

        // Example of a patient-specific method
        public string GetPatientSummary()
        {
            return $"Patient ID: {PatientId}, Name: {FirstName} {LastName}, Gender: {Gender}";
        }



       


        // Override IsValid to include patient-specific validation
        

        // --- IMPLEMENTATION OF ABSTRACT METHOD FROM PERSON ---
        // For registration, the Save logic is complex (two tables).
        // It's best handled by the RegisterController.
        // So, this implementation will be a placeholder or can log.
        // If this method were for updating an *existing* patient, it would
        // typically call a Data Access Layer or Repository.

        
    }
}



