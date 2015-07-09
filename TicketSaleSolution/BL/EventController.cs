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
            var auxDicitonary = new SortedDictionary<int, double>();
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    float entradasTomadas = 0f;
                    float entradasDisp = 0f;
                    
                    eventos = context.Event.Select(e => e).Where(e => e.enabled == 1)
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
                                        entradasTomadas+=1.0f;
                                }
                            }
                        }
                        //double res;
                        if (entradasDisp > 0)
                        {

                            // res= ((entradasTomadas) / (entradasDisp));
                            auxDicitonary.Add(e.id, ((entradasTomadas) / (entradasDisp)));
                        }
                        else
                        {
                            // res = 0.000000f;
                            auxDicitonary.Add(e.id, -1);
                        }
                       // auxDicitonary.Add(e.id, res);
                    }

                    foreach(KeyValuePair<int, double> k in auxDicitonary){
                        var p=k.Value;
                    }

                    //ordeno el diccionario
                    //auxDicitonary = auxDicitonary.OrderBy(i => i.Value).ToDictionary(x => x.Key, x => x.Value);
                   
                   
                    //lo paso a lista de ints, ya ordenada
                    List<int> idList = new List<int>(auxDicitonary.Keys);
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
