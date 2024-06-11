namespace CodeGin.Models
{
  public class Message
  {
    public Guid Id { get; set; }
    public Guid Sender { get; set; }
    public Guid Addressee { get; set; }
    public string? Content { get; set; }
    public DateTime DateMessage { get; set; }
  }
}
