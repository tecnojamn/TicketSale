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
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void signupSubmit_Click(object sender, EventArgs e)
        {
            if (txtMail.Text != "" && txtName.Text != "" && txtLastName.Text != "" && dateBirth.Text != "" && txtPass1.Text != "" && txtPass2.Text != "")
            {
                if (txtPass1.Text == txtPass2.Text)
                {
                    if (txtPass1.Text.Length >= USER.PASSWORD.MINLENGTH)
                    {
                        UserDTO userDTO = new UserDTO()
                        {
                            mail = txtMail.Text,
                            name = txtName.Text,
                            lastName = txtLastName.Text,
                            dateBirth = Convert.ToDateTime(dateBirth.Text),
                            password = txtPass1.Text,
                            active = USER.STATE.ACTIVE, //CAMBIAR POR INACTIVE CUANDO SE HAGA LA CONFIRMACION POR MAIL
                            userType = USER.TYPE.USER ,
                            img = "", //Pendiente de hacer                            
                        };

                        if (ProxyManager.getUserService().newUser(userDTO))
                        {
                            Response.Redirect("Login.aspx");
                        }

                        
                    }
                }
            }
            AlertPanel.CssClass = "alert alert-danger";
            AlertLabel.Text = "Usuario/contraseña no existentes en el sistema";

        }
    }
}