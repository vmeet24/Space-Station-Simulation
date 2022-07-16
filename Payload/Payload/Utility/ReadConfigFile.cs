using Newtonsoft.Json;
using Payload.Dto;
using System.IO;

namespace Payload.Utility
{
    public class ReadConfigFile
    {
        public static PayloadDto GetVehicleDto(string path)
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<PayloadDto>(json);
            }
        }
    }
}
