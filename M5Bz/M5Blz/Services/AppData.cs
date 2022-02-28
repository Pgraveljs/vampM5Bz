using DataAccessLibrary.Models;
using M5Blz.Models;

namespace M5Blz.Services
{
    public class AppData
    {
        public UserModel SelectedUser { get; set; } = new UserModel();
        //Contient le jeux utiliser
        public CoreRulesModel SelectedCoreRules { get; set; } = new CoreRulesModel();
        public CampaignModel SelectedCampaign { get; set; } = new CampaignModel();

        //Liste pour le fil d'Ariane
        public List<NavItem> NavItems { get; set; } = new List<NavItem>();

        public AppData()
        {
            NavItems.Add(new NavItem { Href = "/", Icon = "/icons/victorian-house.png" });
        }

        public event Action OnChange;

        public void SetUser(UserModel user)
        {
            if (SelectedUser.Id != user.Id)
            {
                SelectedUser = user;
                NotifyStateChanged();
            }
        }
        public void SetCoreRules(CoreRulesModel selectedCoreRules)
        {
            if (selectedCoreRules.Id != SelectedCoreRules.Id)
            {
                SelectedCoreRules = selectedCoreRules;
                NotifyStateChanged();
            }
        }
        public void SetCampaign(CampaignModel selectedCampaign)
        {
            if (selectedCampaign.Id != SelectedCampaign.Id)
            {
                SelectedCampaign = selectedCampaign;
                NotifyStateChanged();
            }
        }

        public void SetNavItems(NavItem navItem)
        {
            if (NavItems.Any(x => x.Href == navItem.Href))
            {
                for (int i = NavItems.Count - 1; i >= 0; i--)
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
