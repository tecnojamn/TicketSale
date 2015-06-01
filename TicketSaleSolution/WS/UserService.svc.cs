using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BO;
using BL;
using DTO;

namespace WS
{
    //Servicio Usuario
    public class UserService : IUserService
    {
        public DTOUser authorize(string mail, string pass)
        {

            UserController uc = new UserController();

            return uc.authorize(mail, pass);

        }
       // public bool newUser(string mail, string name, string lastName, DateTime dateBirth, string pass)
        public bool newUser(DTOUser dtoUser)
        {
            UserController uc = new UserController();
            return uc.newUser(mail, name, lastName, dateBirth, pass);
        }
    }
}

