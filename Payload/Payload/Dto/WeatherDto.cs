using System.Runtime.Serialization;

namespace Payload.Dto
{
    public class WeatherDto
    {
        public int Rain { get; set; }
        public int Humidity { get; set; }
        public int Snow { get; set; }
    }
}
