using System.ComponentModel.DataAnnotations;

namespace Funda.Domain.Requests
{
    public class PropertyRequest
    {
        [Required]
        public string Type { get; set; }

        public string SearchText { get; set; }

        public int Count { get; set; }
    }
}
