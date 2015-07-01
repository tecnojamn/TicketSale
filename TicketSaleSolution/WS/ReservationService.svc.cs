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
    public class ReservationService : IReservationService
    {
        public bool newReservation(ReservationDTO resDTO)
        {
            ReservationController rc = new ReservationController();

            Mapper.CreateMap<ReservationDTO, Reservation>()
                .ForMember(r => r.SubOrder, opt => opt.MapFrom(x => x.SubOrder))
                .ForMember(r => r.Payment, opt => opt.Ignore())                
                .ForMember(r => r.User, opt => opt.Ignore());

            Mapper.CreateMap<SubOrderDTO, SubOrder>()
                .ForMember(so => so.Reservation, opt => opt.Ignore())
                .ForMember(so => so.Ticket, opt => opt.Ignore());

            return rc.newReservation(Mapper.Map<Reservation>(resDTO));
        }
        public bool autoCancelation() { return false; } //Despues se ve
        public List<ReservationDTO> getReservationsByUser(int idUser, int page, int pageSize)
        {
            ReservationController rc = new ReservationController();

            Mapper.CreateMap<Reservation, ReservationDTO>()
                .ForMember(r => r.User, opt => opt.Ignore())
                .ForMember(r => r.Payment, opt => opt.Ignore())
                .ForMember(r => r.SubOrder, opt => opt.Ignore());

            return Mapper.Map<List<ReservationDTO>>(rc.getReservationsByUser(idUser, page, pageSize));
        }
        public List<ReservationDTO> getReservations(int page, int pageSize)
        {
            ReservationController rc = new ReservationController();

            Mapper.CreateMap<Reservation, ReservationDTO>()
                .ForMember(r => r.User, opt => opt.Ignore())
                .ForMember(r => r.Payment, opt => opt.Ignore())
                .ForMember(r => r.SubOrder, opt => opt.Ignore());

            return Mapper.Map<List<ReservationDTO>>(rc.getReservations(page, pageSize)); ;
        }

        public ReservationDTO getReservation(int idReservation)
        {
            ReservationController rc = new ReservationController();

            Mapper.CreateMap<Reservation, ReservationDTO>()
                .ForMember(r => r.Payment, opt => opt.Ignore())
                .ForMember(r => r.User, opt => opt.MapFrom(x => x.User))
                .ForMember(r => r.SubOrder, opt => opt.MapFrom(x => x.SubOrder));
            Mapper.CreateMap<User, UserDTO>()
                .ForMember(u => u.Reservation, opt => opt.Ignore());
            Mapper.CreateMap<SubOrder, SubOrderDTO>()
                .ForMember(so => so.Reservation, opt => opt.Ignore())
                .ForMember(so => so.Ticket, opt => opt.MapFrom(x => x.Ticket));
            Mapper.CreateMap<Ticket, TicketDTO>()
                .ForMember(t => t.SubOrder, opt => opt.Ignore())
                .ForMember(t => t.TicketType, opt => opt.MapFrom(x => x.TicketType));
            Mapper.CreateMap<TicketType, TicketTypeDTO>()
                .ForMember(tt => tt.Ticket, opt => opt.Ignore())
                .ForMember(tt => tt.Event, opt => opt.MapFrom(x => x.Event));
            Mapper.CreateMap<Event, EventDTO>()
                .ForMember(e => e.EventLocation, opt => opt.MapFrom(x => x.EventLocation))
                .ForMember(e => e.TicketType, opt => opt.Ignore());
            Mapper.CreateMap<EventLocation, EventLocationDTO>()
                .ForMember(eLoc => eLoc.Event, opt => opt.Ignore());



            return Mapper.Map<ReservationDTO>(rc.getReservation(idReservation));

        }
    }
}
