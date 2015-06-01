using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BO;

namespace AppWeb
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["log"] == null)
            {
                Session.Add("log", SessionState.OFF);
                Session.Add("mail", "");
                Session.Add("name", "");
                Session.Add("userType", "");
            }
            if (Session["log"].ToString() == SessionState.ON)
            {
                panelLogin.Controls.Clear();
                panelLogin.Controls.Add(Page.LoadControl("/Views/Controls/HeaderSession.ascx"));
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            Response.Redirect("Signup.aspx");
        }


    }
}