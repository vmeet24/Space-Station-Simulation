using System.Runtime.Serialization;

namespace Payload.Dto
{
    public class TelemetryDto
    {
        public int Altitude { get; set; }
        public int Longitude { get; set; }
        public int Latitude { get; set; }
        public int Temperature { get; set; }
        public int TimeToOrbit { get; set; }
    }
}
