namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    [DataContract]
    public class PaypalPaymentDTO
    {
        [DataMember]
        public int idPayment { get; set; }
        [DataMember]
        public string transactionCod { get; set; }
        [DataMember]
        public virtual PaymentDTO Payment { get; set; }
    }
}
