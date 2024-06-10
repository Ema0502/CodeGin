using CodeGin.Models;

{
  public class Message
  {
    public Guild Id { get; set; }
    public Guild Sender { get; set; }
    public Guild Addressee { get; set; }
    public string Content { get; set; }
    public DateTime DateMessage { get; set; }
  }
}