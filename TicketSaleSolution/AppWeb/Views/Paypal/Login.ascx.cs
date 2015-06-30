using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWeb.Views.Paypal
{
    public partial class Login : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ProxyManager.getPaypalClient().login(txtUser.ToString(), txtPass.ToString()))
            {
                Panel p = (Panel)(this.Parent.FindControl("panelContent"));
                p.Controls.Clear();
                p.Controls.Add(this.LoadControl("Confirm.ascx"));
              //  String hola = tb.Text;
            }
        }
    }
}