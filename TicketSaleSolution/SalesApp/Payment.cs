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
using COM;
namespace SalesApp
{
    public partial class frmPayment : Form
    {
        private List<PaymentLocationDTO> payLoc = null;
        public frmPayment()
        {
            InitializeComponent();
            //Ubicarlo en otro sitio si es necesario
            payLoc = ProxyManager.getPaymentService().getPaymentLocations().ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = payLoc;
            cblocation.DataSource = bindingSource.DataSource;

            cblocation.DisplayMember = "Name";
            cblocation.ValueMember = "Name";
        }

        public frmReservationPay otherForm;

        private void cblocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPayment_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            PaymentDTO payment = new PaymentDTO();
            CashPaymentDTO cashPayment = new CashPaymentDTO();
            //PaymentLocationDTO paymentLoc = new PaymentLocationDTO();
            DateTime thisDay = DateTime.Today;
           
            payment.idReservation = Convert.ToInt32(otherForm.txtIdreserva.Text);
            payment.amount = Convert.ToInt32(otherForm.total.Text);
            payment.date = thisDay;
            ProxyManager.getPaymentService().newPayment(payment);
            cashPayment.idReservation = Convert.ToInt32(otherForm.txtIdreserva.Text);
            foreach(PaymentLocationDTO pl in payLoc){
                if(pl.name.Equals(cblocation.SelectedValue)){
                    cashPayment.idPaymentLocation = pl.id;
                }
            }
            cashPayment.cod = Convert.ToInt32(COM.SECURITY.GENERATE_CODE());
            ProxyManager.getPaymentService().newCashPayment(cashPayment);
            MessageBox.Show("You have payed correctly, have a nice day");
            this.Close();
        }
    }
}
