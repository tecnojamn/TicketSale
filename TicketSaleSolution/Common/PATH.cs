using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace COM
{
    public class PATH
    {
        public static string UPLOADS = Directory.GetParent(Directory.GetParent(Directory.GetParent(System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath).ToString()).ToString()).ToString() + "\\uploads";
        
        public static string BASE_URL = "http://localhost:1341/";
        public static string UPLOADS_VISTA = BASE_URL + "/uploads/events/";
    }
}
