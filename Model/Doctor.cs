using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Model
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Specialty { get; set; }
        public decimal Consultation { get; set; }
        public int TotalPatients { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
