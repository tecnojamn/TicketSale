using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using COM;

namespace BL
{
    public class EventController
    {
        //Nuevo evento
        public bool newEvent(Event ev)
        {
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    if (context.Event.Add(ev) != null)
                    {
                        context.SaveChanges();
                    }
                    else { return false; }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return true;
        }
        //Borrar Evento --- NO SIRVE
        /*public bool removeEvent(int idEv)
            {
                try
                {
                    using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                    {
                        Event e = context.Event.FirstOrDefault(ev => ev.id == idEv);
                        if (e != null)
                        {
                            if (context.Event.Remove(e) != null)
                            {
                                context.SaveChanges();
                            }

                        }
                        else { return false; }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                return false;
            }*/
        //Cancelar evento (no lo borra)
        public bool cancelEvent(int id)
        {
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    Event e = context.Event.FirstOrDefault(ev => ev.id == id);
                    if (e != null)
                    {
                        e.enabled = EVENT.STATE.UNABLE;
                        context.SaveChanges();
                    }
                    else { return false; }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return false;
        }
        //Editar Evento
        public bool updateEvent(Event ev)
        {
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    Event e = context.Event.FirstOrDefault(evn => evn.id == ev.id);
                    if (e != null)
                    {
                        e.date = ev.date;
                        e.description = ev.description;
                        e.enabled = ev.enabled;
                        e.EventLocation = ev.EventLocation;
                        e.idEventLocation = ev.idEventLocation;
                        e.name = ev.name;
                        e.TicketType = ev.TicketType;
                        e.type = ev.type;
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
        //Listar Eventos
        public List<Event> getEvents(int page, int pageSize)
        {
            List<Event> events = null;
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    events = context.Event.Select(e => e)
                        .OrderByDescending(e => e.date)
                        .Skip((page - 1) * pageSize)
                        .Take(pageSize)
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return events;

        }
        //Obtener Evento
        public Event getEvent(int id)
        {
            Event ev = null;
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    ev = context.Event
                        //Traeme relaciones
                        .Include("EventLocation")
                        .Include("TicketType.Ticket.SubOrder")
                        .FirstOrDefault(e => e.id == id);

                }

            }
            catch (Exception)
            {
                throw;
            }
            return ev;
        }
        public List<Event> getEventsForGv()
        {
            List<Event> events = null;
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    events = context.Event.Include("EventLocation").Select(e => e).ToList();


                    return events;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Event getEventReport(int x)
        {
            List<Event> events = null;
            DateTime today = DateTime.Today;
            Event eve = null;

            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    events = new List<Event>();
                    //traer eventos con fecha de estreno del mes actual
                    events = context.Event.Include("EventLocation").Include("TicketType.Ticket.SubOrder.Reservation.Payment")
                        .Where(e => e.date.Month == today.Month).ToList();
                    //guardar del evento, su cantidad total de entradas y sus ventas de entradas
                    List<int[]> TicketsInfo = new List<int[]>();
                    int totalCant = 0;
                    int totalCantSold = 0;
                    foreach (Event ev in events)
                    {
                        totalCant = 0;
                        totalCantSold = 0;
                        //segun los ticketstype del evento, calcular la cantidad total de tickets
                        foreach (TicketType tt in ev.TicketType)
                        {
                            totalCant += tt.Ticket.Count();
                        }
                        List<Payment> payments;
                        //buscar todos los pagos relacionados al evento
                        payments = context.Payment.Include("Reservation.SubOrder.Ticket.TicketType.Event")
                            .Where(p => p.Reservation.SubOrder.FirstOrDefault().Ticket.TicketType.Event.id == ev.id
                                //&& ev.date.Month == today.Month
                                && p.Reservation.SubOrder.Where(so => so.active == RESERVATION.SUBORDER.ACTIVE).Count() > 0).ToList();
                        foreach (Payment p in payments)
                        {
                            foreach (SubOrder s in p.Reservation.SubOrder)
                            {
                                if (s.active == RESERVATION.SUBORDER.ACTIVE)
                                {
                                    totalCantSold++;
                                }
                            }
                        }
                        TicketsInfo.Add(new int[] { ev.id, totalCant, totalCantSold });

                    }
                    int idEvent = 0;
                    if (x == COM.EVENT.REPORT.BEST)
                    {
                        float max = 0;
                        foreach (int[] ticketInfo in TicketsInfo)
                        {
                            if (((ticketInfo[2] * 100) / ticketInfo[1]) > max)
                            {
                                idEvent = ticketInfo[0];
                                max = (ticketInfo[2] * 100 / ticketInfo[1]);
                            }
                        }
                    }
                    else
                    {
                        float min = 0;
                        foreach (int[] ticketInfo in TicketsInfo)
                        {
                            if (min == 0)
                            {
                                idEvent = ticketInfo[0];
                                min = (ticketInfo[2] * 100 / ticketInfo[1]);
                            }
                            else if (((ticketInfo[2] * 100) / ticketInfo[1]) <= min)
                            {
                                idEvent = ticketInfo[0];
                                min = (ticketInfo[2] * 100 / ticketInfo[1]);
                            }
                        }

                    }
                    eve = context.Event.FirstOrDefault(e => e.id == idEvent);
                    return eve;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Event> getEventsForSTR(DateTime start, DateTime end)
        {
            List<Event> events = null;
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    events = new List<Event>();
                    events = context.Event.Include("EventLocation").Include("TicketType.Ticket.SubOrder.Reservation.Payment")
                        .Where(e => e.TicketType
                            .Where(tt => tt.Ticket
                                .Where(t => t.SubOrder.FirstOrDefault().Reservation.Payment.date >= start 
                                    && t.SubOrder.FirstOrDefault().Reservation.Payment.date <= end 
                                    && t.SubOrder.FirstOrDefault().active == COM.RESERVATION.SUBORDER.ACTIVE )
                                    .Any()) //que alguna suborden del ticket cumpla con las condiciones
                                    .Any()) // que algun tickettype del evento contenga algun ticket que cumpla con las condiciones
                                    .ToList();
                    return events;
                } 

                }

            catch (Exception)
            {
                
                throw;
            }
        }
        /*
        public int getTotalTicketCount(int id)
        {
            Event ev = null;
            int count = 0;
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    ev = context.Event.Include("TicketType").FirstOrDefault(e => e.id == id);
                }

            }
            catch (Exception)
            {
                throw;
            }
            
            foreach (var tt in ev.TicketType)
            {
                count += tt.finalNum - tt.startNum;
            }
            return count;
        }*/
    }
}
