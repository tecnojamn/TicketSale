﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using BO;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TicketSaleEntities : DbContext
    {
        public TicketSaleEntities()
            : base("name=TicketSaleEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EventLocation> EventLocation { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<PaypalPayment> PaypalPayment { get; set; }
        public virtual DbSet<Reservation> Reservation { get; set; }
        public virtual DbSet<SubOrder> SubOrder { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<TicketType> TicketType { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<CashPayment> CashPayment { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<PaymentLocation> PaymentLocation { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
