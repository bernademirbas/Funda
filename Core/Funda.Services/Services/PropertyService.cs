using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Funda.Domain.Requests;
using Funda.Domain.Responses;
using Funda.Integration.Interfaces;
using Funda.Services.Interfaces;

namespace Funda.Services.Services
{
    public class PropertyService : IPropertyService
    {
        private readonly IFundaClient _fundaClient;

        public PropertyService(IFundaClient fundaClient)
        {
            _fundaClient = fundaClient;
        }

        /// <summary>
        /// gets estate agents filtered by property filter request
        /// </summary>
        /// <param name="propertyRequest">filter model for properties</param>
        /// <returns></returns>
        public async Task<List<EstateAgentResponse>> GetEstateAgentsByPropertyAsync(PropertyRequest propertyRequest)
        {
            var propertySearchRequest = new PropertySearchRequest()
            {
                Type = propertyRequest.Type,
                Zo = propertyRequest.SearchText
            };

            var properties = await _fundaClient.GetPropertiesAsync(propertySearchRequest);
            return properties.GroupBy(property => property.EstateAgentId)
                .OrderByDescending(property => property.Count()).Take(propertyRequest.Count)
                .Select(property => new EstateAgentResponse()
                {
                    EstateAgentId = property.Key,
                    EstateAgentName = property.FirstOrDefault()?.EstateAgentName,
                    PropertyCount = property.Count()
                }).ToList();
        }
    }
}
