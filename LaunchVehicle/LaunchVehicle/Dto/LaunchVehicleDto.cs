using System.Runtime.Serialization;

namespace LaunchVehicle.Model
{
    public class LaunchVehicleDto
    {
        public string Name { get; set; }
        public int OrbitInfo { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeployed { get; set; }
        public bool ShouldDeploy { get; set; }
        public bool ShowTelemetry { get; set; }
        public string PayLoad { get; set; }
    }
}
