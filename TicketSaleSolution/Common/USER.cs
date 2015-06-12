using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace COM
{

    public class USER
    {
        public struct TYPE
        {
            public static byte ADMIN = 1;
            public static byte USER = 0;
        }
        public struct PASSWORD
        {
            public static int MINLENGTH = 6;
        }
        public struct STATE
        {
            public static byte ACTIVE = 1;
            public static byte INACTIVE = 0;
        }

        public static string GUESTNAME = "Invitado";

        
    }
}
