using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Funda.Domain.Options;
using Funda.Domain.Requests;
using Funda.Domain.Responses;
using Funda.Integration.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace Funda.Integration.Clients
{
    public class FundaClient : RestClient, IFundaClient
    {
        private readonly FundaClientOptions _fundaClientOptions;
        private readonly ILogger<FundaClient> _logger;
        public FundaClient(IOptions<FundaClientOptions> fundaClientOptions, ILogger<FundaClient> logger) : base(logger)
        {
            _fundaClientOptions = fundaClientOptions.Value;
            _logger = logger;
        }

        /// <summary>
        /// Get Filtered Properties from Http Rest Client
        /// </summary>
        /// <param name="propertySearchRequest"></param>
        /// <returns></returns>
        public async Task<IEnumerable<PropertyResponse>> GetPropertiesAsync(PropertySearchRequest propertySearchRequest)
        {
            var uri = GenerateApiUrl("feeds/Aanbod.svc");
            var result = await GetAsync<BasePropertyResponse<IEnumerable<PropertyResponse>>>
                ($"{uri}", queryParams: propertySearchRequest);

            if (result.ValidationFailed)
            {
                _logger.LogError(JsonConvert.SerializeObject(result.ValidationReport));
                throw new Exception(
                    $"GetPropertiesAsync Failed - Message:{JsonConvert.SerializeObject(result.ValidationReport)}");
            }
            return result.Objects.ToList();
        }

        /// <summary>
        /// Generates full endpoint url with base url and api key
        /// </summary>
        /// <param name="apiUrl">endpoint path</param>
        /// <returns></returns>
        private string GenerateApiUrl(string apiUrl)
        {
            return
                $"{_fundaClientOptions.BaseUrl}/{apiUrl}/{_fundaClientOptions.DataFormat}/{_fundaClientOptions.ApiKey}";
        }
    }
}
