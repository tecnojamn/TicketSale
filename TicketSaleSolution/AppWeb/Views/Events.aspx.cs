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

                name.InnerText = eventDTO.name;
                lblDate.Text = eventDTO.date.ToString("dd/MM/yyyy");
                lblTime.Text = eventDTO.date.ToString("HH:mm");
                lblLoc.Text = eventDTO.EventLocation.name;
                lblTickets.Text = eventDTO.getAvailableTicketCount().ToString() + " / "+ eventDTO.getTotalTicketCount().ToString();

                grdTickets.DataSource = eventDTO.TicketType;
                
                grdTickets.DataBind();
            }

            else
            {
                Response.Redirect("Default.aspx");
            }
        }
    }
}