namespace DTO
{
    using System;
    using System.Collections.Generic;

    public class ReservationDTO
    {
        public ReservationDTO()
        {
            this.SubOrder = new HashSet<SubOrderDTO>();
            this.Payment = new HashSet<PaymentDTO>();
        }

        public int id { get; set; }
        public int idUser { get; set; }
        public System.DateTime date { get; set; }

        public virtual UserDTO User { get; set; }
        public virtual ICollection<SubOrderDTO> SubOrder { get; set; }
        public virtual ICollection<PaymentDTO> Payment { get; set; }
    }
}