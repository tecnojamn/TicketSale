namespace DTO
{
    using System;
    using System.Collections.Generic;

    public class PaymentLocationDTO
    {
        public PaymentLocationDTO()
        {
            this.CashPayment = new HashSet<CashPaymentDTO>();
        }

        public int id { get; set; }
        public int phoneNumber { get; set; }
        public string address { get; set; }
        public string name { get; set; }

        public virtual ICollection<CashPaymentDTO> CashPayment { get; set; }
    }
}
