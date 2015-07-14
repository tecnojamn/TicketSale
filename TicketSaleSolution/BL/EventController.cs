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
        //Retorna el id del evento creado, devolvera 0 en caso de error
        public int newEvent(Event ev)
        {
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    //para que no intente agregar un evento con el id de alguien
                    if (ev.id == 0)
                    {
                        if (context.Event.Add(ev) != null)
                        {
                            context.SaveChanges();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                return 0;
            }
            return ev.id;
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
                        e.EventLocation = (ev.EventLocation != null) ? ev.EventLocation : e.EventLocation;
                        e.idEventLocation = ev.idEventLocation;
                        e.name = ev.name;
                        e.TicketType = (ev.TicketType != null) ? ev.TicketType : e.TicketType;
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
                    DateTime aYearAgo = DateTime.Today.AddYears(-1);


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
        public List<Event> getFeatuerdEvents(int page, int pageSize)
        {
            List<Event> eventos = null;
            var auxDictionary = new SortedDictionary<int, double>();
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    float entradasTomadas = 0f;
                    float entradasDisp = 0f;
                    DateTime now = DateTime.Now;

                    eventos = context.Event.Include("EventLocation").Select(e => e).Where(e => e.enabled == 1 && e.date >= now)
                         .OrderByDescending(e => e.date)
                         .Skip((page - 1) * pageSize)
                         .Take(pageSize)
                         .ToList();
                    foreach (Event e in eventos)
                    {

                        entradasTomadas = 0.000000f;
                        entradasDisp = 0.000000f;

                        foreach (TicketType et in e.TicketType)
                        {
                            int entradas = et.finalNum - et.startNum;
                            entradasDisp += (float)entradas;
                            foreach (var t in et.Ticket)
                            {
                                foreach (var s in t.SubOrder)
                                {
                                    if (s.active == 1)
                                        entradasTomadas += 1.0f;
                                }
                            }
                        }
                        //double res;
                        if (entradasDisp > 0)
                        {

                            // res= ((entradasTomadas) / (entradasDisp));
                            auxDictionary.Add(e.id, ((entradasTomadas) / (entradasDisp)));
                        }
                        else
                        {
                            // res = 0.000000f;
                            auxDictionary.Add(e.id, -1);
                        }
                        // auxDicitonary.Add(e.id, res);
                    }
                    Dictionary<int, double> _sorteDictionary = new Dictionary<int, double>();

                    foreach (KeyValuePair<int, double> k in auxDictionary.OrderByDescending(x => x.Value))
                    {
                        _sorteDictionary.Add(k.Key, k.Value);
                    }

                    //ordeno el diccionario
                    //string sortedDictionary = auxDicitonary.OrderBy(key => key.Value);



                    //lo paso a lista de ints, ya ordenada
                    List<int> idList = new List<int>(_sorteDictionary.Keys);
                    //orden la lista de eventos en base a la lista de ints
                    eventos = eventos.OrderBy(e => idList.IndexOf(e.id)).ToList();


                }
            }
            catch (Exception)
            {
                throw;
            }
            return eventos;

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
                    List<float[]> TicketsInfo = new List<float[]>();
                    int totalCant = 0;
                    int totalCantSold = 0;
                    foreach (Event ev in events)
                    {
                        totalCant = 0;
                        totalCantSold = 0;
                        //segun los ticketstype del evento, calcular la cantidad total de tickets
                        foreach (TicketType tt in ev.TicketType)
                        {
                            totalCant += tt.finalNum - tt.startNum;
                            foreach (Ticket t in tt.Ticket)
                            {
                                foreach (SubOrder so in t.SubOrder)
                                {
                                    if (so.active == RESERVATION.SUBORDER.ACTIVE && so.Reservation.Payment != null)
                                    {
                                        totalCantSold += 1;
                                    }
                                }
                            }
                        }
                        TicketsInfo.Add(new float[] { ev.id, totalCant, totalCantSold });

                    }
                    int idEvent = 0;
                    if (x == COM.EVENT.REPORT.BEST)
                    {
                        float max = 0;
                        foreach (float[] ticketInfo in TicketsInfo)
                        {
                            float porcent = (ticketInfo[2] * 100) / ticketInfo[1];
                            if (((ticketInfo[2] * 100) / ticketInfo[1]) > max)
                            {
                                idEvent = Convert.ToInt32(ticketInfo[0]);
                                max = (ticketInfo[2] * 100 / ticketInfo[1]);
                            }
                        }
                    }
                    else
                    {
                        float min = 100;
                        foreach (float[] ticketInfo in TicketsInfo)
                        {
                            if (((ticketInfo[2] * 100) / ticketInfo[1]) <= min)
                            {
                                idEvent = Convert.ToInt32(ticketInfo[0]);
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
                                    && t.SubOrder.FirstOrDefault().active == COM.RESERVATION.SUBORDER.ACTIVE)
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

        //Si la fecha es 01/01/0001 0:00:00, NO la va a tomar en cuenta
        //Si el local es none, NO lo va a tomar en cuenta
        //Si page o pageSize es menor a 1, NO lo tomara en cuenta y devolvera TODOS los que encuentre
        public List<Event> searchEvents(string text, int page = 0, int pageSize = 0, DateTime maxDate = default(DateTime), DateTime minDate = default(DateTime), String local = "none", double price = 0, string type = "none")
        {
            List<Event> events = null;
            try
            {

                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    //El select es porque necesito un IOrderedQueryable
                    var query = context.Event
                        .Include("EventLocation")
                        .Include("TicketType")
                        .OrderByDescending(e => e.date)
                        .Select(e => e);
                    if (page > 0 && pageSize > 0)
                    {
                        query = query.Skip((page - 1) * pageSize).Take(pageSize);
                    }
                    if (text != "" && text != null)
                    {
                        query = query.Where(e => e.name.Contains(text));
                    }
                    //verifica que la fecha no sea 01/01/0001 0:00:00
                    if (maxDate != default(DateTime))
                    {
                        query = query.Where(e => e.date <= maxDate);
                    }
                    if (minDate != default(DateTime))
                    {
                        query = query.Where(e => e.date >= minDate);
                    }
                    if (local != "none" && local != "" && local != null)
                    {
                        query = query.Where(e => e.EventLocation.name == local);
                    }
                    if (price > 0)
                    {
                        query = query.Where(e => e.TicketType.Min(tt => tt.cost) <= price);
                    }
                    if (type != "none" && type != "" && type != null)
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

        public int newEventLocation(EventLocation el)
        {
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    if (el.id == 0)
                    {
                        if (context.EventLocation.Add(el) != null)
                        {
                            context.SaveChanges();
                        }
                    }
                }
                return el.id;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public bool updateEventLocation(EventLocation eventLocation)
        {
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    EventLocation el = context.EventLocation.FirstOrDefault(e => e.id == eventLocation.id);
                    if (el != null)
                    {
                        el.name = eventLocation.name;
                        el.address = eventLocation.address;
                        el.phoneNumber = eventLocation.phoneNumber;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
