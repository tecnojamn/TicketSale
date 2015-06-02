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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "EventService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione EventService.svc o EventService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class EventService : IEventService
    {
        public bool newEvent(EventDTO evDTO) { return false; }

        public bool cancelEvent(int id) { return false; }

        public bool updateEvent(EventDTO evDTO) { return false; }

        public List<EventDTO> getEvents(int page, int pageSize) { return null; }

        public EventDTO getEvent(int id) { return null; }
    }
}
