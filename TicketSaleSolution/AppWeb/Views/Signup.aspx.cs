using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;

namespace AppWeb.Views
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void signupSubmit_Click(object sender, EventArgs e)
        {
            if (txtMail.Text != "" && txtName.Text != "" && txtLastName.Text != "" && dateBirth.Text != "" && txtPass1.Text != "" && txtPass2.Text != "")
            {
                if (txtPass1.Text == txtPass2.Text)
                {
                    if (txtPass1.Text.Length >= inputRestriction.minLenghtPass)
                    {
                        UserDTO userDTO = new UserDTO()
                        {
                            mail = txtMail.Text,
                            name = txtName.Text,
                            lastName = txtLastName.Text,
                            dateBirth = Convert.ToDateTime(dateBirth.Text),
                            password = txtPass1.Text
                        };
                        ProxyManager.getUserService().newUser(userDTO);
                        Response.Redirect("Login.aspx");
                    }
                }
            }

        }
    }
}