using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DTO
{
    [DataContract]
    public class EventDTO
    {
        public EventDTO()
        {
            this.TicketType = new HashSet<TicketTypeDTO>();
        }
        public int getTotalTicketCount(){
            int count = 0;
            foreach(var tt in TicketType){
                count += tt.getTotalTicketCount();
            }
            return count;
        }
        public int getAvailableTicketCount()
        {
            int count = 0;
            foreach (var tt in TicketType)
            {
                count += tt.getAvailableTicketCount();
            }
            return count;
        }


        [DataMember]
        public int id { get; set; }
        [DataMember]
        public System.DateTime date { get; set; }
        [DataMember]
        public byte enable { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public int idEventLocation { get; set; }
        [DataMember]
        public string type { get; set; }
        [DataMember]
        public virtual EventLocationDTO EventLocation { get; set; }
        [DataMember]
        public virtual ICollection<TicketTypeDTO> TicketType { get; set; }
    }
}
