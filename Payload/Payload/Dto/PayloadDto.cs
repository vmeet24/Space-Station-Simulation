using Payload.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payload.Dto
{
    public class PayloadDto
    {
        public string Name { get; set; }
        public PayloadType payloadType { get; set; }
        public bool IsActive { get; set; }
        public bool ShowTelemetry { get; set; }
        public bool ShowData { get; set; }
    }
}
