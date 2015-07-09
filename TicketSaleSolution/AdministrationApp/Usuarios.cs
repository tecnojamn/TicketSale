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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            //List<UserDTO> users = ProxyManager.getUserService().getPreferredUsers().ToList();
            //foreach (var u in users)
            //{
            //    gvUsers.Rows.Add(u.id, u., ev.type, ev.description, ev.EventLocation.name, ev.date);
            //}
        }
    }
}
