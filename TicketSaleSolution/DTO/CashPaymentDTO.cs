namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    [DataContract]
    public class CashPaymentDTO
    {
        [DataMember]
        public int idPayment { get; set; }
        [DataMember]
        public int cod { get; set; }
        [DataMember]
        public int idPaymentLocation { get; set; }
        [DataMember]
        public virtual PaymentLocationDTO PaymentLocation { get; set; }
        [DataMember]
        public virtual PaymentDTO Payment { get; set; }
    }
}
