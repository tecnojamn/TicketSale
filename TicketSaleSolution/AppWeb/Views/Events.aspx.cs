using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;

namespace AppWeb.Views
{
    public partial class Events : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int idEvent;

            if (Int32.TryParse(Request.QueryString["id"], out idEvent))
            {
                EventDTO eventDTO = ProxyManager.getEventService().getEvent(idEvent);
                //Hay que traer mas weas de las entradas y eso

                name.InnerText = eventDTO.name;
                lblDate.Text = eventDTO.date.ToString("dd/MM/yyyy");
                lblTime.Text = eventDTO.date.ToString("HH:mm");
                lblLoc.Text = eventDTO.EventLocation.name;
            }

            else
            {
                Response.Redirect("Default.aspx");
            }
        }
    }
}