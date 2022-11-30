using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
  public interface IM5DataAccess
  {
    Task<List<AttributeModel>> GetAttribute();
    Task<List<AttributeTypeModel>> GetAttributeType();
    Task<CharacterModel> GetCharacterById(int id);
    Task<List<CharacterModel>> GetCharacters();
    Task<List<ClanModel>> GetClan();
    Task<List<SkillModel>> GetSkill();
    Task<List<SkillPointSystemModel>> GetSkillPointSystem();
  }
}