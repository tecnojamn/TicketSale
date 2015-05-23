using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class EventController
    {
        //Nuevo evento
        public bool newEvent(BO.Event ev)
        {
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    if (context.Event.Add(ev) != null) //Devuelve null si no inserta
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
        //Cancelar Evento
        public bool removeEvent(int idEv)
        {
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    BO.Event e = context.Event.FirstOrDefault(ev => ev.id == idEv);
                    if (e != null)
                    {
                        if (context.Event.Remove(e) != null) //Devuelve null si no borra
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
        }
        //Editar Evento
        public bool updateEvent(BO.Event ev)
        {
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    BO.Event e = context.Event.FirstOrDefault(evn => evn.id == ev.id);
                    if (e != null)
                    {
                        e.date = ev.date;
                        e.description = ev.description;
                        e.enable = ev.enable;
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
        //Listar Eventos (Web o Movil)
        public List<BO.Event> getEvents()
        {
            List<BO.Event> events = null;
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    events = context.Event.Select(e => e).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return events;
            
        }
        //Obtener Evento
        //Return null si no existe
        public BO.Event getEvent(int idEv)
        {
            BO.Event ev = null;
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    /*var consulta = from u in context.User
                            select new { u.id, u.name, u.lastName, u.mail };
                    return consulta;*/
                    ev = context.Event.FirstOrDefault(e => e.id == idEv);
                }

            }
            catch (Exception)
            {
                throw;
            }
            return ev;
        }
    }
}
