using System;
using System.ServiceModel;

namespace PayloadHost
{
    internal class Program
    {
        static void Main()
        {
            using (ServiceHost serviceHost = new ServiceHost(typeof(Payload.PayloadService)))
            {
                serviceHost.Open();
                Console.WriteLine("Hello from Payload");
                Console.ReadLine();
            }
        }
    }
}
