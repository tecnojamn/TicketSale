﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34014
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdministrationApp.UserService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserService.IUserService")]
    public interface IUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/authorize", ReplyAction="http://tempuri.org/IUserService/authorizeResponse")]
        DTO.UserDTO authorize(string mail, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/authorize", ReplyAction="http://tempuri.org/IUserService/authorizeResponse")]
        System.Threading.Tasks.Task<DTO.UserDTO> authorizeAsync(string mail, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/newUser", ReplyAction="http://tempuri.org/IUserService/newUserResponse")]
        bool newUser(DTO.UserDTO userDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/newUser", ReplyAction="http://tempuri.org/IUserService/newUserResponse")]
        System.Threading.Tasks.Task<bool> newUserAsync(DTO.UserDTO userDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/confirmUser", ReplyAction="http://tempuri.org/IUserService/confirmUserResponse")]
        bool confirmUser(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/confirmUser", ReplyAction="http://tempuri.org/IUserService/confirmUserResponse")]
        System.Threading.Tasks.Task<bool> confirmUserAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/getUser", ReplyAction="http://tempuri.org/IUserService/getUserResponse")]
        DTO.UserDTO getUser(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/getUser", ReplyAction="http://tempuri.org/IUserService/getUserResponse")]
        System.Threading.Tasks.Task<DTO.UserDTO> getUserAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/getUsers", ReplyAction="http://tempuri.org/IUserService/getUsersResponse")]
        DTO.UserDTO[] getUsers(int page, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/getUsers", ReplyAction="http://tempuri.org/IUserService/getUsersResponse")]
        System.Threading.Tasks.Task<DTO.UserDTO[]> getUsersAsync(int page, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/updateUser", ReplyAction="http://tempuri.org/IUserService/updateUserResponse")]
        bool updateUser(DTO.UserDTO userDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/updateUser", ReplyAction="http://tempuri.org/IUserService/updateUserResponse")]
        System.Threading.Tasks.Task<bool> updateUserAsync(DTO.UserDTO userDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/removeUser", ReplyAction="http://tempuri.org/IUserService/removeUserResponse")]
        bool removeUser(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/removeUser", ReplyAction="http://tempuri.org/IUserService/removeUserResponse")]
        System.Threading.Tasks.Task<bool> removeUserAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/getPreferredUsers", ReplyAction="http://tempuri.org/IUserService/getPreferredUsersResponse")]
        DTO.UserDTO[] getPreferredUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/getPreferredUsers", ReplyAction="http://tempuri.org/IUserService/getPreferredUsersResponse")]
        System.Threading.Tasks.Task<DTO.UserDTO[]> getPreferredUsersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServiceChannel : AdministrationApp.UserService.IUserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<AdministrationApp.UserService.IUserService>, AdministrationApp.UserService.IUserService {
        
        public UserServiceClient() {
        }
        
        public UserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DTO.UserDTO authorize(string mail, string pass) {
            return base.Channel.authorize(mail, pass);
        }
        
        public System.Threading.Tasks.Task<DTO.UserDTO> authorizeAsync(string mail, string pass) {
            return base.Channel.authorizeAsync(mail, pass);
        }
        
        public bool newUser(DTO.UserDTO userDTO) {
            return base.Channel.newUser(userDTO);
        }
        
        public System.Threading.Tasks.Task<bool> newUserAsync(DTO.UserDTO userDTO) {
            return base.Channel.newUserAsync(userDTO);
        }
        
        public bool confirmUser(string token) {
            return base.Channel.confirmUser(token);
        }
        
        public System.Threading.Tasks.Task<bool> confirmUserAsync(string token) {
            return base.Channel.confirmUserAsync(token);
        }
        
        public DTO.UserDTO getUser(int id) {
            return base.Channel.getUser(id);
        }
        
        public System.Threading.Tasks.Task<DTO.UserDTO> getUserAsync(int id) {
            return base.Channel.getUserAsync(id);
        }
        
        public DTO.UserDTO[] getUsers(int page, int pageSize) {
            return base.Channel.getUsers(page, pageSize);
        }
        
        public System.Threading.Tasks.Task<DTO.UserDTO[]> getUsersAsync(int page, int pageSize) {
            return base.Channel.getUsersAsync(page, pageSize);
        }
        
        public bool updateUser(DTO.UserDTO userDTO) {
            return base.Channel.updateUser(userDTO);
        }
        
        public System.Threading.Tasks.Task<bool> updateUserAsync(DTO.UserDTO userDTO) {
            return base.Channel.updateUserAsync(userDTO);
        }
        
        public bool removeUser(int id) {
            return base.Channel.removeUser(id);
        }
        
        public System.Threading.Tasks.Task<bool> removeUserAsync(int id) {
            return base.Channel.removeUserAsync(id);
        }
        
        public DTO.UserDTO[] getPreferredUsers() {
            return base.Channel.getPreferredUsers();
        }
        
        public System.Threading.Tasks.Task<DTO.UserDTO[]> getPreferredUsersAsync() {
            return base.Channel.getPreferredUsersAsync();
        }
    }
}
