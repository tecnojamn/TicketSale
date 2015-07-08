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
        String imgPath;
        public string IMG_PATH { get { return imgPath; } }
        protected void Page_Load(object sender, EventArgs e)
        {
            imgPath = COM.PATH.UPLOADS_VISTA;
            if (Session["log"] == null)
            {
                //Instancia variables de sesión
                Session.Add("log", SESSION.STATE.OFF);
                Session.Add("mail", "");
                Session.Add("name", USER.GUESTNAME);
                Session.Add("id", "");
            }
        }
        public List<EventDTO> listViewEvents_GetData(int startRowIndex, int maximumRows, out int totalRowCount)
        {
            //testing paths
            string path = COM.PATH.UPLOADS_VISTA;
            totalRowCount = 5; // falta funcion getEventsCount
            int page = startRowIndex/maximumRows+1;
            int pageSize = maximumRows;
            List<EventDTO> events = ProxyManager.getEventService().getFeaturedEvents(page, pageSize).ToList();
            return events;
        }

        protected void linkEvent_Click(object sender, CommandEventArgs e)
        {
            string idEvent = e.CommandArgument.ToString();
            Response.Redirect("Events.aspx?id="+idEvent);

        }
    }
}