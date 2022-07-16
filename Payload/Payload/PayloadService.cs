using Newtonsoft.Json;
using Payload.Dto;
using Payload.Repository;
using Payload.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceModel;
using System.Threading;

namespace Payload
{
    [ServiceBehavior(
        ConcurrencyMode = ConcurrencyMode.Single,
        InstanceContextMode = InstanceContextMode.PerCall)]
    public class PayloadService : IPayloadService, IPayloadStartService
    {
        private static List<IPayloadCallbackService> _callbackList = new List<IPayloadCallbackService>();
        private static IDictionary<string, Thread> _threadLst = new Dictionary<string, Thread>();
        private static Random random = new Random();
        private IPayloadRepository _payloadRepository;

        public PayloadService()
        {
            _payloadRepository = WcfServiceFactory.GetPayloadRepository();
        }
        public void StartPayload(string path)
        {
            if (path == null)
            {
                throw new FaultException<ServiceFault>(new ServiceFault("File is invalid, please check the file and try again"));
            }
            PayloadDto payload = ReadConfigFile.GetVehicleDto(path);
            payload.IsActive = true;
            if (_payloadRepository.GetPayloadByName(payload.Name) != null)
            {
                throw new FaultException<ServiceFault>(new ServiceFault("Payload with same name already present, please change the name of the payload"));

            }
            _payloadRepository.AddPayloads(payload);
            Thread t = new Thread(() => { InitiatePayload(payload.Name); });
            _threadLst.Add(payload.Name, t);
            t.Start();
        }

        public void DecommissionPayload(string name)
        {
            PayloadDto payload = _payloadRepository.GetPayloadByName(name);
            if (!payload.IsActive)
            {
                throw new FaultException<ServiceFault>(new ServiceFault("Cannot decommission, payload is not active"));
            }
            SuspendThread(name);
            _payloadRepository.DeletePayload(name);
        }

        public List<PayloadDto> GetPayloads()
        {
            return _payloadRepository.GetPayloads();
        }

        public void SendTelemetryRequest(string name, bool status)
        {
            PayloadDto payload = _payloadRepository.GetPayloadByName(name);
            IPayloadCallbackService data = OperationContext.Current.GetCallbackChannel<IPayloadCallbackService>();
            if (!_callbackList.Contains(data))
            {
                _callbackList.Add(data);
            }
            if (payload == null)
            {
                throw new FaultException<ServiceFault>(new ServiceFault("Cannot send command, payload not found"));
            }
            if (!payload.IsActive)
            {
                throw new FaultException<ServiceFault>(new ServiceFault("Cannot send command, payload is not active"));
            }
            payload.ShowTelemetry = status;
            if (!_threadLst.ContainsKey(name))
            {
                Thread t = new Thread(() => { InitiatePayload(payload.Name); });
                _threadLst.Add(name, t);
                t.Start();
            }
        }

        public void SendDataRequest(string name, bool status)
        {
            PayloadDto payload = _payloadRepository.GetPayloadByName(name);
            IPayloadCallbackService data = OperationContext.Current.GetCallbackChannel<IPayloadCallbackService>();
            if (!_callbackList.Contains(data))
            {
                _callbackList.Add(data);
            }
            if (payload == null)
            {
                throw new FaultException<ServiceFault>(new ServiceFault("Cannot send command, payload not found"));
            }
            if (!payload.IsActive)
            {
                throw new FaultException<ServiceFault>(new ServiceFault("Cannot send command, payload is not active"));
            }
            payload.ShowData = status;
            string payloadName = name + "data";
            if (!_threadLst.ContainsKey(payloadName))
            {
                Thread t = new Thread(() => { InitiatePayloadData(payload.Name); });
                _threadLst.Add(payloadName, t);
                t.Start();
            }
        }

        private void InitiatePayload(string name)
        {
            PayloadDto payload = _payloadRepository.GetPayloadByName(name);
            while (payload.IsActive)
            {
                if (payload.ShowTelemetry)
                {
                    _callbackList[0].NotifyPayloadTelemetryData(new TelemetryDto
                    {
                        Altitude = random.Next(0, 10000),
                        Longitude = random.Next(-90, 90),
                        Latitude = random.Next(-180, 180),
                        Temperature = random.Next(0, 373),
                        TimeToOrbit = 0
                    });
                    Thread.Sleep(1000);
                }
            }
        }

        private void InitiatePayloadData(string name)
        {
            PayloadDto payload = _payloadRepository.GetPayloadByName(name);
            while (payload.IsActive)
            {
                if (payload.ShowData)
                {
                    object data;
                    if (payload.payloadType == Enum.PayloadType.Scientific)
                    {
                        data = new WeatherDto()
                        {
                            Rain = random.Next(0, 100),
                            Humidity = random.Next(0, 100),
                            Snow = random.Next(0, 100)
                        };
                        _callbackList[0].NotifyData(JsonConvert.SerializeObject(data));
                        Thread.Sleep(60000);
                    }
                    else if (payload.payloadType == Enum.PayloadType.Communication)
                    {
                        data = new CommunicationDto()
                        {
                            Uplink = random.Next(0, 10000),
                            Downlink = random.Next(0, 10000),
                            ActiveTransponders = random.Next(1, 100)
                        };
                        _callbackList[0].NotifyData(JsonConvert.SerializeObject(data));
                        Thread.Sleep(5000);
                    }
                    else if (payload.payloadType == Enum.PayloadType.Spy)
                    {
                        data = ImageUtil.GetThumbnail(random.Next(1, 5));
                        _callbackList[0].NotifyImage((Stream)data);
                        Thread.Sleep(10000);
                    }
                }
            }
        }
        private void SuspendThread(string name)
        {
            if (_threadLst.ContainsKey(name))
            {
                _threadLst[name].Abort();
                _threadLst.Remove(name);
            }
            name = name + "data";
            if (_threadLst.ContainsKey(name))
            {
                _threadLst[name].Abort();
                _threadLst.Remove(name);
            }
        }
    }
}
