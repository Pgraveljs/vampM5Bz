namespace M5Blz.Models
{
  public class SimpleRule
  {
    public string Titre { get; set; } = "";
    public string Description { get; set; } = "";
    public string Difficulty { get; set; } = "";

    public SimpleRule(string titre, string description, string difficulty)
    {
      Titre = titre;
      Description = description;
      Difficulty = difficulty;
    }
  }
}
