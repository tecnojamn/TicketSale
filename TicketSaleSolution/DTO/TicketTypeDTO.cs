namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
   [DataContract]
    public class TicketTypeDTO
    {
        public TicketTypeDTO()
        {
            this.Ticket = new HashSet<TicketDTO>();
        }
       [DataMember]
        public int id { get; set; }
       [DataMember]
       public double cost { get; set; }
       [DataMember] 
       public string description { get; set; }
       [DataMember] 
       public int startNum { get; set; }
       [DataMember] 
       public int finalNum { get; set; }
       [DataMember] 
       public int idEvent { get; set; }
       [DataMember]
        public virtual EventDTO Event { get; set; }
       [DataMember] 
       public virtual ICollection<TicketDTO> Ticket { get; set; }
    }
}