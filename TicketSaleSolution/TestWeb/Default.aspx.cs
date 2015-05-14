using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
using BO;

namespace TestWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserController uc = new UserController();
            User us = uc.getUser(2);
            Response.Write(us.id + " - " + us.name + " - " + us.mail);
        }
    }
}