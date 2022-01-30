using System.ComponentModel.DataAnnotations;

namespace Funda.Domain.Requests
{
    public class PropertySearchRequest
    {
        [Required]
        public string Type { get; set; }

        public string Zo { get; set; }

        public string Page { get; set; }

        public string PageSize { get; set; }
    }
}
