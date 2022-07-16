using Payload.Repository;

namespace Payload
{
    public class WcfServiceFactory
    {
        private static IPayloadRepository payloadRepository;

        public static IPayloadRepository GetPayloadRepository()
        {
            if (payloadRepository == null)
            {
                payloadRepository = new PayloadRepository();
            }
            return payloadRepository;
        }
    }
}
