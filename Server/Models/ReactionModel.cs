using CodeGin.Models;

{
  public class Reaction 
  {
    public Guild Id { get; set; }
    public Guild PublicationId { get; set; }
    public Guild UserId { get; set; }
    public string Type { get; set; }
  }
}