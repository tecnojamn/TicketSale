using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWeb.Views.Controls
{
    public partial class HeaderSession : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["log"] != null && Session["log"].ToString() == "1")
            {
                lblName.Text = Session["name"].ToString();
            }

        }
    }
}