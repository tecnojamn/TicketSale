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
    public partial class frmEventos : Form
    {

        bool isEventSelect = false;
        public frmEventos()
        {
            InitializeComponent();

        }
        private void gvEventLoad()
        {
            gvEventos.Rows.Clear();
            List<EventDTO> events = ProxyManager.getEventService().getEventsForGv().ToList();
            foreach (var ev in events)
            {
                gvEventos.Rows.Add(ev.id, ev.name, ev.type, ev.description, ev.EventLocation.name, ev.date);
            }
        }
        private void Eventos_Load(object sender, EventArgs e)
        {
            gvEventLoad();
        }


        private void gvEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex >= 0 && gvEventos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtName.Text = gvEventos.Rows[e.RowIndex].Cells["EventName"].Value.ToString();
                txtDescripcion.Text = gvEventos.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                txtId.Text = gvEventos.Rows[e.RowIndex].Cells["id"].Value.ToString();

                DateTime eventDate = Convert.ToDateTime(gvEventos.Rows[e.RowIndex].Cells["Date"].Value.ToString());

                txtDay.Text = eventDate.Day.ToString();
                txtMonth.Text = eventDate.Month.ToString();
                txtYear.Text = eventDate.Year.ToString();
                txtHour.Text = eventDate.Hour.ToString();
                txtMinutes.Text = eventDate.Minute.ToString();

                if (!isEventSelect)
                {
                    string[] types = ProxyManager.getEventService().getEventType();
                    cbType.DataSource = types;

                    List<EventLocationDTO> evLocal = ProxyManager.getEventService().getLocals().ToList();
                    cbEventLocation.DataSource = evLocal;
                    cbEventLocation.DisplayMember = "name";
                }

                int index = cbType.FindString(gvEventos.Rows[e.RowIndex].Cells["Type"].Value.ToString());
                cbType.SelectedIndex = index;

                index = cbEventLocation.FindString(gvEventos.Rows[e.RowIndex].Cells["LocationName"].Value.ToString());
                cbEventLocation.SelectedIndex = index;

                isEventSelect = true;
            }
        }

        private void gvEventos_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void gvEventos_AllowUserToDeleteRowsChanged(object sender, EventArgs e)
        {

        }

        private void gvEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEvent child = new frmAddEvent();
            child.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Si hay hay una fila seleccionada
            if (isEventSelect)
            {
                if (txtName.Text != "" && txtDescripcion.Text != "")
                {
                    EventDTO evento = new EventDTO();
                    try
                    {
                        DateTime dateEv = new DateTime(Convert.ToInt32(txtYear.Text), Convert.ToInt32(txtMonth.Text), Convert.ToInt32(txtDay.Text), Convert.ToInt32(txtHour.Text), Convert.ToInt32(txtMinutes.Text), 0);
                        evento.date = dateEv;

                        evento.description = txtDescripcion.Text;
                        evento.name = txtName.Text;
                        evento.id = Convert.ToInt32(txtId.Text);
                        evento.type = cbType.SelectedItem.ToString();
                        EventLocationDTO evLocal = (EventLocationDTO)cbEventLocation.SelectedItem;
                        evento.idEventLocation = evLocal.id;

                        evento.enabled = EVENT.STATE.ENABLE;
                        evento.EventLocation = null;
                        evento.TicketType = null;

                        if (ProxyManager.getEventService().updateEvent(evento))
                        {
                            MessageBox.Show("Event update successfully");
                            gvEventLoad();
                        }
                        else
                        {
                            MessageBox.Show("An error has ocurred");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Incorrect date or time");
                    }
                }
                else
                {
                    MessageBox.Show("Name and Description are required");
                }
            }
            else
            {
                MessageBox.Show("Select an event first");
            }
        }

        private void txtDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtMinutes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int eventId = Convert.ToInt32(gvEventos.Rows[gvEventos.SelectedRows[0].Index].Cells["id"].Value);
            ProxyManager.getEventService().cancelEvent(eventId);
            gvEventLoad();
        }
    }
}
