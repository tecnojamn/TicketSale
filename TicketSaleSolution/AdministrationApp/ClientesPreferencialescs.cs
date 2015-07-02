using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace AdministrationApp
{
    public partial class frmPreferredUsers : Form
    {
        public frmPreferredUsers()
        {
            InitializeComponent();
        }

        private void ClientesPreferencialescs_Load(object sender, EventArgs e)
        {
            List<UserDTO> users = ProxyManager.getUserService().getPreferredUsers().ToList();
            if (users != null)
            {
                foreach (var u in users)
                {
                    gvUsers.Rows.Add(u.mail, u.active, u.name + " " + u.lastName, u.dateBirth.ToString("dd/MM/yyyy"));
                }
            }

        }
    }
}
