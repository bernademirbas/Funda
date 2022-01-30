using Funda.Integration.Interfaces;
using Funda.Services.Services;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Funda.Domain.Requests;
using Funda.Domain.Responses;
using Xunit;

namespace Funda.Services.Tests
{
    public class PropertyServiceTests
    {
        private readonly Mock<IFundaClient> _mockFundaClient;
        public PropertyServiceTests()
        {
            _mockFundaClient = new Mock<IFundaClient>();
        }

        private PropertyService CreatePropertyService()
        {
            return new PropertyService(_mockFundaClient.Object);
        }

        [Fact]
        public async Task GetEstateAgentsByPropertyAsync_ShouldBeTrue_WhenDataIsValid()
        {
            //Arrange
            var propertyService = CreatePropertyService();
            var propertyRequest = new PropertyRequest() { Count = 5};
            _mockFundaClient.Setup(client => client.GetPropertiesAsync(It.IsAny<PropertySearchRequest>()))
                .ReturnsAsync(new List<PropertyResponse>{ new PropertyResponse()
                {
                    EstateAgentId = 1,
                    EstateAgentName = "mock-agent"
                }});

            //Act
            var properties = await propertyService.GetEstateAgentsByPropertyAsync(propertyRequest);

            // Assert
            _mockFundaClient.VerifyAll();
            Assert.IsAssignableFrom<List<EstateAgentResponse>>(properties);
        }
    }
}
