using System;
using System.Threading.Tasks;
using Funda.Domain.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Funda.Web.Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlerMiddleware> _logger;
        public ExceptionHandlerMiddleware(RequestDelegate next, ILogger<ExceptionHandlerMiddleware> logger)
        {
            _logger = logger;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                context.Response.ContentType = "application/json";

                var response = new ApiExceptionResponse(context.Response.StatusCode, ex.Message, ex.StackTrace);

                var json = JsonConvert.SerializeObject(response);

                await context.Response.WriteAsync(json);
            }
        }
    }
}
