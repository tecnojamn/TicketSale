using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BL
{
    public class EventController
    {
        public Ticket getTicket(int idTicketType)
        {
            Ticket t = null;
            try
            {
                using (TicketSaleEntities context = new TicketSaleEntities())
                {
                    t = context.Ticket.FirstOrDefault(ev => ev.idTicketType == idTicketType);
                }
                return t;

            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
