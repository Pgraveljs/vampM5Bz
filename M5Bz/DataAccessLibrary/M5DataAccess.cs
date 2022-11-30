using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
  public class M5DataAccess : IM5DataAccess
  {
    private readonly ISqlDataAccess _db;
    public M5DataAccess(ISqlDataAccess db)
    {
      _db = db;
    }
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
    public Task<List<AttributeTypeModel>> GetAttributeType()
    {
      string sql = "select * from Vm5.AttributeType";
      return _db.LoadData<AttributeTypeModel, dynamic>(sql, new { });
    }
    public Task<List<SkillModel>> GetSkill()
    {
      string sql = "select * from Vm5.Skill";
      return _db.LoadData<SkillModel, dynamic>(sql, new { });
    }
    public Task<List<SkillPointSystemModel>> GetSkillPointSystem()
    {
      string sql = "select * from Vm5.SkillPointSystem";
      return _db.LoadData<SkillPointSystemModel, dynamic>(sql, new { });
    }
    public Task<List<CharacterModel>> GetCharacters()
    {
      string sql = "select * from Vm5.Character";
      return _db.LoadData<CharacterModel, dynamic>(sql, new { });
    }
    public Task<CharacterModel> GetCharacterById(int id)
    {
      var parameter = new { Id = id };
      string sql = $"select * from Vm5.Character where id = @Id";
      return _db.GetData<CharacterModel, dynamic>(sql, parameter);
    }
  }
}
