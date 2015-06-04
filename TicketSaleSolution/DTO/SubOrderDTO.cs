namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    [DataContract]
    public class SubOrderDTO
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public byte active { get; set; }
        [DataMember]
        public int idReservation { get; set; }
        [DataMember]
        public int idTicket { get; set; }
        [DataMember]
        public virtual ReservationDTO Reservation { get; set; }
        [DataMember]
        public virtual TicketDTO Ticket { get; set; }
    }
}