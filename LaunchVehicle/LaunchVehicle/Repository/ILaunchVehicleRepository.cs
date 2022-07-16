using LaunchVehicle.Model;
using System.Collections.Generic;

namespace LaunchVehicle.Repository
{
    public interface ILaunchVehicleRepository
    {
        void AddLaunchVehicles(LaunchVehicleDto launchVehicleDto);
        void DeleteLaunchVehicles(string name);
        List<LaunchVehicleDto> GetLaunchVehicles();
        LaunchVehicleDto GetLaunchVehicleByName(string name);
        void SetStatusOfDeploy(string name, bool value);
    }
}
