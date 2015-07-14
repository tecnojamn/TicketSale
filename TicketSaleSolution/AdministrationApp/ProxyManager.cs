
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationApp
{
    class ProxyManager
    {
        public static UserService.UserServiceClient _UserService;
        public static EventService.EventServiceClient _EventService;
        public static ReservationService.ReservationServiceClient _ReservationService;
        public static UserService.UserServiceClient getUserService()
        {
            if (_UserService == null)
                _UserService = new UserService.UserServiceClient();
            return _UserService;
        }
        public static EventService.EventServiceClient getEventService()
        {
            if (_EventService == null)
                _EventService = new EventService.EventServiceClient();
            return _EventService;
        }
        public static ReservationService.ReservationServiceClient getReservationService()
        {
            if (_ReservationService == null)
                _ReservationService = new ReservationService.ReservationServiceClient();
            return _ReservationService;
        }
    }
}
