using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BO;
using BL;
using DTO;
using AutoMapper;

namespace WS
{
    //Servicio Usuario
    public class UserService : IUserService
    {
        public UserDTO authorize(string mail, string pass)
        {
            UserController uc = new UserController();
            Mapper.CreateMap<User, UserDTO>()
                .ForMember(u => u.Reservation, opt => opt.Ignore()); //No me traigas reservas, no las necesito
            return Mapper.Map<UserDTO>(uc.authorize(mail, pass));
        }
        public bool newUser(UserDTO userDTO)
        {
            UserController uc = new UserController();
            Mapper.CreateMap<UserDTO, User>()
                .ForMember(u => u.Reservation, opt => opt.Ignore()); //No me traigas reservas, no las necesito
            return uc.newUser(Mapper.Map<User>(userDTO));
        }
        UserDTO getUser(int id)
        {
            UserController uc = new UserController();
            Mapper.CreateMap<User, UserDTO>();
            return Mapper.Map<UserDTO>(uc.getUser(id));
        }
        //public bool newUser(string mail, string name, string lastName, DateTime dateBirth, string pass)
       /* public bool newUser(DTOUser dtoUser)
        {
            UserController uc = new UserController();
            return uc.newUser(mail, name, lastName, dateBirth, pass);
        }*/
    }
}

