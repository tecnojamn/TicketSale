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
    public partial class frmAddTicketType : Form
    {
        frmAddEvent frmParent = null;
        public frmAddTicketType(frmAddEvent parent)
        {
            InitializeComponent();
            frmParent = parent;

        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtMinNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtMaxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to cancel this window ??",
"Confirmed",
MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCost.Text != "" && txtDescription.Text != "" && txtMaxNumber.Text != "" && txtMinNumber.Text != "")
            {
                var confirmResult = MessageBox.Show("Are you sure to add this ticket type ??",
"Confirmed",
MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    int cost = Convert.ToInt32(txtCost.Text);
                    int maxNum = Convert.ToInt32(txtMaxNumber.Text);
                    int minNum = Convert.ToInt32(txtMinNumber.Text);
                    String description = txtDescription.Text;
                    if (maxNum > minNum)
                    {
                        TicketTypeDTO tt = new TicketTypeDTO();
                        tt.cost = cost;
                        tt.description = description;
                        tt.startNum = minNum;
                        tt.finalNum = maxNum;

                        tt.Ticket = null;
                        tt.Event = null;
                        tt.idEvent = 0;
                        frmParent.addTicketType(tt);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Min number should be smaller than Max number");
                    }
                }
            }
            //frmParent.addTicketType();
        }
    }
}
