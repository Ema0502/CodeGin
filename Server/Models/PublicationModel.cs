namespace CodeGin.Models
{
  public class Publication 
  {
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
    public string? Image { get; set; }
    public DateTime CreatedPublication { get; set; }
  }
}
