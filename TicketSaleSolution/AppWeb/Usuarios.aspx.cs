using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWeb
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BL.OrderController oc = new BL.OrderController();
            //oc.getReservationsByUser(2);
            /*BL.UserController uc = new BL.UserController();
            BO.User user = new BO.User();
            user.name = "prueba";
            user.lastName = "prueba";
            user.mail = "prueba@prueba";
            user.mobileNum = 2123123;
            user.Order = null;
            user.password = "123456";
            user.userType = 1;
            uc.push(user);*/
            //grvUsuarios.DataSource = uc.getUser(3);
            //grvUsuarios.DataBind();
            
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