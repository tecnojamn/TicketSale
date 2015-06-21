using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using COM;

namespace AppWeb.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int userId;
                if (Int32.TryParse("" + Session["id"] + "", out userId))
                {
                    Response.Redirect("Default.aspx");
                }
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtMail.Text.Equals("") || txtPass.Text.Equals("")) {
                AlertPanel.CssClass = "alert alert-danger";
                AlertLabel.Text = "Posible falta de parámetros";
                return;
            }
            if (txtPass.Text.Length < USER.PASSWORD.MINLENGTH)
            {
                AlertPanel.CssClass = "alert alert-danger";
                AlertLabel.Text = "La contraseña debe ser mayor a 8 caracteres";
                return;
            }
            UserDTO userDTO = ProxyManager.getUserService().authorize(txtMail.Text, txtPass.Text);
            if (userDTO != null)
            {
                Session.Add("log", SESSION.STATE.ON);
                Session.Add("mail", userDTO.mail);
                Session.Add("name", userDTO.name);
                Session.Add("id", userDTO.id);

                Response.Redirect("Default.aspx");
            }else {
                AlertPanel.CssClass = "alert alert-danger";
                AlertLabel.Text = "Usuario/contraseña no existentes en el sistema";
                //Response.Redirect("Login.aspx");
            } //Error al iniciar sesion?
        }
        protected void btnSignup_Click(object sender, EventArgs e)
        {
            Response.Redirect("Signup.aspx");
        }
    }
}