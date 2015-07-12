using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COM;
using DTO;

namespace AdministrationApp
{
    public partial class frmLogin : Form
    {
        private bool canClose = false;
        MenuPrincipal frmParent = null;
        public frmLogin(MenuPrincipal parent)
        {
            frmParent = parent;
            InitializeComponent();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (canClose)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmParent.Close();
            canClose = true;
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtEmail.Text != null && txtPassword.Text != "" && txtPassword.Text != null)
            {
                UserDTO user = null;
                user = ProxyManager.getUserService().authorize(txtEmail.Text, txtPassword.Text);
                if (user == null)
                {
                    MessageBox.Show("User doesnt exist, check email and password and try again");
                }
                else if (user.userType != USER.TYPE.ADMIN)
                {
                    MessageBox.Show("User doesnt have privileges");
                }
                else
                {
                    canClose = true;
                    Close();
                }
            }
        }
    }
}
