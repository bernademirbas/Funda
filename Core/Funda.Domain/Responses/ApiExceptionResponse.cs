namespace Funda.Domain.Responses
{
    public class ApiExceptionResponse : ApiExceptionBaseResponse
    {
        public string Details { get; set; }
        public ApiExceptionResponse(int statusCode, string message = null, string details = null) : base(statusCode, message)
        {
            Details = details;
        }
    }
}
