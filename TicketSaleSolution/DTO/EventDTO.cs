using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using COM;

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
                count += tt.finalNum - tt.startNum; ;
            }
            return count;
        }
        public int getAvailableTicketCount()
        {
            int count = 0;
            foreach (var tt in TicketType)
            {
                count += tt.finalNum - tt.startNum - tt.Ticket.Where(t => t.SubOrder.Where(so => so.active == RESERVATION.SUBORDER.ACTIVE).Count() == 1).Count();
            }
            return count;
        }


        [DataMember]
        public int id { get; set; }
        [DataMember]
        public System.DateTime date { get; set; }
        [DataMember]
        public byte enabled { get; set; }
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
