using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using COM;

namespace BL
{
    public class ReservationController
    {
        //Nueva Reserva
        public bool newReservation(Reservation r)
        {
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    if (context.Reservation.Add(r) != null)
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
        // -- AL PEDO
        //Listar reservas de Usuario
        public List<Reservation> getReservationsByUser(int idUser, int page, int pageSize)
        {
            List<Reservation> res = null;
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    res = context.Reservation.Select(r => r)
                        .Where(r => r.idUser == idUser)
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return res;
        }
        //Listar  reservas
        public List<Reservation> getReservations(int page = 1, int pageSize = 1)
        {
            List<Reservation> res = null;
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    res = context.Reservation.Select(r => r)
                        .OrderBy(r => r.date)
                        .Skip(page)
                        .Take(pageSize)
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return res;
        }
        //Cancelar suborden
        public bool cancelSubOrder(int subOrderId)
        {

            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    SubOrder so = context.SubOrder.FirstOrDefault(s => s.id == subOrderId);
                    if (so != null)
                    {
                        so.active = Convert.ToByte(RESERVATION.SUBORDER.INACTIVE);
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
        //obtener reserva (aplicación del vendedor)
        public Reservation getReservation(int idReserva)
        {
            Reservation res = null;
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    res = context.Reservation.FirstOrDefault(r => r.id == idReserva);
                }

            }
            catch (Exception)
            {

                throw;
            }
            return res;

        }
    }
}
