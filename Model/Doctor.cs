using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Model
{
    // Doctor inherits shared properties from Person
    public  class Doctor : Person
    {
        public int DoctorID { get; set; }
        public int UserID { get; set; }
        public string Speciality { get; set; }
        public string PhoneNo { get; set; } // 🔥 FIXED RIGHT HERE

        public string FullName { get; set; }

        public override void SaveToDataStore()
        {
            Console.WriteLine("Saving doctor to data store...");
        }
    }
}
                                                                                   