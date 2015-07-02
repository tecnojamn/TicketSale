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
        //Si la fecha es 01/01/0001 0:00:00, no la va a tomar en cuenta
        //Si el local es none, no lo va a tomar en cuenta
        public List<Event> searchEvents(string text, DateTime maxDate, DateTime minDate , String local , double price, string type)
        {
            List<Event> events = null;
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    //var query = from e in context.Event select e;
                    var query = context.Event
                        .Include("EventLocation")
                        .Include("TicketType")
                        .OrderByDescending(e => e.date)
                        .Where(e => e.name.Contains(text));
                    //verifica que la fecha no sea 01/01/0001 0:00:00
                    if (DateTime.Compare(maxDate, new DateTime(0001, 01, 01, 0, 0, 0)) != 0 )
                    {
                        query = query.Where(e => e.date <= maxDate);
                    }
                    if ( DateTime.Compare(minDate, new DateTime(0001, 01, 01, 0, 0, 0)) != 0 )
                    {
                        query = query.Where(e => e.date >= minDate);
                    }
                    if(local != "none")
                    {
                        query = query.Where(e => e.EventLocation.name == local);
                    }
                    //if (price > 0)
                    //{
                     //   query = query.Where(e => e.TicketType.Min(tt => tt.cost) <= price);
                    //}
                    if (type != "none")
                    {
                        query = query.Where(e => e.type == type);
                    }
                    events = query
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return events;
        }
        public List<EventLocation> getLocals()
        {
            List<EventLocation> locals = null;
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    locals = context.EventLocation
                               .Select(l => l)
                               .OrderBy(l => l.name)
                               .ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return locals;
        }
        public List<string> getEventType()
        {
            List<string> eventsType = null;
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    eventsType = context.Event
                        .Select(e => e.type)
                        .Distinct()
                        .ToList();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            return eventsType;
        }
    }
}
