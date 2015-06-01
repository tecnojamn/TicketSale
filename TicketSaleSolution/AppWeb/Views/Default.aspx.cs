using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;

namespace AppWeb.Views
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["log"] == null)
            {
                //Instancia variables de sesión
                Session.Add("log", SessionState.OFF);
                Session.Add("mail", "");
                Session.Add("name", "");
            }
            
        }
    }
}