using System.ServiceModel;
using System.Threading.Tasks;
using MarketingBox.Template.Grpc.Models;

namespace MarketingBox.Template.Grpc
{
    [ServiceContract]
    public interface IHelloService
    {
        [OperationContract]
        Task<HelloMessage> SayHelloAsync(HelloRequest request);
    }
}
