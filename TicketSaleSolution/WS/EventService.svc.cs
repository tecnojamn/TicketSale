using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BO;
using DTO;
using BL;
using AutoMapper;

namespace WS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "EventService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione EventService.svc o EventService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class EventService : IEventService
    {
        public bool newEvent(EventDTO evDTO)
        {
            EventController ec = new EventController();
            Mapper.CreateMap<EventDTO, Event>();
            return ec.newEvent(Mapper.Map<Event>(evDTO));
        }

        public bool cancelEvent(int id)
        {
            EventController ec = new EventController();
            return ec.cancelEvent(id);
        }

        public bool updateEvent(EventDTO evDTO)
        {
            EventController ec = new EventController();
            Mapper.CreateMap<EventDTO, Event>();
            return ec.updateEvent(Mapper.Map<Event>(evDTO));
        }

        public List<EventDTO> getEvents(int page, int pageSize)
        {
            EventController ec = new EventController();
            Mapper.CreateMap<EventDTO, Event>();
            return Mapper.Map<List<EventDTO>>(ec.getEvents(page, pageSize));
        }

        public EventDTO getEvent(int id)
        {
            EventController ec = new EventController();
            Mapper.CreateMap<Event, EventDTO>();
            return Mapper.Map<EventDTO>(ec.getEvent(id));
        }
    }
}
