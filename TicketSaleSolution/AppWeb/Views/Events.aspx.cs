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
                    EventDTO eventDTO = ProxyManager.getEventService().getEvent(idEvent);

                    name.InnerText = eventDTO.name;
                    lblDate.Text = eventDTO.date.ToString("dd/MM/yyyy");
                    lblTime.Text = eventDTO.date.ToString("HH:mm");
                    lblLoc.Text = eventDTO.EventLocation.name;
                    lblTickets.Text = eventDTO.getAvailableTicketCount().ToString() + " / " + eventDTO.getTotalTicketCount().ToString();

                    DataTable dt = new DataTable();

                    //Columnas
                    dt.Columns.Add("Sector");
                    dt.Columns.Add("Costo");
                    dt.Columns.Add("EntradasDisponibles");



                    foreach (var tt in eventDTO.TicketType)
                    {
                        DataRow _row = dt.NewRow();
                        _row["Sector"] = tt.description;
                        _row["Costo"] = tt.cost;
                        _row["EntradasDisponibles"] = tt.getAvailableTicketCount();
                        // _row["Reservar"] = (new Button() { Text="+"});

                        //if (log) { _row["Reserva"] = 0; }
                        dt.Rows.Add(_row);
                    }

                    /*
                    //Creo datatable para meter en el gridview
                    DataTable dtTicketType = new DataTable();

                    //Columnas
                    dtTicketType.Columns.Add("Sector");
                    dtTicketType.Columns.Add("Costo");
                    dtTicketType.Columns.Add("Disponibles/Totales");


                    //Creo rows
                    foreach (var tt in eventDTO.TicketType)
                    {
                        DataRow _row = dtTicketType.NewRow();
                        _row["Sector"] = tt.description;
                        _row["Costo"] = tt.cost;
                        _row["Entradas"] = tt.getAvailableTicketCount() + " / " + tt.getTotalTicketCount();
                        // _row["Reservar"] = (new Button() { Text="+"});
                        //if (log) { _row["Reserva"] = 0; }
                        dtTicketType.Rows.Add(_row);
                    }*/
                    if (!log)
                    {
                        gvTickets.Columns.RemoveAt(3);
                    }


                    gvTickets.DataSource = dt;


                    gvTickets.DataBind();


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
            int _tickets = int.Parse(gvTickets.Rows[row].Cells[4].Text);
            _tickets++;
            gvTickets.Rows[row].Cells[4].Text = _tickets.ToString();
        }

        protected void btnRemoveTicket_Click(object sender, CommandEventArgs e)
        {
            int row = int.Parse(e.CommandArgument.ToString());
        }

        protected void btnDoReserve_Click(object sender, EventArgs e)
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

            if (!log)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                int ttCount = gvTickets.Rows.Count;
                int[,] tickets = new int[ttCount,2];

                for (int i = 0; i < gvTickets.Rows.Count; i++)
                {
                    tickets[i, 0] = int.Parse(((TextBox)gvTickets.Rows[i].Cells[3].FindControl("txtTickets")).Text);
                    tickets[i, 1] = i+1;
                }

                List<SubOrderDTO> listSubOrderDTO = new List<SubOrderDTO>();
               // listSubOrderDTO.Add()

                ReservationDTO resDTO = new ReservationDTO(){
                    date = DateTime.Today,
                    idUser = int.Parse(Session["id"].ToString()),
                    
                    
                };
                
            }
        }
    }
}