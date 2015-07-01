using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DTO;

namespace WS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IEventService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IEventService
    {
       
        [OperationContract]
        bool newEvent(EventDTO evDTO);

        [OperationContract]
        bool cancelEvent(int id);

        [OperationContract]
        bool updateEvent(EventDTO evDTO);

        [OperationContract]
        List<EventDTO> getEvents(int page, int pageSize);

        [OperationContract]
        EventDTO getEvent(int id);

        [OperationContract]
        List<EventDTO> searchEvents(string text, DateTime maxDate, DateTime minDate, String local, double price, string type);
        
        [OperationContract]
        List<EventLocationDTO> getLocals();

        [OperationContract]
        List<string> getEventType();
    }
}
