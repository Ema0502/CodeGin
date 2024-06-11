namespace CodeGin.Models
{
  public class Reaction 
  {
    public Guid Id { get; set; }
    public Guid PublicationId { get; set; }
    public Guid UserId { get; set; }
    public string? Type { get; set; }
  }
}
