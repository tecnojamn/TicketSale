using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BO;
using BL;

namespace WS
{
    //Servicio Usuario
    public class UserService : IUserService
    {
        public User authorize(string mail, string pass)
        {
            UserController uc = new UserController();
            User user = uc.authorize(mail, pass);
            return user;
        }
        public bool newUser(string mail, string name, string lastName, DateTime dateBirth, string pass)
        {
            UserController uc = new UserController();
            User user = new User() { 
                mail=mail,
                name=name,
                lastName=lastName,
                dateBirth=dateBirth,
                password=pass 
            };
            return uc.newUser(user);
        }
    }
}
