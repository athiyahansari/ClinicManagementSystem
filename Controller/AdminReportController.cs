using CMS.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace CMS.Controller
{
    // Controller class that handles all admin reporting logic (doctor schedule & patient trends)
    internal class AdminReportController
    {
        // Retrieves a list of appointments for a given doctor and date range
        public List<AdminReport> GetAppointmentsByDoctorAndDate(int doctorId, DateTime fromDate, DateTime toDate)
        {
            List<AdminReport> reports = new List<AdminReport>();

            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString))
            {
                conn.Open();

                // SQL query to fetch appointment details
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

                // Execute query with parameters
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DoctorId", doctorId);
                cmd.Parameters.AddWithValue("@FromDate", fromDate.Date);
                cmd.Parameters.AddWithValue("@ToDate", toDate.Date);

                using (var reader = cmd.ExecuteReader())
                {
                    // Read each record and populate the list
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

            return reports; // Return the list of appointments
        }

        // Retrieves a summary of patient trends (total appointments and last appointment date)
        public List<PatientTrend> GetPatientTrendsByDateRange(DateTime fromDate, DateTime toDate)
        {
            List<PatientTrend> trends = new List<PatientTrend>();

            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString))
            {
                conn.Open();

                // SQL query to get appointment trends per patient
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
                    // Add each result to the list
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

            return trends; // Return trend results
        }

        // Public method used by the View to validate and return doctor schedule report
        public List<AdminReport> GetDoctorScheduleReport(int doctorId, DateTime fromDate, DateTime toDate, out string errorMessage)
        {
            errorMessage = null;

            // Basic validation: From date should not be after To date
            if (fromDate > toDate)
            {
                errorMessage = "From date cannot be after To date.";
                return new List<AdminReport>();
            }

            var reports = GetAppointmentsByDoctorAndDate(doctorId, fromDate, toDate);

            // Show message if no appointments found
            if (reports.Count == 0)
            {
                errorMessage = "No appointments found for the selected doctor and date range.";
            }

            return reports;
        }

        // Public method to get patient trends after validating the date range
        public List<PatientTrend> GetPatientTrends(DateTime fromDate, DateTime toDate, out string errorMessage)
        {
            errorMessage = null;

            // Validate date range
            if (fromDate > toDate)
            {
                errorMessage = "From date cannot be after To date.";
                return new List<PatientTrend>();
            }

            var trends = GetPatientTrendsByDateRange(fromDate, toDate);

            // Handle empty result
            if (trends.Count == 0)
            {
                errorMessage = "No trends found for the selected date range.";
            }

            return trends;
        }
    }
}
