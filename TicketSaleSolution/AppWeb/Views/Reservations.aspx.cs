using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using COM;
using AppWeb.WebEntities;
using System.Web.Services;

namespace AppWeb.Views
{
    public partial class Reservations : System.Web.UI.Page
    {
        [WebMethod(BufferResponse = false)]
        public static string cancelSubOrder(string idSO)
        {
            return ProxyManager.getReservationService().cancelSubOrder(int.Parse(idSO)) ? "true" : "false";
        }
        [WebMethod(BufferResponse = false)]
        public static string cancelAllSubOrders(string idRes)
        {
            return "true";
            //return ProxyManager.getReservationService().cancelAllSubOrders(int.Parse(idRes))? "true":"false";
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["log"] != null && Session["log"].Equals(SESSION.STATE.ON))
            {

                //Action Cancelar Suborden
                if (Request.QueryString["action"] != null && Request.QueryString["action"].Equals("cancel_suborder"))
                {
                    int idRes = 0;
                    int idSO = 0;
                    try
                    {
                        idRes = int.Parse(Request.QueryString["res_id"]);
                        idSO = int.Parse(Request.QueryString["suborder_id"]);
                    }
                    catch (Exception)
                    {
                        Response.Redirect("Reservation.aspx");
                    }
                    ReservationDTO resDTO = ProxyManager.getReservationService().getReservation(idRes);
                    if (Session["id"].ToString().Equals(resDTO.idUser.ToString()))
                    {
                        if (ProxyManager.getReservationService().cancelSubOrder(idSO))
                        {
                            Response.Redirect("Reservations.aspx?page=" + Request.QueryString["page"].ToString() + "&item=" + Request.QueryString["item"].ToString());
                        }
                    }
                    else
                    {
                        Response.Redirect("Reservations.aspx");
                    }

                }

            }
        }
        //Obtener monto total a pagar de una reserva
        public double getTotalAmount(ICollection<SubOrderDTO> soDTO)
        {
            double _amount = 0;
            foreach (var so in soDTO)
            {
                if (so.active == RESERVATION.SUBORDER.ACTIVE)
                    _amount += so.Ticket.TicketType.cost;
            }
            return _amount;
        }
        public string isPaid(PaymentDTO p, int itemIndex)
        {
            if (p == null)
            {
                //Sin pagar
                return "PAGAR";
                ((LinkButton)lvReservations.Items[itemIndex].FindControl("btnCancelAllSubOrders")).Visible = true;
            }
            else
            {
                if (p.CashPayment != null)
                {

                    return "PAGA (EFECTIVO: " + p.date + ")";
                }

                else
                {
                    return "PAGA (PAYPAL: " + p.date.ToString("dd/MM/yyyy") + ")";
                }
            }
        }
        public string alreadyCanceled(ICollection<SubOrderDTO> subOrders)
        {
            if (subOrders.Where(so => so.active == RESERVATION.SUBORDER.ACTIVE).Count() == 0)
            {
                return "CANCELADA";
            }
            else
            {
                return "CANCELAR";
            }
        }
        public List<ReservationDTO> lvReservations_GetData(int startRowIndex, int maximumRows, out int totalRowCount)
        {

            totalRowCount = 0;

            //Obtener id de usuario logueado , sino redirigir al Default
            if (Session["log"] != null && Session["log"].Equals(SESSION.STATE.ON))
            {
                int page;
                int pageSize;
                int _idUser;
                int idRes;

                if (Request.QueryString["page"] == null || !int.TryParse(Request.QueryString["page"], out page))
                {
                    page = startRowIndex / maximumRows + 1;
                }

                pageSize = maximumRows;

                //id Usuario
                _idUser = int.Parse(Session["id"].ToString());


                //Cantidad de reservas de un usuario para paginador.
                totalRowCount = ProxyManager.getReservationService().getReservationCountByUser(_idUser, false);
                //Reservas de usuario para mostrar en el listView
                List<ReservationDTO> listResDTO = ProxyManager.getReservationService().getReservationsByUser(_idUser, page, pageSize).ToList();

                return listResDTO;
            }
            else
            {
                Response.Redirect("Default.aspx");
                return null;
            }
        }

