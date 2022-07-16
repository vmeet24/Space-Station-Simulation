using Payload.Dto;
using System.IO;
using System.ServiceModel;

namespace Payload
{
    public interface IPayloadCallbackService
    {
        [OperationContract(IsOneWay = true)]
        void NotifyPayloadTelemetryData(TelemetryDto telemetry);

        [OperationContract(IsOneWay = true)]
        void NotifyData(string data);

        [OperationContract(IsOneWay = true)]
        void NotifyImage(Stream data);
    }
}
