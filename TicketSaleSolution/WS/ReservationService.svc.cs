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
                .ForMember(so => so.Ticket, opt => opt.MapFrom(x=>x.Ticket));

            Mapper.CreateMap<TicketDTO, Ticket>()
                .ForMember(t => t.SubOrder, opt => opt.Ignore())
                .ForMember(t => t.TicketType, opt => opt.Ignore());

            return rc.newReservation(Mapper.Map<Reservation>(resDTO));
        }
        public bool autoCancelation() { return false; } //Despues se ve
        public List<ReservationDTO> getReservationsByUser(int idUser, int page, int pageSize, bool onlyPayments = false)
        {
            ReservationController rc = new ReservationController();

            Mapper.CreateMap<Reservation, ReservationDTO>()
                .ForMember(r => r.User, opt => opt.Ignore())
                .ForMember(r => r.Payment, opt => opt.MapFrom(x => x.Payment))
                .ForMember(r => r.SubOrder, opt => opt.MapFrom(x => x.SubOrder));
            Mapper.CreateMap<Payment, PaymentDTO>()
                .ForMember(p => p.CashPayment, opt => opt.MapFrom(x => x.CashPayment))
                .ForMember(p => p.PaypalPayment, opt => opt.MapFrom(x => x.PaypalPayment))
                .ForMember(p => p.Reservation, opt => opt.Ignore());
            Mapper.CreateMap<CashPayment, CashPaymentDTO>()
                .ForMember(cp => cp.PaymentLocation, opt => opt.Ignore())
                .ForMember(cp => cp.Payment, opt => opt.Ignore());
            Mapper.CreateMap<PaypalPayment, PaypalPaymentDTO>()
                .ForMember(pp => pp.Payment, opt => opt.Ignore());
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
                .ForMember(e => e.EventLocation, opt => opt.Ignore())
                .ForMember(e => e.TicketType, opt => opt.Ignore());

            return Mapper.Map<List<ReservationDTO>>(rc.getReservationsByUser(idUser, page, pageSize, onlyPayments));
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
                .ForMember(r => r.Payment, opt => opt.MapFrom(x => x.Payment))
                .ForMember(r => r.User, opt => opt.MapFrom(x => x.User))
                .ForMember(r => r.SubOrder, opt => opt.MapFrom(x => x.SubOrder));
            Mapper.CreateMap<Payment, PaymentDTO>()
                .ForAllMembers(opt => opt.Ignore());
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
        public int getReservationCountByUser(int idUser, bool onlyPayments = false)
        {
            ReservationController rc = new ReservationController();
            return rc.getReservationCountByUser(idUser, onlyPayments);
        }
        public bool cancelSubOrder(int idSO)
        {
            ReservationController rc = new ReservationController();
            return rc.cancelSubOrder(idSO);
        }
        public bool cancelAllSubOrders(int idRes)
        {
            ReservationController rc = new ReservationController();
            return rc.cancelAllSubOrders(idRes);
        }
        public TicketDTO generateNewTicket(int idTicketType)
        {
            ReservationController rc = new ReservationController();

            Mapper.CreateMap<Ticket, TicketDTO>()
                .ForMember(t => t.SubOrder, opt => opt.Ignore())
                .ForMember(t => t.TicketType, opt => opt.Ignore());

            return Mapper.Map<TicketDTO>(rc.generateNewTicket(idTicketType));
        }
    }
}
