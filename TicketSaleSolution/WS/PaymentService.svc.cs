using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BL;
using BO;
using DTO;
using AutoMapper;

namespace WS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "PaymentService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione PaymentService.svc o PaymentService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class PaymentService : IPaymentService
    {
        public PaymentDTO getPayment(int id)
        {
            PaymentController pc = new PaymentController();

            Mapper.CreateMap<PaymentDTO, Payment>()
                .ForMember(p => p.CashPayment, opt => opt.Ignore())
                .ForMember(p => p.PaypalPayment, opt => opt.Ignore())
                .ForMember(p => p.Reservation, opt => opt.Ignore());

            return Mapper.Map<PaymentDTO>(pc.getPayment(id));
        }
        public List<PaymentDTO> getPayments(int page, int pageSize)
        {
            PaymentController pc = new PaymentController();

            Mapper.CreateMap<PaymentDTO, Payment>()
                .ForMember(p => p.CashPayment, opt => opt.Ignore())
                .ForMember(p => p.PaypalPayment, opt => opt.Ignore())
                .ForMember(p => p.Reservation, opt => opt.Ignore());

            return Mapper.Map<List<PaymentDTO>>(pc.getPayments(page, pageSize));
        }
        public int newPayment(PaymentDTO pDTO)
        {
            PaymentController pc = new PaymentController();

            Mapper.CreateMap<Payment, PaymentDTO>()
                .ForMember(p => p.CashPayment, opt => opt.Ignore())
                .ForMember(p => p.PaypalPayment, opt => opt.Ignore())
                .ForMember(p => p.Reservation, opt => opt.Ignore());

            return pc.newPayment(Mapper.Map<Payment>(pDTO));
        }
        public bool updatePayment(PaymentDTO pDTO)
        {
            PaymentController pc = new PaymentController();

            Mapper.CreateMap<Payment, PaymentDTO>()
                .ForMember(p => p.CashPayment, opt => opt.Ignore())
                .ForMember(p => p.PaypalPayment, opt => opt.Ignore())
                .ForMember(p => p.Reservation, opt => opt.Ignore());

            return pc.updatePayment(Mapper.Map<Payment>(pDTO));
        }

        public List<PaymentLocationDTO> getPaymentLocations()
        {
            PaymentController pc = new PaymentController();

            Mapper.CreateMap<PaymentLocation, PaymentLocationDTO>()
                .ForMember(p => p.CashPayment, opt => opt.Ignore());

            return Mapper.Map<List<PaymentLocationDTO>>(pc.getPaymentLocations().ToList());
        }
    }
}
