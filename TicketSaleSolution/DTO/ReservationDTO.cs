using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DTO
{
    [DataContract]
    public class ReservationDTO
    {
        public ReservationDTO()
        {
            this.SubOrder = new HashSet<SubOrderDTO>();
        }

        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int idUser { get; set; }
        [DataMember]
        public System.DateTime date { get; set; }
        [DataMember]
        public virtual UserDTO User { get; set; }
        [DataMember]
        public virtual ICollection<SubOrderDTO> SubOrder { get; set; }
        [DataMember]
        public virtual PaymentDTO Payment { get; set; }
    }
}