namespace M5Blz.Models.M5
{
  public class DisplayBaseCharacterModel
  {
    public int Id { get; set; }
    public string ClanName { get; set; } = "";
    public string CampaignName { get; set; } = "";
    public string Name { get; set; } = "";

    public DisplayBaseCharacterModel(int id, string clanName, string campaignName, string name)
    {
      Id = id;
      ClanName = clanName;
      CampaignName = campaignName;
      Name = name;
    }

  }
}
