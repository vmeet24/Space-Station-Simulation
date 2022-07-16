using LaunchVehicle.Repository;

namespace LaunchVehicle
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WcfServiceFactory" in both code and config file together.
    public class WcfServiceFactory
    {
        private static ILaunchVehicleRepository launchVehicleRepository;

        public static ILaunchVehicleRepository GetLaunchVehicleRepository()
        {
            if (launchVehicleRepository == null)
            {
                launchVehicleRepository = new LaunchVehicleRepository();
            }
            return launchVehicleRepository;
        }
    }
}
