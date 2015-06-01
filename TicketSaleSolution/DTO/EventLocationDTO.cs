namespace DTO
{
    using System;
    using System.Collections.Generic;

    public class EventLocationDTO
    {
        public EventLocationDTO()
        {
            this.Event = new HashSet<EventDTO>();
        }

        public int id { get; set; }
        public string name { get; set; }
        public int phoneNumber { get; set; }
        public string address { get; set; }

        public virtual ICollection<EventDTO> Event { get; set; }
    }
}
