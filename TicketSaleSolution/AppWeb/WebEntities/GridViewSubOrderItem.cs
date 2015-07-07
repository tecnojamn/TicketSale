using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWeb.WebEntities
{
    public class GridViewSubOrderItem
    {
        public int id { get; set; }
        public double amount { get; set; }
        public string description { get; set; }
        public string stateOrCancel { get; set; }
    }
}