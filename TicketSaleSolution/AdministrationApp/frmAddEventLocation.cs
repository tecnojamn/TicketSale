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
    public partial class frmAddEventLocation : Form
    {
        frmEventLocation parent;
        public frmAddEventLocation(frmEventLocation frmParent)
        {
            parent = frmParent;
            InitializeComponent();
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text != "" && txtName.Text != "" && txtPhoneNumber.Text != "")
            {
                EventLocationDTO el = new EventLocationDTO();

                el.address = txtAddress.Text;
                el.name = txtName.Text;
                el.phoneNumber = Convert.ToInt32(txtPhoneNumber.Text);

                el.id = 0;
                el.Event = null;
                if (ProxyManager.getEventService().newEventLocation(el) != 0)
                {
                    MessageBox.Show("Event location added successfully");
                    parent.gvEventLocatioLoad();
                    Close();
                }
                else
                {
                    MessageBox.Show("An error has ocurred");
                }
            }
            else
            {
                MessageBox.Show("Fill all fields");
            }
        }
    }
}
