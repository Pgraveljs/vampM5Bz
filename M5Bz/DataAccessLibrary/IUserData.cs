using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IUserData
    {
        Task<List<UserModel>> GetUsers();
        Task<UserModel> GetUser(string code);
        Task InsertUser(UserModel userModel);
    }
}