using CMS.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CMS.Controller
{
    internal class Appointmentcontroller
    { //handle all database related operations

        private string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        //method to get all appointments for a patient to fll datagridview or listview
        public List<Appointment> GetAppointmentsByPatientId(int patientId)
        { //get appointments from db for a specifc patient 

            var appointments = new List<Appointment>();
            //@ patientId is a parameter/placeholder to prevent SQL injection attacks
            string query = @"
        SELECT 
            a.appointment_id, 
            a.appointment_date, 
            a.appointment_time, 
            a.status, 
            a.patient_id,
            p.first_name AS patient_name, 
            a.doctor_id, 
            d.full_name AS doctor_name, 
            a.notes AS consultation 
        FROM appointments a               
        JOIN patients p ON a.patient_id = p.patient_id
        JOIN doctors d ON a.doctor_id = d.doctor_id
        WHERE a.patient_id = @patientId";

            using (var connection = new MySqlConnection(connectionString))
            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@patientId", patientId);

                connection.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var appointment = new Appointment //creatinga a new object. object represents one row
                        { //reading from the database and mapping to the Appointment model
                            AppointmentId = reader.GetInt32("appointment_id"),
                            Date = reader.GetDateTime("appointment_date"),
                            Time = reader.GetTimeSpan("appointment_time"),
                            Status = reader.GetString("status"),
                            PatientId = reader.GetInt32("patient_id"),
                            PatientName = reader.GetString("patient_name"),
                            DoctorId = reader.GetInt32("doctor_id"),
                            DoctorName = reader.GetString("doctor_name"),
                            Consultation = reader["consultation"] != DBNull.Value ? reader.GetString("consultation") : ""
                        };
                        appointments.Add(appointment);
                    }
                }
            }

            return appointments;
        }


        //method to insert a new appointment into the database
        public void BookAppointment(Appointment appt)
        { //passing object of appointment class to this method because it needs many values
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO appointments (patient_id, doctor_id, appointment_date, appointment_time, notes) VALUES (@patientId, @doctorId, @date, @appointmentTime, @notes)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@patientId", appt.PatientId);
                cmd.Parameters.AddWithValue("@doctorId", appt.DoctorId);
                cmd.Parameters.AddWithValue("@date", appt.Date); //replaces @date with the actual date value
                cmd.Parameters.AddWithValue("@appointmentTime", appt.Time);
                cmd.Parameters.AddWithValue("@notes", appt.Consultation); // Using notes for consultation text
                //status has been removed cus the deafult value is Scheduled

                cmd.ExecuteNonQuery(); //execute the insert command
                                       //save a new appointment to the database
            } //links a variable to the placeholder in ur sql query @patientId, @date, etc..addwithvalue is used to replace the placeholder with the actual value
        }

        public void CancelAppointment(int appointmentId)
        { //appointmentId is the unique identifier for the appointment to be cancelled
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE appointments SET status = 'Cancelled' WHERE appointment_id = @appointmentId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                cmd.ExecuteNonQuery();
            }
        } //update the appointments status to 'Cancelled'

        public void RescheduleAppointment(int appointmentId, DateTime newDate, TimeSpan newTime)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE appointments SET appointment_date = @date, appointment_time = @time, status = 'Rescheduled' WHERE appointment_id = @appointmentId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@date", newDate);
                cmd.Parameters.AddWithValue("@time", newTime);
                cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                cmd.ExecuteNonQuery();
            }
        }

        public string ValidateAppointmentInput(int doctorId, DateTime date, string time, string notes)
        {

            if (doctorId <= 0)
                return "Please select a doctor.";

            if (date.Date < DateTime.Today)
                return "Please select a valid appointment date.";

            if (string.IsNullOrWhiteSpace(time))
                return "Please select a time slot.";

            // Declare parsedTime variable and try to parse
            if (!TimeSpan.TryParse(time, out TimeSpan parsedTime))
                return "Invalid time format selected.";

            // Check if time is within business hours (9 AM to 5 PM)
            if (parsedTime < new TimeSpan(9, 0, 0) || parsedTime >= new TimeSpan(17, 0, 0))
                return "Please select a time between 9:00 AM and 5:00 PM.";



            if (string.IsNullOrWhiteSpace(notes) || notes.Length < 5)
                return "Please enter consultation notes (at least 5 characters).";

            return null; // no errors
        }

        //public void BookAppointment(Appointment appt)
        //{
        //    // Call repo to save appointment (your data access)
        //}
        public bool IsSlotAvailable(int doctorId, DateTime date, TimeSpan time)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT COUNT(*) FROM appointments 
                         WHERE doctor_id = @doctorId 
                           AND appointment_date = @date 
                           AND appointment_time = @time 
                           AND status != 'Cancelled'";  // Exclude cancelled appointments

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@doctorId", doctorId);
                cmd.Parameters.AddWithValue("@date", date.Date); // Date part only
                cmd.Parameters.AddWithValue("@time", time);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count == 0;  // True if no conflicting appointment
            }
        }


        public List<string> GenerateTimeSlots()
        {
            var slots = new List<string>();

            // 10:00 - 13:30
            for (int hour = 10; hour <= 13; hour++)
            {
                slots.Add($"{hour:D2}:00");
                if (hour < 13)
                    slots.Add($"{hour:D2}:30");
            }

            // Skip 14:00 to 14:30 (no slots here)

            // 15:00 - 16:30
            for (int hour = 15; hour <= 16; hour++)
            {
                slots.Add($"{hour:D2}:00");
                if (hour < 16)
                    slots.Add($"{hour:D2}:30");
            }

            return slots;
        }

    }
}
