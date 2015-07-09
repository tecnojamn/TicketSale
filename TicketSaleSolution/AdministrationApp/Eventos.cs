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
    public partial class frmEventos : Form
    {
        public frmEventos()
        {
            InitializeComponent();

        }
        List<EventDTO> events = ProxyManager.getEventService().getEventsForGv().ToList();




        private void button1_Click(object sender, EventArgs e)
        {
            EventDTO evento = new EventDTO();
            string date = cbDay.Text + "/" + cbMonth.Text + "/" + cbYear.Text + " " + cbHour.Text + ":" + cbMinutes.Text + ":00 ";
            if (Convert.ToInt32(cbHour.Text) >= 12)
            {
                date += "PM";
            }
            else
                date += "AM";
            DateTime dateEv = DateTime.Parse(date, System.Globalization.CultureInfo.InvariantCulture);
            evento.date = dateEv;
            evento.description = txtDescripcion.Text;
            evento.name = txtName.Text;
            evento.id = Convert.ToInt32(txtId.Text);
            evento.type = cbType.SelectedItem.ToString();
            evento.idEventLocation = 0;
        }

        private void Eventos_Load(object sender, EventArgs e)
        {
            foreach (var ev in events)
            {
                gvEventos.Rows.Add(ev.id, ev.name, ev.type, ev.description, ev.EventLocation.name, ev.date);
            }

        }


        private void gvEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && gvEventos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
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
                //MessageBox.Show(gvEventos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                txtName.Text = gvEventos.Rows[e.RowIndex].Cells["EventName"].Value.ToString();
                txtDescripcion.Text = gvEventos.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                cbType.Text = gvEventos.Rows[e.RowIndex].Cells["Type"].Value.ToString();
                cbEventLocation.Text = gvEventos.Rows[e.RowIndex].Cells["LocationName"].Value.ToString();
                txtId.Text = gvEventos.Rows[e.RowIndex].Cells["id"].Value.ToString();
                string eventDate = gvEventos.Rows[e.RowIndex].Cells["Date"].Value.ToString();
                MessageBox.Show(eventDate);
                string date = eventDate.Substring(0, 2);
                cbDay.Text = date;
                date = eventDate.Substring(3, 2);
                cbMonth.Text = date;
                date = eventDate.Substring(6, 4);
                cbYear.Text = date;
                date = eventDate.Substring(11, 2);
                cbHour.Text = date;
                date = eventDate.Substring(14, 2);
                cbMinutes.Text = date;
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




    }
}
