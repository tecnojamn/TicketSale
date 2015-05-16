using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace AppWeb2
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //BL.UserController uc = new BL.UserController();
            //BO.User us = uc.getUser(2);
                       
            //grvUsuarios.DataSource = us;           
            //grvUsuarios.DataBind();

            BL.EventController ec = new BL.EventController();
            BO.Ticket t = ec.getTicket(5);
            
        }
    }
}