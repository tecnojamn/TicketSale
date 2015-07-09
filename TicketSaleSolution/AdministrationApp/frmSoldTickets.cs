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
    public partial class frmSoldTickets : Form
    {
        public frmSoldTickets()
        {
            InitializeComponent();
        }

        private void frmSoldTickets_Load(object sender, EventArgs e)
        {
            for (int i = 2000; i <= 2016; i++)
            {
                cbDate1Year.Items.Add(i);
                cbDate2Year.Items.Add(i);
            }
            for (int i = 1; i <= 12; i++)
            {
                cbDate1Month.Items.Add(i);
                cbDate2Month.Items.Add(i);
            }
            for (int i = 1; i <= 31; i++)
            {
                cbDate1Day.Items.Add(i);
                cbDate2Day.Items.Add(i);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            List<EventDTO> events = ProxyManager.getEventService()
                .getSoldTickets
                (new DateTime(Convert.ToInt32(cbDate1Year.Text), Convert.ToInt32(cbDate1Month.Text), Convert.ToInt32(cbDate1Day.Text)),
                new DateTime(Convert.ToInt32(cbDate2Year.Text), Convert.ToInt32(cbDate2Month.Text), Convert.ToInt32(cbDate2Day.Text)))
                .ToList();
            int cont;
            foreach (EventDTO ev in events)
            {
                cont = 0;
                foreach (TicketTypeDTO tt in ev.TicketType)
                {
                    foreach (TicketDTO t in tt.Ticket)
                    {
                        foreach (SubOrderDTO so in t.SubOrder)
                        {
                            if (so.active == COM.RESERVATION.SUBORDER.ACTIVE && so.Reservation.Payment != null)
                            {
                                cont++;
                            }
                        }
                    }
                }
                gvEvents.Rows.Add(ev.id, ev.name, ev.date.Date, ev.EventLocation.name, ev.description, ev.type, cont);

            }
        }
    }
}
