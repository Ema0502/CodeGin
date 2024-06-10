using CodeGin.Models;

{
  public class Friend
  {
    public Guild Id { get; set; }
    public Guild User1Id { get; set; }
    public Guild User2Id { get; set; }
    public string State { get; set; }
  }
}