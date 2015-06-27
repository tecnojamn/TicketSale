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
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            if (searchText != "")
            {
                List<EventDTO> events = ProxyManager.getEventService().searchEvents(searchText).ToList();
            }
        }
    }
}