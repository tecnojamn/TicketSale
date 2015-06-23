using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DTO;

namespace WS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IPaymentService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IPaymentService
    {
        [OperationContract]
        PaymentDTO getPayment(int id);
        [OperationContract]
        List<PaymentDTO> getPayments(int page, int pageSize);
        [OperationContract]
        int newPayment(PaymentDTO p);
        [OperationContract]
        bool updatePayment(PaymentDTO p);
        [OperationContract]
        List<PaymentLocationDTO> getPaymentLocations();
    }
}
