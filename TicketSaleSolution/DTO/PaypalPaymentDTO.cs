namespace DTO
{
    using System;
    using System.Collections.Generic;

    public class PaypalPaymentDTO
    {
        public int idPayment { get; set; }
        public string transactionCod { get; set; }

        public virtual PaymentDTO Payment { get; set; }
    }
}
