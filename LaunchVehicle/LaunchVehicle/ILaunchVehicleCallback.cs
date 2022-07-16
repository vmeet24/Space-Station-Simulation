using LaunchVehicle.Dto;
using System.ServiceModel;

namespace LaunchVehicle
{
    public interface ILaunchVehicleCallbackService
    {
        [OperationContract(IsOneWay = true)]
        void NotifyTelemetryData(TelemetryDto telemetry);

        [OperationContract(IsOneWay = true)]
        void NotifyDeployStatus(string name, bool status);
    }
}
