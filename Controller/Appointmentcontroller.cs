using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Model;
using CMS.Utils;
using CMS.Controller;
using MySql.Data.MySqlClient;

namespace CMS.Controller
{
    internal class Appointmentcontroller
    {
        // Connection string to connect to MySQL database, loaded from config file
        private string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        //method to get all appointments for a patient to fll datagridview or listview

        //ADDED: NotificationController instance to handle notifications related to appointments
        private readonly NotificationController notificationController = new NotificationController();

        // Retrieves all appointments for a specific patient by patientId
        // Ensure single definition of GetAppointmentsByPatientId
        public List<Appointment> GetAppointmentsByPatientId(int patientId)
        {
            var appointments = new List<Appointment>();
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
                        var appointment = new Appointment
                        {
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

        // Cancels an appointment by setting its status to 'Cancelled' based on appointmentId
        public void CancelAppointment(int appointmentId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE appointments SET status = 'Cancelled' WHERE appointment_id = @appointmentId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                cmd.ExecuteNonQuery();
            }
        }

        // Validates appointment input fields before booking/rescheduling
        // Returns null if all inputs are valid, otherwise returns an error message
        public string ValidateAppointmentInput(int doctorId, DateTime date, string time, string notes)
        {
            if (doctorId <= 0)
                return "Please select a doctor.";

            if (date.Date < DateTime.Today)
                return "Please select a valid appointment date.";

            if (string.IsNullOrWhiteSpace(time))
                return "Please select a time slot.";

            // Parse the time string to TimeSpan for further validation
            if (!TimeSpan.TryParse(time, out TimeSpan parsedTime))
                return "Invalid time format selected.";

            // Check if the time slot is within working hours (9 AM to 5 PM)
            if (parsedTime < new TimeSpan(9, 0, 0) || parsedTime >= new TimeSpan(17, 0, 0))
                return "Please select a time between 9:00 AM and 5:00 PM.";

            if (string.IsNullOrWhiteSpace(notes) || notes.Length < 5)
                return "Please enter consultation notes (at least 5 characters).";

            return null; // all inputs valid
        }

        // Checks if a doctor has an available slot at the given date and time
        // Returns true if the slot is free (no conflicting appointments except cancelled ones)
        public bool IsSlotAvailable(int doctorId, DateTime date, TimeSpan time)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT COUNT(*) FROM appointments 
                         WHERE doctor_id = @doctorId 
                           AND appointment_date = @date 
                           AND appointment_time = @time 
                           AND status != 'Cancelled'";  // Ignore cancelled appointments

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@doctorId", doctorId);
                cmd.Parameters.AddWithValue("@date", date.Date); // Use only the date part
                cmd.Parameters.AddWithValue("@time", time);

                cmd.ExecuteNonQuery(); //execute the insert command
                                       //save a new appointment to the database

            } //links a variable to the placeholder in ur sql query @patientId, @date, etc..addwithvalue is used to replace the placeholder with the actual value
            return false;
        }

        // Generates a list of available time slots for booking appointments
        // Skips the 14:00 - 14:30 slot as per business rule
        public List<string> GenerateTimeSlots()
        {
            var slots = new List<string>();

            // Morning slots: 10:00 - 13:30 in 30-minute intervals
            for (int hour = 10; hour <= 13; hour++)
            {
                slots.Add($"{hour:D2}:00");
                if (hour < 13)
                    slots.Add($"{hour:D2}:30");
            }

            // Afternoon slots: 15:00 - 16:30 in 30-minute intervals
            for (int hour = 15; hour <= 16; hour++)
            {
                slots.Add($"{hour:D2}:00");
                if (hour < 16)
                    slots.Add($"{hour:D2}:30");
            }

            return slots;
        }

        // Retrieves all doctors from the database as a DataTable for UI dropdowns or other use
        public DataTable GetAllDoctors()
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT doctor_id, full_name FROM doctors";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        // Alias for GetAppointmentsByPatientId to provide a clear method name
        public List<Appointment> GetAppointmentsForPatient(int patientId)
        {
            return GetAppointmentsByPatientId(patientId);
        }

        // Books a new appointment or reschedules an existing one depending on isReschedule flag
        // Inserts a new record or updates existing appointment with new date/time/notes/status
        public bool BookOrReschedule(Appointment appt, bool isReschedule)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query;
                MySqlCommand cmd;

