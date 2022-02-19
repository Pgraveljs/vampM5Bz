
namespace DataAccessLibrary.Models
{
    public class CampaignModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CoreRulesId { get; set; }
        public int UserId { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
