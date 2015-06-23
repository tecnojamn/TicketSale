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

namespace SalesApp
{
    public partial class frmReservationPay : Form
    {
        public frmReservationPay()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIdReserva.Text != "")
            { 
                ReservationDTO res = ProxyManager.getReservationService().getReservation(Convert.ToInt32(txtIdReserva.Text));
                this.txtFechaReserva.Text = res.date.ToString("dd/MM/yyyy");
                this.txtUsuario.Text = res.User.name + " " + res.User.lastName;
                this.txtNombreEvento.Text = res.SubOrder.First().Ticket.TicketType.Event.name;
                this.txtDireccionEvento.Text = res.SubOrder.First().Ticket.TicketType.Event.EventLocation.address;
                this.txtFechaEvento.Text = res.SubOrder.First().Ticket.TicketType.Event.date.ToString("dd/MM/yyyy");
                this.txtLugarEvento.Text = res.SubOrder.First().Ticket.TicketType.Event.EventLocation.name;
                this.txtTipoEvento.Text = res.SubOrder.First().Ticket.TicketType.Event.type;
                this.txtNroTelefono.Text = res.SubOrder.First().Ticket.TicketType.Event.EventLocation.phoneNumber.ToString();
                
                

                
                //res.SubOrder.GroupBy(x => x.Ticket.TicketType.id).Select(x => x.Count());
                
                foreach (var so in res.SubOrder)
                {
                  gvTickets.Rows.Add(so.Ticket.number,so.Ticket.TicketType.cost,so.Ticket.TicketType.description);
                }     
                //this.txtNombreEvento.Text = res.SubOrder;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPayment payment = new frmPayment();
            payment.MdiParent = this.ParentForm;
            payment.Show();
        }

        private void gvTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
