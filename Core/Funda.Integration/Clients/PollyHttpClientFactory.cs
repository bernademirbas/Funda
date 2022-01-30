using System.Net.Http;
using Flurl.Http.Configuration;

namespace Funda.Integration.Clients
{
    public class PollyHttpClientFactory : DefaultHttpClientFactory
    {
        public override HttpMessageHandler CreateMessageHandler()
        {
            return new PolicyHandler
            {
                InnerHandler = base.CreateMessageHandler()
            };
        }
    }
}
