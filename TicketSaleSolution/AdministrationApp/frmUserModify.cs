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
    public partial class frmUserModify : Form
    {
        frmUsuarios frmParent = new frmUsuarios();
        UserDTO user = new UserDTO();
        public frmUserModify(UserDTO user, frmUsuarios parent)
        {
            frmParent = parent;
            this.user = user;
            InitializeComponent();
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void frmUserModify_Load(object sender, EventArgs e)
        {
            txtId.Text = user.id.ToString();
            txtMail.Text = user.mail;
            txtName.Text = user.name;
            txtLastName.Text = user.lastName;
            txtDay.Text = user.dateBirth.Day.ToString();
            txtMonth.Text = user.dateBirth.Month.ToString();
            txtYear.Text = user.dateBirth.Year.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtLastName.Text != "" && txtMail.Text != "" && txtYear.Text != "" && txtDay.Text != "" && txtMonth.Text != "")
            {
                if (Convert.ToInt32(txtYear.Text) < (DateTime.Now.Year - 18))
                {
                    var confirmResult = MessageBox.Show("Are you sure to modify this user ??",
"Confirmed",
MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        user.name = txtName.Text;
                        user.lastName = txtLastName.Text;
                        user.mail = txtMail.Text;
                        if (txtPassword.Text != "")
                        {
                            user.password = txtPassword.Text;
                        }
                        try
                        {
                            DateTime birthday = new DateTime(Convert.ToInt32(txtYear.Text), Convert.ToInt32(txtMonth.Text), Convert.ToInt32(txtDay.Text), 0, 0, 0);
                            user.dateBirth = birthday;
                            try
                            {
                                if (ProxyManager.getUserService().updateUser(user))
                                {
                                    MessageBox.Show("User updated succefully");
                                    frmParent.userGridLoad();
                                    Close();
                                }
                                else
                                {
                                    MessageBox.Show("An error has ocurred");
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("An error has ocurred");
                            }
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Incorrect date");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("User should has 18 year at least");
                }
            }
            else
            {
                MessageBox.Show("Only password can be empty");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                                    var confirmResult = MessageBox.Show("Are you sure to close this window ??",
"Confirmed",
MessageBoxButtons.YesNo);
                                    if (confirmResult == DialogResult.Yes)
                                    {
                                        Close();
                                    }
        }
    }
}
