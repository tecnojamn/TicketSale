//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class SubOrder
{
    public int id { get; set; }
    public byte active { get; set; }
    public int idReservation { get; set; }
    public int idTicket { get; set; }

    public virtual Reservation Reservation { get; set; }
    public virtual Ticket Ticket { get; set; }
}
