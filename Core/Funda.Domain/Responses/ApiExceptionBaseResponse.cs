﻿namespace Funda.Domain.Responses
{
    public class ApiExceptionBaseResponse
    {
        public ApiExceptionBaseResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request",
                401 => "Unauthorized",
                404 => "Resource not found",
                500 => "Api Exception ",
                _ => null
            };
        }
    }
}
