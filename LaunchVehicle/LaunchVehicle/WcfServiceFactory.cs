using LaunchVehicle.Repository;
using Unity;
using Unity.Wcf;

namespace LaunchVehicle
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WcfServiceFactory" in both code and config file together.
    public class WcfServiceFactory : UnityServiceHostFactory
    {
        protected override void ConfigureContainer(IUnityContainer container)
        {
            // configure container
            container
                .RegisterType<ILaunchVehicleRepository, LaunchVehicleRepository>()
                .RegisterType<ILaunchVehicleService, LaunchVehicleService>();
        }
    }
}
