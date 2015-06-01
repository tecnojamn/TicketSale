using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BO;

namespace AppWeb.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            DTOUser dtoUser = ProxyManager.getUserService().authorize(txtMail.Text, txtPass.Text);
            if (dtoUser != null)
            {
                Session.Add("log", SessionState.ON);
                Session.Add("mail", dtoUser.mail);
                Session.Add("name", dtoUser.name);
                Session.Add("userType", dtoUser.userType);

                Response.Redirect("Default.aspx");
            }
            else { } //Error al iniciar sesion?
        }
        protected void btnSignup_Click(object sender, EventArgs e)
        {
            Response.Redirect("Signup.aspx");
        }
    }
}