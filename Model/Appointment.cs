using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Model
{
    internal class Appointment
    {
        public int AppointmentId { get; set; }//PK
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Status { get; set; }
        public int PatientId { get; set; }  //FK
        public int DoctorId { get; set; }  //FK TO CONNECT TO THE Proper database
        // Navigation properties
        public virtual Patients Patient { get; set; } // You can populate this via a JOIN in your query
        //public virtual Doctor Doctor { get; set; } //allows u to access patient.Fullname etc 
        public string DoctorName { get; set; } // You can populate this via a JOIN in your query
        public string Consultation { get; set; } // Add if needed
        public string PatientName { get; set; } // You can populate this via a JOIN in your query



        public Appointment()  //this runs when u create a new object like new Appointment()
        { 
            Date = DateTime.Now;
            Time = new TimeSpan(0, 0, 0);
            Status = "Scheduled"; // Default status
        }

        public Appointment(int appointmentId, DateTime date, TimeSpan time, string status, int patientId, int doctorId)
        {
            this.AppointmentId = appointmentId;
            this.Date = date;
            this.Time = time;
            this.Status = status;
            this.PatientId = patientId;
            this.DoctorId = doctorId;

        }

        public bool IsPast() //checks if the appointment is already in the past
        {
            return DateTime.Now > Date.Add(Time);
        }
        //Can be used to gray out old appointments, disable editing, or update status.

    }
}
