using DataAccessLibrary.Models;
namespace DataAccessLibrary
{
    public class CoreRulesData : ICoreRulesData
    {

        private readonly ISqlDataAccess _db;
        public CoreRulesData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task<List<CoreRulesModel>> GetCoreRules()
        {
            string sql = "select * from Core.CoreRules";
            return _db.LoadData<CoreRulesModel, dynamic>(sql, new { });
        }

        public Task InsertUser(CoreRulesModel userModel)
        {
            string sql = @"insert into Core.CoreRules (Name)
                            values (@Name);";

            return _db.SaveData(sql, userModel);
        } 
  }
}
