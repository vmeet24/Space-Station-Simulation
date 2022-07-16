using LaunchVehicle.Model;
using System;
using System.Collections.Generic;

namespace LaunchVehicle.Repository
{
    public class LaunchVehicleRepository : ILaunchVehicleRepository
    {
        public static List<LaunchVehicleDto> launchVehicles = new List<LaunchVehicleDto>();

        public LaunchVehicleDto GetLaunchVehicleByName(string name)
        {
            return launchVehicles.Find(x => x.Name == name);
        }

        public List<LaunchVehicleDto> GetLaunchVehicles()
        {
            return launchVehicles;
        }

        public void SetStatusOfDeploy(string name, bool value)
        {
            var launchVehicle = launchVehicles.Find(x => x.Name == name);
            launchVehicle.ShouldDeploy = value;
        }

        public void AddLaunchVehicles(LaunchVehicleDto launchVehicleDto)
        {
            launchVehicles.Add(launchVehicleDto);
        }

        public void DeleteLaunchVehicles(string name)
        {
            var launchVehicleDto = launchVehicles.Find(x => x.Name == name);
            if (launchVehicleDto == null)
            {
                throw new ArgumentException();
            }
            launchVehicles.Remove(launchVehicleDto);
        }
    }
}
