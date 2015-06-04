using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using COM;

namespace AppWeb.Views.Controls
{
    public partial class HeaderSession : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["log"] != null)
                if (Session["log"].ToString() == SESSION.STATE.ON)
                {
                    navName.Text = Session["name"].ToString();
                }

        }

        protected void linkExit_Click(object sender, EventArgs e)
        {
            //Desloguear y redirigir
            Session["log"] = SESSION.STATE.OFF;
            Session["name"] = USER.GUESTNAME;
            Session["mail"] = "";
            Session["userType"] = "";

            Response.Redirect("Default.aspx");
        }
    }
}