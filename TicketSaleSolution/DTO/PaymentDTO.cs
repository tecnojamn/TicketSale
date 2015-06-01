namespace DTO
{
    using System;
    using System.Collections.Generic;

    public class PaymentDTO
    {
        public int id { get; set; }
        public System.DateTime date { get; set; }
        public double amount { get; set; }
        public int idReservation { get; set; }

        public virtual CashPaymentDTO CashPayment { get; set; }
        public virtual ReservationDTO Reservation { get; set; }
        public virtual PaypalPaymentDTO PaypalPayment { get; set; }
    }
}