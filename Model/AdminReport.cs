using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Model
{
    internal class AdminReport
    {
        public int AppointmentId { get; set; }
        public string PatientName { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Status { get; set; }

        public string TimeFormatted => Time.ToString(@"hh\:mm");

    }
}
