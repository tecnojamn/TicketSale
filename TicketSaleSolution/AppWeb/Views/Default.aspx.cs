using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BO;

namespace AppWeb.Views
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string hola = Session["name"].ToString();
        }

        protected void signup_Click(object sender, EventArgs e)
        {
            Response.Redirect("Signup.aspx");
        }
        protected void login_Click(object sender, EventArgs e)
        {
            SRUser.UserServiceClient prox = new SRUser.UserServiceClient();
            User user = ProxyManager.getUserService().authorize(txtMail.Text, txtPass.Text);
            if (user != null)
            {
                Session.Add("log", 1);
                Session.Add("mail", dtoUser.mail);
                Session.Add("name", dtoUser.name);
                Session.Add("userType", dtoUser.userType);
            }               
            else { } //Error al iniciar sesion
        }
    }
}