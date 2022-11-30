using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
  public class CharacterData
  {
    private readonly ISqlDataAccess _db;

    public CharacterData(ISqlDataAccess db)
    {
      _db = db;
    }
  }
}
