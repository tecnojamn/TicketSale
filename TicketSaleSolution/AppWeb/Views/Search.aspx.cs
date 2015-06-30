using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;

namespace AppWeb.Views
{
    public partial class Search : System.Web.UI.Page
    {
        private class gridRow
        {
            public string name { get; set; }
            public string description { get; set; }
            public DateTime date { get; set; }
            public string type { get; set; }
            public string location { get; set; }
            public string adress { get; set; }
            public string availability { get; set; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                panelAdvanced.Visible = false;
                for (int i = 0; i <= 31; i++)
                {
                    ddListMaxDay.Items.Add(i.ToString());
                    ddListMinDay.Items.Add(i.ToString());
                }

                for (int i = 0; i <= 12; i++)
                {
                    ddListMaxMonth.Items.Add(i.ToString());
                    ddListMinMonth.Items.Add(i.ToString());
                }
                List<EventLocationDTO> locals = ProxyManager.getEventService().getLocals().ToList();
                ddListLocal.Items.Add("none");
                foreach (EventLocationDTO local in locals)
                {
                    ddListLocal.Items.Add(local.name);
                }
                ddListMaxYear.Items.Add(DateTime.Now.Year.ToString());
                ddListMaxYear.Items.Add((DateTime.Now.Year + 1).ToString());

                ddListMinYear.Items.Add(DateTime.Now.Year.ToString());
                ddListMinYear.Items.Add((DateTime.Now.Year + 1).ToString());
            }


        }
        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            DateTime minDate = new DateTime();
            DateTime maxDate = new DateTime();
            string local = ddListLocal.SelectedItem.Text;
            if (searchText != "")
            {
                if (panelAdvanced.Visible)
                {

                    if (ddListMinDay.SelectedItem.Text != "0" && ddListMinMonth.SelectedItem.Text != "0")
                    {
                        minDate = new DateTime(
                            int.Parse(ddListMinYear.SelectedItem.Text),
                            int.Parse(ddListMinMonth.SelectedItem.Text),
                            int.Parse(ddListMinDay.SelectedItem.Text));
                    }

                    if (ddListMaxDay.SelectedItem.Text != "0" && ddListMaxMonth.SelectedItem.Text != "0")
                    {
                        maxDate = new DateTime(
                            int.Parse(ddListMaxYear.SelectedItem.Text),
                            int.Parse(ddListMaxMonth.SelectedItem.Text),
                            int.Parse(ddListMaxDay.SelectedItem.Text));
                    }
                }

                //Datos traidos de BD
                List<EventDTO> events = ProxyManager.getEventService().searchEvents(searchText, maxDate, minDate, local).ToList();

                //Datos para mostrar
                List<gridRow> gridData = new List<gridRow>();
                foreach (EventDTO item in events)
                {
                    gridRow row = new gridRow();
                    row.name = item.name;
                    row.description = item.description;
                    row.date = item.date;
                    row.type = item.type;
                    row.location = item.EventLocation.name;
                    row.adress = item.EventLocation.address;

                    int available = 0;
                    foreach (TicketTypeDTO tt in item.TicketType)
                    {
                        available += tt.finalNum - tt.startNum;
                    }
                    row.availability = available.ToString() + " tickets";
                    gridData.Add(row);
                }
                eventsGrid.DataSource = gridData;
                eventsGrid.DataBind();
            }
        }

        protected void btnAdvanced_Click(object sender, EventArgs e)
        {
            if (panelAdvanced.Visible)
            {
                panelAdvanced.Visible = false;
            }
            else
            {
                panelAdvanced.Visible = true;
            }
        }
    }
}