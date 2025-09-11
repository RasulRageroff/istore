using System.ComponentModel.DataAnnotations;

namespace Store.Web.Models
{
    public class ErrorViewModel
    {

        [Required]

        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
