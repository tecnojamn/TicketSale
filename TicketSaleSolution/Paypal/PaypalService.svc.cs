using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Paypal
{


    public class PaypalService : IPaypalService
    {
        string _user = "Pepe";
        string _pass = "123456";
        double _countAmount = 40133;
        bool _isLogged = false;

        public bool login(string user, string pass)
        {
            if (!user.Equals("") && !pass.Equals(""))
            {
                if (_user.Equals(user) && _pass.Equals(pass))
                {
                    _isLogged = true;
                    return true;
                }
            }
            return false;
        }
        public bool doPayment(double amount)
        {
            if (_isLogged)
            {
                if (amount <= _countAmount)
                {
                    _countAmount -= amount;

                    return true;
                }

            }
            return false;
        }

    }
}
