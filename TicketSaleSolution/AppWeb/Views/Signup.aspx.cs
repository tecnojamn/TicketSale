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
            if (!IsPostBack) { 
            int userId;
            if (Int32.TryParse("" + Session["id"] + "", out userId))
            {
                Response.Redirect("Default.aspx");
            }
            }
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
                            active = USER.STATE.INACTIVE,
                            userType = USER.TYPE.USER,
                            img = "", //Pendiente de hacer                            
                        };

                        if (ProxyManager.getUserService().newUser(userDTO))
                        {
                            AlertPanel.CssClass = "alert alert-success";
                            AlertLabel.Text = "Creado correctamente";
                            Response.Redirect("Login.aspx"); return;
                        }else{
                            AlertPanel.CssClass = "alert alert-danger";
                            AlertLabel.Text = "Error al agregar el nuevo usuario";
                            return;
                        }

                        
                    }
                }
            }
            AlertPanel.CssClass = "alert alert-danger";
            AlertLabel.Text = "Error al procesar la acción requerida";
            

        }
    }
}