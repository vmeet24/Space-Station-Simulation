using LaunchVehicle.Model;
using System.Collections.Generic;
using System.ServiceModel;

namespace LaunchVehicle
{
    [ServiceContract(SessionMode = SessionMode.Required,
        CallbackContract = typeof(ILaunchVehicleCallbackService))]
    public interface ILaunchVehicleService
    {
        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        void AddVehicle(string path);

        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        void StartVehicle(string name);

        [OperationContract]
        void SendTelemetryRequest(string name, bool status);

        [OperationContract]
        List<LaunchVehicleDto> GetVehicles();

        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        void DeployPayload(string name);

        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        void DeorbitLaunchVehicle(string name);

    }
}
