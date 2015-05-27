using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWeb
{

    //Clase que consume webservice
    public class ProxyManager
    {
        public static UserServiceClient.UserServiceClient _UserService;

        public static UserServiceClient.UserServiceClient getUserService()
        {
            if (_UserService == null)
                _UserService = new UserServiceClient.UserServiceClient();
            return _UserService;
        }

    }
}