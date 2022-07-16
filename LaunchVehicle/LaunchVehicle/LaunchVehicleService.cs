using LaunchVehicle.Model;
using LaunchVehicle.Payload;
using LaunchVehicle.Repository;
using LaunchVehicle.Utility;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;

namespace LaunchVehicle
{
    [ServiceBehavior(
        ConcurrencyMode = ConcurrencyMode.Single,
        InstanceContextMode = InstanceContextMode.PerCall)]
    public class LaunchVehicleService : ILaunchVehicleService
    {
        private static List<ILaunchVehicleCallbackService> _callbackList = new List<ILaunchVehicleCallbackService>();
        private static IDictionary<string, Thread> _threadLst = new Dictionary<string, Thread>();
        private static Random random = new Random();
        private ILaunchVehicleRepository _launchVehicleRepository;
        private PayloadStartServiceClient psClient;

        /* public LaunchVehicleService(ILaunchVehicleRepository launchVehicleRepository)
         {
             _launchVehicleRepository = launchVehicleRepository;
         }*/

        public void AddVehicle(string path)
        {
            if (path == null)
            {
                throw new FaultException<ServiceFault>(new ServiceFault("File is invalid, please check the file and try again"));
            }
            _launchVehicleRepository = new LaunchVehicleRepository();
            LaunchVehicleDto launchVehicle = ReadConfigFile.GetVehicleDto(path);
            ILaunchVehicleCallbackService data = OperationContext.Current.GetCallbackChannel<ILaunchVehicleCallbackService>();
            if (!_callbackList.Contains(data))
            {
                _callbackList.Add(data);
            }
            if (_launchVehicleRepository.GetLaunchVehicleByName(launchVehicle.Name) != null)
            {
                throw new FaultException<ServiceFault>(new ServiceFault("Vehicle with same name already present, please change the name of the vehicle"));
            }
            else
            {
                _launchVehicleRepository.AddLaunchVehicles(launchVehicle);
            }
        }

        public void StartVehicle(string name)
        {
            _launchVehicleRepository = new LaunchVehicleRepository();
            LaunchVehicleDto launchVehicle = _launchVehicleRepository.GetLaunchVehicleByName(name);
            ILaunchVehicleCallbackService data = OperationContext.Current.GetCallbackChannel<ILaunchVehicleCallbackService>();
            if (!_callbackList.Contains(data))
            {
                _callbackList.Add(data);
            }
            if (launchVehicle.IsActive)
            {
                throw new FaultException<ServiceFault>(new ServiceFault("Vehicle with same name is already launched"));
            }
            launchVehicle.IsActive = true;
            int orbitTime = ((launchVehicle.OrbitInfo / 3600) + 10);
            Thread t = new Thread(() => { InitiateVehicle(launchVehicle.Name, orbitTime); });
            _threadLst.Add(name, t);
            t.Start();
        }

        public List<LaunchVehicleDto> GetVehicles()
        {
            _launchVehicleRepository = new LaunchVehicleRepository();
            return _launchVehicleRepository.GetLaunchVehicles();
        }

        public void SendTelemetryRequest(string name, bool status)
        {
            _launchVehicleRepository = new LaunchVehicleRepository();
            _launchVehicleRepository.GetLaunchVehicleByName(name).ShowTelemetry = status;
        }

        private void InitiateVehicle(string name, int orbit)
        {
            while (true)
            {
                _launchVehicleRepository = new LaunchVehicleRepository();
                if (_launchVehicleRepository.GetLaunchVehicleByName(name).ShowTelemetry)
                {
                    _callbackList[0].NotifyTelemetryData(new Dto.TelemetryDto
                    {
                        Altitude = random.Next(0, 10000),
                        Longitude = random.Next(-90, 90),
                        Latitude = random.Next(-180, 180),
                        Temperature = random.Next(0, 373),
                        TimeToOrbit = orbit < 0 ? 0 : orbit
                    });
                }
                if (orbit == 0)
                {
                    _launchVehicleRepository.SetStatusOfDeploy(name, true);
                    _callbackList[0].NotifyDeployStatus(name, _launchVehicleRepository.GetLaunchVehicleByName(name).ShouldDeploy);
                }
                orbit--;
                Thread.Sleep(1000);
            }
        }

        public void DeployPayload(string name)
        {
            _launchVehicleRepository = new LaunchVehicleRepository();
            LaunchVehicleDto launchVehicle = _launchVehicleRepository.GetLaunchVehicleByName(name);
            if (launchVehicle == null)
            {
                throw new FaultException<ServiceFault>(new ServiceFault("Cannot deploy, vehicle not found"));
            }
            if (!launchVehicle.IsActive)
            {
                throw new FaultException<ServiceFault>(new ServiceFault("Cannot deploy, vehicle is not launched yet"));
            }
            else if (!launchVehicle.ShouldDeploy)
            {
                throw new FaultException<ServiceFault>(new ServiceFault("Cannot deploy, vehicle haven't reached to orbit yet"));
            }
            else if (launchVehicle.IsDeployed)
            {
                throw new FaultException<ServiceFault>(new ServiceFault("Vehicle already deployed"));
            }
            else
            {
                launchVehicle.IsDeployed = true;
                psClient = new PayloadStartServiceClient("NetTcpBinding_IPayloadStartService");
                psClient.Open();
                psClient.StartPayload(launchVehicle.PayLoad);
            }
        }

        public void DeorbitLaunchVehicle(string name)
        {
            _launchVehicleRepository = new LaunchVehicleRepository();
            LaunchVehicleDto launchVehicle = _launchVehicleRepository.GetLaunchVehicleByName(name);
            if (launchVehicle == null)
            {
                throw new FaultException<ServiceFault>(new ServiceFault("Cannot deploy, vehicle not found"));
            }
            if (!launchVehicle.IsDeployed)
            {
                throw new FaultException<ServiceFault>(new ServiceFault("Cannot derobit, payload not deployed yet"));
            }
            try
            {
                _launchVehicleRepository.DeleteLaunchVehicles(name);
                SuspendThread(name);
            }
            catch (ArgumentException ex)
            {
                throw new FaultException<ServiceFault>(new ServiceFault("Cannot derobit, vehicle with such name not found"));
            }
        }

        private void SuspendThread(string name)
        {
            if (_threadLst.ContainsKey(name))
            {
                _threadLst[name].Abort();
                _threadLst.Remove(name);
            }
        }
    }
}
