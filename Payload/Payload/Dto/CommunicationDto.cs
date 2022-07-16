using System.Runtime.Serialization;

namespace Payload.Dto
{
    public class CommunicationDto
    {
        public int Uplink { get; set; }
        public int Downlink { get; set; }
        public int ActiveTransponders { get; set; }
    }
}
