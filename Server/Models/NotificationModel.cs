using CodeGin.Models;

{
  public class Notification 
  {
    public Guild Id { get; set; }
    public Guild UserId { get; set; }
    public string Type { get; set; }
    public string Content { get; set; }
    public DateTime DateNotification { get; set; }
  }
}