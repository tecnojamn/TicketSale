namespace DTO
{
    using System;
    using System.Collections.Generic;

    public class TicketTypeDTO
    {
        public TicketTypeDTO()
        {
            this.Ticket = new HashSet<TicketDTO>();
        }

        public int id { get; set; }
        public double cost { get; set; }
        public string description { get; set; }
        public int startNum { get; set; }
        public int finalNum { get; set; }
        public int idEvent { get; set; }

        public virtual EventDTO Event { get; set; }
        public virtual ICollection<TicketDTO> Ticket { get; set; }
    }
}