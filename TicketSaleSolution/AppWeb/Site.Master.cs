using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using COM;

namespace AppWeb
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["log"] == null)
            {
                Session.Add("log", SESSION.STATE.OFF);
                Session.Add("mail", "");
                Session.Add("id", 0);
                Session.Add("name", USER.GUESTNAME);
                Session.Add("userType", "");
            }
            else if (Session["log"].ToString() == SESSION.STATE.ON)
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

        protected void imgbtnLogo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "" && txtSearch.Text != null)
            {
                Response.Redirect("Search.aspx?searchText="+txtSearch.Text);
            }
        }
    }
}