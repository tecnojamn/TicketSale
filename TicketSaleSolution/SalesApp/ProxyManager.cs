using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp
{
    class ProxyManager
    {
        public static UserService.UserServiceClient _UserService;
        public static ReservationService.ReservationServiceClient _ReservationService;
        public static PaymentService.PaymentServiceClient _PaymentService;

        public static UserService.UserServiceClient getUserService()
        {
            if (_UserService == null)
                _UserService = new UserService.UserServiceClient();
            return _UserService;
        }
    
        public static ReservationService.ReservationServiceClient getReservationService()
        {
            if (_ReservationService == null)
                _ReservationService = new ReservationService.ReservationServiceClient();
            return _ReservationService;
        }
        public static PaymentService.PaymentServiceClient getPaymentService()
        {
            if (_PaymentService == null)
                _PaymentService = new PaymentService.PaymentServiceClient();
            return _PaymentService;
        }

    }
}
