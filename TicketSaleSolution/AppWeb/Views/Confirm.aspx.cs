using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COM;
namespace AppWeb.Views
{
    public partial class Confirm : System.Web.UI.Page
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


            if (!IsPostBack)
            {
                if (Request.QueryString["auth_token"]!=null)
                {
                    bool res = ProxyManager.getUserService().confirmUser(Request.QueryString["auth_token"]);
                    if (res)
                    {
                        AlertPanel.CssClass = "alert alert-success";
                        AlertLabel.Text = "Usuario Confirmado, ya puede ingresar al sitio.";
                        return;
                    }
                }
                AlertPanel.CssClass = "alert alert-danger";
                AlertLabel.Text = "Código de confirmación inexistente o ya utilizado.";
                return;
            }
            

        }
    }
}