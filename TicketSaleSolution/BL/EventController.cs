﻿using System;
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
            var auxDicitonary = new Dictionary<int, decimal>();
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    int entradasTomadas = 0;
                    int entradasDisp = 0;
                    decimal res = 0M;
                    eventos = context.Event.Select(e => e)
                        .OrderByDescending(e => e.date)
                        .Skip((page - 1) * pageSize)
                        .Take(pageSize)
                        .ToList();
                     foreach (Event e in eventos)
                     {
                         entradasTomadas = 0;
                         entradasDisp = 0;

                         foreach (TicketType et in e.TicketType) {
                             int entradas=et.finalNum - et.startNum;
                             entradasDisp += entradas;
                              foreach (var t in et.Ticket)
                                 {
                                    /* if (t.SubOrder.Count == 0)
                                     {*/
                                     entradasTomadas+=t.SubOrder.Count;
                                     /*}*/
                                 }
                         }
                         res = 0M;
                         if(entradasDisp>0)
                             res = ((decimal)entradasTomadas) / ((decimal)entradasDisp);
                         auxDicitonary.Add(e.id, res);
                     }
                     //ordeno el diccionario
                     auxDicitonary.OrderBy(key => key.Value);
                     //lo paso a lista de ints, ya ordenada
                     List<int> idList=new List<int>(auxDicitonary.Keys);
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
    }
}
