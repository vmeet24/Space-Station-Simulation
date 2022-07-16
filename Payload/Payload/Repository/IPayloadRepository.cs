using Payload.Dto;
using System.Collections.Generic;

namespace Payload.Repository
{
    public interface IPayloadRepository
    {
        void AddPayloads(PayloadDto payloadDto);
        List<PayloadDto> GetPayloads();
        PayloadDto GetPayloadByName(string name);
        void DeletePayload(string name);
    }
}
