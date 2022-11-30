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

        public Task<List<CampaignModel>> GetCampaigns()
        {
            string sql = "select * from Vm5.Campaign";
            return _db.LoadData<CampaignModel, dynamic>(sql, new { });
        }

        public Task InsertCampaign(CampaignModel campaign)
        {
            string sql = @"insert into Vm5.Campaign (Name, CreationDate)
                            value (@Name, @CreationDate);";
            return _db.SaveData(sql, campaign);
        }
    }
}
