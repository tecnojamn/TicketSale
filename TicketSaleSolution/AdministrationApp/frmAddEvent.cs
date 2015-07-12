using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using COM;
using DTO;

namespace AdministrationApp
{
    public partial class frmAddEvent : Form
    {
        private string imgPath = "";
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
        //"Setea" la cantidad de dias de cbDay y el dia seleccionado
        private void setDay(int cant, int current = 1)
        {
            cbDay.Items.Clear();
            for (int i = 1; i <= cant; i++)
            {
                cbDay.Items.Add(i);
            }
            cbDay.SelectedIndex = current - 1;
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
            for (int i = DateTime.Now.Year; i <= DateTime.Now.Year + 5; i++)
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

            //fecha menor a la de hoy
            if (date > DateTime.Now)
            {
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
                //Si tiene almenos 1 ticket type asociado
                if (cbTicketType.Items.Count != 0)
                {
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
                    int eventId = ProxyManager.getEventService().newEvent(newEvent);
                    if (eventId != 0)
                    {
                        if (imgPath != "")
                        {
                            string[] fname;
                            fname = imgPath.Split('.');
                            //Obtiene la ruta en donde se guardan las imagenes
                            string targetDir = Directory.GetParent(Directory.GetParent(Directory.GetParent(Path.GetDirectoryName(Application.ExecutablePath)).ToString()).ToString()).ToString() + "\\AppWeb\\uploads\\events\\";
                            File.Copy(imgPath, targetDir + eventId + "." + fname[fname.Length - 1]);
                        }
                        DialogResult dResult = MessageBox.Show("Event added successfully");

                        if (dResult == DialogResult.OK)
                        {
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("An error has ocurred");
                    }
                }
                else
                {
                    MessageBox.Show("Add at least 1 ticket type");
                }
            }
            else
            {
                MessageBox.Show("Incorrect date");
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            fileDialog.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (fileDialog.FileName != "")
            {
                pbImage.Image = Image.FromFile(fileDialog.FileName);
                imgPath = fileDialog.FileName;
            }
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cambia la cantidad de dias de cbDay segun el mes seleccionado ej:enero-31 dias
            int month = Convert.ToInt32(cbMonth.SelectedItem);
            int day = Convert.ToInt32(cbDay.SelectedItem);
            if (month == 2)
            {
                if (day > 28)
                {
                    day = 1;
                }
                setDay(28, day);
            }
            else if ( month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (day > 30)
                {
                    day = 1;
                }
                setDay(30, day);
            }
            else
            {
                setDay(31, day);
            }
            
            
        }
    }
}
