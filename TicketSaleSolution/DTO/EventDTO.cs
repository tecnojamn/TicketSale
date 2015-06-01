namespace DTO
{
    using System;
    using System.Collections.Generic;

    public class EventDTO
    {
        public EventDTO()
        {
            this.TicketType = new HashSet<TicketTypeDTO>();
        }

        public int id { get; set; }
        public System.DateTime date { get; set; }
        public byte enable { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int idEventLocation { get; set; }
        public string type { get; set; }

        public virtual EventLocationDTO EventLocation { get; set; }
        public virtual ICollection<TicketTypeDTO> TicketType { get; set; }
    }
}
