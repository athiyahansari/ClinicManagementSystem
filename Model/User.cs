using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Model
{
    // Represents associated user account
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        // Add properties like Password, Role if needed
    }
}