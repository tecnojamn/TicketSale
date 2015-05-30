using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWeb
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["log"] == null)
            {
                Session.Add("log", "0");
                Session.Add("mail", "");
                Session.Add("name", "");
            }
            if (Session["log"].ToString() == "1")
            {
                panelLogin.Controls.Add(Page.LoadControl("/Controls/HeaderSession.ascx"));
            }
        }

    }
}