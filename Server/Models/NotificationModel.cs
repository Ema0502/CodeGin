namespace CodeGin.Models
{
  public class Notification 
  {
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string? Type { get; set; }
    public string? Content { get; set; }
    public DateTime DateNotification { get; set; }
  }
}
