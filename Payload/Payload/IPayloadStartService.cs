using System.ServiceModel;

namespace Payload
{
    [ServiceContract]
    public interface IPayloadStartService
    {
        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        void StartPayload(string name);
    }
}
