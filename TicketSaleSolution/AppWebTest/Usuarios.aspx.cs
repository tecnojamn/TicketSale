using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWebTest
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BL.UserController uc = new BL.UserController();

            GridView1.DataSource = uc.getUsers();
            GridView1.DataBind();
            
        }
    }
}