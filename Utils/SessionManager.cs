//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CMS.Utils
//{
//    internal class SessionManager
//    {
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Utils
{
    internal class SessionManager
    {
        // Will hold whichever user ID patient logged in from
        public static int CurrentUserId { get; set; }

        // Will hold whichever doctor ID doctor logged in from
        public static int CurrentDoctorId { get; set; }
    }
}