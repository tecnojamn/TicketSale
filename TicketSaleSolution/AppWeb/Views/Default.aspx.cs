using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DTO;
using COM;

namespace AppWeb.Views
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["log"] == null)
            {
                //Instancia variables de sesión
                Session.Add("log", SESSION.STATE.OFF);
                Session.Add("mail", "");
                Session.Add("name", USER.GUESTNAME);
                Session.Add("userType", "");
            }


        }
        public List<EventDTO> listViewEvents_GetData(int startRowIndex, int maximumRows, out int totalRowCount)
        {
            string path2 = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath;
            string path = System.IO.Directory.GetParent(System.IO.Directory.GetParent(System.IO.Directory.GetParent("~/").ToString()).ToString()).ToString()+"\\uploads\\events";
            string path3 = COM.PATH.UPLOADS;



            totalRowCount = 5; // falta funcion getEventsCount
            int page = startRowIndex/maximumRows+1;
            int pageSize = maximumRows;
            List<EventDTO> events = ProxyManager.getEventService().getEvents(page, pageSize).ToList();
            return events;
        }

        protected void linkEvent_Click(object sender, CommandEventArgs e)
        {
            string idEvent = e.CommandArgument.ToString();
            Response.Redirect("Events.aspx?id="+idEvent);

        }
    }
}