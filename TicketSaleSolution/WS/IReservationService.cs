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
        bool newReservation(ReservationDTO resDTO);

        [OperationContract]
        bool autoCancelation();

        [OperationContract]
        List<ReservationDTO> getReservationsByUser(int idUser, int page, int pageSize);

        [OperationContract]
        List<ReservationDTO> getReservations(int page, int pageSize);

        [OperationContract] 
        ReservationDTO getReservation(int idReservation);

        [OperationContract]
        int getReservationCountByUser(int idUser, bool onlyPayments = false);

        [OperationContract] 
        bool cancelSubOrder(int idSO);

        [OperationContract]
        bool cancelAllSubOrders(int idRes);
    }
}
