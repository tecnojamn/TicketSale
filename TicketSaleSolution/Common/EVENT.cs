using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM
{
    public class EVENT
    {
        public struct STATE
        {
            public static byte ENABLE = 1;
            public static byte UNABLE = 0;
            public static int pageSize = 10;
        }

        public struct REPORT
        {
            public static byte BEST = 1;
            public static byte WORST = 0;
        }
        public List<string> EVENT_TYPE = new List<string>() {"futbol", "cine", "circo", "teatro", "musical", "deporte"};
    }
}
