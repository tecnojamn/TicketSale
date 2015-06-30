using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWeb
{
    //Manejador de servicios web
    public class ProxyManager
    {
        public static UserServiceClient.UserServiceClient _UserService;
        public static EventServiceClient.EventServiceClient _EventService;
        public static ReservationServiceClient.ReservationServiceClient _ReservationService;
        public static PaymentServiceClient.PaymentServiceClient _PaymentService;
        public static PaypalServiceClient.PaypalServiceClient _PaypalService;

        public static UserServiceClient.UserServiceClient getUserService()
        {
            if (_UserService == null)
                _UserService = new UserServiceClient.UserServiceClient();
            return _UserService;
        }
        public static EventServiceClient.EventServiceClient getEventService()
        {
            if (_EventService == null)
                _EventService = new EventServiceClient.EventServiceClient();
            return _EventService;
        }
        public static ReservationServiceClient.ReservationServiceClient getReservationService()
        {
            if (_ReservationService == null)
                _ReservationService = new ReservationServiceClient.ReservationServiceClient();
            return _ReservationService;
        }
        public static PaymentServiceClient.PaymentServiceClient getPaymentService()
        {
            if (_PaymentService == null)
                _PaymentService = new PaymentServiceClient.PaymentServiceClient();
            return _PaymentService;
        }
        public static PaypalServiceClient.PaypalServiceClient getPaypalClient()
        {
            if (_PaypalService == null)
                _PaypalService = new PaypalServiceClient.PaypalServiceClient();
            return _PaypalService;
        }
    }
}