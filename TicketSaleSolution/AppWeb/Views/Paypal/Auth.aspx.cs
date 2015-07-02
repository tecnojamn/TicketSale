using COM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWeb.Views.Paypal
{
    public partial class Auth : System.Web.UI.Page
    {
        string redirectTo = "../Default.aspx"; //En caso de error
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["log"].ToString().Equals(SESSION.STATE.ON))
            {
                int idReservation;
                if (int.TryParse(Request.QueryString["res_id"], out idReservation))
                {
                    int idUser = ProxyManager.getReservationService().getReservation(idReservation).idUser; //Esta logueado el dueño de la reserva?
                    if (idUser != int.Parse(Session["id"].ToString()))
                    {
                        Response.Redirect(redirectTo);
                    }
                }
                else
                {
                    Response.Redirect(redirectTo);
                }

            }
            else
            {
                Response.Redirect(redirectTo);
            }


            panelAlert.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (ProxyManager.getPaypalClient().login(txtUser.Text, txtPassword.Text))
            {
                int idReservation = int.Parse(Request.QueryString["res_id"]);
                Response.Redirect("PaymentConfirmation.aspx?res_id=" + idReservation + "&auth_token=asdxx36az339982345hhfdfsdfgjhdfgshdfJarasBlackFingerdfifgiug");
            }
            else
            {
                panelAlert.Visible = true;
            }
        }
    }
}