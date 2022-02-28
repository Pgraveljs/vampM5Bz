using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public class CampaignData : ICampaignData
    {
        private readonly ISqlDataAccess _db;

        public CampaignData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<CampaignModel>> GetCampaigns(int userId, int coreRulesId)
        {
            string sql = $"select * from dbo.Campaign where UserId = {userId} and CoreRulesId = {coreRulesId} and IsDeleted = 0";
            return _db.LoadData<CampaignModel, dynamic>(sql, new { });
        }

        public Task InsertCampaign(CampaignModel campaign)
        {
            string sql = @"insert into dbo.Campaign (Name, CreationDate, CoreRulesId, UserId)
                            values (@Name, @CreationDate, @CoreRulesId, @UserId);";
            return _db.SaveData(sql, campaign);
        }

        public Task UpdateCampaign(CampaignModel campaign)
        {
            string sql = $"update dbo.Campaign set Name = {campaign.Name} where id = {campaign.Id};";
            return _db.SaveData(sql, campaign);
        }
    }
}
