using DataAccessLibrary.Models;

namespace DataAccessLibrary.Interfaces
{
    public interface ICampaignData
    {
        Task<List<CampaignModel>> GetCampaigns(int userID, int coreRulesID);
        Task InsertCampaign(CampaignModel campaign);
        Task UpdateCampaign(CampaignModel campaign);
    }
}