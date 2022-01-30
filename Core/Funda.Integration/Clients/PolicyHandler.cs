using Polly.Timeout;
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using Polly;
using Polly.Retry;
using Polly.Wrap;

namespace Funda.Integration.Clients
{
    public class PolicyHandler : DelegatingHandler
    {
        protected override HttpResponseMessage Send(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return Policies.PolicyStrategy.Execute(ct => base.Send(request, ct), cancellationToken);
        }
    }

    public static class Policies
    {
        private static RetryPolicy<HttpResponseMessage> RetryPolicy
        {
            get
            {
                return Policy.HandleResult<HttpResponseMessage>
                        (r => r.StatusCode == HttpStatusCode.TooManyRequests || r.StatusCode == HttpStatusCode.Unauthorized)
                    .Or<TimeoutRejectedException>()
                    .WaitAndRetry(new[]
                        {
                            TimeSpan.FromSeconds(60)
                        });
            }
        }

        public static PolicyWrap<HttpResponseMessage> PolicyStrategy => Policy.Wrap(RetryPolicy);
    }
}
