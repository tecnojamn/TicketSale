namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    [DataContract]
    public class PaymentDTO
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public System.DateTime date { get; set; }
        [DataMember]
        public double amount { get; set; }
        [DataMember]
        public int idReservation { get; set; }
        [DataMember]
        public virtual CashPaymentDTO CashPayment { get; set; }
        [DataMember]
        public virtual ReservationDTO Reservation { get; set; }
        [DataMember]
        public virtual PaypalPaymentDTO PaypalPayment { get; set; }
    }
}