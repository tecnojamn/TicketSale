using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BL
{
    public class UserController
    {
        public User getUser(int pid)
        {
            User us = null;
            try
            {
                using (TicketSaleEntities context = new TicketSaleEntities())
                {
                    us = context.User.FirstOrDefault(u => u.id == pid);
                }

            }
            catch (Exception)
            {
                throw;
            }
            return us;
        }
    }
}
