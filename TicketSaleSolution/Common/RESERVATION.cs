using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM
{
    public class RESERVATION
    {
        public struct SUBORDER
        {
            public static int ACTIVE = 1;
            public static int INACTIVE = 0;
        }
        public struct TICKET
        {
            public struct CODE
            {
                public static int LENGTH = 5;
                public static string CHARS = "0123456789";
            }
        }
    }
}
