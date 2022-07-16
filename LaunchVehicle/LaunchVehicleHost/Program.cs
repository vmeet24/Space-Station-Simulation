using LaunchVehicle;
using System;
using System.ServiceModel;

namespace LaunchVehicleHost
{
    internal class Program
    {
        static void Main()
        {
            using (ServiceHost serviceHost = new ServiceHost(typeof(LaunchVehicleService)))
            {
                serviceHost.Open();
                Console.WriteLine("Hello from Launch Vehicle");
                Console.ReadLine();
            }
        }
    }
}
