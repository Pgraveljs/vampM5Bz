using System.ComponentModel.DataAnnotations;

namespace M5Blz.Models
{
    public class DisplayUserModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "Le prénom est trop long.")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Le nom est trop long.")]
        public string LastName { get; set; }
        [Required]
        [MinLength(4, ErrorMessage = "Le code doit avoir 4 caractère.")]
        [MaxLength(4, ErrorMessage = "Le code doit avoir 4 caractère.")]
        public string Code { get; set; }
        [Required]
        public bool IsDM { get; set; }
    }
}
