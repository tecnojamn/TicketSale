using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BO;
using BO.DTO;

namespace WS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IUserService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        DTOUser authorize(string mail,string pass);

        [OperationContract]
        bool newUser(string mail, string name, string lastName, DateTime dateBirth, string pass);
    }
}