                if (isReschedule)
                {
                    // Update existing appointment
                    query = "UPDATE appointments SET appointment_date = @date, appointment_time = @time, notes = @notes, status = 'Rescheduled' WHERE appointment_id = @id";
                    cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", appt.AppointmentId);
                }
                else
                {
                    // Insert new appointment
                    query = "INSERT INTO appointments (patient_id, doctor_id, appointment_date, appointment_time, notes) VALUES (@patientId, @doctorId, @date, @time, @notes)";
                    cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@patientId", appt.PatientId);
                    cmd.Parameters.AddWithValue("@doctorId", appt.DoctorId);
                }

                // Set parameters common for both insert and update
                cmd.Parameters.AddWithValue("@date", appt.Date);
                cmd.Parameters.AddWithValue("@time", appt.Time);
                cmd.Parameters.AddWithValue("@notes", appt.Consultation);

                cmd.ExecuteNonQuery();
                return true;
            }
        }

        // Wrapper method to cancel an appointment with possible confirmation logic in the future
        public void CancelAppointmentWithConfirmation(int appointmentId)
        {
            CancelAppointment(appointmentId); // Reuse existing cancel method
        }

        // Prepares a new Appointment object for rescheduling purposes, copying necessary properties
        public Appointment PrepareAppointmentForReschedule(Appointment appt)
        {
            return new Appointment
            {
                AppointmentId = appt.AppointmentId,
                DoctorId = appt.DoctorId,
                Date = appt.Date,
                Time = appt.Time,
                Consultation = appt.Consultation
            };
        }

        // Attempts to book or reschedule an appointment with full validation and error handling
        // Returns a tuple: success flag and message string for UI feedback
        public (bool success, string message) TryBookOrRescheduleAppointment(
                int patientId,
                int doctorId,
                DateTime date,
                string timeText,
                string notes,
                int? rescheduleId)
        {
            if (doctorId <= 0 || string.IsNullOrWhiteSpace(timeText))
                return (false, "Please select a doctor and time slot.");

            // Validate inputs and return error message if invalid
            string validationError = ValidateAppointmentInput(doctorId, date, timeText, notes);
            if (validationError != null)
                return (false, validationError);

            // Parse the time string to TimeSpan
            if (!TimeSpan.TryParse(timeText, out TimeSpan time))
                return (false, "Invalid time format.");

            var appointment = new Appointment
            {
                AppointmentId = rescheduleId ?? 0,
                PatientId = patientId,
                DoctorId = doctorId,
                Date = date.Date,
                Time = time,
                Consultation = notes
            };

            try
            {
                // Book or reschedule appointment in DB
                BookOrReschedule(appointment, rescheduleId.HasValue);

                // !!!create a notification - addition
                if (!rescheduleId.HasValue)
                {
                    // 1) get the new appointment_id
                    int newApptId;
                    using (var conn = DBHelper.GetConnection())
                    {
                        conn.Open();
                        using (var cmd = new MySqlCommand("SELECT LAST_INSERT_ID()", conn))
                        {
                            newApptId = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                    }
                    // 2) compose the message
                    string msg = $"Your appointment with Dr. {appointment.DoctorId} is booked for {appointment.Date:yyyy-MM-dd} at {appointment.Time:hh\\:mm}.";
                    // 3) insert it
                    notificationController.CreateNotification(newApptId, msg);
                }

                return (true, rescheduleId.HasValue ? "Appointment rescheduled." : "Appointment booked!");
            }
            catch (MySqlException ex) when (ex.Number == 1062) // Duplicate entry (e.g., slot already booked)
            {
                return (false, "This slot is already booked.");
            }
            catch (Exception ex)
            {
                return (false, "Unexpected error: " + ex.Message);
            }
        }

        //public void BookAppointment(Appointment appt)
        //{
        //    // Call repo to save appointment (your data access)
        //}


        //Notification - method to retrieves the next appointment for a patient, ordered by date and time.
        public static Appointment GetNextAppointmentForPatient(int patientId)
        {
            Appointment appt = null;

            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"
                SELECT a.*, d.full_name AS DoctorName
                FROM appointments a
                JOIN doctors d ON a.doctor_id = d.doctor_id
                WHERE a.patient_id = @patientId AND a.appointment_date >= CURDATE()
                ORDER BY a.appointment_date ASC, a.appointment_time ASC
                LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@patientId", patientId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                appt = new Appointment
                                {
                                    AppointmentId = reader.GetInt32("appointment_id"),
                                    Date = reader.GetDateTime("appointment_date"),
                                    Time = reader.GetTimeSpan("appointment_time"),
                                    Status = reader.GetString("status"),
                                    PatientId = reader.GetInt32("patient_id"),
                                    DoctorId = reader.GetInt32("doctor_id"),
                                    DoctorName = reader["DoctorName"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching appointment: " + ex.Message);
            }

            return appt;
        }
        
    }
}
