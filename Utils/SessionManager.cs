using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Utils
{
    internal class SessionManager
    {
        // Will hold whichever user ID just logged in
        public static int CurrentUserId { get; set; }
    }
}
