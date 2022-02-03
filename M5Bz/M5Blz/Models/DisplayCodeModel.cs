using System.ComponentModel.DataAnnotations;

namespace M5Blz.Models
{
    public class DisplayCodeModel
    {
        [Required(ErrorMessage = "Le code est requis.")]
        [MinLength(4, ErrorMessage = "Le code doit avoir 4 caractères.")]
        [MaxLength(4, ErrorMessage = "Le code doit avoir 4 caractères.")]
        public string Code { get; set; }
    }
}