        protected void showSubOrders_Command(object sender, CommandEventArgs e)
        {

            string[] args = new string[2];
            args = e.CommandArgument.ToString().Split(';');
            int itemIndex = int.Parse(args[0]) - lvDataPager.StartRowIndex;
            int idRes = int.Parse(args[1]);
            // Argumentos: index del elemento clickeado ; id de la reserva clickeada


            ReservationDTO resDTO = ProxyManager.getReservationService().getReservation(idRes);

            List<GridViewSubOrderItem> gridViewSOItems = new List<GridViewSubOrderItem>();


            bool isPaid = resDTO.Payment != null ? true : false;

            foreach (SubOrderDTO so in resDTO.SubOrder)
            {
                //int _state = so.active == RESERVATION.SUBORDER.INACTIVE ? (int)SubOrderGridItemState.CANCELED : (isPaid ? (int)SubOrderGridItemState.PAID : (int)SubOrderGridItemState.UNPAID);
                gridViewSOItems.Add(new GridViewSubOrderItem()
                {
                    id = so.id,
                    description = so.Ticket.TicketType.description,
                    amount = so.Ticket.TicketType.cost,

                    stateOrCancel = so.active == RESERVATION.SUBORDER.INACTIVE ? "Cancelada" : (isPaid ? "Paga" : "Pendiente")
                });
            }



            GridView gvSubOrders = new GridView();
            gvSubOrders.DataSource = gridViewSOItems;
            gvSubOrders.ID = "gvSubOrders";


            //Mostrar gridview con detalle de SubOrdenes
            lvReservations.Items[itemIndex].Controls.Add(gvSubOrders);

            ((GridView)lvReservations.Items[itemIndex].FindControl("gvSubOrders")).DataBind();

            for (int i = 0; i < gridViewSOItems.Count(); i++)
            {
                switch (gridViewSOItems[i].stateOrCancel)
                {
                    case "Pendiente":
                        Button btnCancelSubOrder = new Button()
                        {
                            ID = "btnCancelSubOrder",
                            Text = "CANCELAR",
                            CssClass = "btn-primary",
                            UseSubmitBehavior = false,
                            OnClientClick = "cancelSubOrder(" + gridViewSOItems[i].id + "," + i + "," + itemIndex + ");return false"
                        };
                        gvSubOrders.Rows[i].Cells[3].Controls.Add(btnCancelSubOrder);
                        break;
                    case "Cancelada":
                        Literal lc = new Literal()
                        {
                            Text = "<div style='background-color:#e74c3c'>Cancelada</div>"

                        };
                        gvSubOrders.Rows[i].Cells[3].Controls.Add(lc);
                        break;
                    case "Paga":
                        //Cuando está paga..
                        break;
                    default:
                        break;
                }
            }
        }

        void btnDoPayment_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        protected void lvReservations_DataBinding(object sender, EventArgs e)
        {
            //int itemIndex;
            //int idRes;
            //if (!alreadyCanceled && Request.QueryString["item"] != null && Request.QueryString["res_id"] != null && int.TryParse(Request.QueryString["item"].ToString(), out itemIndex) && int.TryParse(Request.QueryString["res_id"].ToString(), out idRes))
            //{
            //    string args = itemIndex.ToString() + ";" + idRes.ToString();
            //    CommandEventArgs eSubOrder = new CommandEventArgs("", itemIndex);
            //    showSubOrders_Command(null, eSubOrder);
            //}

        }

        protected void btnCancelAllSubOrders_Command(object sender, CommandEventArgs e)
        {
            string[] args = new string[2];
            args = e.CommandArgument.ToString().Split(';');
            if (ProxyManager.getReservationService().cancelAllSubOrders(int.Parse(args[1])))
            {
                showSubOrders_Command(null, new CommandEventArgs("", args[0] + ";" + args[1]));
            }
        }

        protected void btnDoPayment_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("Paypal/Auth.aspx/res_id=" + e.CommandArgument.ToString());
        }

    }
}