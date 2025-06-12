using CMS.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Controller
{
    internal class AdminPatientController
    {
        private string connectionString = "server=localhost;user=root;password=;database=clinic_db;";

        public List<AdminPatientAppointment> GetAllAppointments()
        {
            var appointments = new List<AdminPatientAppointment>();

            string query = @"
            SELECT a.appointment_id, 
                   CONCAT(p.first_name, ' ', p.last_name) AS patient_name, 
                   d.full_name AS doctor_name, 
                   a.appointment_date, 
                   a.appointment_time, 
                   a.status
            FROM appointments a
            JOIN patients p ON a.patient_id = p.patient_id
            JOIN doctors d ON a.doctor_id = d.doctor_id";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        appointments.Add(new AdminPatientAppointment
                        {
                            AppointmentID = reader.GetInt32("appointment_id"),
                            PatientName = reader.GetString("patient_name"),
                            DoctorName = reader.GetString("doctor_name"),
                            Date = reader.GetDateTime("appointment_date"),
                            Time = reader.GetTimeSpan("appointment_time").ToString(@"hh\:mm"),
                            Status = reader.GetString("status")
                        });

                    }
                }
            }

            return appointments;
        }


        public bool RescheduleAppointment(int appointmentId, DateTime newDate, TimeSpan newTime)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE appointments SET appointment_date=@date, appointment_time=@time, status='Rescheduled' WHERE appointment_id=@id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@date", newDate);
                    cmd.Parameters.AddWithValue("@time", newTime);
                    cmd.Parameters.AddWithValue("@id", appointmentId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool CancelAppointment(int appointmentId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE appointments SET status='Cancelled' WHERE appointment_id=@id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", appointmentId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

    }

}




