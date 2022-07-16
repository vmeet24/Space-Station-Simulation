using Payload.Dto;
using System.Collections.Generic;
using System.ServiceModel;

namespace Payload
{
    [ServiceContract(SessionMode = SessionMode.Required,
        CallbackContract = typeof(IPayloadCallbackService))]
    public interface IPayloadService
    {
        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        void SendTelemetryRequest(string name, bool status);

        [OperationContract]
        List<PayloadDto> GetPayloads();

        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        void DecommissionPayload(string name);

        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        void SendDataRequest(string name, bool status);
    }
}
