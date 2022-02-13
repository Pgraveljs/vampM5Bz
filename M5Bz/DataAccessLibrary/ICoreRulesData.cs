using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface ICoreRulesData
    {
        Task<List<CoreRulesModel>> GetCoreRules();
        Task InsertUser(CoreRulesModel coreRulesModel);
    }
}