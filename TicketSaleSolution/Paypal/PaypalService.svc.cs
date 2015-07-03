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
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        int transactionLength = 10;
        Random random = new Random();
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
        public string doPayment(double amount)
        {
            if (amount <= _countAmount)
            {
                _countAmount -= amount;
                return new string(Enumerable.Repeat(chars, transactionLength).Select(s => s[random.Next(s.Length)]).ToArray());
            }

            return "";
        }

    }
}
