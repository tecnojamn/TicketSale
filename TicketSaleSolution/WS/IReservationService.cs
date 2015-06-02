using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DTO;

namespace WS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IReservationService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IReservationService
    {
        [OperationContract]
        public bool newReservation(ReservationDTO resDTO);

        [OperationContract]
        public bool autoCancelation();

        [OperationContract]
        public List<ReservationDTO> getReservationsByUser(int idUser, int page, int pageSize);

        [OperationContract]
        public List<ReservationDTO> getReservations(int page, int pageSize);
    }
}
