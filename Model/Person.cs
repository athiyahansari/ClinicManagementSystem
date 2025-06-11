using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Model
{
    public abstract class Person
    {
       
            // Encapsulation: Properties with public getters and setters
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }

            public Person()
            {
                // Default constructor
            }

            public Person(string firstName, string lastName, DateTime dateOfBirth, string phoneNumber, string email)
            {
                FirstName = firstName;
                LastName = lastName;
                DateOfBirth = dateOfBirth;
                PhoneNumber = phoneNumber;
                Email = email;
            }

            // Basic validation for common fields
            public virtual bool IsValid() // virtual allows derived classes to override (Polymorphism)
            {
                if (string.IsNullOrWhiteSpace(FirstName) ||
                    string.IsNullOrWhiteSpace(LastName) ||
                    string.IsNullOrWhiteSpace(Email) ||
                    string.IsNullOrWhiteSpace(PhoneNumber))
                {
                    return false;
                }
                // Add more robust validation (e.g., email format, phone number format)
                return true;
            }

            // Abstract method: forces derived classes to implement their own Save logic
            // This is a form of Polymorphism
            public abstract void SaveToDataStore();
        
    }
}
