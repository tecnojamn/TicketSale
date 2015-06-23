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
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

                if (null!=Request.QueryString["deleted"])
                {
                    string isUserDeletedParameter = Request.QueryString["deleted"];
                    if (isUserDeletedParameter.Equals("true")) {
                        PanelUser.Visible = false;
                        AlertPanel.CssClass = "alert alert-success";
                        AlertLabel.Text = "Su usuario ha sido eliminado del sistema.";
                        return;
                    }
                }
           
                int userId;
                if (Int32.TryParse("" + Session["id"] + "", out userId))
                {
                    UserDTO userDTO = ProxyManager.getUserService().getUser(userId);
                    if (userDTO != null)
                    {
                        PanelUser.Visible = true;
                        LblDOB.Text = userDTO.dateBirth.ToString();
                        LblLastName.Text = userDTO.lastName;
                        LblMail.Text = userDTO.mail;
                        LblName.Text = userDTO.name;
                    }
                    else {
                        Response.Redirect("Default.aspx"); return;
                    }
                }
                else {

                    Response.Redirect("Default.aspx");

                }
           
        }

        protected void Unsuscribe_Click(object sender, EventArgs e)
        {
            int userId;
            if (Int32.TryParse("" + Session["id"] + "", out userId))
            {
                bool res=ProxyManager.getUserService().removeUser(userId);
                Session["log"] = SESSION.STATE.OFF;
                Session["name"] = USER.GUESTNAME;
                Session["mail"] = "";
                Session["userType"] = "";
                if (res) {
                    Response.Redirect("Profile.aspx?deleted=true"); return;
                }
            }
            Response.Redirect("Default.aspx");
            
        }

        protected void GotoEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Edit.aspx");
        }

       
    }
}