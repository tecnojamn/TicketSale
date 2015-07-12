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
    public partial class frmEventReport : Form
    {
        public frmEventReport()
        {
            InitializeComponent();
        }

        private void BestEvent_Load(object sender, EventArgs e)
        {


        }

        private void btnBestEvent_Click(object sender, EventArgs e)
        {
            EventDTO ev = ProxyManager.getEventService().getEventReport(COM.EVENT.REPORT.BEST);
            if (ev != null)
            {
                txtIdEvento.Text = ev.id.ToString();
                txtEventName.Text = ev.name;
                txtEventLoc.Text = ev.EventLocation.name;
                txtType.Text = ev.type;
                txtDate.Text = ev.date.ToString("dd/MM/yyyy");
            }
            else
            {
                txtIdEvento.Text = "No events";
                txtEventName.Text = "";
                txtEventLoc.Text = "";
                txtType.Text = "";
                txtDate.Text = "";
            }
        }

        private void btnWorstEvent_Click(object sender, EventArgs e)
        {
            EventDTO ev = ProxyManager.getEventService().getEventReport(COM.EVENT.REPORT.WORST);
            if (ev != null)
            {
                txtIdEvento.Text = ev.id.ToString();
                txtEventName.Text = ev.name;
                txtEventLoc.Text = ev.EventLocation.name;
                txtType.Text = ev.type;
                txtDate.Text = ev.date.ToString("dd/MM/yyyy");
            }
            else
            {
                txtIdEvento.Text = "No events";
                txtEventName.Text = "";
                txtEventLoc.Text = "";
                txtType.Text = "";
                txtDate.Text = "";

            }
        }
    }
}
