using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;


namespace BO.DTO
{
    [DataContract]
    public class DTOUser
    {
        
        public DTOUser()
        {
            this.Reservation = new HashSet<Reservation>();
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
        public int mobileNum { get; set; }
        [DataMember]
        public virtual ICollection<Reservation> Reservation { get; set; }
    }
}