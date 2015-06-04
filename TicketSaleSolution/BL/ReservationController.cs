﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace BL
{
    public class ReservationController
    {
        //Nueva Reserva
        public bool newReservation(Reservation r)
        {
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    if (context.Reservation.Add(r) != null)
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
        //Cancelacion automatica
        public bool autoCancelation()
        {
            using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
            {
                return false;
            }
        }
        //Listar reservas de Usuario
        public List<Reservation> getReservationsByUser(int idUser, int page, int pageSize)
        {
            List<Reservation> res = null;
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    res = context.Reservation.Select(r => r).
                        Where(r => r.idUser == idUser).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return res;
        }
        //Listar  reservas
        public List<Reservation> getReservations(int page = 1, int pageSize = 1)
        {
            List<Reservation> res = null;
            try
            {
                using (DAL.TicketSaleEntities context = new DAL.TicketSaleEntities())
                {
                    res = context.Reservation.Select(r => r).Skip(page).Take(pageSize).OrderBy(r => r.date).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return res;
        }
    }
}