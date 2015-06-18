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
                .ForMember(r => r.Payment, opt => opt.Ignore())
                .ForMember(r => r.SubOrder, opt => opt.Ignore())
                .ForMember(r => r.User, opt => opt.Ignore());

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

            return Mapper.Map<List<ReservationDTO>>(rc.getReservations(page, pageSize));;
        }

        public ReservationDTO getReservation(int idReservation)
        {
            ReservationController rc = new ReservationController();

            Mapper.CreateMap<Reservation, ReservationDTO>()
                .ForMember(r => r.User, opt => opt.Ignore())
                .ForMember(r => r.Payment, opt => opt.Ignore())
                .ForMember(r => r.SubOrder, opt => opt.Ignore());

            return Mapper.Map<ReservationDTO>(rc.getReservation(idReservation));

        }
    }
}
