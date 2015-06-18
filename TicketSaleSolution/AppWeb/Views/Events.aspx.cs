using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using System.Data;
using COM;

namespace AppWeb.Views
{
    public partial class Events : System.Web.UI.Page
    {
        [System.Web.Services.WebMethod]
        public string GetPageMethod()
        {
            int _tickets = int.Parse(grdTickets.Rows[1].Cells[4].Text);
            _tickets++;
            grdTickets.Rows[1].Cells[4].Text = _tickets.ToString();
            return "";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            bool log = false;
            if (Session["log"] == null)
            {
                Session["log"] = SESSION.STATE.OFF;
            }
            if (Session["log"] == SESSION.STATE.ON)
            {
                log = true;
            }

            int idEvent;

            if (!IsPostBack)
            {
                if (Int32.TryParse(Request.QueryString["id"], out idEvent))
                {
                    //Le falta mucho style baby
                    EventDTO eventDTO = ProxyManager.getEventService().getEvent(idEvent);

                    name.InnerText = eventDTO.name;
                    lblDate.Text = eventDTO.date.ToString("dd/MM/yyyy");
                    lblTime.Text = eventDTO.date.ToString("HH:mm");
                    lblLoc.Text = eventDTO.EventLocation.name;
                    lblTickets.Text = eventDTO.getAvailableTicketCount().ToString() + " / " + eventDTO.getTotalTicketCount().ToString();

                    /*
                    //Creo datatable para meter en el gridview
                    DataTable dtTicketType = new DataTable();

                    //Columnas
                    dtTicketType.Columns.Add("Sector");
                    dtTicketType.Columns.Add("Costo");
                    dtTicketType.Columns.Add("Entradas");
                    if (log)
                    {
                        dtTicketType.Columns.Add("Reserva");
                    }

                    //Creo rows
                    foreach (var tt in eventDTO.TicketType)
                    {
                        DataRow _row = dtTicketType.NewRow();
                        _row["Sector"] = tt.description;
                        _row["Costo"] = tt.cost;
                        _row["Entradas"] = tt.getAvailableTicketCount() + " / " + tt.getTotalTicketCount();
                        // _row["Reservar"] = (new Button() { Text="+"});
                        if (log) { _row["Reserva"] = 0; }
                        dtTicketType.Rows.Add(_row);
                    }
                    */
                    //grdTickets.DataSource = dtTicketType;
                    grdTickets.DataBind();

                }
                else
                {
                    Response.Redirect("Default.aspx");
                }
            }

        }

        protected void btnAddTicket_Click(object sender, CommandEventArgs e)
        {
            int row = int.Parse(e.CommandArgument.ToString());
            int _tickets = int.Parse(grdTickets.Rows[row].Cells[4].Text);
            _tickets++;
            grdTickets.Rows[row].Cells[4].Text = _tickets.ToString();
        }

        protected void btnRemoveTicket_Click(object sender, CommandEventArgs e)
        {
            int row = int.Parse(e.CommandArgument.ToString());
        }
    }
}