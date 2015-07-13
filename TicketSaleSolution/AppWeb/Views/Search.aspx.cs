using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using COM;

namespace AppWeb.Views
{
    public partial class Search : System.Web.UI.Page
    {
        public string IMG_PATH { get { return PATH.UPLOADS_VISTA; } }
        private class gridRow
        {
            public int idEvent { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string date { get; set; }
            public string type { get; set; }
            public string location { get; set; }
            public string address { get; set; }

            //Se elimina porque no se estan trayendo tickettypes
            //public string availability { get; set; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //Llenar los datos del panel, solo la primera vez
            if (!IsPostBack)
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

            //Pido los datos del request
            string searchText = Request.QueryString["searchText"];
            string eventLocation = Request.QueryString["local"];
            string eventType = Request.QueryString["type"];
            int page = 1;
            int.TryParse(Request.QueryString["page"], out page);
            if (page < 1)
            {
                page = 1;
            }
            double price = 0;
            double.TryParse(Request.QueryString["price"], out price);
            DateTime minDate = default(DateTime);
            DateTime.TryParse(Request.QueryString["minDate"], out minDate);
            DateTime maxDate = default(DateTime);
            DateTime.TryParse(Request.QueryString["maxDate"], out maxDate);
            //Verifica que almenos un campo tenga algo
            if ((searchText != "" && searchText != null) ||
                (eventLocation != "none" && eventLocation != "" && eventLocation != null) ||
                (eventType != "none" && eventType != "" && eventType != null) ||
                minDate != default(DateTime) || maxDate != default(DateTime) || price != 0)
            {
                //Datos traidos de BD
                List<EventDTO> events = ProxyManager.getEventService().searchEvents(searchText, page, EVENT.STATE.pageSize, maxDate, minDate, eventLocation, price, eventType).ToList();

                //Datos para mostrar
                List<gridRow> gridData = new List<gridRow>();
                foreach (EventDTO item in events)
                {
                    //gridRow es una clase personalizada con los datos que quiero mostrar
                    gridRow row = new gridRow();
                    row.idEvent = item.id; // esta columna quedaa oculta vease eventsGrid_RowCreated
                    row.name = item.name;
                    row.description = item.description;
                    row.date = item.date.ToString("dd/MM/yyyy");
                    row.type = item.type;
                    row.location = item.EventLocation.name;
                    row.address = item.EventLocation.address;

                    //int available = 0;
                    //foreach (TicketTypeDTO tt in item.TicketType)
                    //{
                    //    available += tt.finalNum - tt.startNum;
                    //}
                    //row.availability = available.ToString() + " tickets";
                    gridData.Add(row);

                }
                //Asociacion de data con el gridView
                ListView1.DataSource = gridData;
                ListView1.DataBind();
            }
        }
        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            string local = ddListLocal.SelectedItem.Text;
            string type = ddListType.SelectedItem.Text;
            DateTime minDate = default(DateTime);
            DateTime maxDate = default(DateTime);
            double price = 0;
            double.TryParse(txtPrice.Text, out price);

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
            string pageRedirect = "Search.aspx?";
            bool preAttr = false;//Para verificar si debo agregar un "&" a la url o no

            if (searchText != "" && searchText != "none")
            {
                pageRedirect = pageRedirect + "searchText=" + searchText;
                preAttr = true;
            }
            if (local != "" && local != "none")
            {
                if (preAttr)
                {
                    pageRedirect = pageRedirect + "&";
                }
                pageRedirect = pageRedirect + "local=" + local;
                preAttr = true;
            }
            if (type != "" && type != "none")
            {
                if (preAttr)
                {
                    pageRedirect = pageRedirect + "&";
                }
                pageRedirect = pageRedirect + "type=" + type;
                preAttr = true;
            }
            if (price != 0)
            {
                if (preAttr)
                {
                    pageRedirect = pageRedirect + "&";
                }
                pageRedirect = pageRedirect + "price=" + price.ToString();
                preAttr = true;
            }
            if (minDate != default(DateTime))
            {
                if (preAttr)
                {
                    pageRedirect = pageRedirect + "&";
                }
                pageRedirect = pageRedirect + "minDate=" + minDate.ToString("dd/MM/yyyy");
                preAttr = true;
            }
            if (maxDate != default(DateTime))
            {
                if (preAttr)
                {
                    pageRedirect = pageRedirect + "&";
                }
                pageRedirect = pageRedirect + "maxDate=" + maxDate.ToString("dd/MM/yyyy");
            }
            Response.Redirect(pageRedirect);
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
        protected void linkEvent_Click(object sender, CommandEventArgs e)
        {
            string idEvent = e.CommandArgument.ToString();
            Response.Redirect("Events.aspx?id=" + idEvent);

        }
    }
}