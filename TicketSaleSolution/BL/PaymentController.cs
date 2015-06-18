using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace BL
{
    public class PaymentController
    {
        //Obtener Pago
        public Payment getPayment(int idRes){
            Payment p = null;
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    p = context.Payment.FirstOrDefault(pay => pay.idReservation == idRes);
                }

            }
            catch (Exception)
            {
                throw;
            }
            return p;
        }
        public List<Payment> getPayments(int page, int pageSize)
        {
            List<Payment> payments = new List<Payment>();
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    //otra alternativa de hacer consultas a la que dio el bonfri (LINQ)
                    var query = from p in context.Payment select p; 
                    payments = query.Skip((page - 1) * pageSize).Take(pageSize).ToList();
                }

            }
            catch (Exception)
            {
                throw;
            }
            return payments;
        }
        public bool newPayment(Payment p)
        {
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    if (context.Payment.Add(p) != null)
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
        public bool updatePayment(Payment p)
        {
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    Payment pay = context.Payment.FirstOrDefault(paym => paym.idReservation == p.idReservation);
                    if (pay != null)
                    {
                        pay.amount = p.amount;
                        pay.date = p.date;
                        //Ver si setear también las relaciones acá o en otra función
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
    }
}
