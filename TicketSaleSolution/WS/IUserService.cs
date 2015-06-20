using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DTO;

namespace WS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IUserService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        UserDTO authorize(string mail, string pass);

        [OperationContract]
        bool newUser(UserDTO userDTO);

        [OperationContract]
        bool confirmUser(String token);

        [OperationContract]
        UserDTO getUser(int id);

        [OperationContract]
        List<UserDTO> getUsers(int page, int pageSize);

        [OperationContract]
        bool updateUser(UserDTO userDTO);

        [OperationContract]
        bool removeUser(int id);
    }
}
