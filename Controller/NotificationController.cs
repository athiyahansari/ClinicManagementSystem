using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Model;
using CMS.Utils;
using MySql.Data.MySqlClient;

namespace CMS.Controller
{
    /// <summary>
    /// Handles fetching and formatting notifications for the view.
    /// </summary>
    internal class NotificationController
    {
        /// <summary>
        /// Retrieves the most recent unread notification for a patient.
        /// Formatting (line breaks every 5 words) is handled here.
        /// </summary>
        public Notification GetLatestNotificationForPatient(int patientId, out string formattedMessage)
        {
            Notification notif = null;
            formattedMessage = string.Empty;

            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        SELECT n.notification_id, n.appointment_id, n.message, n.created_at, n.is_read
                        FROM notifications n
                        JOIN appointments a ON n.appointment_id = a.appointment_id
                        WHERE a.patient_id = @patientId AND n.is_read = 0
                        ORDER BY n.created_at DESC
                        LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@patientId", patientId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                notif = new Notification(
                                    reader.GetInt32("notification_id"),
                                    reader.GetInt32("appointment_id"),
                                    reader.GetString("message"),
                                    reader.GetDateTime("created_at"),
                                    reader.GetBoolean("is_read")
                                );

                                // Prepare formatted string for the view
                                formattedMessage = ApplyLineBreaks(notif.Message, 5);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching notifications: " + ex.Message);
            }

            return notif;
        }

        /// <summary>
        /// Inserts a newline every N words.
        /// </summary>
        private static string ApplyLineBreaks(string text, int wordsPerLine)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            var words = text.Split(' ');
            var sb = new System.Text.StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                sb.Append(words[i]).Append(' ');
                if ((i + 1) % wordsPerLine == 0)
                    sb.AppendLine();
            }

            return sb.ToString().TrimEnd();
        }
    }
}
