

namespace DataAccessLibrary.Models
{
  public class CharacterModel
  {
public int Id { get; set; }
public int CampaignId { get; set; }
    public int ClanId { get; set; }
    public string NameWhenAlive { get; set; } = "";
    public string WhatWasHeDoingInLife { get; set; } = "";
    public string WhereAndWhenWasHeEmbrace { get; set; } = "";
    public string WhatIsHisNameNow { get; set; } = "";
    public string WhereIsHeNow { get; set; } = "";
    public string SirName { get; set; } = "";
    public int SkillPointSystemId { get; set; }
    public int FreeSpeId { get; set; }
    public string FreeSpeValue { get; set; } = "";
    public string FreeSpeArtisanatValue { get; set; } = "";
    public string FreeSpeRepresentationValue { get; set; } = "";
    public string FreeSpeEruditionValue { get; set; } = "";
    public string FreeSpeSciencesValue { get; set; } = "";
    public int DiciplinePower2Id { get; set; }
    public int DiciplinePower1Id { get; set; }
  }
}
