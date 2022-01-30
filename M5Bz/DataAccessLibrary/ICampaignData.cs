using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface ICampaignData
    {
        Task<List<CampaignModel>> GetCampaigns();
        Task InsertCampaign(CampaignModel campaign);
    }
}