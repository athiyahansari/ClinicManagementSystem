using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Model
{
    public class DoctorProfile
    {
        public int ProfileId { get; set; }
        public int DoctorId { get; set; }
        public string Description { get; set; }
        public string Speciality { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
    }
}

