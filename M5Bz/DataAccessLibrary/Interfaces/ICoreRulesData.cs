using DataAccessLibrary.Models;

namespace DataAccessLibrary.Interfaces
{
    public interface ICoreRulesData
    {
        Task<List<CoreRulesModel>> GetCoreRules();
        Task InsertUser(CoreRulesModel coreRulesModel);
    }
}