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
            double _amount = 0;
            foreach (SubOrderDTO so in resDTO.SubOrder)
            {
                _amount += so.Ticket.TicketType.cost;
            }
            string _transactionCod = ProxyManager.getPaypalClient().doPayment(_amount);
            if (!_transactionCod.Equals(""))
            {
                ProxyManager.getPaymentService().newPayment(new PaymentDTO() {
                    amount = _amount,
                    idReservation=resDTO.id,
                    date=DateTime.Today,
                    PaypalPayment = new PaypalPaymentDTO()
                    {
                        transactionCod = _transactionCod,
                        idReservation=resDTO.id
                    }
                });
            }
            else
            {
                panelAlert.Visible = true;
            }
        }
    }
}