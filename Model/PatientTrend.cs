using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Model
{
    internal class PatientTrend
    {
        public string PatientName { get; set; }
        public int TotalAppointments { get; set; }
        public DateTime LastAppointmentDate { get; set; }
    }
}
