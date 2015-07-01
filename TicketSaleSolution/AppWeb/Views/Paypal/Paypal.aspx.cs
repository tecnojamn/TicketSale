using COM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWeb.Views.Paypal
{
    public partial class Paypal : System.Web.UI.Page
    {
        string redirectTo = "../Default.aspx"; //En caso de error
        protected void Page_Load(object sender, EventArgs e)
        {
            if (hfAccess.Value != "1")
            {
                if (Request.QueryString.Count == 1)
                {
                    if (Session["log"].ToString().Equals(SESSION.STATE.ON))
                    {
                        int idReservation;
                        if (int.TryParse(Request.QueryString["idReservation"], out idReservation))
                        {
                            hfReservationId.Value = idReservation.ToString();
                            int idUser = ProxyManager.getReservationService().getReservation(idReservation).idUser; //Esta logueado el dueño de la reserva?

                            if (idUser == int.Parse(Session["id"].ToString()))
                            {
                                panelContent.Controls.Add(Page.LoadControl("Login.ascx"));
                            }
                            else { Response.Redirect(redirectTo); }
                        }
                        else { Response.Redirect(redirectTo); }

                    }
                    else { Response.Redirect(redirectTo); }
                }

            }
        }
    }
}
