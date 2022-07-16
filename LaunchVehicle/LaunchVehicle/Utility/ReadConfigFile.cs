using LaunchVehicle.Model;
using Newtonsoft.Json;
using System.IO;


namespace LaunchVehicle.Utility
{
    public class ReadConfigFile
    {
        public static LaunchVehicleDto GetVehicleDto(string path)
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<LaunchVehicleDto>(json);
            }
        }
    }
}
