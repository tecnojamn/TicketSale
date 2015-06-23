using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using BO;
using DTO;
namespace SalesApp
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
            //Ubicarlo en otro sitio si es necesario
            List<PaymentLocationDTO> payLoc = ProxyManager.getPaymentService().getPaymentLocations().ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = payLoc;
            cblocation.DataSource = bindingSource.DataSource;

            cblocation.DisplayMember = "Name";
            cblocation.ValueMember = "Name";
        }

        private void cblocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPayment_Load(object sender, EventArgs e)
        {

        }
    }
}
