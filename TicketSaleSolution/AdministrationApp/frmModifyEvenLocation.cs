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
    public partial class frmModifyEvenLocation : Form
    {
        private frmEventLocation parent;
        private EventLocationDTO eventLocation;
        public frmModifyEvenLocation(EventLocationDTO el, frmEventLocation frmParent)
        {
            parent = frmParent;
            eventLocation = el;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmModifyEvenLocation_Load(object sender, EventArgs e)
        {
            txtId.Text = eventLocation.id.ToString(); ;
            txtName.Text = eventLocation.name;
            txtAddress.Text = eventLocation.address;
            txtPhoneNumber.Text = eventLocation.phoneNumber.ToString();
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtAddress.Text != "" && txtPhoneNumber.Text != "")
            {
                eventLocation.name = txtName.Text;
                eventLocation.address = txtAddress.Text;
                eventLocation.phoneNumber = Convert.ToInt32(txtPhoneNumber.Text );
                eventLocation.Event = null;
                if (ProxyManager.getEventService().updateEventLocation(eventLocation))
                {
                    MessageBox.Show("Event location modify successfully");
                    parent.gvEventLocatioLoad();
                    Close();
                }
                else
                {
                    MessageBox.Show("An erro has ocurred");
                }
            }
            else
            {
                MessageBox.Show("All fields are required");
            }
        }
    }
}
