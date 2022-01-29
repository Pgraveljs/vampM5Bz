using DataAccessLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class CampaignData
    {
        private readonly ISqlDataAccess _db;

        public CampaignData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<CampaignModel>> GetCampaigns()
        {
            string sql = "select * from dbo.Campaign";
            return _db.LoadData<CampaignModel, dynamic>(sql, new { });
        }
    }
}
