using CMS.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Controller
{
    internal class AdminReportController
    {
        public List<AdminReport> GetAppointmentsByDoctorAndDate(int doctorId, DateTime fromDate, DateTime toDate)
        {
            List<AdminReport> reports = new List<AdminReport>();

            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString))
            {
                conn.Open();
                string query = @"
            SELECT 
                CONCAT(p.first_name, ' ', p.last_name) AS patient_name,
                a.appointment_date, 
                a.appointment_time, 
                a.status
            FROM appointments a
            JOIN patients p ON a.patient_id = p.patient_id
            WHERE a.doctor_id = @DoctorId
              AND a.appointment_date BETWEEN @FromDate AND @ToDate
            ORDER BY a.appointment_date, a.appointment_time";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DoctorId", doctorId);
                cmd.Parameters.AddWithValue("@FromDate", fromDate.Date);
                cmd.Parameters.AddWithValue("@ToDate", toDate.Date);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        reports.Add(new AdminReport
                        {
                            PatientName = reader["patient_name"].ToString(),
                            Date = Convert.ToDateTime(reader["appointment_date"]),
                            Time = (TimeSpan)reader["appointment_time"],
                            Status = reader["status"].ToString()
                        });
                    }
                }
            }

            return reports;
        }
        
 public List<PatientTrend> GetPatientTrendsByDateRange(DateTime fromDate, DateTime toDate)
        {
            List<PatientTrend> trends = new List<PatientTrend>();

            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString))
            {
                conn.Open();
                string query = @"
                    SELECT 
                        CONCAT(p.first_name, ' ', p.last_name) AS patient_name,
                        COUNT(*) AS total_appointments,
                        MAX(a.appointment_date) AS last_appointment_date
                    FROM appointments a
                    JOIN patients p ON a.patient_id = p.patient_id
                    WHERE a.appointment_date BETWEEN @FromDate AND @ToDate
                    GROUP BY p.patient_id, patient_name
                    ORDER BY patient_name";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FromDate", fromDate.Date);
                cmd.Parameters.AddWithValue("@ToDate", toDate.Date);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        trends.Add(new PatientTrend
                        {
                            PatientName = reader["patient_name"].ToString(),
                            TotalAppointments = Convert.ToInt32(reader["total_appointments"]),
                            LastAppointmentDate = Convert.ToDateTime(reader["last_appointment_date"])
                        });
                    }
                }
            }

            return trends;
        }
    }
}







