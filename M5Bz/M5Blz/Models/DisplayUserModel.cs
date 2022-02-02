using System.ComponentModel.DataAnnotations;

namespace M5Blz.Models
{
    public class DisplayUserModel : DisplayCodeModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "Le prénom est trop long.")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Le nom est trop long.")]
        public string LastName { get; set; }
        [Required]
        public bool IsDM { get; set; }
    }
}
