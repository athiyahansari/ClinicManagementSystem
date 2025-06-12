using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Model;
using CMS.Utils;
using MySql.Data.MySqlClient;

namespace CMS.Controller
{
    internal class DocAppointmentController
    {
        // Fetch all appointments by doctor ID
        public List<Appointment> GetAppointmentsByDoctorId(int doctorId)
        {
            List<Appointment> appointments = new List<Appointment>();

            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            a.appointment_id,
                            a.appointment_date,
                            a.appointment_time,
                            a.status,
                            a.notes,
                            p.last_name AS PatientName
                        FROM appointments a
                        JOIN patients p ON a.patient_id = p.patient_id
                        WHERE a.doctor_id = @doctorId
                        ORDER BY a.appointment_date, a.appointment_time;
                    ";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@doctorId", doctorId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Appointment appt = new Appointment
                                {
                                    AppointmentId = Convert.ToInt32(reader["appointment_id"]),
                                    Date = Convert.ToDateTime(reader["appointment_date"]),
                                    Time = TimeSpan.Parse(reader["appointment_time"].ToString()),
                                    Status = reader["status"].ToString(),
                                    PatientName = reader["PatientName"].ToString(),
                                    Consultation = reader["notes"].ToString()
                                };
                                appointments.Add(appt);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // You might want to log this
                System.Windows.Forms.MessageBox.Show("Error loading appointments: " + ex.Message);
            }

            return appointments;
        }

        // Cancel the appointment
        public bool CancelAppointment(int appointmentId)
        {
            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE appointments SET status = 'Cancelled' WHERE appointment_id = @id";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", appointmentId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error cancelling appointment: " + ex.Message);
                return false;
            }
        }
    }
}
