using System.ComponentModel.DataAnnotations;

namespace SampleMvc.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
