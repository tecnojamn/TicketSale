using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
namespace AppWeb.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            UserDTO userDTO = ProxyManager.getUserService().authorize(txtMail.Text, txtPass.Text);
            if (userDTO != null)
            {
                Session.Add("log", SessionState.ON);
                Session.Add("mail", userDTO.mail);
                Session.Add("name", userDTO.name);
                Session.Add("userType", userDTO.userType);

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