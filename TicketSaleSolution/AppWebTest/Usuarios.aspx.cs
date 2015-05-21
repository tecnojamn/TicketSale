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

            grvUsuarios.DataSource = uc.getUsers();
            grvUsuarios.DataBind();
            
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow gvRow = grvUsuarios.Rows[index];
            if(e.CommandName == "eliminar"){
                BL.UserController cu = new BL.UserController();

            }
        }
    }
}