using System.ComponentModel.DataAnnotations;

namespace M5Blz.Models
{
    public class DisplayCodeModel
    {
        [Required]
        [MinLength(4, ErrorMessage = "Le code doit avoir 4 caractère.")]
        [MaxLength(4, ErrorMessage = "Le code doit avoir 4 caractère.")]
        public string Code { get; set; }
    }
}
