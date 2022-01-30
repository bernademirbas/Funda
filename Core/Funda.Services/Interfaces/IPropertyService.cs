using System.Collections.Generic;
using Funda.Domain.Responses;
using System.Threading.Tasks;
using Funda.Domain.Requests;

namespace Funda.Services.Interfaces
{
    public interface IPropertyService
    {
        Task<List<EstateAgentResponse>> GetEstateAgentsByPropertyAsync(PropertyRequest propertyRequest);
    }
}
