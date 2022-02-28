
using System.ComponentModel.DataAnnotations;

namespace DataAccessLibrary.Models
{
    public class CampaignModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Entrer un nom")]
        [MaxLength(50, ErrorMessage ="Le nom est trop long")]
        public string Name { get; set; }
        public int CoreRulesId { get; set; }
        public int UserId { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
