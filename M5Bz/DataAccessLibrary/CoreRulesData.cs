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


    //Get valeurs de bases

    public Task<List<AttributeModel>> GetAttribute()
    {
      string sql = "select * from Vm5.Attribute";
      return _db.LoadData<AttributeModel, dynamic>(sql, new { });
    }
    public Task<List<ClanModel>> GetClan()
    {
      string sql = "select * from Vm5.Clan";
      return _db.LoadData<ClanModel, dynamic>(sql, new { });
    }
    public Task<List<AttributeType>> GetAttributeType()
    {
      string sql = "select * from Vm5.AttributeType";
      return _db.LoadData<AttributeTypem, dynamic>(sql, new { });
    }
  }
}
