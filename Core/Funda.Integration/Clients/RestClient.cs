using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;
using Microsoft.Extensions.Logging;

namespace Funda.Integration.Clients
{
    public class RestClient
    {
        private readonly ILogger<RestClient> _logger;
        public RestClient(ILogger<RestClient> logger)
        {
            _logger = logger;
        }

        public async Task<T> GetAsync<T>(string uri, Dictionary<string, string> headers = null, object queryParams = null)
        {
            var request = uri
                .AllowAnyHttpStatus()
                .WithHeaders(headers)
                .SetQueryParams(queryParams);

            var response = await request.GetAsync();
            if (!response.ResponseMessage.IsSuccessStatusCode)
            {
                _logger.LogError(response.ResponseMessage.ReasonPhrase);
                throw new Exception($"Status Code:{response.StatusCode} - Message:{response.ResponseMessage.ReasonPhrase}");
            }

            return await response.GetJsonAsync<T>();
        }
        
    }
}
