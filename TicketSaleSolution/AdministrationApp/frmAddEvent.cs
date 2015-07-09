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
    public partial class frmAddEvent : Form
    {
        public void addTicketType(TicketTypeDTO tt)
        {
            if (tt != null)
            {
                cbTicketType.Items.Add(tt);
            }
            if (cbTicketType.Items.Count == 1)
            {
                cbTicketType.SelectedIndex = 0;
            }
        }
        public frmAddEvent()
        {
            InitializeComponent();
            cbTicketType.DisplayMember = "description";
        }

        private void frmAddEvent_Load(object sender, EventArgs e)
        {
            List<EventLocationDTO> locals = null;
            List<string> types = null;
            locals = ProxyManager.getEventService().getLocals().ToList();
            types = ProxyManager.getEventService().getEventType().ToList();

            cbType.DataSource = types;
            cbEventLocation.DataSource = locals;
            cbEventLocation.DisplayMember = "name";
            for (int i = 2000; i <= 2016; i++)
            {
                cbYear.Items.Add(i);
            }
            for (int i = 1; i <= 12; i++)
            {
                cbMonth.Items.Add(i);
            }
            for (int i = 1; i <= 31; i++)
            {
                cbDay.Items.Add(i);
            }
            for (int i = 00; i <= 23; i++)
            {
                cbHour.Items.Add(i);
            }
            for (int i = 00; i <= 59; i++)
            {
                cbMinutes.Items.Add(i);
            }
            cbEventLocation.SelectedIndex = 0;
            cbType.SelectedIndex = 0;
            cbDay.SelectedIndex = 0;
            cbMonth.SelectedIndex = 0;
            cbYear.SelectedIndex = 0;
            cbMinutes.SelectedIndex = 0;
            cbHour.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            int day = Convert.ToInt32(cbDay.Text);
            int month = Convert.ToInt32(cbMonth.Text);
            int year = Convert.ToInt32(cbYear.Text);
            int minute = Convert.ToInt32(cbMinutes.Text);
            int hour = Convert.ToInt32(cbHour.Text);

            DateTime date = new DateTime(year, month, day, hour, minute, 0);//0 es la cantidad de segundos
            EventLocationDTO el = null;
            el = (EventLocationDTO)cbEventLocation.SelectedValue;

            EventDTO newEvent = new EventDTO();
            newEvent.date = date;
            newEvent.name = txtName.Text;
            newEvent.description = txtDescripcion.Text;
            newEvent.enabled = EVENT.STATE.ENABLE;
            newEvent.type = cbType.Text;
            newEvent.EventLocation = el;
            newEvent.idEventLocation = el.id;
            newEvent.TicketType = null;
            foreach (Object tt in cbTicketType.Items)
            {
                TicketTypeDTO ticketType = (TicketTypeDTO)tt;
                if (newEvent.TicketType == null)
                {
                    List<TicketTypeDTO> ttList = new List<TicketTypeDTO>();
                    newEvent.TicketType = ttList;
                }
                newEvent.TicketType.Add(ticketType);
            }
            if (ProxyManager.getEventService().newEvent(newEvent))
            {
                DialogResult dResult = MessageBox.Show("Event added successfully");
                if (dResult == DialogResult.OK)
                {
                    Close();
                }
            }

        }

        private void btnAddTicketType_Click(object sender, EventArgs e)
        {
            frmAddTicketType formAdd = new frmAddTicketType(this);
            formAdd.ShowDialog();
        }

        private void btnDeleteTicketType_Click(object sender, EventArgs e)
        {
            cbTicketType.Items.Remove(cbTicketType.SelectedIndex);
        }
    }
}
