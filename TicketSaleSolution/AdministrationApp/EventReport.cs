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
            }
            else
            {
                txtIdEvento.Text = "No events";
            }
        }

        private void btnWorstEvent_Click(object sender, EventArgs e)
        {
            EventDTO ev = ProxyManager.getEventService().getEventReport(COM.EVENT.REPORT.WORST);
            if (ev != null)
            {
                txtIdEvento.Text = ev.id.ToString();
            }
            else
            {
                txtIdEvento.Text = "No events";
            }
        }
    }
}
