using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWeb.Views.Paypal
{
    public partial class PaymentConfirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            panelAlert.Visible = false;
            int idReservation = int.Parse(Request.QueryString["res_id"]);
            ReservationDTO resDTO = ProxyManager.getReservationService().getReservation(idReservation);
            double amount = 0;
            foreach (SubOrderDTO so in resDTO.SubOrder)
            {
                amount += so.Ticket.TicketType.cost;
            }
            lblMail.Text = resDTO.User.mail;
            lblEvent.Text = resDTO.SubOrder.First().Ticket.TicketType.Event.name;
            lblAmount.Text = "$" + amount.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int idReservation = int.Parse(Request.QueryString["res_id"]);
            ReservationDTO resDTO = ProxyManager.getReservationService().getReservation(idReservation);
            double amount = 0;
            foreach (SubOrderDTO so in resDTO.SubOrder)
            {
                amount += so.Ticket.TicketType.cost;
            }
            if (ProxyManager.getPaypalClient().doPayment(amount))
            {
                ProxyManager.getPaymentService().newPayment(null);
            }
            else
            {
                panelAlert.Visible = true;
            }
        }
    }
}