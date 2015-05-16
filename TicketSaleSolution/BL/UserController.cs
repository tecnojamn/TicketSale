using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class UserController
    {
        public BO.User getUser(int pid)
        {
            BO.User us = null;
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    /*var consulta = from u in context.User
                                   select new { u.id, u.name, u.lastName, u.mail };
                    return consulta;*/
                    
                    us = context.User.FirstOrDefault(u => u.id == pid);
                    return us;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<BO.User> getUsers()
        {
            List<BO.User> users = new List<BO.User>();
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    /*var consulta = from u in context.User
                                   select new { u.id, u.name, u.lastName, u.mail };
                    return consulta;*/

                    var query = from u in context.User select u;
                    users = query.ToList();
                    return users;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
