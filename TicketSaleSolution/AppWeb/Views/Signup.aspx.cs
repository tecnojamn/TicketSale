using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWeb.Views
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void signupSubmit_Click(object sender, EventArgs e)
        {
            ProxyManager.getUserService().newUser(txtMail.Text, txtName.Text, txtLastName.Text, Convert.ToDateTime(dateBirth.Text), txtPass1.Text);
            Response.Redirect("Login.aspx");
        }
    }
}