using System.Collections.Generic;
using System.Threading.Tasks;
using Funda.Domain.Requests;
using Funda.Domain.Responses;

namespace Funda.Integration.Interfaces
{
    public interface IFundaClient
    {
        Task<IEnumerable<PropertyResponse>> GetPropertiesAsync(PropertySearchRequest propertySearchRequest);
    }
}
