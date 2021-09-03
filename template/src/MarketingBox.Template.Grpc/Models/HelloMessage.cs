using System.Runtime.Serialization;
using MarketingBox.Template.Domain.Models;

namespace MarketingBox.Template.Grpc.Models
{
    [DataContract]
    public class HelloMessage : IHelloMessage
    {
        [DataMember(Order = 1)]
        public string Message { get; set; }
    }
}
