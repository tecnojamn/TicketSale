using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DTO
{

    [DataContract]
    public class UserDTO
    {
        public UserDTO()
        {
            this.Reservation = new HashSet<ReservationDTO>();
        }
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string mail { get; set; }
        [DataMember]
        public string password { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string lastName { get; set; }
        [DataMember]
        public System.DateTime dateBirth { get; set; }
        [DataMember]
        public byte userType { get; set; }
        [DataMember]
        public byte active { get; set; }
        [DataMember]
        public string registrationLink { get; set; }
        [DataMember]
        public string img { get; set; }
        [DataMember]
        public virtual ICollection<ReservationDTO> Reservation { get; set; }
    }
}