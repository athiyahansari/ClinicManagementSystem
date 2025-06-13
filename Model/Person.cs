using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Model
{
    // Base class Person to apply inheritance
    public class Person
    {
        public int Id { get; set; } // Unique ID
        public string Name { get; set; } // Name of the person
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
    }
}
