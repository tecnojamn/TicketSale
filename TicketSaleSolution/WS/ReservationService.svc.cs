using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BO;
using DTO;

namespace WS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ReservationService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ReservationService.svc o ReservationService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ReservationService : IReservationService
    {
        public bool newReservation(ReservationDTO resDTO) { return false; }
        public bool autoCancelation() { return false; }
        public List<ReservationDTO> getReservationsByUser(int idUser, int page, int pageSize) { return null; }
        public List<ReservationDTO> getReservations(int page, int pageSize) { return null; }
    }
}
