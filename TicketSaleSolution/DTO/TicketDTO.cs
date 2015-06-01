namespace DTO
{
    using System;
    using System.Collections.Generic;

    public class TicketDTO
    {
        public TicketDTO()
        {
            this.SubOrder = new HashSet<SubOrderDTO>();
        }

        public int id { get; set; }
        public int number { get; set; }
        public int idTicketType { get; set; }

        public virtual ICollection<SubOrderDTO> SubOrder { get; set; }
        public virtual TicketTypeDTO TicketType { get; set; }
    }
}