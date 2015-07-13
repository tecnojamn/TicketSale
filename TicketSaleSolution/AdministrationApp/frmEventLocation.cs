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
    public partial class frmEventLocation : Form
    {
        public frmEventLocation()
        {
            InitializeComponent();
        }
        public void gvEventLocatioLoad()
        {
            gvEventLocation.Rows.Clear();
            List<EventLocationDTO> locals = ProxyManager.getEventService().getLocals().ToList();
            foreach (EventLocationDTO l in locals)
            {
                gvEventLocation.Rows.Add(l.id, l.name, l.phoneNumber, l.address);
            }
        }
        private void EventLocation_Load(object sender, EventArgs e)
        {
            gvEventLocatioLoad();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEventLocation child = new frmAddEventLocation(this);
            child.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            EventLocationDTO el = new EventLocationDTO();
            int index = gvEventLocation.SelectedCells[0].RowIndex;
            el.address = gvEventLocation.Rows[index].Cells["address"].Value.ToString();
            el.name = gvEventLocation.Rows[index].Cells["name"].Value.ToString();
            el.id = Convert.ToInt32(gvEventLocation.Rows[index].Cells["id"].Value.ToString());
            el.phoneNumber = Convert.ToInt32(gvEventLocation.Rows[index].Cells["phoneNumber"].Value.ToString());

            frmModifyEventLocation child = new frmModifyEventLocation(el, this);
            child.ShowDialog();
        }
    }
}
