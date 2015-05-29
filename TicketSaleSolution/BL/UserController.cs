using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO.DTO;
using BO;

namespace BL
{
    public class UserController
    {
        //Obtener Usuario
        //Return null si no existe
        public BO.User getUser(int idUs)
        {
            BO.User us = null;
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    /*var consulta = from u in context.User
                            select new { u.id, u.name, u.lastName, u.mail };
                    return consulta;*/
                    us = context.User.FirstOrDefault(u => u.id == idUs);
                }

            }
            catch (Exception)
            {
                throw;
            }
            return us;
        }
        //Inicio sesion
        public DTOUser authorize(string mail, string password)
        {
            User user = null;
            DTOUser dtoUser = null;
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    user = context.User.First(u => u.mail == mail && u.password == password);
                    if (user != null)
                    {
                        dtoUser = new DTOUser()
                        {
                            name = user.name,
                            lastName = user.lastName,
                            mail = user.mail,
                            dateBirth = user.dateBirth,
                            password = user.password,
                            userType = 0,
                            mobileNum = 0 //SACAR LUEGO
                        };
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dtoUser;
        }
        //Nuevo Evento
        public bool newUser(BO.User us)
        {
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    if (context.User.Add(us) != null) //Devuelve null si no inserta
                    {
                        context.SaveChanges();
                    }
                    else { return false; }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }
        //Remover usuario
        public bool removeUser(int id)
        {
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    BO.User u = context.User.FirstOrDefault(us => us.id == id);
                    if (u != null)
                    {
                        if (context.User.Remove(u) != null) //Devuelve null si no borra
                        {
                            context.SaveChanges();
                        }

                    }
                    else { return false; }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return false;
        }
        //Editar datos usuario
        public bool updateUser(int id, string mail, string password, string name, string lastName, System.DateTime dateBirth, byte userType, int mobileNum)
        {
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    BO.User u = context.User.FirstOrDefault(us => us.id == id);
                    if (u != null)
                    {
                        u.mail = mail;
                        u.password = password;
                        u.name = name;
                        u.lastName = lastName;
                        u.dateBirth = dateBirth;
                        u.userType = userType;
                        u.mobileNum = mobileNum;
                        context.SaveChanges();
                    }
                    else { return false; }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return true;


        }
        //Editar datos a partir de un BO.User
        public bool updateUser(BO.User us)
        {
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    BO.User u = context.User.FirstOrDefault(user => user.id == us.id);
                    if (u != null)
                    {
                        u.mail = us.mail;
                        u.password = us.password;
                        u.name = us.name;
                        u.lastName = us.lastName;
                        u.dateBirth = us.dateBirth;
                        u.userType = us.userType;
                        u.mobileNum = us.mobileNum;
                        context.SaveChanges();
                    }
                    else { return false; }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return true;

        }
        //Obtener Lista de Usuarios
        public List<BO.User> getUsers()
        {
            List<BO.User> users = new List<BO.User>();
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    //otra alternativa de hacer consultas a la que dio el bonfri
                    var query = from u in context.User select u;
                    users = query.ToList();
                }

            }
            catch (Exception)
            {
                throw;
            }
            return users;
        }
    }
}
