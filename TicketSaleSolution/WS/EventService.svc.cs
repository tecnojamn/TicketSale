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
            Mapper.CreateMap<Event, EventDTO>()
                .ForMember(e => e.TicketType, opt => opt.Ignore())
                .ForMember(e => e.EventLocation, opt => opt.Ignore());
            return Mapper.Map<List<EventDTO>>(ec.getEvents(page, pageSize));
        }

        public EventDTO getEvent(int id)
        {
            EventController ec = new EventController();

            //Configuracion Automapper (Pasar a constructor asi queda mas prolijo?)
            Mapper.CreateMap<Event, EventDTO>()
                .ForMember(e => e.TicketType, opt => opt.MapFrom(x => x.TicketType))
                .ForMember(e => e.EventLocation, opt => opt.MapFrom(x => x.EventLocation));
            Mapper.CreateMap<EventLocation, EventLocationDTO>()
                .ForMember(eLoc => eLoc.Event, opt => opt.Ignore());
            Mapper.CreateMap<TicketType, TicketTypeDTO>()
                .ForMember(tt => tt.Ticket, opt => opt.MapFrom(x => x.Ticket))
                .ForMember(tt => tt.Event, opt => opt.Ignore());
            Mapper.CreateMap<Ticket, TicketDTO>()
                .ForMember(t => t.SubOrder, opt => opt.MapFrom(x => x.SubOrder))
                .ForMember(t => t.TicketType, opt => opt.Ignore());
            Mapper.CreateMap<SubOrder, SubOrderDTO>()
                .ForMember(so => so.Reservation, opt => opt.Ignore())
                .ForMember(so => so.Ticket, opt => opt.Ignore());


            return Mapper.Map<EventDTO>(ec.getEvent(id));
        }
    }
}
