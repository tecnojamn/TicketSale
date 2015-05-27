using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class OrderController
    {
        //Nueva Orden (paga)
        public bool newOrder(BO.Reservation o)
        {
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    if (context.Reservation.Add(o) != null) //Devuelve null si no inserta
                    {
                        context.SaveChanges();
                    }
                    else { return false; }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }
        //Cancelacion automatica
        public bool autoCancelation()
        {
            using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
            {
                return false;
            }
        }
        //Listar reservas de Usuario
        /*public List<BO.Reservation> getReservationsByUser(int idUs)
        {
            List<BO.Reservation> res = null;
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    res = context.Reservation.Select(o => o).
                        Where(o => o.idUser == idUs && o.Reservation != null).
                        Select(o => o.Reservation).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return res;            
        }*/
        //Listar todas las reservas
        /*public List<BO.Reservation> getReservations()
        {
            List<BO.Reservation> res = null;
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    res = context.Reservation.Select(e => e).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return res;
        }*/
    }
}
