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
        public ReservationDTO res = null;
        public frmReservationPay()
        {
            InitializeComponent();
        }

        public TextBox txtIdreserva
        {
            get
            {
                return txtIdReserva;
            }
        }

        public TextBox total
        {
            get
            {
                return txtTotal;
            }
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
                if (res == null || res.id != Convert.ToInt32(txtIdReserva.Text))
                {
                    res = ProxyManager.getReservationService().getReservation(Convert.ToInt32(txtIdReserva.Text));
                    if (res != null)
                    {
                        this.txtFechaReserva.Text = res.date.ToString("dd/MM/yyyy");
                        this.txtUsuario.Text = res.User.name + " " + res.User.lastName;
                        this.txtNombreEvento.Text = res.SubOrder.Where(s => s.active == COM.RESERVATION.SUBORDER.ACTIVE).FirstOrDefault().Ticket.TicketType.Event.name;
                        this.txtDireccionEvento.Text = res.SubOrder.First().Ticket.TicketType.Event.EventLocation.address;
                        this.txtFechaEvento.Text = res.SubOrder.First().Ticket.TicketType.Event.date.ToString("dd/MM/yyyy");
                        this.txtLugarEvento.Text = res.SubOrder.First().Ticket.TicketType.Event.EventLocation.name;
                        this.txtTipoEvento.Text = res.SubOrder.First().Ticket.TicketType.Event.type;
                        this.txtNroTelefono.Text = res.SubOrder.First().Ticket.TicketType.Event.EventLocation.phoneNumber.ToString();

                        double total = 0;

                        foreach (var so in res.SubOrder)
                        {
                            if (so.active == COM.RESERVATION.SUBORDER.ACTIVE)
                            {
                                gvTickets.Rows.Add(so.Ticket.number, so.Ticket.TicketType.cost, so.Ticket.TicketType.description);
                                total += so.Ticket.TicketType.cost;
                            }
                        }
                        txtTotal.Text = total.ToString();
                    }
                    else
                        MessageBox.Show("Such a reservation does not exist");

                }
                

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (res.Payment == null)
            {
                frmPayment payment = new frmPayment();
                payment.otherForm = this;
                payment.MdiParent = this.ParentForm;

                payment.Show();
            }
            else
                MessageBox.Show("The Reservation have been payed");


        }

        private void gvTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmReservationPay_Load(object sender, EventArgs e)
        {

        }

        private void txtIdReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Only numbers", "Danger!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
