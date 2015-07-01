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
            public int idEvent { get; set; }
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
                Array types = ProxyManager.getEventService().getEventType();
                ddListType.Items.Add("none");
                foreach (string type in types)
                {
                    ddListType.Items.Add(type);
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
            //Si el texto es vacio no se realiza la busqueda
            if (searchText != "")
            {
                DateTime minDate = new DateTime(0001, 01, 01, 0, 0, 0);
                DateTime maxDate = new DateTime(0001, 01, 01, 0, 0, 0);
                string local = "none";
                double price = 0;
                string type = "none";
                //Si el panel esta oculto ignora los datos de los elementos de adentro
                if (panelAdvanced.Visible)
                {
                    local = ddListLocal.SelectedItem.Text;
                    double.TryParse(txtPrice.Text, out price);
                    type = ddListType.SelectedItem.Text;
                    //Verifica que no ingrese fecha invalida (falta arreglos)
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
                List<EventDTO> events = ProxyManager.getEventService().searchEvents(searchText, maxDate, minDate, local, price, type).ToList();

                //Datos para mostrar
                List<gridRow> gridData = new List<gridRow>();
                foreach (EventDTO item in events)
                {
                    gridRow row = new gridRow();
                    row.idEvent = item.id; // esta columna quedaa oculta vease eventsGrid_RowCreated
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
                    
                    //Asociacion de data con el gridView
                    eventsGrid.DataSource = gridData;
                    eventsGrid.DataBind();
                }
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

        protected void eventsGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
            if (e.CommandName == "Select")
            {
                //Convierto el comandArgument en un dato usable (int)
                //De esta forma consigo el index de la linea clickeada
                int index = Convert.ToInt32(e.CommandArgument);

                //Traigo el contenido de la columna 2 (correspondiente a idEvent) de la linea seleccionada
                string id = eventsGrid.Rows[index].Cells[1].Text;
                Response.Redirect("Events.aspx?id="+id);
            }
        }

        protected void eventsGrid_RowCreated(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[1].Visible = false; //Oculta la segunda columna
        }
    }
}