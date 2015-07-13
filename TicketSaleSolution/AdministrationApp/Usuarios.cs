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
using COM;
namespace AdministrationApp
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        public void userGridLoad()
        {
            gvUsers.Rows.Clear();
            List<UserDTO> users = ProxyManager.getUserService().getUsers(1, 100).ToList();
            foreach (UserDTO u in users)
            {
                gvUsers.Rows.Add(u.id, u.mail, u.name, u.lastName, u.dateBirth, u.active);
            }
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            userGridLoad();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            UserDTO user = new UserDTO();
            int index = gvUsers.SelectedCells[0].RowIndex;
            user.id = Convert.ToInt32(gvUsers.Rows[index].Cells["Id"].Value.ToString());
            user.dateBirth = Convert.ToDateTime(gvUsers.Rows[index].Cells["Birthday"].Value.ToString());
            user.mail = gvUsers.Rows[index].Cells["Mail"].Value.ToString();
            user.name = gvUsers.Rows[index].Cells["UserName"].Value.ToString();
            user.lastName = gvUsers.Rows[index].Cells["LastName"].Value.ToString();
            user.img = "";
            user.password = "";
            user.Reservation = null;
            user.token = "";
            user.active = USER.STATE.ACTIVE;
            user.userType = USER.TYPE.USER;
            frmUserModify frmModify = new frmUserModify(user, this);
            frmModify.ShowDialog();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gvUsers.SelectedCells[0].RowIndex;
                int idUser = Convert.ToInt32(gvUsers.Rows[index].Cells["Id"].Value.ToString());
                if (ProxyManager.getUserService().removeUser(idUser))
                {
                    MessageBox.Show("User has been disabled");
                    userGridLoad();
                }
                else
                {
                    MessageBox.Show("An error has occurred");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("An error has occurred");
            }

        }
    }
}
