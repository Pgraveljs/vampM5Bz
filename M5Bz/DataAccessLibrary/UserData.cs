using DataAccessLibrary.Models;


namespace DataAccessLibrary
{
    public class UserData : IUserData
    {
        private readonly ISqlDataAccess _db;
        public UserData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<UserModel>> GetUsers()
        {
            string sql = "select * from dbo.[User]";
            return _db.LoadData<UserModel, dynamic>(sql, new { });
        }
        public Task<UserModel> GetUser(string code)
        {
            var parameter = new { Code = code };
            string sql = "select * from dbo.[User] where Code = @Code";
            return _db.GetData<UserModel, dynamic>(sql, parameter);
        }

        public Task InsertUser(UserModel userModel)
        {
            string sql = @"insert into dbo.[User] (FirstName, LastName, Code, IsDM)
                                values (@FirstName, @LastName, @Code, @IsDM);";

            return _db.SaveData(sql, userModel);
        }
    }
}
