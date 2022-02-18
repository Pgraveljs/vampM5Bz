using DataAccessLibrary.Models;
using M5Blz.Models;

namespace M5Blz.Services
{
    public class AppData
    {

        public int Id { get; set ; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsDM { get; set; }

        //Contient le jeux utiliser
        public CoreRulesModel SelectedCoreRules { get; set; } = new CoreRulesModel();

        //Liste pour le fil d'Ariane
        public List<NavItem> NavItems { get; set; } = new List<NavItem>();

        public AppData()
        {
            NavItems.Add(new NavItem { Href = "/", Icon = "/icons/victorian-house.png" });
        }


        public event Action OnChange;

        public void SetUser(UserModel user)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            IsDM = user.IsDM;

            NotifyStateChanged();
        }
        public void SetCoreRules(CoreRulesModel selectedCoreRules)
        {
            if (selectedCoreRules.Id != SelectedCoreRules.Id) 
            {
                SelectedCoreRules = selectedCoreRules;
                NotifyStateChanged();
            }
        }

        public void SetNavItems(NavItem navItem) 
        {
            if(NavItems.Any(x => x.Href == navItem.Href))
            {
                for (int i = NavItems.Count - 1; i >=0 ; i--)
                {
                    if (NavItems[i].Href != navItem.Href)
                        NavItems.RemoveAt(i);
                    else
                        break;
                }
            }
            else 
            {
                NavItems.Add(navItem);
            }

            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();

    }
}
