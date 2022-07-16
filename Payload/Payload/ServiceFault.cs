using System.Runtime.Serialization;

namespace Payload
{
    [DataContract]
    public class ServiceFault
    {
        private string _message;

        public ServiceFault(string message)
        {
            _message = message;
        }

        [DataMember]
        public string Message { get { return _message; } set { _message = value; } }
    }
}
