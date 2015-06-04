namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    [DataContract]
    public class PaymentLocationDTO
    {
        public PaymentLocationDTO()
        {
            this.CashPayment = new HashSet<CashPaymentDTO>();
        }
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int phoneNumber { get; set; }
        [DataMember]
        public string address { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public virtual ICollection<CashPaymentDTO> CashPayment { get; set; }
    }
}
