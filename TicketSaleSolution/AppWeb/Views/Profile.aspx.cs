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
            int userId;
            if (Int32.TryParse("" + Session["id"] + "", out userId))
            {
                UserDTO userDTO = ProxyManager.getUserService().getUser(userId);
                if (userDTO != null)
                {
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            int userId;
            if (Int32.TryParse("" + Session["id"] + "", out userId))
            {
                ProxyManager.getUserService().removeUser(userId);
                Session["log"] = SESSION.STATE.OFF;
                Session["name"] = USER.GUESTNAME;
                Session["mail"] = "";
                Session["userType"] = "";
            }
            Response.Redirect("Default.aspx");
        }

       
    }
}