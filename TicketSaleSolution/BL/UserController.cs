using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using COM;
using System.Net.Mail;
using System.Web;

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
                    user.token = SECURITY.STRING_TO_MD5(user.mail+"12345");
                    user.active = USER.STATE.INACTIVE;
                    
                    //HttpRequest request = HttpContext.Current.Request;
                    //string url = request.Url.Authority.ToString();
                    
                    String url = PATH.BASE_URL+"Views/Confirm.aspx?auth_token=" + user.token + "";

                    if (context.User.Add(user) != null)
                    {
                        MAILER.sendCofirmationMail(user.mail,url);
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
        //Confirmar usuario
        public bool confirmUser(String token)
        {
            User user;
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {

                    user = context.User.First(u => u.token == token && u.active==USER.STATE.INACTIVE);
                    if (user!=null) {

                        user.token="";
                        user.active = USER.STATE.ACTIVE;
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return (user!=null);
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
                        //if (context.User.Remove(u) != null)
                        //{
                            u.active = USER.STATE.INACTIVE;
                            context.SaveChanges();
                        //}

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
                       // u.mail = (us.mail!=null && !us.mail.Equals(""))?us.mail:u.mail;
                       // u.password = (us.password != null && !us.password.Equals("")) ? us.password : u.password;
                        u.name = (us.name != null && !us.name.Equals("")) ? us.name : u.name; ;
                        u.lastName = (us.lastName != null && !us.lastName.Equals("")) ? us.lastName : u.lastName; ;
                       // u.dateBirth = (us.dateBirth != null) ? us.dateBirth : u.dateBirth;
                       // u.userType = (us.userType!=null)?us.userType:u.userType;
                       // u.active = (us.active != null) ? us.active : u.active;
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
        public bool updatePassword(String oldPassword,String password,int userId)
        {
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    User u = context.User.FirstOrDefault(user => user.id == userId && user.password==oldPassword);
                    if (u != null)
                    {
                        u.password = password;   
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
        //returns true if email is already in use
        private bool isEmailTaken(String email)
        {
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
            return (user != null);
        }
    }
}
