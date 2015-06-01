namespace DTO
{
    using System;
    using System.Collections.Generic;

    public class SubOrderDTO
    {
        public int id { get; set; }
        public byte active { get; set; }
        public int idReservation { get; set; }
        public int idTicket { get; set; }

        public virtual ReservationDTO Reservation { get; set; }
        public virtual TicketDTO Ticket { get; set; }
    }
}