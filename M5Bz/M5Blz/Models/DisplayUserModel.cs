using System.ComponentModel.DataAnnotations;

namespace M5Blz.Models
{
    public class DisplayUserModel : DisplayCodeModel
    {
        [Required(ErrorMessage = "Le prénom est requis.")]
        [StringLength(50, ErrorMessage = "Le prénom est trop long.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Le nom est requis.")]
        [StringLength(50, ErrorMessage = "Le nom est trop long.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Le code est requis.")   ]
        public bool IsDM { get; set; }
    }
}
