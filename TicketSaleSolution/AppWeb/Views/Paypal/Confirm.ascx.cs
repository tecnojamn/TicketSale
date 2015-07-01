using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWeb.Views.Paypal
{
    public partial class Confirm : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            panelAlert.Visible = false;
            int idReservation = int.Parse(((HiddenField)this.Parent.FindControl("hfReservationId")).Value);
            ReservationDTO resDTO = ProxyManager.getReservationService().getReservation(idReservation);
            double amount = 0;
            foreach (SubOrderDTO so in resDTO.SubOrder)
            {
                amount += so.Ticket.TicketType.cost;
            }
            lblMail.Text = resDTO.User.mail;
            lblEvent.Text = resDTO.SubOrder.First().Ticket.TicketType.Event.name;
            lblAmount.Text = "$" + amount.ToString();
            ((HiddenField)this.Parent.FindControl("hfAccess")).Value = "1";

        }
        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            int idReservation = int.Parse(((HiddenField)this.Parent.FindControl("hdReservationId")).Value);
            ReservationDTO resDTO = ProxyManager.getReservationService().getReservation(idReservation);
            double amount = 0;
            foreach (SubOrderDTO so in resDTO.SubOrder)
            {
                amount += so.Ticket.TicketType.cost;
            }
            if (ProxyManager.getPaypalClient().doPayment(amount))
            {

            }
            else
            {
                panelAlert.Visible = true;
            }

        }
    }
}