using System.ComponentModel.DataAnnotations;

namespace SampleMvc.Models.ManageViewModels
{
    public class VerifyNumberModel
    {
        [Required]
        public string Code { get; set; }
    }
}
