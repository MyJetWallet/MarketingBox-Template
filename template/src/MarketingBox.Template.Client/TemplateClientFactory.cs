using JetBrains.Annotations;
using MarketingBox.Template.Grpc;
using MyJetWallet.Sdk.Grpc;

namespace MarketingBox.Template.Client
{
    [UsedImplicitly]
    public class TemplateClientFactory: MyGrpcClientFactory
    {
        public TemplateClientFactory(string grpcServiceUrl) : base(grpcServiceUrl)
        {
        }

        public IHelloService GetHelloService() => CreateGrpcService<IHelloService>();
    }
}
