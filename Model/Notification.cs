using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Model
{
    /// <summary>
    /// Represents a notification record from the database.
    /// </summary>
    internal class Notification
    {
        public int NotificationId { get; set; } // PK
        public int AppointmentId { get; set; } // FK
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsRead { get; set; }

        public Notification() { }

        public Notification(int id, int appointmentId, string message, DateTime createdAt, bool isRead)
        {
            NotificationId = id;
            AppointmentId = appointmentId;
            Message = message;
            CreatedAt = createdAt;
            IsRead = isRead;
        }
    }
}
