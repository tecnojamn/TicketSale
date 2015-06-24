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

                        if (log)
                        {
                            //_row["ttid"] = tt.id;
                        }
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
                EventDTO eventDTO = ProxyManager.getEventService().getEvent(int.Parse(Request.QueryString["id"]));
                int ttCount = gvTickets.Rows.Count;
                int[,] tickets = new int[ttCount, 2];
                int i;
                int j;
                int ticketQuantity;
                bool parsingError = false;


                for (i = 0; i < gvTickets.Rows.Count; i++)
                {
                    string auxTicketQuantity = ((TextBox)gvTickets.Rows[i].Cells[3].FindControl("txtTickets")).Text;
                    if (auxTicketQuantity.Equals("")) { auxTicketQuantity = "0"; }
                    if (int.TryParse(auxTicketQuantity, out ticketQuantity))
                    {
                        tickets[i, 0] = ticketQuantity;
                        tickets[i, 1] = i;
                    }
                    else { parsingError = true; break; } //ERROR de PARSEO en CANTIDAD DE ENTRADAS

                }

                if (!parsingError)
                {

                    List<SubOrderDTO> listSubOrderDTO = new List<SubOrderDTO>();
                    //int idTicket = eventDTO.TicketType.Skip(tickets[0, 1]).FirstOrDefault().Ticket.Where(t => t.SubOrder.Count == 0 || t.SubOrder.Where(so => so.active == RESERVATION.SUBORDER.ACTIVE).Count() == 0).Skip(1).FirstOrDefault().id;

                    for (i = 0; i < ttCount; i++)
                    {
                        for (j = 0; j < tickets[i, 0]; j++)
                        {
                            listSubOrderDTO.Add(
                                new SubOrderDTO()
                                {
                                    active = (byte)RESERVATION.SUBORDER.ACTIVE,
                                    idTicket = eventDTO.TicketType
                                        .Skip(tickets[i, 1])
                                        .FirstOrDefault()
                                        .Ticket
                                            .Where(t => t.SubOrder.Count == 0 || t.SubOrder.Where(so => so.active == RESERVATION.SUBORDER.ACTIVE).Count() == 0)
                                            .Skip(j)
                                            .FirstOrDefault().id,
                                }
                            );
                        }
                    }

                    ReservationDTO resDTO = new ReservationDTO()
                    {
                        date = DateTime.Today,
                        idUser = int.Parse(Session["id"].ToString()),
                        SubOrder = listSubOrderDTO
                    };

                    ProxyManager.getReservationService().newReservation(resDTO);
                }
                else { }//ERROR DE PARSEO, METIO STRING EN CANTIDAD DE ENTRADAS

            }
        }
    }
}