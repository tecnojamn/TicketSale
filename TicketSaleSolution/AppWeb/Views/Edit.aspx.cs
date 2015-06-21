using COM;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWeb.Views
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
                int userId;
                if (Int32.TryParse("" + Session["id"] + "", out userId))
                {
                    UserDTO userDTO = ProxyManager.getUserService().getUser(userId);
                    if (userDTO != null)
                    { 
                    
                    }
                }
            
            }
        }
       
        protected void EditUser_Click(object sender, EventArgs e)
        {
            String name = TextName.Text;
            String lastName = TextLastName.Text;
            int userId;
            if (!Int32.TryParse("" + Session["id"] + "", out userId))
            {
                AlertPanel.CssClass = "alert alert-danger";
                AlertLabel.Text = "Solo si estas logueado.";
                return;
            }
            if (name.Equals("") || name.Equals(""))
            {
                AlertPanel.CssClass = "alert alert-danger";
                AlertLabel.Text = "Los datos son requeridos.";
                return;
            }
            else {
                UserDTO userDTO = new UserDTO()
                {
                    //por ahora solo edita name y lastname
                    id = userId,
                    mail = "",
                    name = name,
                    lastName = lastName,
                    dateBirth = Convert.ToDateTime(DateTime.Today),
                    password = "",
                    active = USER.STATE.ACTIVE,
                    userType = USER.TYPE.USER,                          
                };
                
                bool res=ProxyManager.getUserService().updateUser(userDTO);
                if (res)
                {
                    AlertPanel.CssClass = "alert alert-success";
                    AlertLabel.Text = "Datos actualizados con exito.";
                }
                else {
                    AlertPanel.CssClass = "alert alert-danger";
                    AlertLabel.Text = "Ha ocurrido un error intentelo luego.";
                }

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String currPass = TextCurrentPassword.Text;
            String newPass = TextNewPassword.Text;
            String confirmation = TextConfirmationPassword.Text;
            int userId;
            if (!Int32.TryParse("" + Session["id"] + "", out userId))
            {
                AlertPanel.CssClass = "alert alert-danger";
                AlertLabel.Text = "Solo si estas logueado.";
                return;
            }
            if (newPass.Length < USER.PASSWORD.MINLENGTH)
            {
                AlertPanel.CssClass = "alert alert-danger";
                AlertLabel.Text = "La contraseña debe tener al menos" + USER.PASSWORD.MINLENGTH + " caracteres.";
                return;
            }
            if (!newPass.Equals(confirmation))
            {
                AlertPanel.CssClass = "alert alert-danger";
                AlertLabel.Text = "Las contraseñas no coinciden.";
                return;
            }
            bool res = ProxyManager.getUserService().changePassword(currPass, newPass, userId);
            if (res)
            {
                AlertPanel.CssClass = "alert alert-success";
                AlertLabel.Text = "Contraseña actualizada.";
            }
            else
            {
                AlertPanel.CssClass = "alert alert-danger";
                AlertLabel.Text = "Error al intentar cambiar la contraseña.";
                return;
            }
        }
    }

   
}