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
            Mapper.CreateMap<UserDTO, User>();
            return uc.newUser(Mapper.Map<User>(userDTO));
        }
        public UserDTO getUser(int id)
        {
            UserController uc = new UserController();
            Mapper.CreateMap<User, UserDTO>();
            return Mapper.Map<UserDTO>(uc.getUser(id));
        }
        public List<UserDTO> getUsers(int page, int pageSize)
        {
            UserController uc = new UserController();
            Mapper.CreateMap<User, UserDTO>()
                .ForMember(u => u.Reservation, opt => opt.Ignore());
            return Mapper.Map<List<UserDTO>>(uc.getUsers(page,pageSize));
        }
        public bool updateUser(UserDTO userDTO)
        {
            UserController uc = new UserController();
            Mapper.CreateMap<User, UserDTO>();
            return uc.updateUser(Mapper.Map<User>(userDTO));
        }

    }
}

