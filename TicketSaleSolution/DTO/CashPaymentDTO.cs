namespace DTO
{
    using System;
    using System.Collections.Generic;

    public class CashPaymentDTO
    {
        public int idPayment { get; set; }
        public int cod { get; set; }
        public int idPaymentLocation { get; set; }

        public virtual PaymentLocationDTO PaymentLocation { get; set; }
        public virtual PaymentDTO Payment { get; set; }
    }
}
