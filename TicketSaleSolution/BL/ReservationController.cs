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
                    res = context.Reservation
                        .Include("SubOrder.Ticket.TicketType.Event")
                        .Select(r => r)
                        .OrderByDescending(r => r.date)
                        .Where(r => r.idUser == idUser)                        
                        .Skip(page-1)
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
        //Listar  reservas
        public List<Reservation> getReservations(int page = 1, int pageSize = 1)
        {
            List<Reservation> res = null;
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    res = context.Reservation.Select(r => r)
                        .OrderByDescending(r => r.date)
                        .Skip(page-1)
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
        public bool cancelSubOrder(int idSO)
        {

            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    SubOrder so = context.SubOrder.FirstOrDefault(s => s.id == idSO);
                    if (so != null)
                    {
                        so.active = Convert.ToByte(RESERVATION.SUBORDER.INACTIVE);
                        context.SaveChanges();
                    }
                    else { return false; }
                }
            }
            catch (Exception)
            {
                return false;
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
                    res = context.Reservation
                        .Include("SubOrder.Ticket.TicketType.Event.EventLocation")
                        .Include("User")
                        .Include("Payment")
                        .FirstOrDefault(r => r.id == idReserva);
                }

            }
            catch (Exception)
            {

                throw;
            }
            return res;

        }
        public int getReservationCountByUser(int idUser, bool onlyPayments=false)
        {
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    if (onlyPayments)
                    {
                        return context.Reservation.Select(r => r.idUser == idUser).Count();
                    }
                    else
                    {
                        return context.Reservation.Select(r => r.idUser == idUser && r.Payment!=null ).Count();
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
