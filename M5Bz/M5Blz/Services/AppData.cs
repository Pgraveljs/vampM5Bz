using DataAccessLibrary.Models;

namespace M5Blz.Services
{
    public class AppData
    {
        public int Id { get; set ; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsDM { get; set; }

        public event Action OnChange;

        public void SetUser(UserModel user) 
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            IsDM = user.IsDM;

            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
