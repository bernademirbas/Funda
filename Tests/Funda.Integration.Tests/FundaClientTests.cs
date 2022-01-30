using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Flurl.Http.Testing;
using Funda.Domain.Options;
using Funda.Domain.Requests;
using Funda.Domain.Responses;
using Funda.Integration.Clients;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;
using Xunit;

namespace Funda.Integration.Tests
{
    public class FundaClientTests
    {
        private readonly Mock<IOptions<FundaClientOptions>> _mockFundaClientOptions;
        private readonly Mock<ILogger<FundaClient>> _mockLogger;
        public FundaClientTests()
        {
            _mockFundaClientOptions = new Mock<IOptions<FundaClientOptions>>();
            _mockLogger = new Mock<ILogger<FundaClient>>();
        }

        private FundaClient CreateFundaClient()
        {
            IOptions<FundaClientOptions> apiOptions = Options.Create(new FundaClientOptions()
            { BaseUrl = "https://mockurl", ApiKey = "1", DataFormat = "json" });
            _mockFundaClientOptions.Setup(a => a.Value).Returns(apiOptions.Value);

            return new FundaClient(_mockFundaClientOptions.Object, _mockLogger.Object);
        }

        [Fact]
        public async Task GetPropertiesAsync_ShouldThrowsException_WhenHttpResponseFailed()
        {
            //Arrange
            var channelEngineClient = CreateFundaClient();
            var propertySearchRequest = new PropertySearchRequest
            {
                Type = "koop"
            };
            using var httpTest = new HttpTest();
            httpTest.RespondWith(status: (int)HttpStatusCode.BadRequest);

            // Assert
            await Assert.ThrowsAsync<Exception>(async () => await channelEngineClient.GetPropertiesAsync(propertySearchRequest));
            httpTest.ShouldHaveCalled($"{_mockFundaClientOptions.Object.Value.BaseUrl}/feeds/Aanbod.svc/{_mockFundaClientOptions.Object.Value.DataFormat}/{_mockFundaClientOptions.Object.Value.ApiKey}")
                .WithVerb(HttpMethod.Get)
                .WithQueryParams(new { Type = "koop" })
                .Times(1);
        }

        [Fact]
        public async Task GetPropertiesAsync_ShouldThrowsException_WhenResultNotSuccess()
        {
            //Arrange
            var channelEngineClient = CreateFundaClient();
            var propertySearchRequest = new PropertySearchRequest
            {
                Type = "koop"
            };
            using var httpTest = new HttpTest();
            var response = new BasePropertyResponse<List<PropertyResponse>>() { ValidationFailed = true };
            httpTest.RespondWithJson(response);

            // Assert
            await Assert.ThrowsAsync<Exception>(async () => await channelEngineClient.GetPropertiesAsync(propertySearchRequest));
            httpTest.ShouldHaveCalled($"{_mockFundaClientOptions.Object.Value.BaseUrl}/feeds/Aanbod.svc/{_mockFundaClientOptions.Object.Value.DataFormat}/{_mockFundaClientOptions.Object.Value.ApiKey}")
                .WithVerb(HttpMethod.Get)
                .WithQueryParams(new { Type = "koop" })
                .Times(1);
        }

        [Fact]
        public async Task GetPropertiesAsync_ShouldBeTrue_WhenDataIsValid()
        {
            //Arrange
            var channelEngineClient = CreateFundaClient();
            var propertySearchRequest = new PropertySearchRequest
            {
                Type = "koop"
            };
            using var httpTest = new HttpTest();
            var response = new BasePropertyResponse<List<PropertyResponse>>() { ValidationFailed = false, Objects = new List<PropertyResponse>()};
            httpTest.RespondWithJson(response);

            //Act
            var result = await channelEngineClient.GetPropertiesAsync(propertySearchRequest);

            // Assert
            Assert.IsAssignableFrom<IEnumerable<PropertyResponse>>(result);
            httpTest.ShouldHaveCalled($"{_mockFundaClientOptions.Object.Value.BaseUrl}/feeds/Aanbod.svc/{_mockFundaClientOptions.Object.Value.DataFormat}/{_mockFundaClientOptions.Object.Value.ApiKey}")
                .WithVerb(HttpMethod.Get)
                .WithQueryParams(new { Type = "koop" })
                .Times(1);
        }
    }
}
