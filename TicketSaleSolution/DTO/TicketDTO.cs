namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class TicketDTO
    {
        public TicketDTO()
        {
            this.SubOrder = new HashSet<SubOrderDTO>();
        }
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int number { get; set; }
        [DataMember]
        public int idTicketType { get; set; }
        [DataMember]
        public virtual ICollection<SubOrderDTO> SubOrder { get; set; }
        [DataMember]
        public virtual TicketTypeDTO TicketType { get; set; }
    }
}