using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using COM;
using System.Net.Mail;
namespace BL
{
    public class UserController
    {
        //Obtener Usuario
        public User getUser(int idUs)
        {
            User user = null;
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    user = context.User.FirstOrDefault(u => u.id == idUs);
                }

            }
            catch (Exception)
            {
                throw;
            }
            return user;
        }
        //Obtener Lista de Usuarios
        public List<User> getUsers(int page = 1, int pageSize = 1)
        {
            List<User> users = new List<User>();
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    var query = from u in context.User where u.active == USER.STATE.ACTIVE select u;
                    users = query
                        .Skip((page - 1) * pageSize)
                        .Take(pageSize)
                        .ToList();
                }

            }
            catch (Exception)
            {
                throw;
            }
            return users;
        }
        //Inicio sesion
        public User authorize(string mail, string password)
        {
            User user = null;
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    user = context.User.First(u => u.mail == mail && u.password == password && u.active == USER.STATE.ACTIVE);
                }
            }
            catch (Exception)
            {
                return null;
            }
            return user;
        }
        //returns true if email is already in use
        private bool isEmailTaken(String email) {
            User user = null;
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    user = context.User.First(u => u.mail == email);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return (user!=null);
        }
        
        //Nuevo Usuario
        public bool newUser(User user)
        {
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                   
                    if(isEmailTaken(user.mail)){
                        return false;
                    }
                    user.token = ""; //Falta crear random esto antes, traerlo desde el servicio

                    if (context.User.Add(user) != null)
                    {
                        string code=SECURITY.STRING_TO_MD5(user.mail+"12345");
                        MAILER.sendCofirmationMail(user.mail,code);
                        context.SaveChanges();
                    }
                    else { return false; }
                }
            }
            catch (Exception)
            {
                return false;
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
                    User u = context.User.FirstOrDefault(us => us.id == id);
                    if (u != null)
                    {
                        if (context.User.Remove(u) != null)
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
        /* //Editar datos usuario (NO SIRVE)
         public bool updateUser(int id, string mail, string password, string name, string lastName, System.DateTime dateBirth, byte userType)
         {
             try
             {
                 using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                 {
                     User u = context.User.FirstOrDefault(us => us.id == id);
                     if (u != null)
                     {
                         u.mail = mail;
                         u.password = password;
                         u.name = name;
                         u.lastName = lastName;
                         u.dateBirth = dateBirth;
                         u.userType = userType;
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


         }*/
        //Editar datos a partir de un BO.User
        public bool updateUser(User us)
        {
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    User u = context.User.FirstOrDefault(user => user.id == us.id);
                    if (u != null)
                    {
                        u.mail = us.mail;
                        u.password = us.password;
                        u.name = us.name;
                        u.lastName = us.lastName;
                        u.dateBirth = us.dateBirth;
                        u.userType = us.userType;
                        u.active = us.active;
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

        //Usuario inactivo 
        public bool desactivateUser(int id)
        {
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    User user = context.User.FirstOrDefault(u => u.id == id);
                    if (user != null)
                    {
                        user.active = USER.STATE.INACTIVE;
                        context.SaveChanges();
                        return true;
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return false;
        }
    }
}
