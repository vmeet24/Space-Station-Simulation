using Payload.Dto;
using System;
using System.Collections.Generic;

namespace Payload.Repository
{
    public class PayloadRepository : IPayloadRepository
    {
        public static List<PayloadDto> payloads = new List<PayloadDto>();

        public void AddPayloads(PayloadDto payloadDto)
        {
            payloads.Add(payloadDto);
        }

        public void DeletePayload(string name)
        {
            var payloadDto = payloads.Find(x => x.Name == name);
            if (payloadDto == null)
            {
                throw new ArgumentException();
            }
            payloads.Remove(payloadDto);
        }

        public PayloadDto GetPayloadByName(string name)
        {
            return payloads.Find(x => x.Name == name);
        }

        public List<PayloadDto> GetPayloads()
        {
            return payloads;
        }
    }
}
