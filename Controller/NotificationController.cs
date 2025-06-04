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
    internal class NotificationController
    {
        public static Notification GetLatestUnreadNotificationForPatient(int patientId)
        {
            Notification notif = null;

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
    }
}
